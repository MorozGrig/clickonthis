using System;
using System.Windows.Forms;
using BusStationApp.BLL.Services;

namespace BusStationApp.UI.Forms
{
    public class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;

        public LoginForm()
        {
            Text = "Авторизация";
            Width = 360;
            Height = 220;
            InitializeControls();
        }

        private void InitializeControls()
        {
            txtLogin = new TextBox { Left = 20, Top = 20, Width = 300 };
            txtPassword = new TextBox { Left = 20, Top = 60, Width = 300, PasswordChar = '*' };
            btnLogin = new Button { Left = 20, Top = 100, Width = 145, Text = "Войти", Name = "btnLogin" };
            btnRegister = new Button { Left = 175, Top = 100, Width = 145, Text = "Регистрация" };

            var lblLogin = new Label { Left = 20, Top = 2, Width = 300, Text = "Email или телефон" };
            var lblPassword = new Label { Left = 20, Top = 42, Width = 300, Text = "Пароль" };

            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += (s, e) => new RegisterForm().ShowDialog();

            Controls.AddRange(new Control[] { lblLogin, txtLogin, lblPassword, txtPassword, btnLogin, btnRegister });
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _authService.Login(txtLogin.Text.Trim(), txtPassword.Text);
                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.ErrorMessage, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Hide();
                new MainForm(result.UserId, result.UserName, result.Role).ShowDialog();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
