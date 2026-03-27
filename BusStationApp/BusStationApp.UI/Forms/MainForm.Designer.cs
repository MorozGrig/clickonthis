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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.actionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
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
            this.containerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.containerPanel.Size = new System.Drawing.Size(525, 227);
            this.containerPanel.TabIndex = 0;
            // 
            // actionsPanel
            // 
            this.actionsPanel.ColumnCount = 2;
            this.actionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionsPanel.Controls.Add(this.btnCatalog, 0, 0);
            this.actionsPanel.Controls.Add(this.btnCart, 1, 0);
            this.actionsPanel.Controls.Add(this.btnOrders, 0, 1);
            this.actionsPanel.Controls.Add(this.btnAdmin, 1, 1);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsPanel.Location = new System.Drawing.Point(15, 39);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.RowCount = 3;
            this.actionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.actionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.actionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.actionsPanel.Size = new System.Drawing.Size(495, 175);
            this.actionsPanel.TabIndex = 1;
            // 
            // btnCatalog
            // 
            this.btnCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCatalog.Location = new System.Drawing.Point(2, 2);
            this.btnCatalog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(243, 30);
            this.btnCatalog.TabIndex = 0;
            this.btnCatalog.Text = "Каталог";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCart.Location = new System.Drawing.Point(249, 2);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(244, 30);
            this.btnCart.TabIndex = 1;
            this.btnCart.Text = "Корзина";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.Location = new System.Drawing.Point(2, 36);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(243, 30);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "История заказов";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmin.Location = new System.Drawing.Point(249, 36);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(244, 30);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Админ-панель";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.headerLabel.Location = new System.Drawing.Point(15, 13);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(495, 26);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Главное меню";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 227);
            this.Controls.Add(this.containerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(484, 222);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.containerPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TableLayoutPanel actionsPanel;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAdmin;
    }
}
