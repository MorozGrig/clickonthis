using System;
using System.Drawing;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            cardPanel.BackColor = UiTheme.Surface;
            lblTitle.ForeColor = UiTheme.TextPrimary;
            UiTheme.ApplyPrimaryButtonStyle(btnLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = _authService.Login(txtLogin.Text, txtPassword.Text);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenMain(result.UserId, result.UserName, result.Role);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm())
            {
                registerForm.ShowDialog(this);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            OpenMain(0, "Гость", UserRole.Guest);
        }

        private void OpenMain(int userId, string userName, UserRole role)
        {
            Hide();
            using (var main = new MainForm(userId, userName, role))
            {
                main.ShowDialog(this);
            }
            Show();
        }
    }
}
