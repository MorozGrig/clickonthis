using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;
using BusStationApp.UI.Helpers;

namespace BusStationApp.UI.Forms
{
    public partial class UserEditForm : Form
    {
        private readonly User _user;

        public User User => _user;

        public UserEditForm(User user)
        {
            _user = user;
            InitializeComponent();
            ApplyTheme();
            FillForm();
            LoadRoles();
        }

        private void ApplyTheme()
        {
            BackColor = UiTheme.Background;
            Font = new Font("Segoe UI", 10F);
            panelContainer.BackColor = UiTheme.Surface;

        }

        private void FillForm()
        {
            txtName.Text = _user.Name;
            txtEmail.Text = _user.Email;
            txtPhone.Text = _user.Phone;
        }

        private void LoadRoles()
        {
            using (var context = new BusStationDbContext())
            {
                var roles = context.Roles.OrderBy(x => x.Id).ToList();
                cmbRole.DataSource = roles;
                cmbRole.DisplayMember = "Name";
                cmbRole.ValueMember = "Id";
                cmbRole.SelectedValue = _user.RoleId;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите имя пользователя.", "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _user.Name = txtName.Text.Trim();
            _user.Email = txtEmail.Text.Trim();
            _user.Phone = txtPhone.Text.Trim();
            _user.RoleId = (int)cmbRole.SelectedValue;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
