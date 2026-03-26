using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.Common.Enums;
using BusStationApp.DAL.Contexts;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class OrderHistoryForm : Form
    {
        private readonly int _userId;
        private readonly UserRole _role;
        private readonly DataGridView _grid = new DataGridView { Dock = DockStyle.Fill };

        public OrderHistoryForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            Text = "История заказов";
            Width = 760;
            Height = 450;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            InitializeControls();
            LoadData();
        }

        private void InitializeControls()
        {
            var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16), BackColor = UiTheme.Surface };
            UiTheme.StyleGrid(_grid);
            panel.Controls.Add(_grid);
            Controls.Add(panel);
        }

        private void LoadData()
        {
            if (_role == UserRole.Guest)
            {
                MessageBox.Show("Гостю недоступна история заказов.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            using (var context = new BusStationDbContext())
            {
                _grid.DataSource = context.Orders
                    .Where(x => x.UserId == _userId)
                    .OrderByDescending(x => x.Date)
                    .Select(x => new { x.Id, x.Date, x.TotalPrice })
                    .ToList();
            }
        }
    }
}
