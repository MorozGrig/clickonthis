using System;
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
            Width = 500;
            Height = 260;
            Initialize();
        }

        private void Initialize()
        {
            var btnCatalog = new Button { Left = 30, Top = 30, Width = 200, Text = "Каталог рейсов" };
            var btnCart = new Button { Left = 250, Top = 30, Width = 200, Text = "Корзина" };
            var btnAdmin = new Button { Left = 30, Top = 80, Width = 420, Text = "Админ-панель", Enabled = RoleAccessHelper.CanOpenAdminPanel(_role) };

            btnCatalog.Click += (s, e) => new CatalogForm(_userId, _role).ShowDialog();
            btnCart.Click += (s, e) => new CartForm(_userId).ShowDialog();
            btnAdmin.Click += (s, e) => new AdminPanelForm(_role).ShowDialog();

            Controls.AddRange(new Control[] { btnCatalog, btnCart, btnAdmin });
        }
    }
}
