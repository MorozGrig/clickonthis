namespace BusStationApp.UI.Forms
{
    partial class LoginForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.actionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.credentialsGroup = new System.Windows.Forms.GroupBox();
            this.credentialsTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.cardPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.credentialsGroup.SuspendLayout();
            this.credentialsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.cardPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(24);
            this.mainPanel.Size = new System.Drawing.Size(560, 430);
            this.mainPanel.TabIndex = 0;
            // 
            // cardPanel
            // 
            this.cardPanel.Controls.Add(this.actionsPanel);
            this.cardPanel.Controls.Add(this.credentialsGroup);
            this.cardPanel.Controls.Add(this.lblTitle);
            this.cardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPanel.Location = new System.Drawing.Point(24, 24);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Padding = new System.Windows.Forms.Padding(20);
            this.cardPanel.Size = new System.Drawing.Size(512, 382);
            this.cardPanel.TabIndex = 0;
            // 
            // actionsPanel
            // 
            this.actionsPanel.ColumnCount = 3;
            this.actionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.actionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.actionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.actionsPanel.Controls.Add(this.btnLogin, 0, 0);
            this.actionsPanel.Controls.Add(this.btnRegister, 1, 0);
            this.actionsPanel.Controls.Add(this.btnGuest, 2, 0);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsPanel.Location = new System.Drawing.Point(20, 312);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.RowCount = 1;
            this.actionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.actionsPanel.Size = new System.Drawing.Size(472, 50);
            this.actionsPanel.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 44);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.Location = new System.Drawing.Point(160, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(151, 44);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuest.Location = new System.Drawing.Point(317, 3);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(152, 44);
            this.btnGuest.TabIndex = 2;
            this.btnGuest.Text = "Продолжить как гость";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // credentialsGroup
            // 
            this.credentialsGroup.Controls.Add(this.credentialsTable);
            this.credentialsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.credentialsGroup.Location = new System.Drawing.Point(20, 55);
            this.credentialsGroup.Name = "credentialsGroup";
            this.credentialsGroup.Padding = new System.Windows.Forms.Padding(12);
            this.credentialsGroup.Size = new System.Drawing.Size(472, 170);
            this.credentialsGroup.TabIndex = 1;
            this.credentialsGroup.TabStop = false;
            this.credentialsGroup.Text = "Учетные данные";
            // 
            // credentialsTable
            // 
            this.credentialsTable.ColumnCount = 2;
            this.credentialsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.credentialsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.credentialsTable.Controls.Add(this.lblLogin, 0, 0);
            this.credentialsTable.Controls.Add(this.lblPassword, 0, 1);
            this.credentialsTable.Controls.Add(this.txtLogin, 1, 0);
            this.credentialsTable.Controls.Add(this.txtPassword, 1, 1);
            this.credentialsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.credentialsTable.Location = new System.Drawing.Point(12, 35);
            this.credentialsTable.Name = "credentialsTable";
            this.credentialsTable.RowCount = 2;
            this.credentialsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.credentialsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.credentialsTable.Size = new System.Drawing.Size(448, 123);
            this.credentialsTable.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogin.Location = new System.Drawing.Point(3, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(174, 50);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Email или телефон";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(3, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(174, 73);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Пароль";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLogin
            // 
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogin.Location = new System.Drawing.Point(183, 3);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(262, 29);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(183, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(262, 29);
            this.txtPassword.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(472, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Вход в систему";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 430);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(560, 430);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.mainPanel.ResumeLayout(false);
            this.cardPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.credentialsGroup.ResumeLayout(false);
            this.credentialsTable.ResumeLayout(false);
            this.credentialsTable.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.TableLayoutPanel actionsPanel;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox credentialsGroup;
        private System.Windows.Forms.TableLayoutPanel credentialsTable;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
    }
}
