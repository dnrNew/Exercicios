using System;
using System.Windows.Forms;
using System.Drawing;
using CamadaTransfDados;
using CamadaNegocio;

namespace Crud_Diego_Nogueira
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEnd.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            mskCep.Clear();
            mskCpf.Clear();
            mskTelefoneCel.Clear();
            mskTelefoneRes.Clear();
            cbxUf.SelectedIndex = -1;
            txtId.Enabled = true;
            btnSalvar.Enabled = true;
            txtId.Focus();
        }

        dto_Cliente d_cliente = new dto_Cliente();
        bll_Cliente b_cliente = new bll_Cliente();

        private void ListaCliente()
        {
            dtgLista.DataSource = b_cliente.ListarCliente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "" && txtNome.Text != "" && txtEnd.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && mskCpf.Text.Length == 11 && mskCep.Text.Length == 8 && cbxUf.Text != "" &&
                    mskTelefoneRes.Text.Length == 10 && mskTelefoneCel.Text.Length == 11 && txtEmail.Text != "")
                {
                    d_cliente.Id = int.Parse(txtId.Text);
                    d_cliente.Nome = txtNome.Text;
                    d_cliente.Endereco = txtEnd.Text;
                    d_cliente.Bairro = txtBairro.Text;
                    d_cliente.Cidade = txtCidade.Text;
                    d_cliente.Cpf = long.Parse(mskCpf.Text);
                    d_cliente.Cep = int.Parse(mskCep.Text);
                    d_cliente.Uf = cbxUf.Text;
                    d_cliente.TelefoneRes = long.Parse(mskTelefoneRes.Text);
                    d_cliente.TelefoneCel = long.Parse(mskTelefoneCel.Text);
                    d_cliente.Email = txtEmail.Text;

                    b_cliente.InserirCliente(d_cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK);
                    ListaCliente();
                    Limpar();
                }

                else
                {
                    MessageBox.Show("Cliente não cadastrado, dados incompletos.", "Cadastro", MessageBoxButtons.OK);
                    txtId.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                d_cliente.Id = int.Parse(txtId.Text);
                d_cliente = b_cliente.BuscarCliente(d_cliente);
            }

            if (d_cliente.Id != 0)
            {
                txtId.Text = d_cliente.Id.ToString();
                txtNome.Text = d_cliente.Nome.ToString();
                txtEnd.Text = d_cliente.Endereco.ToString();
                txtBairro.Text = d_cliente.Bairro.ToString();
                txtCidade.Text = d_cliente.Cidade.ToString();
                mskCpf.Text = d_cliente.Cpf.ToString().PadLeft(11, '0');
                mskCep.Text = d_cliente.Cep.ToString();
                cbxUf.Text = d_cliente.Uf.ToString();
                mskTelefoneRes.Text = d_cliente.TelefoneRes.ToString();
                mskTelefoneCel.Text = d_cliente.TelefoneCel.ToString();
                txtEmail.Text = d_cliente.Email.ToString();
            }

            else
            {
                MessageBox.Show("ID inexistente!", "Erro", MessageBoxButtons.OK);
                txtId.Clear();
                txtId.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    d_cliente.Id = int.Parse(txtId.Text);
                    d_cliente = b_cliente.BuscarCliente(d_cliente);
                }

                if (d_cliente.Id != 0)
                {
                    d_cliente.Endereco = txtEnd.Text;
                    d_cliente.Nome = txtNome.Text;
                    d_cliente.Bairro = txtBairro.Text;
                    d_cliente.Cidade = txtCidade.Text;
                    d_cliente.Cpf = long.Parse(mskCpf.Text);
                    d_cliente.Cep = int.Parse(mskCep.Text);
                    d_cliente.Uf = cbxUf.Text;
                    d_cliente.TelefoneRes = long.Parse(mskTelefoneRes.Text);
                    d_cliente.TelefoneCel = long.Parse(mskTelefoneCel.Text);
                    d_cliente.Email = txtEmail.Text;

                    b_cliente.AlterarCliente(d_cliente);
                    MessageBox.Show("Cliente alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaCliente();
                    Limpar();
                }

                else
                {
                    MessageBox.Show("ID não preenchido ou inexistente!", "Erro", MessageBoxButtons.OK);
                    txtId.Clear();
                    txtId.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    d_cliente.Id = int.Parse(txtId.Text);
                    d_cliente = b_cliente.BuscarCliente(d_cliente);
                }

                if (txtId.Text != string.Empty && d_cliente.Id != 0)
                {
                    d_cliente.Id = int.Parse(txtId.Text);
                    b_cliente.ExcluirCliente(d_cliente);
                    MessageBox.Show("Cliente excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaCliente();
                    Limpar();
                }

                else
                {
                    MessageBox.Show("Cliente não excluído, ID não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ListaCliente();
            Limpar();
        }

        private void dtgLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgLista.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgLista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEnd.Text = dtgLista.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBairro.Text = dtgLista.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCidade.Text = dtgLista.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskCpf.Text = dtgLista.Rows[e.RowIndex].Cells[5].Value.ToString();
            mskCep.Text = dtgLista.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbxUf.Text = dtgLista.Rows[e.RowIndex].Cells[7].Value.ToString();
            mskTelefoneCel.Text = dtgLista.Rows[e.RowIndex].Cells[8].Value.ToString();
            mskTelefoneRes.Text = dtgLista.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtEmail.Text = dtgLista.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void txtId_Validated(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Campo ID não pode ser vazio!", "Campo obrigatório", MessageBoxButtons.OK);
                txtId.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void mskCpf_Validated(object sender, EventArgs e)
        {
            if (mskCpf.Text.Length < 11)
            {
                MessageBox.Show("Campo CPF inválido!", "Campo obrigatório", MessageBoxButtons.OK);
                mskCpf.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo NOME não pode ser vazio!", "Campo obrigatório", MessageBoxButtons.OK);
                txtNome.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void txtEnd_Validated(object sender, EventArgs e)
        {
            if (txtEnd.Text == string.Empty)
            {
                MessageBox.Show("Campo ENDEREÇO não pode ser vazio!", "Campo obrigatório", MessageBoxButtons.OK);
                txtEnd.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void txtBairro_Validated(object sender, EventArgs e)
        {
            if (txtBairro.Text == string.Empty)
            {
                MessageBox.Show("Campo BAIRRO não pode ser vazio!", "Campo obrigatório", MessageBoxButtons.OK);
                txtBairro.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void txtCidade_Validated(object sender, EventArgs e)
        {
            if (txtCidade.Text == string.Empty)
            {
                MessageBox.Show("Campo CIDADE não pode ser vazio!", "Campo obrigatório", MessageBoxButtons.OK);
                txtCidade.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void cbxUf_Validated(object sender, EventArgs e)
        {
            if (cbxUf.Text == string.Empty)
            {
                MessageBox.Show("Campo UF não pode ser vazio!", "Campo obrigatório", MessageBoxButtons.OK);
                cbxUf.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void mskCep_Validated(object sender, EventArgs e)
        {
            if (mskCep.Text.Length < 8)
            {
                MessageBox.Show("Campo CEP inválido!", "Campo obrigatório", MessageBoxButtons.OK);
                mskCep.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void mskTelefoneRes_Validated(object sender, EventArgs e)
        {
            if (mskTelefoneRes.Text.Length < 10)
            {
                MessageBox.Show("Campo TELEFONE RESIDENCIAL inválido!", "Campo obrigatório", MessageBoxButtons.OK);
                mskTelefoneRes.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void mskTelefoneCel_Validated(object sender, EventArgs e)
        {
            if (mskTelefoneCel.Text.Length < 11)
            {
                MessageBox.Show("Campo TELEFONE CELULAR inválido!", "Campo obrigatório", MessageBoxButtons.OK);
                mskTelefoneCel.Focus();
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Campo EMAIL não pode ser vazio!", "Campo obrigatório", MessageBoxButtons.OK);
                txtEmail.Focus();
                lblObrigatorio.ForeColor = Color.Red;
            }

            else
                lblObrigatorio.ForeColor = Color.Black;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

