namespace BusStationApp.UI.Forms
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registrationCardPanel = new System.Windows.Forms.Panel();
            this.actionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.formTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.registrationCardPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.formTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationCardPanel
            // 
            this.registrationCardPanel.Controls.Add(this.actionsPanel);
            this.registrationCardPanel.Controls.Add(this.formTableLayout);
            this.registrationCardPanel.Controls.Add(this.lblTitle);
            this.registrationCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationCardPanel.Location = new System.Drawing.Point(15, 13);
            this.registrationCardPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registrationCardPanel.Name = "registrationCardPanel";
            this.registrationCardPanel.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.registrationCardPanel.Size = new System.Drawing.Size(423, 274);
            this.registrationCardPanel.TabIndex = 0;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.btnBackToLogin);
            this.actionsPanel.Controls.Add(this.btnRegister);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionsPanel.Location = new System.Drawing.Point(15, 227);
            this.actionsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.actionsPanel.Size = new System.Drawing.Size(393, 34);
            this.actionsPanel.TabIndex = 2;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.AutoSize = true;
            this.btnBackToLogin.Location = new System.Drawing.Point(259, 7);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(132, 23);
            this.btnBackToLogin.TabIndex = 6;
            this.btnBackToLogin.Text = "Назад к входу";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Location = new System.Drawing.Point(88, 7);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(167, 25);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // formTableLayout
            // 
            this.formTableLayout.ColumnCount = 2;
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formTableLayout.Controls.Add(this.lblName, 0, 0);
            this.formTableLayout.Controls.Add(this.lblEmail, 0, 1);
            this.formTableLayout.Controls.Add(this.lblPhone, 0, 2);
            this.formTableLayout.Controls.Add(this.lblPassword, 0, 3);
            this.formTableLayout.Controls.Add(this.lblConfirmPassword, 0, 4);
            this.formTableLayout.Controls.Add(this.txtName, 1, 0);
            this.formTableLayout.Controls.Add(this.txtEmail, 1, 1);
            this.formTableLayout.Controls.Add(this.txtPhone, 1, 2);
            this.formTableLayout.Controls.Add(this.txtPassword, 1, 3);
            this.formTableLayout.Controls.Add(this.txtConfirmPassword, 1, 4);
            this.formTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTableLayout.Location = new System.Drawing.Point(15, 39);
            this.formTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formTableLayout.Name = "formTableLayout";
            this.formTableLayout.RowCount = 5;
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formTableLayout.Size = new System.Drawing.Size(393, 162);
            this.formTableLayout.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(2, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(2, 32);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(138, 32);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Location = new System.Drawing.Point(2, 64);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(138, 32);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Телефон";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(2, 96);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(138, 32);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmPassword.Location = new System.Drawing.Point(2, 128);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(138, 34);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Подтверждение пароля";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(144, 6);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(144, 38);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(144, 70);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(247, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(144, 102);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(247, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(144, 135);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.MaxLength = 25;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(247, 20);
            this.txtConfirmPassword.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(393, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Создание аккаунта";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 300);
            this.Controls.Add(this.registrationCardPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(469, 339);
            this.Name = "RegisterForm";
            this.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.registrationCardPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.actionsPanel.PerformLayout();
            this.formTableLayout.ResumeLayout(false);
            this.formTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registrationCardPanel;
        private System.Windows.Forms.FlowLayoutPanel actionsPanel;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TableLayoutPanel formTableLayout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblTitle;
    }
}
