namespace BusStationApp.UI.Forms
{
    partial class TripEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.groupTrip = new System.Windows.Forms.GroupBox();
            this.tableTrip = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBusNumber = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.dtDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.groupTrip.SuspendLayout();
            this.tableTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.groupTrip);
            this.panelContainer.Controls.Add(this.btnSave);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(16);
            this.panelContainer.Size = new System.Drawing.Size(620, 420);
            this.panelContainer.TabIndex = 0;
            // 
            // groupTrip
            // 
            this.groupTrip.Controls.Add(this.tableTrip);
            this.groupTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTrip.Location = new System.Drawing.Point(16, 16);
            this.groupTrip.Name = "groupTrip";
            this.groupTrip.Padding = new System.Windows.Forms.Padding(8);
            this.groupTrip.Size = new System.Drawing.Size(588, 350);
            this.groupTrip.TabIndex = 0;
            this.groupTrip.TabStop = false;
            this.groupTrip.Text = "Данные рейса";
            // 
            // tableTrip
            // 
            this.tableTrip.ColumnCount = 2;
            this.tableTrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableTrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTrip.Controls.Add(this.lblDeparture, 0, 0);
            this.tableTrip.Controls.Add(this.lblArrival, 0, 1);
            this.tableTrip.Controls.Add(this.lblDepartureTime, 0, 2);
            this.tableTrip.Controls.Add(this.lblArrivalTime, 0, 3);
            this.tableTrip.Controls.Add(this.lblPrice, 0, 4);
            this.tableTrip.Controls.Add(this.lblBusNumber, 0, 5);
            this.tableTrip.Controls.Add(this.txtDeparture, 1, 0);
            this.tableTrip.Controls.Add(this.txtArrival, 1, 1);
            this.tableTrip.Controls.Add(this.dtDeparture, 1, 2);
            this.tableTrip.Controls.Add(this.dtArrival, 1, 3);
            this.tableTrip.Controls.Add(this.numPrice, 1, 4);
            this.tableTrip.Controls.Add(this.txtBusNumber, 1, 5);
            this.tableTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTrip.Location = new System.Drawing.Point(8, 28);
            this.tableTrip.Name = "tableTrip";
            this.tableTrip.RowCount = 6;
            this.tableTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableTrip.Size = new System.Drawing.Size(572, 314);
            this.tableTrip.TabIndex = 0;
            // 
            // lblDeparture
            // 
            this.lblDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeparture.Location = new System.Drawing.Point(3, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(214, 42);
            this.lblDeparture.TabIndex = 0;
            this.lblDeparture.Text = "Город отправления";
            this.lblDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArrival
            // 
            this.lblArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArrival.Location = new System.Drawing.Point(3, 42);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(214, 42);
            this.lblArrival.TabIndex = 1;
            this.lblArrival.Text = "Город прибытия";
            this.lblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartureTime.Location = new System.Drawing.Point(3, 84);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(214, 42);
            this.lblDepartureTime.TabIndex = 2;
            this.lblDepartureTime.Text = "Дата и время отправления";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArrivalTime.Location = new System.Drawing.Point(3, 126);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(214, 42);
            this.lblArrivalTime.TabIndex = 3;
            this.lblArrivalTime.Text = "Дата и время прибытия";
            this.lblArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(3, 168);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(214, 42);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Цена";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBusNumber
            // 
            this.lblBusNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBusNumber.Location = new System.Drawing.Point(3, 210);
            this.lblBusNumber.Name = "lblBusNumber";
            this.lblBusNumber.Size = new System.Drawing.Size(214, 104);
            this.lblBusNumber.TabIndex = 5;
            this.lblBusNumber.Text = "Номер автобуса";
            this.lblBusNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeparture.Location = new System.Drawing.Point(223, 3);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(346, 29);
            this.txtDeparture.TabIndex = 0;
            // 
            // txtArrival
            // 
            this.txtArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArrival.Location = new System.Drawing.Point(223, 45);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(346, 29);
            this.txtArrival.TabIndex = 1;
            // 
            // dtDeparture
            // 
            this.dtDeparture.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeparture.Location = new System.Drawing.Point(223, 87);
            this.dtDeparture.Name = "dtDeparture";
            this.dtDeparture.Size = new System.Drawing.Size(346, 29);
            this.dtDeparture.TabIndex = 2;
            // 
            // dtArrival
            // 
            this.dtArrival.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrival.Location = new System.Drawing.Point(223, 129);
            this.dtArrival.Name = "dtArrival";
            this.dtArrival.Size = new System.Drawing.Size(346, 29);
            this.dtArrival.TabIndex = 3;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPrice.Location = new System.Drawing.Point(223, 171);
            this.numPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(346, 29);
            this.numPrice.TabIndex = 4;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusNumber.Location = new System.Drawing.Point(223, 213);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(346, 29);
            this.txtBusNumber.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(16, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(588, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TripEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.panelContainer);
            this.Name = "TripEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование рейса";
            this.panelContainer.ResumeLayout(false);
            this.groupTrip.ResumeLayout(false);
            this.tableTrip.ResumeLayout(false);
            this.tableTrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox groupTrip;
        private System.Windows.Forms.TableLayoutPanel tableTrip;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBusNumber;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.DateTimePicker dtDeparture;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Button btnSave;
    }
}
