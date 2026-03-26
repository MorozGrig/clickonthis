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

        public CatalogForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            InitializeComponent();
            ApplyTheme();
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

        private void LoadTrips()
        {
            dgvTrips.DataSource = _tripService.GetTrips()
                .Select(x => new
                {
                    x.Id,
                    Отправление = x.DepartureCity,
                    Прибытие = x.ArrivalCity,
                    Дата = x.DepartureTime,
                    Цена = x.Price
                })
                .ToList();
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
