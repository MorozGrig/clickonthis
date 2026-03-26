using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.DAL.Contexts;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class AdminPanelForm : Form
    {
        private readonly UserRole _role;
        private readonly TripService _tripService = new TripService();

        public AdminPanelForm(UserRole role)
        {
            _role = role;
            InitializeComponent();
            ApplyTheme();
            cmbTables.SelectedIndex = 0;

            if (!RoleAccessHelper.CanManageData(_role))
            {
                MessageBox.Show("Панель управления доступна только менеджеру и администратору.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            wrapperPanel.BackColor = UiTheme.Surface;
            UiTheme.StyleGrid(gridData);

        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void LoadTable()
        {
            using (var context = new BusStationDbContext())
            {
                switch (cmbTables.SelectedItem?.ToString())
                {
                    case "Users":
                        gridData.DataSource = context.Users.Include("Role")
                            .Select(x => new { x.Id, x.Name, x.Email, x.Phone, Role = x.Role.Name, x.RoleId })
                            .ToList();
                        break;
                    case "Trips":
                        gridData.DataSource = context.BusTrips
                            .Select(x => new { x.Id, x.DepartureCity, x.ArrivalCity, x.DepartureTime, x.ArrivalTime, x.Price, x.BusNumber })
                            .OrderBy(x => x.DepartureTime)
                            .ToList();
                        break;
                    case "Orders":
                        gridData.DataSource = context.Orders.Include("User")
                            .Select(x => new { x.Id, User = x.User.Name, x.Date, x.TotalPrice })
                            .OrderByDescending(x => x.Date)
                            .ToList();
                        break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var table = cmbTables.SelectedItem?.ToString();
            if (table == "Users")
            {
                MessageBox.Show("Добавление пользователей выполняется через форму регистрации.");
                return;
            }

            if (table == "Trips")
            {
                using (var dialog = new TripEditForm())
                {
                    if (dialog.ShowDialog(this) != DialogResult.OK) return;
                    _tripService.AddTrip(dialog.Trip);
                }

                LoadTable();
                return;
            }

            MessageBox.Show("Для заказов доступен просмотр и удаление (только для администратора).");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridData.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var table = cmbTables.SelectedItem?.ToString();
            var selectedId = Convert.ToInt32(gridData.CurrentRow.Cells["Id"].Value);

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
                    if (user == null) return;

                    using (var dialog = new UserEditForm(user))
                    {
                        if (dialog.ShowDialog(this) != DialogResult.OK) return;
                        context.SaveChanges();
                    }
                }
                else if (table == "Trips")
                {
                    var trip = context.BusTrips.Find(selectedId);
                    if (trip == null) return;

                    using (var dialog = new TripEditForm(trip))
                    {
                        if (dialog.ShowDialog(this) != DialogResult.OK) return;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!RoleAccessHelper.CanDelete(_role))
            {
                MessageBox.Show("Удаление доступно только администратору.");
                return;
            }

            if (gridData.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления.");
                return;
            }

            var table = cmbTables.SelectedItem?.ToString();
            var selectedId = Convert.ToInt32(gridData.CurrentRow.Cells["Id"].Value);

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
