using System.Drawing;
using System.Windows.Forms;
using BusStationApp.Common.Enums;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly int _userId;
        private readonly UserRole _role;

        public MainForm(int userId, string userName, UserRole role)
        {
            _userId = userId;
            _role = role;
            InitializeComponent();

            Text = $"Автовокзал: {userName} ({role})";
            ApplyTheme();
            ConfigureRoleAccess();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            containerPanel.BackColor = UiTheme.Surface;
        }

        private void ConfigureRoleAccess()
        {
            btnCart.Visible = RoleAccessHelper.CanViewCart(_role);
            btnOrders.Visible = RoleAccessHelper.CanViewCart(_role);
            btnAdmin.Visible = RoleAccessHelper.CanOpenAdminPanel(_role);
        }

        private void btnCatalog_Click(object sender, System.EventArgs e)
        {
            using (var form = new CatalogForm(_userId, _role))
            {
                form.ShowDialog(this);
            }
        }

        private void btnCart_Click(object sender, System.EventArgs e)
        {
            using (var form = new CartForm(_userId, _role))
            {
                form.ShowDialog(this);
            }
        }

        private void btnOrders_Click(object sender, System.EventArgs e)
        {
            using (var form = new OrderHistoryForm(_userId, _role))
            {
                form.ShowDialog(this);
            }
        }

        private void btnAdmin_Click(object sender, System.EventArgs e)
        {
            using (var form = new AdminPanelForm(_role))
            {
                form.ShowDialog(this);
            }
        }
    }
}
