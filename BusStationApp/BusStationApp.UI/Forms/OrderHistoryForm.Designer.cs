namespace BusStationApp.UI.Forms
{
    partial class OrderHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistoryForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.gridOrders);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelContainer.Size = new System.Drawing.Size(570, 292);
            this.panelContainer.TabIndex = 0;
            // 
            // gridOrders
            // 
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrders.Location = new System.Drawing.Point(12, 10);
            this.gridOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RowHeadersWidth = 51;
            this.gridOrders.Size = new System.Drawing.Size(546, 272);
            this.gridOrders.TabIndex = 0;
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 292);
            this.Controls.Add(this.panelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderHistoryForm";
            this.Text = "История заказов";
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView gridOrders;
    }
}
