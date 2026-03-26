namespace BusStationApp.UI.Forms
{
    partial class MainForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.actionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatalog = BusStationApp.UI.Helpers.UiTheme.CreatePrimaryButton("Каталог", 200);
            this.btnCart = BusStationApp.UI.Helpers.UiTheme.CreatePrimaryButton("Корзина", 200);
            this.btnOrders = BusStationApp.UI.Helpers.UiTheme.CreatePrimaryButton("История заказов", 200);
            this.btnAdmin = BusStationApp.UI.Helpers.UiTheme.CreatePrimaryButton("Админ-панель", 200);
            this.containerPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.actionsPanel);
            this.containerPanel.Controls.Add(this.headerLabel);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(20);
            this.containerPanel.Size = new System.Drawing.Size(700, 350);
            this.containerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.headerLabel.Location = new System.Drawing.Point(20, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(660, 35);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Главное меню";
            // 
            // actionsPanel
            // 
            this.actionsPanel.AutoScroll = true;
            this.actionsPanel.Controls.Add(this.btnCatalog);
            this.actionsPanel.Controls.Add(this.btnCart);
            this.actionsPanel.Controls.Add(this.btnOrders);
            this.actionsPanel.Controls.Add(this.btnAdmin);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsPanel.Location = new System.Drawing.Point(20, 55);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(660, 275);
            this.actionsPanel.TabIndex = 1;
            this.actionsPanel.WrapContents = true;
            // 
            // btnCatalog
            // 
            this.btnCatalog.Location = new System.Drawing.Point(3, 3);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(200, 38);
            this.btnCatalog.TabIndex = 0;
            this.btnCatalog.Text = "Каталог";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(209, 3);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(200, 38);
            this.btnCart.TabIndex = 1;
            this.btnCart.Text = "Корзина";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(415, 3);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 38);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "История заказов";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(3, 47);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 38);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Админ-панель";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.containerPanel);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.containerPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.FlowLayoutPanel actionsPanel;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAdmin;
    }
}
