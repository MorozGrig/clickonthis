namespace BusStationApp.UI.Forms
{
    partial class AdminPanelForm
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
            this.wrapperPanel = new System.Windows.Forms.Panel();
            this.gridGroup = new System.Windows.Forms.GroupBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.wrapperPanel.SuspendLayout();
            this.gridGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.filterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.Controls.Add(this.gridGroup);
            this.wrapperPanel.Controls.Add(this.buttonsPanel);
            this.wrapperPanel.Controls.Add(this.filterGroup);
            this.wrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperPanel.Location = new System.Drawing.Point(0, 0);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Padding = new System.Windows.Forms.Padding(16);
            this.wrapperPanel.Size = new System.Drawing.Size(1100, 640);
            this.wrapperPanel.TabIndex = 0;
            // 
            // gridGroup
            // 
            this.gridGroup.Controls.Add(this.gridData);
            this.gridGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroup.Location = new System.Drawing.Point(16, 94);
            this.gridGroup.Name = "gridGroup";
            this.gridGroup.Size = new System.Drawing.Size(1068, 474);
            this.gridGroup.TabIndex = 2;
            this.gridGroup.TabStop = false;
            this.gridGroup.Text = "Данные";
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(3, 25);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.Size = new System.Drawing.Size(1062, 446);
            this.gridData.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.btnAdd);
            this.buttonsPanel.Controls.Add(this.btnEdit);
            this.buttonsPanel.Controls.Add(this.btnDelete);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(16, 568);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1068, 56);
            this.buttonsPanel.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(189, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 38);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.cmbTables);
            this.filterGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterGroup.Location = new System.Drawing.Point(16, 16);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(1068, 78);
            this.filterGroup.TabIndex = 0;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Раздел";
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Items.AddRange(new object[] {
            "Users",
            "Trips",
            "Orders"});
            this.cmbTables.Location = new System.Drawing.Point(16, 30);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(240, 31);
            this.cmbTables.TabIndex = 0;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.wrapperPanel);
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.wrapperPanel.ResumeLayout(false);
            this.gridGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.filterGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel wrapperPanel;
        private System.Windows.Forms.GroupBox gridGroup;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.ComboBox cmbTables;
    }
}
