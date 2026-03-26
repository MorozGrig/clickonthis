using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class AdminPanelForm : Form
    {
        private readonly UserRole _role;
        private readonly TripService _tripService = new TripService();
        private readonly DataGridView _grid = new DataGridView { Dock = DockStyle.Fill };
        private readonly ComboBox _cmbTables = new ComboBox();

        public AdminPanelForm(UserRole role)
        {
            _role = role;
            Text = "Панель управления";
            Width = 1100;
            Height = 640;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            Init();
            _cmbTables.SelectedIndex = 0;
        }

        private void Init()
        {
            var wrapper = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16), BackColor = UiTheme.Surface };
            var filterGroup = new GroupBox { Text = "Раздел", Dock = DockStyle.Top, Height = 78 };
            var gridGroup = new GroupBox { Text = "Данные", Dock = DockStyle.Fill };
            var buttonsPanel = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 56 };

            _cmbTables.Left = 16;
            _cmbTables.Top = 30;
            _cmbTables.Width = 240;
            _cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbTables.Items.AddRange(new object[] { "Users", "Trips", "Orders" });
            _cmbTables.SelectedIndexChanged += (s, e) => LoadTable();

            UiTheme.StyleGrid(_grid);

            var btnAdd = UiTheme.CreatePrimaryButton("Добавить", 180);
            var btnEdit = UiTheme.CreatePrimaryButton("Редактировать", 180);
            var btnDelete = UiTheme.CreatePrimaryButton("Удалить", 180);

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            buttonsPanel.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete });
            filterGroup.Controls.Add(_cmbTables);
            gridGroup.Controls.Add(_grid);
            wrapper.Controls.Add(gridGroup);
            wrapper.Controls.Add(buttonsPanel);
            wrapper.Controls.Add(filterGroup);
            Controls.Add(wrapper);

            if (!RoleAccessHelper.CanManageData(_role))
            {
                MessageBox.Show("Панель управления доступна только менеджеру и администратору.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void LoadTable()
        {
            using (var context = new BusStationDbContext())
            {
                switch (_cmbTables.SelectedItem?.ToString())
                {
                    case "Users":
                        _grid.DataSource = context.Users.Include("Role")
                            .Select(x => new { x.Id, x.Name, x.Email, x.Phone, Role = x.Role.Name, x.RoleId })
                            .ToList();
                        break;
                    case "Trips":
                        _grid.DataSource = context.BusTrips
                            .Select(x => new { x.Id, x.DepartureCity, x.ArrivalCity, x.DepartureTime, x.ArrivalTime, x.Price, x.BusNumber })
                            .OrderBy(x => x.DepartureTime)
                            .ToList();
                        break;
                    case "Orders":
                        _grid.DataSource = context.Orders.Include("User")
                            .Select(x => new { x.Id, User = x.User.Name, x.Date, x.TotalPrice })
                            .OrderByDescending(x => x.Date)
                            .ToList();
                        break;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var table = _cmbTables.SelectedItem?.ToString();
            if (table == "Users")
            {
                MessageBox.Show("Добавление пользователей выполняется через форму регистрации.");
                return;
            }

            if (table == "Trips")
            {
                using (var dialog = new TripEditForm())
                {
                    if (dialog.ShowDialog() != DialogResult.OK) return;
                    _tripService.AddTrip(dialog.Trip);
                }

                LoadTable();
                return;
            }

            MessageBox.Show("Для заказов доступен просмотр и удаление (только для администратора).");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_grid.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var table = _cmbTables.SelectedItem?.ToString();
            var selectedId = Convert.ToInt32(_grid.CurrentRow.Cells["Id"].Value);

            using (var context = new BusStationDbContext())
            {
                if (table == "Users")
                {
                    if (!RoleAccessHelper.CanManageUsers(_role))
                    {
                        MessageBox.Show("Редактирование пользователей доступно только администратору.");
                        return;
                    }

                    var user = context.Users.Find(selectedId);
                    using (var dialog = new UserEditForm(user))
                    {
                        if (dialog.ShowDialog() != DialogResult.OK) return;
                        context.SaveChanges();
                    }
                }
                else if (table == "Trips")
                {
                    var trip = context.BusTrips.Find(selectedId);
                    if (trip == null) return;

                    using (var dialog = new TripEditForm(trip))
                    {
                        if (dialog.ShowDialog() != DialogResult.OK) return;
                        context.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Редактирование заказов недоступно.");
                    return;
                }
            }

            LoadTable();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!RoleAccessHelper.CanDelete(_role))
            {
                MessageBox.Show("Удаление доступно только администратору.");
                return;
            }

            if (_grid.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            var table = _cmbTables.SelectedItem?.ToString();
            var selectedId = Convert.ToInt32(_grid.CurrentRow.Cells["Id"].Value);

            using (var context = new BusStationDbContext())
            {
                if (table == "Users")
                {
                    var user = context.Users.Find(selectedId);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                }
                else if (table == "Trips")
                {
                    _tripService.DeleteTrip(selectedId);
                }
                else if (table == "Orders")
                {
                    var order = context.Orders.Include(x => x.Items).FirstOrDefault(x => x.Id == selectedId);
                    if (order != null)
                    {
                        foreach (var item in order.Items.ToList())
                        {
                            context.OrderItems.Remove(item);
                        }

                        context.Orders.Remove(order);
                        context.SaveChanges();
                    }
                }
            }

            LoadTable();
        }
    }
}
