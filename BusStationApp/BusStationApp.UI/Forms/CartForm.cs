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
    public partial class CartForm : Form
    {
        private readonly int _userId;
        private readonly UserRole _role;
        private readonly CartService _cartService = new CartService();

        public CartForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            InitializeComponent();
            ApplyTheme();
            LoadCart();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            containerPanel.BackColor = UiTheme.Surface;
            UiTheme.StyleGrid(gridCart);
            UiTheme.ApplyPrimaryButtonStyle(btnCheckout);
            btnCheckout.Enabled = RoleAccessHelper.CanCheckout(_role);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                var total = _cartService.Checkout(_userId);
                MessageBox.Show($"Заказ оформлен. Сумма: {total:C2}", "Заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadCart()
        {
            if (!RoleAccessHelper.CanViewCart(_role))
            {
                MessageBox.Show("Гостю корзина недоступна. Выполните вход.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            using (var context = new BusStationDbContext())
            {
                var data = context.CartItems
                    .Include("Product")
                    .Where(x => x.UserId == _userId)
                    .Select(x => new
                    {
                        x.Id,
                        Product = x.Product.Name,
                        x.Quantity,
                        UnitPrice = x.Product.Price,
                        Total = x.Product.Price * x.Quantity
                    })
                    .ToList();

                gridCart.DataSource = data;
            }
        }
    }
}
