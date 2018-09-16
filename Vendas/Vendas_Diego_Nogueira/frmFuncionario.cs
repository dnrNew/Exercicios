using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vendas_Diego_Nogueira
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql = "";
        bool teste = false;

        public void Limpar()
        {
            cbxEstado.SelectedItem = null;
            txtCidade.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();
            rdbNome.Checked = false;
            rdbUsuario.Checked = false;
            rdbCpf.Checked = false;
            mskCpf.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtconfSenha.Clear();
            dtpNascimento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtgLista.DataSource = null;
            txtPesquisa.Clear();
            teste = false;
        }

        private void Validacao()
        {
            string mensagem = string.Empty;

            if (txtNome.Text == string.Empty)
                mensagem = "Preencha o nome. \n";

            else if (txtNome.Text.Length < 5)
                mensagem = "Nome não pode conter menos de 5 caracteres. \n";

            if (txtEndereco.Text == string.Empty)
                mensagem += "Preencha o endereço. \n";

            if (txtCidade.Text == string.Empty)
                mensagem += "Preencha a cidade. \n";

            if (txtEmail.Text == "")
                mensagem += "Preencha o email. \n";

            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                mensagem += "Email inválido. \n";

            if (dtpNascimento.Text == DateTime.Now.ToString("dd/MM/yyyy"))
                mensagem += "Data de nascimento inválida. \n";

            if (mskTelefone.Text == "")
                mensagem += "Preencha o telefone. \n";

            else if (mskTelefone.Text.Length < 10)
                mensagem += "Telefone inválido. \n";

            if (cbxEstado.SelectedItem == null)
                mensagem += "Preencha o estado. \n";

            if (mskCpf.Text.Length < 11)
                mensagem += "Preencha o cpf com 11 dígitos. \n";

            if (txtUsuario.Text == string.Empty)
                mensagem += "Preencha o usuário. \n";

            if (txtSenha.Text == "")
                mensagem += "Preencha a senha. \n";

            if (txtconfSenha.Text == "")
                mensagem += "Preencha a confirmação da senha. ";

            else if (txtSenha.Text != txtconfSenha.Text)
                mensagem += "As senhas devem ser iguais. ";

            

            if (mensagem != "")
            {
                MessageBox.Show(mensagem, "Todos os campos são obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mensagem = "";
                txtNome.Focus();
            }

            else
            {
                teste = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void listar()
        {
            sql = string.Format("select * from Funcionario");
            dtgLista.DataSource = bd.Consultar(sql);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("");

            if (rdbNome.Checked)
            {
                sql = string.Format("select * from Funcionario where nome = '{0}'", txtPesquisa.Text);
            }

            else if (rdbCpf.Checked)
            {
                sql = string.Format("select * from Funcionario where cpf = '{0}'", txtPesquisa.Text);
            }

            else if (rdbUsuario.Checked)
            {
                sql = string.Format("select * from Funcionario where usuario = '{0}'", txtPesquisa.Text);
            }

            else if (rdbTodos.Checked)
            {
                sql = string.Format("select * from Funcionario", txtPesquisa.Text);
            }

            else if (txtPesquisa.Text == string.Empty)
            {
                Limpar();
                MessageBox.Show("Funcionário não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesquisa.Focus();
            }

            if (sql != "")
                dtgLista.DataSource = bd.Consultar(sql);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Validacao();
            if (teste == true)
            {
                DateTime dt = DateTime.Parse(dtpNascimento.Text);
                sql = string.Format("update Funcionario set nome = '{0}', endereco = '{1}', cidade = '{2}', email = '{3}', telefone = '{4}', estado = '{5}', senha = '{6}', usuario = '{7}', dt_Nascimento = '{8}' where cpf = '{9}'",
                                         txtNome.Text, txtEndereco.Text, txtCidade.Text, cbxEstado.Text, mskTelefone.Text, cbxEstado.Text, txtSenha.Text, txtUsuario.Text, dt.ToString("yyyy-MM-dd"), mskCpf.Text); 

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Funcionário alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcCadastroFuncionario.SelectedTab = tbcFuncionarioPag0;
                    Limpar();
                    listar();
                    teste = false;
                }

                else
                    MessageBox.Show("Funcionário não alterado.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validacao();

            if (teste == true)
            {
                DateTime dt = DateTime.Parse(dtpNascimento.Text);

                sql = string.Format("insert into Funcionario values ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}', '{7}', '{8}', '{9}');",
                                    mskCpf.Text, txtNome.Text.ToUpper(), txtEndereco.Text.ToUpper(), txtCidade.Text.ToUpper(), cbxEstado.Text, mskTelefone.Text, dt.ToString("yyyy-MM-dd"), txtEmail.Text, txtUsuario.Text, txtSenha.Text);

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK);
                    tbcCadastroFuncionario.SelectedTab = tbcFuncionarioPag0;
                    Limpar();
                }

                else
                    MessageBox.Show("Erro, Funcionário não cadastrado.", "Cadastro", MessageBoxButtons.OK);
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            if (tbcCadastroFuncionario.SelectedTab == tbcFuncionarioPag0)
            {
                txtNome.Focus();
            }

            else
                txtPesquisa.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtgLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbcFuncionarioPag0.Show();
            btnSalvar.Enabled = false;

            mskCpf.Text = dtgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgLista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dtgLista.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCidade.Text = dtgLista.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxEstado.Text = dtgLista.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskTelefone.Text = dtgLista.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpNascimento.Text = dtgLista.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = dtgLista.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtUsuario.Text = dtgLista.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtSenha.Text = dtgLista.Rows[e.RowIndex].Cells[9].Value.ToString();

            tbcCadastroFuncionario.SelectedTab = tbcFuncionarioPag0;

        }

        private void btn_Excluir(object sender, EventArgs e)
        {
            sql = string.Format("delete from Funcionario where cpf = '{0}'", mskCpf.Text);

            if (bd.Alterar(sql) > 0)
            {
                MessageBox.Show("Funcionário excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbcCadastroFuncionario.SelectedTab = tbcFuncionarioPag0;
                Limpar();
            }

            else
                MessageBox.Show("Funcionário não excluído.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
