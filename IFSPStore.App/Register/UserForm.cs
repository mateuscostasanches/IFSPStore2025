
using IFSPStore.App.Base;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Register
{

    public partial class UserForm : BaseForm
    {

        #region Variables
        public IBaseService<User> _userService;
        public List<UserViewModel>? users;
        #endregion

        #region Constructor
        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void FormToObject(User user)
        {
            user.Name = txtName.Text;
            user.Login = txtLogin.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.RegisterDate = DateTime.Now.Date;
            user.LoginDate = DateTime.Now.Date;
            user.IsActive = checkIsActive.Checked;

        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var user = _userService.GetById<User>(id);
                    FormToObject(user);
                    user = _userService.Update<User, User, UserValidator>(user);
                }
                else
                {
                    var user = new User();
                    FormToObject(user);
                    _userService.Add<User, User, UserValidator>(user);
                }
                tabControlRegister.SelectedIndex = 1;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _userService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            users = _userService.Get<UserViewModel>().ToList();
            dataGridViewList.DataSource = users;
            dataGridViewList.Columns["Name"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Login"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Email"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Password"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["Password"]!.Visible = false;
            dataGridViewList.Columns["RegisterDate"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["RegisterDate"]!.HeaderText = "Register Date";
            dataGridViewList.Columns["LoginDate"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["LoginDate"]!.HeaderText = "Login Date";
            dataGridViewList.Columns["IsActive"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewList.Columns["IsActive"]!.HeaderText = "Is Active";
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            txtId.Text = record!.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtLogin.Text = record.Cells["Login"].Value.ToString();
            txtEmail.Text = record.Cells["Email"].Value.ToString();
            txtPassword.Text = record.Cells["Password"].Value.ToString();
            checkIsActive.Checked = (bool)record.Cells["IsActive"].Value;
            record.Cells["RegisterDate"].Value.ToString();
            record.Cells["LoginDate"].Value.ToString();
        }
        #endregion

        #region Events
        private void txtPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.TrailingIcon = Properties.Resources.hidden;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtPassword.TrailingIcon = Properties.Resources.eye;
            }
            txtPassword.Focus();
        }
        #endregion 

    }
}
