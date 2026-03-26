using System.Drawing;
using System.Windows.Forms;
using BusStationApp.Common.Enums;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class MainForm : Form
    {
        private readonly int _userId;
        private readonly UserRole _role;

        public MainForm(int userId, string userName, UserRole role)
        {
            _userId = userId;
            _role = role;

            Text = $"Автовокзал: {userName} ({role})";
            Width = 700;
            Height = 350;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            Initialize();
        }

        private void Initialize()
        {
            var container = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20), BackColor = UiTheme.Surface };
            var header = new Label { Dock = DockStyle.Top, Height = 35, Font = new Font("Segoe UI", 14F, FontStyle.Bold), Text = "Главное меню" };
            var actions = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight, WrapContents = true, AutoScroll = true };

            var btnCatalog = UiTheme.CreatePrimaryButton("Каталог", 200);
            var btnCart = UiTheme.CreatePrimaryButton("Корзина", 200);
            var btnOrders = UiTheme.CreatePrimaryButton("История заказов", 200);
            var btnAdmin = UiTheme.CreatePrimaryButton("Админ-панель", 200);

            btnCatalog.Click += (s, e) => new CatalogForm(_userId, _role).ShowDialog();
            btnCart.Click += (s, e) => new CartForm(_userId, _role).ShowDialog();
            btnOrders.Click += (s, e) => new OrderHistoryForm(_userId, _role).ShowDialog();
            btnAdmin.Click += (s, e) => new AdminPanelForm(_role).ShowDialog();

            btnCart.Visible = RoleAccessHelper.CanViewCart(_role);
            btnOrders.Visible = RoleAccessHelper.CanViewCart(_role);
            btnAdmin.Visible = RoleAccessHelper.CanOpenAdminPanel(_role);

            actions.Controls.AddRange(new Control[] { btnCatalog, btnCart, btnOrders, btnAdmin });
            container.Controls.Add(actions);
            container.Controls.Add(header);
            Controls.Add(container);
        }
    }
}
