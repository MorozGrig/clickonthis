using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.DAL.Contexts;

namespace BusStationApp.UI.Forms
{
    public class AdminPanelForm : Form
    {
        private readonly UserRole _role;
        private readonly ProductService _productService = new ProductService();
        private readonly DataGridView _grid = new DataGridView();
        private readonly ComboBox _cmbTables = new ComboBox();

        public AdminPanelForm(UserRole role)
        {
            _role = role;
            Text = "Панель управления";
            Width = 980;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;
            Font = new Font("Segoe UI", 10F);
            Init();
        }

        private void Init()
        {
            var wrapper = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16), BackColor = Color.FromArgb(241, 245, 249) };
            var filterGroup = new GroupBox { Text = "Раздел", Dock = DockStyle.Top, Height = 72 };
            var gridGroup = new GroupBox { Text = "Данные", Dock = DockStyle.Fill };
            var buttonsPanel = new Panel { Dock = DockStyle.Bottom, Height = 56 };

            _cmbTables.Left = 16;
            _cmbTables.Top = 28;
            _cmbTables.Width = 220;
            _cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbTables.Items.AddRange(new object[] { "Users", "Products", "Orders" });
            _cmbTables.SelectedIndexChanged += (s, e) => LoadTable();

            _grid.Dock = DockStyle.Fill;
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.BackgroundColor = Color.White;
            _grid.BorderStyle = BorderStyle.None;
            _grid.ReadOnly = true;
            _grid.AllowUserToAddRows = false;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.MultiSelect = false;
            _grid.RowHeadersVisible = false;
            _grid.EnableHeadersVisualStyles = false;
            _grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            _grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            _grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            var btnDelete = new Button { Left = 0, Top = 10, Width = 180, Height = 36, Text = "Удалить выбранный" };
            btnDelete.Click += BtnDelete_Click;

            filterGroup.Controls.Add(_cmbTables);
            gridGroup.Controls.Add(_grid);
            buttonsPanel.Controls.Add(btnDelete);
            wrapper.Controls.Add(gridGroup);
            wrapper.Controls.Add(buttonsPanel);
            wrapper.Controls.Add(filterGroup);
            Controls.Add(wrapper);
        }

        private void LoadTable()
        {
            using (var context = new BusStationDbContext())
            {
                switch (_cmbTables.SelectedItem?.ToString())
                {
                    case "Users":
                        _grid.DataSource = context.Users.Include("Role").Select(x => new { x.Id, x.Name, x.Email, x.Phone, Role = x.Role.Name }).ToList();
                        break;
                    case "Products":
                        _grid.DataSource = context.Products.Include("Category").Select(x => new { x.Id, x.Name, x.Price, x.Discount, Category = x.Category.Name }).ToList();
                        break;
                    case "Orders":
                        _grid.DataSource = context.Orders.Include("User").Select(x => new { x.Id, User = x.User.Name, x.Date, x.TotalPrice }).ToList();
                        break;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_role != UserRole.Admin)
            {
                MessageBox.Show("Удаление доступно только администратору.");
                return;
            }

            if (_cmbTables.SelectedItem?.ToString() != "Products" || _grid.CurrentRow == null)
            {
                return;
            }

            var productId = Convert.ToInt32(_grid.CurrentRow.Cells["Id"].Value);
            var deleted = _productService.DeleteProduct(productId);

            MessageBox.Show(deleted
                ? "Товар удалён."
                : "Невозможно удалить товар: он уже встречается в заказах (OrderItems).");

            LoadTable();
        }
    }
}
