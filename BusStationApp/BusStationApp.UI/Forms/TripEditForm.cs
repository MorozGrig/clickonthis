using System;
using System.Drawing;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.DAL.Entities;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class TripEditForm : Form
    {
        private readonly TripService _tripService = new TripService();
        private readonly BusTrip _trip;
        private TextBox _txtDeparture;
        private TextBox _txtArrival;
        private DateTimePicker _dtDeparture;
        private DateTimePicker _dtArrival;
        private NumericUpDown _numPrice;
        private TextBox _txtBusNumber;

        public BusTrip Trip => _trip;

        public TripEditForm(BusTrip trip = null)
        {
            _trip = trip ?? new BusTrip { DepartureTime = DateTime.Now.AddHours(1), ArrivalTime = DateTime.Now.AddHours(3), Price = 1000 };
            Text = trip == null ? "Добавление рейса" : "Редактирование рейса";
            Width = 620;
            Height = 420;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            InitializeControls();
        }

        private void InitializeControls()
        {
            var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16), BackColor = UiTheme.Surface };
            var group = new GroupBox { Text = "Данные рейса", Dock = DockStyle.Fill };
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, Padding = new Padding(8) };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            _txtDeparture = new TextBox { Text = _trip.DepartureCity ?? string.Empty, Dock = DockStyle.Fill };
            _txtArrival = new TextBox { Text = _trip.ArrivalCity ?? string.Empty, Dock = DockStyle.Fill };
            _dtDeparture = new DateTimePicker { Value = _trip.DepartureTime == default(DateTime) ? DateTime.Now.AddHours(1) : _trip.DepartureTime, Format = DateTimePickerFormat.Custom, CustomFormat = "dd.MM.yyyy HH:mm", Dock = DockStyle.Fill };
            _dtArrival = new DateTimePicker { Value = _trip.ArrivalTime == default(DateTime) ? DateTime.Now.AddHours(3) : _trip.ArrivalTime, Format = DateTimePickerFormat.Custom, CustomFormat = "dd.MM.yyyy HH:mm", Dock = DockStyle.Fill };
            _numPrice = new NumericUpDown { DecimalPlaces = 2, Maximum = 500000, Value = _trip.Price <= 0 ? 1000 : _trip.Price, Dock = DockStyle.Fill };
            _txtBusNumber = new TextBox { Text = _trip.BusNumber ?? string.Empty, Dock = DockStyle.Fill };

            AddRow(layout, 0, "Город отправления", _txtDeparture);
            AddRow(layout, 1, "Город прибытия", _txtArrival);
            AddRow(layout, 2, "Дата и время отправления", _dtDeparture);
            AddRow(layout, 3, "Дата и время прибытия", _dtArrival);
            AddRow(layout, 4, "Цена", _numPrice);
            AddRow(layout, 5, "Номер автобуса", _txtBusNumber);

            var btnSave = UiTheme.CreatePrimaryButton("Сохранить", 180);
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Click += BtnSave_Click;

            group.Controls.Add(layout);
            panel.Controls.Add(group);
            panel.Controls.Add(btnSave);
            Controls.Add(panel);
        }

        private void AddRow(TableLayoutPanel table, int row, string label, Control control)
        {
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
            table.Controls.Add(new Label { Text = label, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, row);
            table.Controls.Add(control, 1, row);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var error = _tripService.Validate(_txtDeparture.Text, _txtArrival.Text, _dtDeparture.Value, _dtArrival.Value, _numPrice.Value);
            if (error != null)
            {
                MessageBox.Show(error, "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _trip.DepartureCity = _txtDeparture.Text.Trim();
            _trip.ArrivalCity = _txtArrival.Text.Trim();
            _trip.DepartureTime = _dtDeparture.Value;
            _trip.ArrivalTime = _dtArrival.Value;
            _trip.Price = _numPrice.Value;
            _trip.BusNumber = _txtBusNumber.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
