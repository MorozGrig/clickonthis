namespace BusStationApp.UI.Forms
{
    partial class CatalogForm
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
            this.containerPanel = new System.Windows.Forms.Panel();
            this.ticketsGroup = new System.Windows.Forms.GroupBox();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.ticketActionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.containerPanel.SuspendLayout();
            this.ticketsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.ticketActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.ticketsGroup);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(16);
            this.containerPanel.Size = new System.Drawing.Size(980, 560);
            this.containerPanel.TabIndex = 0;
            // 
            // ticketsGroup
            // 
            this.ticketsGroup.Controls.Add(this.dgvTrips);
            this.ticketsGroup.Controls.Add(this.ticketActionsPanel);
            this.ticketsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketsGroup.Location = new System.Drawing.Point(16, 16);
            this.ticketsGroup.Name = "ticketsGroup";
            this.ticketsGroup.Size = new System.Drawing.Size(948, 528);
            this.ticketsGroup.TabIndex = 0;
            this.ticketsGroup.TabStop = false;
            this.ticketsGroup.Text = "Доступные билеты";
            // 
            // dgvTrips
            // 
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrips.Location = new System.Drawing.Point(3, 25);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.Size = new System.Drawing.Size(942, 448);
            this.dgvTrips.TabIndex = 0;
            // 
            // ticketActionsPanel
            // 
            this.ticketActionsPanel.Controls.Add(this.btnBuyTicket);
            this.ticketActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ticketActionsPanel.Location = new System.Drawing.Point(3, 473);
            this.ticketActionsPanel.Name = "ticketActionsPanel";
            this.ticketActionsPanel.Size = new System.Drawing.Size(942, 52);
            this.ticketActionsPanel.TabIndex = 1;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(3, 3);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(210, 38);
            this.btnBuyTicket.TabIndex = 0;
            this.btnBuyTicket.Text = "Купить";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.containerPanel);
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог билетов";
            this.containerPanel.ResumeLayout(false);
            this.ticketsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ticketActionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox ticketsGroup;
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.FlowLayoutPanel ticketActionsPanel;
        private System.Windows.Forms.Button btnBuyTicket;
    }
}
