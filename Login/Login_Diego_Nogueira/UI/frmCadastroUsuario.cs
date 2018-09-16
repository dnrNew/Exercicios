using System;
using System.Windows.Forms;
using CamadaNegocio;
using CamadaTrasferenciaDados;


namespace CamadaInterface
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        dto_Usuario d_usuario = new dto_Usuario();
        bll_Usuario b_usuario = new bll_Usuario();

        public void Limpar()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            txtNome.Focus();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtLogin.Text != string.Empty && txtSenha.Text != string.Empty && txtConfirmaSenha.Text != string.Empty && txtConfirmaSenha.Text == txtSenha.Text)
            {
                d_usuario.Nome = txtNome.Text;
                d_usuario.Login = txtLogin.Text;
                d_usuario.Senha = txtSenha.Text;

                b_usuario.InserirUsuario(d_usuario);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }

            else
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
        }
                
        private void txtNome_Validated(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Prencha o Nome", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
        }

        private void txtLogin_Validated_1(object sender, EventArgs e)
        {
            if (txtLogin.Text == string.Empty)
            {
                MessageBox.Show("Prencha o Login", "Campo Obrigatório",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }
        }

        private void txtSenha_Validated_1(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Prencha o Login", "Campo Obrigatório",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
            }
        }

        private void txtConfirmaSenha_Validated_1(object sender, EventArgs e)
        {
            if (txtConfirmaSenha.Text == string.Empty)
            {
                MessageBox.Show("Prencha a Confirmação de Senha", "Campo Obrigatório",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmaSenha.Focus();
            }

            else if (txtConfirmaSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("As senhas devem ser iguais", "Campo Obrigatório",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmaSenha.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

