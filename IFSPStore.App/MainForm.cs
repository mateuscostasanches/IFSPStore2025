using IFSPStore.App.Infra;
using IFSPStore.App.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CategoryForm>();
        }

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.serviceProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
