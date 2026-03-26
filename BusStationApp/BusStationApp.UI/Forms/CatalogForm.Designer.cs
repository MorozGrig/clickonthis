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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.productsGroup = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productActionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.tripsGroup = new System.Windows.Forms.GroupBox();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.productsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.productActionsPanel.SuspendLayout();
            this.tripsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.mainSplitContainer);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(16);
            this.containerPanel.Size = new System.Drawing.Size(1100, 620);
            this.containerPanel.TabIndex = 0;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(16, 16);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.productsGroup);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tripsGroup);
            this.mainSplitContainer.Size = new System.Drawing.Size(1068, 588);
            this.mainSplitContainer.SplitterDistance = 260;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // productsGroup
            // 
            this.productsGroup.Controls.Add(this.dgvProducts);
            this.productsGroup.Controls.Add(this.productActionsPanel);
            this.productsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGroup.Location = new System.Drawing.Point(0, 0);
            this.productsGroup.Name = "productsGroup";
            this.productsGroup.Size = new System.Drawing.Size(1068, 260);
            this.productsGroup.TabIndex = 0;
            this.productsGroup.TabStop = false;
            this.productsGroup.Text = "Товары/услуги";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 25);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(1062, 180);
            this.dgvProducts.TabIndex = 0;
            // 
            // productActionsPanel
            // 
            this.productActionsPanel.Controls.Add(this.btnAddToCart);
            this.productActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productActionsPanel.Location = new System.Drawing.Point(3, 205);
            this.productActionsPanel.Name = "productActionsPanel";
            this.productActionsPanel.Size = new System.Drawing.Size(1062, 52);
            this.productActionsPanel.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(3, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(210, 38);
            this.btnAddToCart.TabIndex = 0;
            this.btnAddToCart.Text = "Добавить в корзину";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // tripsGroup
            // 
            this.tripsGroup.Controls.Add(this.dgvTrips);
            this.tripsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tripsGroup.Location = new System.Drawing.Point(0, 0);
            this.tripsGroup.Name = "tripsGroup";
            this.tripsGroup.Size = new System.Drawing.Size(1068, 324);
            this.tripsGroup.TabIndex = 0;
            this.tripsGroup.TabStop = false;
            this.tripsGroup.Text = "Рейсы";
            // 
            // dgvTrips
            // 
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrips.Location = new System.Drawing.Point(3, 25);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.Size = new System.Drawing.Size(1062, 296);
            this.dgvTrips.TabIndex = 0;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.containerPanel);
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог";
            this.containerPanel.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.productsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.productActionsPanel.ResumeLayout(false);
            this.tripsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.GroupBox productsGroup;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.FlowLayoutPanel productActionsPanel;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.GroupBox tripsGroup;
        private System.Windows.Forms.DataGridView dgvTrips;
    }
}
