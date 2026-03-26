using System;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.DAL.Contexts;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class CartForm : Form
    {
        private readonly int _userId;
        private readonly UserRole _role;
        private readonly CartService _cartService = new CartService();
        private readonly DataGridView _grid = new DataGridView();

        public CartForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            Text = "Корзина";
            Width = 780;
            Height = 500;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            Init();
            LoadCart();
        }

        private void Init()
        {
            var container = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16), BackColor = UiTheme.Surface };
            var group = new GroupBox { Text = "Товары в корзине", Dock = DockStyle.Fill };
            UiTheme.StyleGrid(_grid);

            var btnCheckout = UiTheme.CreatePrimaryButton("Оформить заказ", 200);
            btnCheckout.Enabled = RoleAccessHelper.CanCheckout(_role);
            btnCheckout.Dock = DockStyle.Bottom;
            btnCheckout.Click += (s, e) =>
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
            };

            group.Controls.Add(_grid);
            container.Controls.Add(group);
            container.Controls.Add(btnCheckout);
            Controls.Add(container);
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

                _grid.DataSource = data;
            }
        }
    }
}
