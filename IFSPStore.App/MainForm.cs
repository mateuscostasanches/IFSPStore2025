

using ReaLTaiizor.Forms;
using IFSPStore.App.Login;
using IFSPStore.App.Infra;
using IFSPStore.App.Register;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {

        #region Variables
        public static User user;
        #endregion 

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            LoadLogin();
        }
        #endregion

        #region Events ToolStripMenuItem Clicks
        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CategoryForm>();
        }

        private void CityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CityForm>();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CustomerForm>();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<ProductForm>();
        }

        private void SaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<SaleForm>();
        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<UserForm>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Methods
        private void ShowForm<TForms>()  where TForms : Form
        {
            var cad = ConfigureDI.serviceProvider!.GetService<TForms>();
            if (cad != null && !cad.IsDisposed) cad.ShowDialog();
        }

        private void LoadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<LoginForm>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }
        #endregion

    }

}
