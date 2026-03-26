using System;
using System.Windows.Forms;
using BusStationApp.BLL.Services;

namespace BusStationApp.UI.Forms
{
    public class RegisterForm : Form
    {
        private readonly AuthService _authService = new AuthService();
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtPassword;

        public RegisterForm()
        {
            Text = "Регистрация";
            Width = 400;
            Height = 300;
            Init();
        }

        private void Init()
        {
            txtName = new TextBox { Left = 20, Top = 30, Width = 330 };
            txtEmail = new TextBox { Left = 20, Top = 80, Width = 330 };
            txtPhone = new TextBox { Left = 20, Top = 130, Width = 330 };
            txtPassword = new TextBox { Left = 20, Top = 140, Width = 330, PasswordChar = '*' };
            txtPassword.Top = 180;
            var btnSave = new Button { Left = 20, Top = 230, Width = 330, Text = "Создать аккаунт", Name = "btnSave" };
            Controls.Add(new Label { Left = 20, Top = 10, Width = 330, Text = "Имя" });
            Controls.Add(new Label { Left = 20, Top = 60, Width = 330, Text = "Email" });
            Controls.Add(new Label { Left = 20, Top = 110, Width = 330, Text = "Телефон" });
            Controls.Add(new Label { Left = 20, Top = 160, Width = 330, Text = "Пароль" });

            btnSave.Click += (s, e) =>
            {
                var result = _authService.Register(txtName.Text, txtEmail.Text, txtPhone.Text, txtPassword.Text);
                MessageBox.Show(result.IsSuccess ? "Успешная регистрация." : result.ErrorMessage);
                if (result.IsSuccess)
                {
                    Close();
                }
            };

            Controls.AddRange(new Control[] { txtName, txtEmail, txtPhone, txtPassword, btnSave });
        }
    }
}
