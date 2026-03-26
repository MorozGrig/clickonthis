using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.DAL.Contexts;

namespace BusStationApp.UI.Forms
{
    public class CartForm : Form
    {
        private readonly int _userId;
        private readonly CartService _cartService = new CartService();
        private readonly DataGridView _grid = new DataGridView();

        public CartForm(int userId)
        {
            _userId = userId;
            Text = "Корзина";
            Width = 700;
            Height = 450;
            Init();
            LoadCart();
        }

        private void Init()
        {
            _grid.Dock = DockStyle.Top;
            _grid.Height = 340;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var btnCheckout = new Button { Left = 20, Top = 360, Width = 160, Text = "Оформить заказ" };
            btnCheckout.Click += (s, e) =>
            {
                try
                {
                    var total = _cartService.Checkout(_userId);
                    MessageBox.Show($"Заказ оформлен. Сумма: {total:C2}");
                    LoadCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            Controls.Add(_grid);
            Controls.Add(btnCheckout);
        }

        private void LoadCart()
        {
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
