using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public class UserEditForm : Form
    {
        private readonly User _user;
        private TextBox _txtName;
        private TextBox _txtEmail;
        private TextBox _txtPhone;
        private ComboBox _cmbRole;

        public User User => _user;

        public UserEditForm(User user)
        {
            _user = user;
            Text = "Редактирование пользователя";
            Width = 560;
            Height = 360;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            InitializeControls();
        }

        private void InitializeControls()
        {
            var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(16), BackColor = UiTheme.Surface };
            var group = new GroupBox { Text = "Данные пользователя", Dock = DockStyle.Fill };
            var table = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, Padding = new Padding(8) };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            _txtName = new TextBox { Text = _user.Name, Dock = DockStyle.Fill };
            _txtEmail = new TextBox { Text = _user.Email, Dock = DockStyle.Fill };
            _txtPhone = new TextBox { Text = _user.Phone, Dock = DockStyle.Fill };
            _cmbRole = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList };

            using (var context = new BusStationDbContext())
            {
                var roles = context.Roles.OrderBy(x => x.Id).ToList();
                _cmbRole.DataSource = roles;
                _cmbRole.DisplayMember = "Name";
                _cmbRole.ValueMember = "Id";
                _cmbRole.SelectedValue = _user.RoleId;
            }

            table.Controls.Add(new Label { Text = "Имя", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
            table.Controls.Add(_txtName, 1, 0);
            table.Controls.Add(new Label { Text = "Email", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 1);
            table.Controls.Add(_txtEmail, 1, 1);
            table.Controls.Add(new Label { Text = "Телефон", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 2);
            table.Controls.Add(_txtPhone, 1, 2);
            table.Controls.Add(new Label { Text = "Роль", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 3);
            table.Controls.Add(_cmbRole, 1, 3);

            var btnSave = UiTheme.CreatePrimaryButton("Сохранить", 160);
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(_txtName.Text))
                {
                    MessageBox.Show("Введите имя пользователя.", "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _user.Name = _txtName.Text.Trim();
                _user.Email = _txtEmail.Text.Trim();
                _user.Phone = _txtPhone.Text.Trim();
                _user.RoleId = (int)_cmbRole.SelectedValue;
                DialogResult = DialogResult.OK;
                Close();
            };

            group.Controls.Add(table);
            panel.Controls.Add(group);
            panel.Controls.Add(btnSave);
            Controls.Add(panel);
        }
    }
}
