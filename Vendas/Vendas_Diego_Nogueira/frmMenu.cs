using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas_Diego_Nogueira
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void ptbCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cad = new frmCadastroCliente();
            cad.ShowDialog();
        }

        private void ptbEmpresa_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa cad = new frmCadastroEmpresa();
            cad.ShowDialog();
        }
                

        private void ptbProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cad = new frmCadastroProduto();
            cad.ShowDialog();
        }

        private void smSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cad = new frmCadastroCliente();
            cad.ShowDialog();
        }

        private void smEmpresa_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa cad = new frmCadastroEmpresa();
            cad.ShowDialog();
        }

        private void smProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cad = new frmCadastroProduto();
            cad.ShowDialog();
        }

        private void ptbFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario cad = new frmFuncionario();
            cad.ShowDialog();
        }

        private void smFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario cad = new frmFuncionario();
            cad.ShowDialog();
        }

        private void smSairManut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbVendas_Click(object sender, EventArgs e)
        {
            frmVendas cad = new frmVendas();
            cad.ShowDialog();
        }

        private void smVendas_Click(object sender, EventArgs e)
        {
            frmVendas cad = new frmVendas();
            cad.ShowDialog();
        }
    }
}
