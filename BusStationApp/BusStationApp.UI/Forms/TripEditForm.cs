using System;
using System.Drawing;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.DAL.Entities;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class TripEditForm : Form
    {
        private readonly TripService _tripService = new TripService();
        private readonly BusTrip _trip;

        public BusTrip Trip => _trip;

        public TripEditForm(BusTrip trip = null)
        {
            _trip = trip ?? new BusTrip { DepartureTime = DateTime.Now.AddHours(1), ArrivalTime = DateTime.Now.AddHours(3), Price = 1000 };
            InitializeComponent();
            ApplyTheme();
            FillForm();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            panelContainer.BackColor = UiTheme.Surface;
            Text = _trip.Id == 0 ? "Добавление рейса" : "Редактирование рейса";

        }

        private void FillForm()
        {
            txtDeparture.Text = _trip.DepartureCity ?? string.Empty;
            txtArrival.Text = _trip.ArrivalCity ?? string.Empty;
            dtDeparture.Value = _trip.DepartureTime == default(DateTime) ? DateTime.Now.AddHours(1) : _trip.DepartureTime;
            dtArrival.Value = _trip.ArrivalTime == default(DateTime) ? DateTime.Now.AddHours(3) : _trip.ArrivalTime;
            numPrice.Value = _trip.Price <= 0 ? 1000 : _trip.Price;
            txtBusNumber.Text = _trip.BusNumber ?? string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var error = _tripService.Validate(txtDeparture.Text, txtArrival.Text, dtDeparture.Value, dtArrival.Value, numPrice.Value);
            if (error != null)
            {
                MessageBox.Show(error, "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _trip.DepartureCity = txtDeparture.Text.Trim();
            _trip.ArrivalCity = txtArrival.Text.Trim();
            _trip.DepartureTime = dtDeparture.Value;
            _trip.ArrivalTime = dtArrival.Value;
            _trip.Price = numPrice.Value;
            _trip.BusNumber = txtBusNumber.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
