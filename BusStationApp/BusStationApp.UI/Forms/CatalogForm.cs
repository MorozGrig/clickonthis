using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class CatalogForm : Form
    {
        private readonly ProductService _productService = new ProductService();
        private readonly CartService _cartService = new CartService();
        private readonly TripService _tripService = new TripService();
        private readonly int _userId;
        private readonly UserRole _role;

        public CatalogForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            InitializeComponent();
            ApplyTheme();
            LoadData();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            containerPanel.BackColor = UiTheme.Surface;
            UiTheme.StyleGrid(dgvProducts);
            UiTheme.StyleGrid(dgvTrips);
            btnAddToCart.Enabled = RoleAccessHelper.CanAddToCart(_role);
        }

        private void LoadData()
        {
            dgvProducts.DataSource = _productService.GetCatalog().Select(x => new
            {
                x.Id,
                x.Name,
                Category = x.Category.Name,
                x.Price,
                x.Discount
            }).ToList();

            dgvTrips.DataSource = _tripService.GetTrips().Select(x => new
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

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!RoleAccessHelper.CanAddToCart(_role))
            {
                MessageBox.Show("Гость не может добавлять товары в корзину. Войдите в систему.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Выберите товар перед добавлением в корзину.", "Каталог", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);
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
