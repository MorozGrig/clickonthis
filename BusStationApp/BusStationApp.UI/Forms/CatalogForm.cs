using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class CatalogForm : Form
    {
        private readonly ProductService _productService = new ProductService();
        private readonly CartService _cartService = new CartService();
        private readonly TripService _tripService = new TripService();
        private readonly int _userId;
        private readonly UserRole _role;

        private readonly DataGridView _dgvProducts = new DataGridView();
        private readonly DataGridView _dgvTrips = new DataGridView();

        public CatalogForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            Text = "Каталог";
            Width = 1100;
            Height = 620;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            Init();
            LoadData();
        }

        private void Init()
        {
            var container = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16), BackColor = UiTheme.Surface };
            var split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Horizontal, SplitterDistance = 260 };

            var productsGroup = new GroupBox { Text = "Товары/услуги", Dock = DockStyle.Fill };
            var tripsGroup = new GroupBox { Text = "Рейсы", Dock = DockStyle.Fill };

            UiTheme.StyleGrid(_dgvProducts);
            UiTheme.StyleGrid(_dgvTrips);

            var productActions = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 52 };
            var btnAddToCart = UiTheme.CreatePrimaryButton("Добавить в корзину", 210);
            btnAddToCart.Enabled = RoleAccessHelper.CanAddToCart(_role);
            btnAddToCart.Click += BtnAddToCart_Click;
            productActions.Controls.Add(btnAddToCart);

            productsGroup.Controls.Add(_dgvProducts);
            productsGroup.Controls.Add(productActions);
            tripsGroup.Controls.Add(_dgvTrips);
            split.Panel1.Controls.Add(productsGroup);
            split.Panel2.Controls.Add(tripsGroup);

            container.Controls.Add(split);
            Controls.Add(container);
        }

        private void LoadData()
        {
            _dgvProducts.DataSource = _productService.GetCatalog().Select(x => new
            {
                x.Id,
                x.Name,
                Category = x.Category.Name,
                x.Price,
                x.Discount
            }).ToList();

            _dgvTrips.DataSource = _tripService.GetTrips().Select(x => new
            {
                x.Id,
                x.DepartureCity,
                x.ArrivalCity,
                x.DepartureTime,
                x.ArrivalTime,
                x.Price,
                x.BusNumber
            }).ToList();
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (!RoleAccessHelper.CanAddToCart(_role))
            {
                MessageBox.Show("Гость не может добавлять товары в корзину. Войдите в систему.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Выберите товар перед добавлением в корзину.", "Каталог", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var productId = Convert.ToInt32(_dgvProducts.CurrentRow.Cells["Id"].Value);
                _cartService.AddToCart(_userId, productId, 1);
                MessageBox.Show("Товар успешно добавлен в корзину.", "Каталог", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
