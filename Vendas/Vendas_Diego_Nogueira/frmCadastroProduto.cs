using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vendas_Diego_Nogueira
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql = "";
        int Id = 0;
        bool teste = false;

        public void CarregaEmpresa()
        {
            sql = string.Format("select id, nome from empresa");
            cbxEmpresa.DataSource = bd.Consultar(sql);
            cbxEmpresa.DisplayMember = "nome";
            cbxEmpresa.ValueMember = "id";
            cbxEmpresa.SelectedIndex = -1;
        }

        public void Limpar()
        {
            cbxEmpresa.SelectedIndex = -1;
            txtValor.Clear();
            txtQuantidade.Clear();
            txtDescricao.Clear();
            rdbDescricao.Checked = false;
            rdbTodos.Checked = false;
            dtgLista.DataSource = null;
            txtPesquisa.Clear();
            teste = false;
        }

        private void Validacao()
        {
            string mensagem = string.Empty;

            if (txtDescricao.Text == string.Empty)
                mensagem = "Preencha a descrição. \n";

            if (txtQuantidade.Text == string.Empty)
                mensagem += "Preencha a quantidade. \n";

            if (txtValor.Text == string.Empty)
                mensagem += "Preencha o valor. \n";

            if (cbxEmpresa.SelectedIndex == -1)
                mensagem += "Selecione uma empresa. \n";

            if (mensagem != "")
            {
                MessageBox.Show(mensagem, "Todos os campos são obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mensagem = "";
                txtDescricao.Focus();
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
            sql = string.Format("select * from produto");
            dtgLista.DataSource = bd.Consultar(sql);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("");

            if (rdbDescricao.Checked)
            {
                sql = string.Format("select produto.id, produto.descricao, produto.quantidade, produto.valor, empresa.nome  as empresa  from produto join empresa on produto.empresa_id = empresa.id where produto.descricao like '%{0}%'", txtPesquisa.Text);
            }

            else if (rdbTodos.Checked)
            {
                sql = string.Format("select produto.id, produto.descricao, produto.quantidade, produto.valor, empresa.nome as empresa from produto join empresa on produto.empresa_id = empresa.id");
            }

            else if (txtPesquisa.Text == string.Empty)
            {
                Limpar();
                MessageBox.Show("Produto não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                sql = string.Format("update produto set descricao = '{0}', quantidade = '{1}', valor = '{2}', empresa_id = '{3}' where id = '{4}'",
                            txtDescricao.Text, txtQuantidade.Text, txtValor.Text.Replace(",", "."), cbxEmpresa.SelectedValue, Id);

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Produto alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcCadastroProduto.SelectedTab = tbcProdutoPag0;
                    Limpar();
                    teste = false;
                }

                else
                    MessageBox.Show("Produto não alterado.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validacao();

            if (teste == true)
            {

                sql = string.Format("insert into produto values (null, '{0}','{1}','{2}','{3}');",
                                    txtDescricao.Text.ToUpper(), txtQuantidade.Text.ToUpper(), txtValor.Text.Replace(",", "."), cbxEmpresa.SelectedValue);

                if (bd.Alterar(sql) > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK);
                    Limpar();
                }

                else
                    MessageBox.Show("Erro! Produto não cadastrado.", "Cadastro", MessageBoxButtons.OK);
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            if (tbcCadastroProduto.SelectedTab == tbcProdutoPag0)
            {
                CarregaEmpresa();
                txtDescricao.Focus();
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
            tbcProdutoPag0.Show();
            btnSalvar.Enabled = false;

            Id = int.Parse(dtgLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDescricao.Text = dtgLista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantidade.Text = dtgLista.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValor.Text = double.Parse(dtgLista.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString("0.00");
            cbxEmpresa.Text = dtgLista.Rows[e.RowIndex].Cells[4].Value.ToString();

            tbcCadastroProduto.SelectedTab = tbcProdutoPag0;
        }

        private void btn_Excluir(object sender, EventArgs e)
        {
            sql = string.Format("delete from Produto where id = '{0}'", Id);

            if (bd.Alterar(sql) > 0)
            {
                MessageBox.Show("Produto excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbcCadastroProduto.SelectedTab = tbcProdutoPag0;
                Limpar();
            }

            else
                MessageBox.Show("Produto não excluído.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
