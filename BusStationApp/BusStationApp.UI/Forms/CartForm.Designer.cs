namespace BusStationApp.UI.Forms
{
    partial class CartForm
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
            this.groupCart = new System.Windows.Forms.GroupBox();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.btnCheckout = BusStationApp.UI.Helpers.UiTheme.CreatePrimaryButton("Оформить заказ", 200);
            this.containerPanel.SuspendLayout();
            this.groupCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.groupCart);
            this.containerPanel.Controls.Add(this.btnCheckout);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(16);
            this.containerPanel.Size = new System.Drawing.Size(780, 500);
            this.containerPanel.TabIndex = 0;
            // 
            // groupCart
            // 
            this.groupCart.Controls.Add(this.gridCart);
            this.groupCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCart.Location = new System.Drawing.Point(16, 16);
            this.groupCart.Name = "groupCart";
            this.groupCart.Size = new System.Drawing.Size(748, 430);
            this.groupCart.TabIndex = 0;
            this.groupCart.TabStop = false;
            this.groupCart.Text = "Товары в корзине";
            // 
            // gridCart
            // 
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCart.Location = new System.Drawing.Point(3, 25);
            this.gridCart.Name = "gridCart";
            this.gridCart.RowHeadersWidth = 51;
            this.gridCart.Size = new System.Drawing.Size(742, 402);
            this.gridCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckout.Location = new System.Drawing.Point(16, 446);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(748, 38);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Оформить заказ";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.containerPanel);
            this.Name = "CartForm";
            this.Text = "Корзина";
            this.containerPanel.ResumeLayout(false);
            this.groupCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.GroupBox groupCart;
        private System.Windows.Forms.DataGridView gridCart;
        private System.Windows.Forms.Button btnCheckout;
    }
}
