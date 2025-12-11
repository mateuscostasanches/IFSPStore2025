

using ReaLTaiizor.Forms;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;

namespace IFSPStore.App.Login
{

    public partial class LoginForm : MaterialForm
    {

        private readonly IBaseService<User> _userService;

        #region Constructor
        public LoginForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        #endregion

        #region Methods
        private User? GetUser(string login, string password)
        {
            CheckUser();
            var user = _userService.Get<User>().Where(x => x.Login == login).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }

        private void CheckUser()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Login = "admin",
                    Password = "AdminSystem",
                    Name = "System Admin",
                    IsActive = true,
                    RegisterDate = DateTime.Now,
                    Email = "admin@gmail.com"
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }
        #endregion

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? user = GetUser(txtLogin.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!user.IsActive)
            {
                MessageBox.Show("User inactive!", "IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.LoginDate = DateTime.Now;
                user = _userService.Update<User, User, UserValidator>(user);
                MainForm.user = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

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
