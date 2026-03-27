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
        private readonly CartService _cartService = new CartService();
        private readonly TripService _tripService = new TripService();
        private readonly int _userId;
        private readonly UserRole _role;
        private Button btnSortByDeparture;
        private Button btnSortByArrival;

        public CatalogForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            InitializeComponent();
            ApplyTheme();
            CreateSortButtons();
            LoadTrips();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            containerPanel.BackColor = UiTheme.Surface;
            UiTheme.StyleGrid(dgvTrips);

            btnBuyTicket.Enabled = RoleAccessHelper.CanAddToCart(_role);
        }

        private void CreateSortButtons()
        {
            btnSortByDeparture = new Button
            {
                Text = "Сортировать по городу отправления",
                Location = new Point(10, 10),
                Size = new Size(250, 30)
            };
            btnSortByDeparture.Click += (s, e) =>
            {
                SortTripsByCity(sortByDeparture: true);
            };

            btnSortByArrival = new Button
            {
                Text = "Сортировать по городу прибытия",
                Location = new Point(btnSortByDeparture.Right + 10, 10),
                Size = new Size(250, 30)
            };
            btnSortByArrival.Click += (s, e) =>
            {
                SortTripsByCity(sortByDeparture: false);
            };

            containerPanel.Controls.Add(btnSortByDeparture);
            containerPanel.Controls.Add(btnSortByArrival);
        }

        private void LoadTrips()
        {
            dgvTrips.DataSource = _tripService.GetTrips()
                .Select(x => new
                {
                    x.Id,
                    Отправление = x.DepartureCity,
                    Прибытие = x.ArrivalCity,
                    Время_отправления = x.DepartureTime,
                    Время_прибытия = x.ArrivalTime,
                    Цена = x.Price,
                    Номер_автобуса = x.BusNumber
                })
                .ToList();
        }

        private void SortTripsByCity(bool sortByDeparture)
        {
            var list = dgvTrips.DataSource as System.Collections.IList;
            if (list == null) return;

            var sorted = list
                .Cast<object>()
                .Select(x => new
                {
                    Id = (int)x.GetType().GetProperty("Id").GetValue(x),
                    Отправление = (string)x.GetType().GetProperty("Отправление").GetValue(x),
                    Прибытие = (string)x.GetType().GetProperty("Прибытие").GetValue(x),
                    Время_отправления = (DateTime)x.GetType().GetProperty("Время_отправления").GetValue(x),
                    Время_прибытия = (DateTime)x.GetType().GetProperty("Время_прибытия").GetValue(x),
                    Цена = (decimal)x.GetType().GetProperty("Цена").GetValue(x),
                    Номер_автобуса = (string)x.GetType().GetProperty("Номер_автобуса").GetValue(x)
                })
                .OrderBy(x => sortByDeparture ? x.Отправление : x.Прибытие)
                .ToList();

            dgvTrips.DataSource = null;
            dgvTrips.DataSource = sorted;
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (!RoleAccessHelper.CanAddToCart(_role))
            {
                MessageBox.Show("Гость не может покупать билеты. Войдите в систему.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvTrips.CurrentRow == null)
            {
                MessageBox.Show("Выберите рейс перед покупкой билета.", "Каталог", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var tripId = Convert.ToInt32(dgvTrips.CurrentRow.Cells["Id"].Value);
                _cartService.AddTripToCart(_userId, tripId);
                MessageBox.Show("Билет добавлен в корзину.", "Каталог", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
