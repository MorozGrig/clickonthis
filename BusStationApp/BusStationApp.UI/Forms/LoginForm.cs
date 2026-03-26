using System;
using System.Drawing;
using System.Windows.Forms;
using BusStationApp.BLL.Services;

namespace BusStationApp.UI.Forms
{
    public class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        private readonly Color _primaryColor = Color.FromArgb(37, 99, 235);
        private readonly Color _secondaryColor = Color.FromArgb(30, 41, 59);
        private readonly Color _backgroundColor = Color.FromArgb(241, 245, 249);
        private readonly Color _placeholderColor = Color.Gray;

        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;

        public LoginForm()
        {
            Text = "Авторизация";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(520, 420);
            BackColor = _backgroundColor;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InitializeControls();
        }

        private void InitializeControls()
        {
            var mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24)
            };

            var cardPanel = new Panel
            {
                Width = 440,
                Height = 290,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.None
            };

            var title = new Label
            {
                Text = "Вход в систему",
                Left = 24,
                Top = 18,
                Width = 380,
                Height = 32,
                ForeColor = _secondaryColor,
                Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold)
            };

            var groupCredentials = new GroupBox
            {
                Text = "Учетные данные",
                Left = 20,
                Top = 58,
                Width = 396,
                Height = 145,
                ForeColor = _secondaryColor
            };

            var lblLogin = new Label { Left = 14, Top = 30, Width = 160, Text = "Email или телефон" };
            var lblPassword = new Label { Left = 14, Top = 82, Width = 160, Text = "Пароль" };

            txtLogin = new TextBox { Left = 170, Top = 26, Width = 200, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            txtPassword = new TextBox { Left = 170, Top = 78, Width = 200, PasswordChar = '*', Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };

            SetPlaceholder(txtLogin, "example@mail.com или +79990000000");
            SetPlaceholder(txtPassword, "Введите пароль", true);

            btnLogin = new Button
            {
                Left = 20,
                Top = 220,
                Width = 190,
                Height = 38,
                Text = "Войти",
                Name = "btnLogin",
                BackColor = _primaryColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnLogin.FlatAppearance.BorderSize = 0;

            btnRegister = new Button
            {
                Left = 226,
                Top = 220,
                Width = 190,
                Height = 38,
                Text = "Регистрация",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = _secondaryColor
            };
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);

            AddHoverEffect(btnLogin, _primaryColor, Color.FromArgb(29, 78, 216));
            AddHoverEffect(btnRegister, Color.White, Color.FromArgb(241, 245, 249));

            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += (s, e) => new RegisterForm().ShowDialog();

            groupCredentials.Controls.AddRange(new Control[] { lblLogin, txtLogin, lblPassword, txtPassword });
            cardPanel.Controls.AddRange(new Control[] { title, groupCredentials, btnLogin, btnRegister });

            mainPanel.Controls.Add(cardPanel);
            Controls.Add(mainPanel);

            mainPanel.Resize += (s, e) => CenterCard(cardPanel, mainPanel);
            CenterCard(cardPanel, mainPanel);
        }

        private void CenterCard(Control card, Control parent)
        {
            card.Left = Math.Max(0, (parent.ClientSize.Width - card.Width) / 2);
            card.Top = Math.Max(0, (parent.ClientSize.Height - card.Height) / 2);
        }

        private void AddHoverEffect(Button button, Color normalColor, Color hoverColor)
        {
            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = normalColor;
        }

        private void SetPlaceholder(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.Tag = placeholder;
            textBox.Text = placeholder;
            textBox.ForeColor = _placeholderColor;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text != placeholder)
                {
                    return;
                }

                textBox.Text = string.Empty;
                textBox.ForeColor = _secondaryColor;
                if (isPassword)
                {
                    textBox.PasswordChar = '*';
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return;
                }

                textBox.Text = placeholder;
                textBox.ForeColor = _placeholderColor;
                if (isPassword)
                {
                    textBox.PasswordChar = '\0';
                }
            };

            if (isPassword)
            {
                textBox.PasswordChar = '\0';
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var login = txtLogin.Text == txtLogin.Tag?.ToString() ? string.Empty : txtLogin.Text.Trim();
                var password = txtPassword.Text == txtPassword.Tag?.ToString() ? string.Empty : txtPassword.Text;

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Введите email/телефон и пароль.", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = _authService.Login(login, password);
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
                MessageBox.Show("Ошибка при входе: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
