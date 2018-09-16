using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vendas_Diego_Nogueira
{
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql = "";
        int Id = 0;
        bool teste = false;

        public void Limpar()
        {
            txtSite.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();
            rdbNome.Checked = false;
            rdbCidade.Checked = false;
            rdbEndereco.Checked = false;
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

            if (mskTelefone.Text == "")
                mensagem += "Preencha o telefone. \n";

            else if (mskTelefone.Text.Length < 10)
                mensagem += "Telefone inválido. \n";

            if (txtSite.Text == "")
                mensagem += "Preencha o site. \n";

            else if (!txtSite.Text.Contains(".") || !txtSite.Text.Contains("com"))
                mensagem += "Site inválido. \n";

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
            sql = string.Format("select * from empresa");
            dtgLista.DataSource = bd.Consultar(sql);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("");

            if (rdbNome.Checked)
            {
                sql = string.Format("select * from empresa where nome = '{0}'", txtPesquisa.Text);
            }

            else if (rdbEndereco.Checked)
            {
                sql = string.Format("select * from empresa where endereco = '{0}'", txtPesquisa.Text);
            }

            else if (rdbCidade.Checked)
            {
                sql = string.Format("select * from empresa where cidade = '{0}'", txtPesquisa.Text);
            }

            else if (rdbTodos.Checked)
            {
                sql = string.Format("select * from empresa", txtPesquisa.Text);
            }

            else if (txtPesquisa.Text == string.Empty)
            {
                Limpar();
                MessageBox.Show("Empresa não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                sql = string.Format("update empresa set nome = '{0}', endereco = '{1}', cidade = '{2}', email = '{3}', telefone = '{4}', site = '{5}' where id = '{6}'",
                                         txtNome.Text, txtEndereco.Text, txtCidade.Text, txtEmail.Text, mskTelefone.Text, txtSite.Text, Id);

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Empresa alterada com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcCadastroEmpresa.SelectedTab = tbcEmpresaPag0;
                    Limpar();
                    listar();
                    teste = false;
                }

                else
                    MessageBox.Show("Empresa não alterada.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validacao();

            if (teste == true)
            {

                sql = string.Format("insert into empresa values (null, '{0}','{1}','{2}','{3}','{4}','{5}');",
                                    txtNome.Text.ToUpper(), txtEndereco.Text.ToUpper(), txtCidade.Text.ToUpper(), txtEmail.Text, mskTelefone.Text, txtSite.Text);

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso.", "Cadastro", MessageBoxButtons.OK);
                    tbcCadastroEmpresa.SelectedTab = tbcEmpresaPag0;
                    Limpar();
                }

                else
                    MessageBox.Show("Erro, Empresa não cadastrada.", "Cadastro", MessageBoxButtons.OK);
            }
        }

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {
            if (tbcCadastroEmpresa.SelectedTab == tbcEmpresaPag0)
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
            tbcEmpresaPag0.Show();
            btnSalvar.Enabled = false;

            Id = int.Parse(dtgLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dtgLista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dtgLista.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCidade.Text = dtgLista.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dtgLista.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskTelefone.Text = dtgLista.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSite.Text = dtgLista.Rows[e.RowIndex].Cells[6].Value.ToString();

            tbcCadastroEmpresa.SelectedTab = tbcEmpresaPag0;
        }

        private void btn_Excluir(object sender, EventArgs e)
        {
            sql = string.Format("delete from empresa where id = '{0}'", Id);

            if (bd.Alterar(sql) > 0)
            {
                MessageBox.Show("Empresa excluída com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbcCadastroEmpresa.SelectedTab = tbcEmpresaPag0;
                Limpar();
            }

            else
                MessageBox.Show("Empresa não excluída.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
