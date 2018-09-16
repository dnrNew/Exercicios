using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vendas_Diego_Nogueira
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        DataTable dt;
        string sql = "";
        int item;
        double total;

        public void Limpar()
        {
            cbxCliente.SelectedText = string.Empty;
            txtObservacao.Clear();
            txtDescricao.Clear();
            txtTotalVenda.Clear();
            txtId.Clear();
            txtQuantidade.Clear();
            rdbVenda.Checked = false;
            rdbFuncionario.Checked = false;
            rdbCliente.Checked = false;
            mskData.Clear();
            txtValorUnit.Clear();
            txtTotal.Clear();
            dtgVenda.DataSource = null;
            dtgLista.DataSource = null;
            txtPesquisa.Clear();
        }

        public void ListarProdutos()
        {
            sql = string.Format("select iv.id, p.descricao, iv.quantidade, iv.valor_unit, iv.total from itens_vendas iv, produto p where iv.produto_id = p.id and iv.vendas_id = '{0}'", txtId.Text);
            dtgLista.DataSource = bd.Consultar(sql);
        }

        public void CarregaCliente()
        {
            sql = string.Format("select id, nome from cliente");
            cbxCliente.DataSource = bd.Consultar(sql);
            cbxCliente.DisplayMember = "nome";
            cbxCliente.ValueMember = "id";
            cbxCliente.SelectedIndex = -1;
        }

        public void CarregaFuncionario()
        {
            sql = string.Format("select cpf, nome from funcionario");
            cbxFuncionario.DataSource = bd.Consultar(sql);
            cbxFuncionario.DisplayMember = "nome";
            cbxFuncionario.ValueMember = "cpf";
            cbxFuncionario.SelectedIndex = -1;
        }

        public void CarregaProduto()
        {
            sql = string.Format("select id, descricao from produto");
            cbxProduto.DataSource = bd.Consultar(sql);
            cbxProduto.DisplayMember = "descricao";
            cbxProduto.ValueMember = "id";
            cbxProduto.SelectedIndex = -1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            pnlProduto.Enabled = false;
        }

        public void listar()
        {
            sql = string.Format("select * from Vendas");
            dtgVenda.DataSource = bd.Consultar(sql);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (rdbVenda.Checked)
            {
                sql = string.Format("select v.id, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario_cpf from vendas v, cliente c where v.cliente_id = c.id and c.id = '{0}'", txtPesquisa.Text);
            }

            else if (rdbFuncionario.Checked)
            {
                sql = string.Format("select v.id, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario_cpf from vendas v, cliente c where v.cliente_id = c.id and v.funcionario_cpf = '{0}'", txtPesquisa.Text);
            }
            else if (rdbCliente.Checked)
            {
                sql = string.Format("select v.id, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario_cpf from vendas v, cliente c where v.cliente_id = c.id and c.nome like '%{0}%'", txtPesquisa.Text);
            }
            else if (rdbData.Checked)
            {
                sql = string.Format("select v.id, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario_cpf from vendas v, cliente c where v.cliente_id = c.id and v.data_venda = '{0}'", txtPesquisa.Text);
            }

            else
            {
                rdbTodos.Checked = true;
                sql = string.Format("select v.id, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario_cpf from vendas v, cliente c where v.cliente_id = c.id");
            }

            dtgVenda.DataSource = bd.Consultar(sql);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update vendas set descricao = '{0}', observacao = '{1}' where id = '{2}'",
                                txtDescricao.Text, txtObservacao.Text, txtId.Text);
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = string.Format("select valor from produto where descricao = '{0}'", cbxProduto.Text);
            dt = bd.Consultar(sql);

            if (dt.Rows.Count > 0)
            {
                txtValorUnit.Text = dt.Rows[0]["valor"].ToString();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into Vendas values (null, '{0}','{1}','{2}','{3}','{4}','{5}');",
                                txtDescricao.Text, DateTime.Now.ToString("yyyy-MM-dd"), txtTotalVenda.Text.Replace(",", "."), txtObservacao.Text, cbxCliente.SelectedValue, cbxFuncionario.SelectedValue);

            if (bd.Alterar(sql) > 0)
            {
                sql = string.Format("select max(id) as id from vendas");
                dt = bd.Consultar(sql);
            }

            if (dt.Rows.Count > 0)
            {
                txtId.Text = dt.Rows[0]["id"].ToString();
                pnlProduto.Enabled = true;
            }
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            CarregaCliente();
            CarregaFuncionario();
            mskData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CarregaProduto();
            txtValorUnit.Clear();

            if (tbcCadastroVendas.SelectedTab == tbcVendasPag0)
            {
                txtDescricao.Focus();
            }

            else
                txtPesquisa.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Item_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from itens_vendas where vendas_id = '{0}'", txtId.Text);
            bd.Alterar(sql);

            sql = string.Format("delete from vendas where id = '{0}'", txtId.Text);
            bd.Alterar(sql);
        }

        private void btn_Excluir(object sender, EventArgs e)
        {
            sql = string.Format("delete from itens_vendas where id = '{0}'", item);

            if (bd.Alterar(sql) > 0)
            {
                ListarProdutos();
                txtTotal.Text = (double.Parse(txtTotal.Text) - total).ToString();
                sql = string.Format("update vendas set total = '{0}' where id = '{1}'",
                                            txtTotal.Text.Replace(",", "."), txtId.Text);
                bd.Alterar(sql);
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double total = 0;

            total = double.Parse(txtValorUnit.Text) * int.Parse(txtQuantidade.Text);
            txtTotal.Text = total.ToString();

            txtTotalVenda.Text = (double.Parse(txtTotalVenda.Text) + total).ToString();

            sql = string.Format("insert into itens_vendas values(null, '{0}','{1}','{2}','{3}','{4}')",
                txtValorUnit.Text.Replace(",", "."), txtQuantidade.Text, txtTotal.Text.Replace(",", "."), txtId.Text, cbxProduto.SelectedValue);

            if (bd.Alterar(sql) > 0)
            {
                ListarProdutos();
                sql = string.Format("update vendas set total = '{0}' where id = '{1}'",
                                            txtTotal.Text.Replace(",", "."), txtId.Text);
                bd.Alterar(sql);
            }
        }

        private void dtgLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            item = 0;
            total = 0;

            item = int.Parse(dtgLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            total = double.Parse(dtgLista.Rows[e.RowIndex].Cells[4].Value.ToString());

            MessageBox.Show("Codigo do item selecionado " + item);
        }

    }
}
