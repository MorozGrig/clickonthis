using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.Common.Enums;
using BusStationApp.DAL.Contexts;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class OrderHistoryForm : Form
    {
        private readonly int _userId;
        private readonly UserRole _role;

        public OrderHistoryForm(int userId, UserRole role)
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
            panelContainer.BackColor = UiTheme.Surface;
            UiTheme.StyleGrid(gridOrders);
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
                var history = context.OrderItems
                    .Include(x => x.Order)
                    .Include(x => x.BusTrip)
                    .Where(x => x.Order.UserId == _userId)
                    .OrderByDescending(x => x.Order.Date)
                    .Select(x => new
                    {
                        x.Id,
                        Дата_Заказа = x.Order.Date,
                        Отправление = x.BusTrip.DepartureCity,
                        Прибытие = x.BusTrip.ArrivalCity,
                        Время_отправления = x.BusTrip.DepartureTime,
                        Время_прибытия = x.BusTrip.ArrivalTime,
                        Цена = x.Price,
                        Номер_автобуса = x.BusTrip.BusNumber
                    })
                    .ToList();

                gridOrders.DataSource = history;
            }
        }
    }
}
