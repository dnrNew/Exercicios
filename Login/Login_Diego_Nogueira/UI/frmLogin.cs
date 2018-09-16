using System;
using System.Windows.Forms;
using CamadaTrasferenciaDados;
using CamadaNegocio;

namespace CamadaInterface
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
               
        dto_Usuario d_usuario = new dto_Usuario();
        bll_Usuario b_usuario = new bll_Usuario();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastro = new frmCadastroUsuario();
            cadastro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
