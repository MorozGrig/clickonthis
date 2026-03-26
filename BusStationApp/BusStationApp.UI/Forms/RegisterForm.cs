using System.Drawing;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class RegisterForm : Form
    {
        private readonly AuthService _authService = new AuthService();
        private TextBox _txtName;
        private TextBox _txtEmail;
        private TextBox _txtPhone;
        private TextBox _txtPassword;

        public RegisterForm()
        {
            Text = "Регистрация";
            Width = 580;
            Height = 420;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            InitializeControls();
        }

        private void InitializeControls()
        {
            var container = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20), BackColor = UiTheme.Surface };
            var group = new GroupBox { Text = "Создание аккаунта", Dock = DockStyle.Top, Height = 250 };
            var formTable = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, Padding = new Padding(10) };
            formTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
            formTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            _txtName = new TextBox { Dock = DockStyle.Fill };
            _txtEmail = new TextBox { Dock = DockStyle.Fill };
            _txtPhone = new TextBox { Dock = DockStyle.Fill };
            _txtPassword = new TextBox { Dock = DockStyle.Fill, PasswordChar = '*' };

            formTable.Controls.Add(new Label { Text = "Имя", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 0);
            formTable.Controls.Add(_txtName, 1, 0);
            formTable.Controls.Add(new Label { Text = "Email", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 1);
            formTable.Controls.Add(_txtEmail, 1, 1);
            formTable.Controls.Add(new Label { Text = "Телефон", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 2);
            formTable.Controls.Add(_txtPhone, 1, 2);
            formTable.Controls.Add(new Label { Text = "Пароль", TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill }, 0, 3);
            formTable.Controls.Add(_txtPassword, 1, 3);

            var btnSave = UiTheme.CreatePrimaryButton("Создать аккаунт", 220);
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.Click += (s, e) =>
            {
                var result = _authService.Register(_txtName.Text, _txtEmail.Text, _txtPhone.Text, _txtPassword.Text);
                MessageBox.Show(result.IsSuccess ? "Регистрация выполнена успешно." : result.ErrorMessage, "Регистрация",
                    MessageBoxButtons.OK, result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                if (result.IsSuccess) Close();
            };

            group.Controls.Add(formTable);
            container.Controls.Add(btnSave);
            container.Controls.Add(group);
            btnSave.Top = 280;
            Controls.Add(container);
        }
    }
}
