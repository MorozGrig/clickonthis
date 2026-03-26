namespace BusStationApp.UI.Forms
{
    partial class UserEditForm
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
            this.groupUser = new System.Windows.Forms.GroupBox();
            this.tableUser = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.groupUser.SuspendLayout();
            this.tableUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.groupUser);
            this.panelContainer.Controls.Add(this.btnSave);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(16);
            this.panelContainer.Size = new System.Drawing.Size(560, 360);
            this.panelContainer.TabIndex = 0;
            // 
            // groupUser
            // 
            this.groupUser.Controls.Add(this.tableUser);
            this.groupUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupUser.Location = new System.Drawing.Point(16, 16);
            this.groupUser.Name = "groupUser";
            this.groupUser.Padding = new System.Windows.Forms.Padding(8);
            this.groupUser.Size = new System.Drawing.Size(528, 290);
            this.groupUser.TabIndex = 0;
            this.groupUser.TabStop = false;
            this.groupUser.Text = "Данные пользователя";
            // 
            // tableUser
            // 
            this.tableUser.ColumnCount = 2;
            this.tableUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUser.Controls.Add(this.lblName, 0, 0);
            this.tableUser.Controls.Add(this.lblEmail, 0, 1);
            this.tableUser.Controls.Add(this.lblPhone, 0, 2);
            this.tableUser.Controls.Add(this.lblRole, 0, 3);
            this.tableUser.Controls.Add(this.txtName, 1, 0);
            this.tableUser.Controls.Add(this.txtEmail, 1, 1);
            this.tableUser.Controls.Add(this.txtPhone, 1, 2);
            this.tableUser.Controls.Add(this.cmbRole, 1, 3);
            this.tableUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUser.Location = new System.Drawing.Point(8, 28);
            this.tableUser.Name = "tableUser";
            this.tableUser.RowCount = 4;
            this.tableUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableUser.Size = new System.Drawing.Size(512, 254);
            this.tableUser.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 48);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(3, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(174, 48);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Location = new System.Drawing.Point(3, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(174, 48);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Телефон";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRole
            // 
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Location = new System.Drawing.Point(3, 144);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(174, 110);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Роль";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(183, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 29);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(183, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Location = new System.Drawing.Point(183, 99);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(326, 29);
            this.txtPhone.TabIndex = 2;
            // 
            // cmbRole
            // 
            this.cmbRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(183, 147);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(326, 31);
            this.cmbRole.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(16, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(528, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Controls.Add(this.panelContainer);
            this.Name = "UserEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование пользователя";
            this.panelContainer.ResumeLayout(false);
            this.groupUser.ResumeLayout(false);
            this.tableUser.ResumeLayout(false);
            this.tableUser.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox groupUser;
        private System.Windows.Forms.TableLayoutPanel tableUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSave;
    }
}
