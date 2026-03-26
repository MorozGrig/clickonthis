using System;
using System.Drawing;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();
        private TextBox _txtLogin;
        private TextBox _txtPassword;

        public LoginForm()
        {
            Text = "Авторизация";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(560, 430);
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            InitializeControls();
        }

        private void InitializeControls()
        {
            var mainPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(24) };
            var card = new Panel { Dock = DockStyle.Fill, BackColor = UiTheme.Surface, Padding = new Padding(20) };
            var title = new Label { Text = "Вход в систему", Dock = DockStyle.Top, Height = 35, Font = new Font("Segoe UI", 16F, FontStyle.Bold), ForeColor = UiTheme.TextPrimary };

            var group = new GroupBox { Text = "Учетные данные", Dock = DockStyle.Top, Height = 170, Padding = new Padding(12), ForeColor = UiTheme.TextPrimary };
            var table = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2 };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            _txtLogin = new TextBox { Dock = DockStyle.Fill };
            _txtPassword = new TextBox { Dock = DockStyle.Fill, PasswordChar = '*' };
            table.Controls.Add(new Label { Text = "Email или телефон", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
            table.Controls.Add(_txtLogin, 1, 0);
            table.Controls.Add(new Label { Text = "Пароль", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 1);
            table.Controls.Add(_txtPassword, 1, 1);
            group.Controls.Add(table);

            var actions = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 50, FlowDirection = FlowDirection.LeftToRight };
            var btnLogin = UiTheme.CreatePrimaryButton("Войти");
            var btnRegister = new Button { Text = "Регистрация", Width = 180, Height = 38 };
            var btnGuest = new Button { Text = "Продолжить как гость", Width = 180, Height = 38 };
            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += (s, e) => new RegisterForm().ShowDialog();
            btnGuest.Click += (s, e) => OpenMain(0, "Гость", UserRole.Guest);

            actions.Controls.AddRange(new Control[] { btnLogin, btnRegister, btnGuest });

            card.Controls.Add(actions);
            card.Controls.Add(group);
            card.Controls.Add(title);
            mainPanel.Controls.Add(card);
            Controls.Add(mainPanel);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = _authService.Login(_txtLogin.Text, _txtPassword.Text);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenMain(result.UserId, result.UserName, result.Role);
        }

        private void OpenMain(int userId, string userName, UserRole role)
        {
            Hide();
            new MainForm(userId, userName, role).ShowDialog();
            Show();
        }
    }
}
