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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.groupCart = new System.Windows.Forms.GroupBox();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.btnCheckout = new System.Windows.Forms.Button();
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
            this.containerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.containerPanel.Size = new System.Drawing.Size(585, 325);
            this.containerPanel.TabIndex = 0;
            // 
            // groupCart
            // 
            this.groupCart.Controls.Add(this.gridCart);
            this.groupCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCart.Location = new System.Drawing.Point(12, 10);
            this.groupCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupCart.Name = "groupCart";
            this.groupCart.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupCart.Size = new System.Drawing.Size(561, 280);
            this.groupCart.TabIndex = 0;
            this.groupCart.TabStop = false;
            this.groupCart.Text = "Билеты в корзине";
            // 
            // gridCart
            // 
            this.gridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCart.Location = new System.Drawing.Point(2, 15);
            this.gridCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridCart.Name = "gridCart";
            this.gridCart.RowHeadersWidth = 51;
            this.gridCart.Size = new System.Drawing.Size(557, 263);
            this.gridCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckout.Location = new System.Drawing.Point(12, 290);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(561, 25);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Оформить заказ";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 325);
            this.Controls.Add(this.containerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
