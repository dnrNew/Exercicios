using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vendas_Diego_Nogueira
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql = "";
        int Id = 0;
        bool teste = false;

        public void Limpar()
        {
            cbxEstado.SelectedItem = null;
            txtCidade.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
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
                        
            if (cbxEstado.SelectedItem == null)
                mensagem += "Preencha o estado. \n";

            if (mskTelefone.Text == "")
                mensagem += "Preencha o telefone. \n";

            else if (mskTelefone.Text.Length < 10)
                mensagem += "Telefone inválido. ";
            

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
            sql = string.Format("select * from Cliente");
            dtgLista.DataSource = bd.Consultar(sql);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("");

            if (rdbNome.Checked)
            {
                sql = string.Format("select * from Cliente where nome = '{0}'", txtPesquisa.Text);
            }

            else if (rdbEndereco.Checked)
            {
                sql = string.Format("select * from Cliente where endereco = '{0}'", txtPesquisa.Text);
            }

            else if (rdbCidade.Checked)
            {
                sql = string.Format("select * from Cliente", txtPesquisa.Text);
            }

            else if (rdbTodos.Checked)
            {
                sql = string.Format("select * from Cliente", txtPesquisa.Text);
            }

            else if (txtPesquisa.Text == string.Empty)
            {
                Limpar();
                MessageBox.Show("Cliente não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                sql = string.Format("update Cliente set nome = '{0}', endereco = '{1}', cidade = '{2}', estado = '{3}', telefone = '{4}' where id = '{5}'",
                                         txtNome.Text, txtEndereco.Text, txtCidade.Text, cbxEstado.Text, mskTelefone.Text, Id);

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Cliente alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcCadastroCliente.SelectedTab = tbcClientePag0;
                    Limpar();
                    listar();
                    teste = false;
                }

                else
                    MessageBox.Show("Cliente não alterado.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validacao();

            if (teste == true)
            {

                sql = string.Format("insert into Cliente values (null, '{0}','{1}','{2}','{3}','{4}');",
                                    txtNome.Text.ToUpper(), txtEndereco.Text.ToUpper(), txtCidade.Text.ToUpper(), cbxEstado.Text, mskTelefone.Text);

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK);
                    tbcCadastroCliente.SelectedTab = tbcClientePag0;
                    Limpar();
                }

                else
                    MessageBox.Show("Erro, Cliente não cadastrado.", "Cadastro", MessageBoxButtons.OK);
            }
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            if (tbcCadastroCliente.SelectedTab == tbcClientePag0)
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
            tbcClientePag0.Show();
            btnSalvar.Enabled = false;

            Id = int.Parse(dtgLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dtgLista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dtgLista.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCidade.Text = dtgLista.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxEstado.Text = dtgLista.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskTelefone.Text = dtgLista.Rows[e.RowIndex].Cells[5].Value.ToString();

            tbcCadastroCliente.SelectedTab = tbcClientePag0;
        }

        private void btn_Excluir(object sender, EventArgs e)
        {
            sql = string.Format("delete from Cliente where id = '{0}'", Id);

            if (bd.Alterar(sql) > 0)
            {
                MessageBox.Show("Cliente excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbcCadastroCliente.SelectedTab = tbcClientePag0;
                Limpar();
            }

            else
                MessageBox.Show("Cliente não excluído.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
