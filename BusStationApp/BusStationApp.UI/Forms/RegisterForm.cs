using System;
using System.Drawing;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Validation;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        public RegisterForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            registrationCardPanel.BackColor = UiTheme.Surface;
            lblTitle.ForeColor = UiTheme.TextPrimary;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var validationError = ValidateRegistrationInput();
            if (!string.IsNullOrEmpty(validationError))
            {
                MessageBox.Show(validationError, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _authService.Register(
                txtName.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPhone.Text.Trim(),
                txtPassword.Text);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Регистрация выполнена успешно.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearRegistrationForm();
        }

        private string ValidateRegistrationInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) return "Введите имя.";
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) return "Введите email.";
            if (!InputValidator.IsValidEmail(txtEmail.Text.Trim())) return "Введите корректный email(text@example.com).";
            if (string.IsNullOrWhiteSpace(txtPhone.Text)) return "Введите телефон.";
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) return "Введите пароль.";
            if (txtPassword.Text.Length < 6) return "Пароль должен содержать минимум 6 символов.";
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) return "Подтвердите пароль.";
            if (!string.Equals(txtPassword.Text, txtConfirmPassword.Text, StringComparison.Ordinal))
            {
                return "Пароль и подтверждение не совпадают.";
            }

            return string.Empty;
        }

        private void ClearRegistrationForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtName.Focus();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
