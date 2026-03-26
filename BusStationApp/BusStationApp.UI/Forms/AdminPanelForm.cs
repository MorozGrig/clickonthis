using System;
using System.Data.Entity;
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
            Width = 900;
            Height = 550;
            Init();
        }

        private void Init()
        {
            _cmbTables.Left = 20;
            _cmbTables.Top = 20;
            _cmbTables.Width = 200;
            _cmbTables.Items.AddRange(new object[] { "Users", "Products", "Orders" });
            _cmbTables.SelectedIndexChanged += (s, e) => LoadTable();

            _grid.Top = 60;
            _grid.Left = 20;
            _grid.Width = 840;
            _grid.Height = 400;
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var btnDelete = new Button { Left = 20, Top = 470, Width = 180, Text = "Удалить выбранный" };
            btnDelete.Click += BtnDelete_Click;

            Controls.AddRange(new Control[] { _cmbTables, _grid, btnDelete });
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
