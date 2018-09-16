namespace Vendas_Diego_Nogueira
{
    partial class frmVendas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.tbcCadastroVendas = new System.Windows.Forms.TabControl();
            this.tbcVendasPag0 = new System.Windows.Forms.TabPage();
            this.pnlVenda = new System.Windows.Forms.Panel();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.btnExcluir_Item = new System.Windows.Forms.Button();
            this.lblTotal_Item = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.tbcVendasPag1 = new System.Windows.Forms.TabPage();
            this.gpxConsultaVendas = new System.Windows.Forms.GroupBox();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbFuncionario = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbVenda = new System.Windows.Forms.RadioButton();
            this.pnlCadastroVendas = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            this.tbcCadastroVendas.SuspendLayout();
            this.tbcVendasPag0.SuspendLayout();
            this.pnlVenda.SuspendLayout();
            this.pnlProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.tbcVendasPag1.SuspendLayout();
            this.gpxConsultaVendas.SuspendLayout();
            this.pnlCadastroVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantidade
            // 
            resources.ApplyResources(this.lblQuantidade, "lblQuantidade");
            this.lblQuantidade.Name = "lblQuantidade";
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.Name = "lblDescricao";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtQuantidade, "txtQuantidade");
            this.txtQuantidade.Name = "txtQuantidade";
            // 
            // lblObservacao
            // 
            resources.ApplyResources(this.lblObservacao, "lblObservacao");
            this.lblObservacao.Name = "lblObservacao";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtDescricao, "txtDescricao");
            this.txtDescricao.Name = "txtDescricao";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtObservacao, "txtObservacao");
            this.txtObservacao.Name = "txtObservacao";
            // 
            // dtgVenda
            // 
            this.dtgVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgVenda.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgVenda, "dtgVenda");
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.ReadOnly = true;
            // 
            // tbcCadastroVendas
            // 
            this.tbcCadastroVendas.Controls.Add(this.tbcVendasPag0);
            this.tbcCadastroVendas.Controls.Add(this.tbcVendasPag1);
            resources.ApplyResources(this.tbcCadastroVendas, "tbcCadastroVendas");
            this.tbcCadastroVendas.Name = "tbcCadastroVendas";
            this.tbcCadastroVendas.SelectedIndex = 0;
            this.tbcCadastroVendas.Click += new System.EventHandler(this.frmVendas_Load);
            this.tbcCadastroVendas.Enter += new System.EventHandler(this.frmVendas_Load);
            // 
            // tbcVendasPag0
            // 
            this.tbcVendasPag0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcVendasPag0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcVendasPag0.Controls.Add(this.pnlVenda);
            this.tbcVendasPag0.Controls.Add(this.pnlProduto);
            resources.ApplyResources(this.tbcVendasPag0, "tbcVendasPag0");
            this.tbcVendasPag0.Name = "tbcVendasPag0";
            // 
            // pnlVenda
            // 
            this.pnlVenda.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlVenda.Controls.Add(this.mskData);
            this.pnlVenda.Controls.Add(this.cbxFuncionario);
            this.pnlVenda.Controls.Add(this.lblFuncionario);
            this.pnlVenda.Controls.Add(this.cbxCliente);
            this.pnlVenda.Controls.Add(this.lblObservacao);
            this.pnlVenda.Controls.Add(this.txtId);
            this.pnlVenda.Controls.Add(this.txtObservacao);
            this.pnlVenda.Controls.Add(this.lblData);
            this.pnlVenda.Controls.Add(this.lblDescricao);
            this.pnlVenda.Controls.Add(this.txtDescricao);
            this.pnlVenda.Controls.Add(this.txtTotalVenda);
            this.pnlVenda.Controls.Add(this.btnSalvar);
            this.pnlVenda.Controls.Add(this.lblTotal);
            this.pnlVenda.Controls.Add(this.lblCliente);
            resources.ApplyResources(this.pnlVenda, "pnlVenda");
            this.pnlVenda.Name = "pnlVenda";
            // 
            // mskData
            // 
            this.mskData.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.mskData, "mskData");
            this.mskData.Name = "mskData";
            this.mskData.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbxFuncionario, "cbxFuncionario");
            this.cbxFuncionario.ForeColor = System.Drawing.Color.Black;
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Name = "cbxFuncionario";
            // 
            // lblFuncionario
            // 
            resources.ApplyResources(this.lblFuncionario, "lblFuncionario");
            this.lblFuncionario.Name = "lblFuncionario";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbxCliente, "cbxCliente");
            this.cbxCliente.ForeColor = System.Drawing.Color.Black;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Name = "cbxCliente";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // lblData
            // 
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.Name = "lblData";
            // 
            // txtTotalVenda
            // 
            resources.ApplyResources(this.txtTotalVenda, "txtTotalVenda");
            this.txtTotalVenda.Name = "txtTotalVenda";
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Image = global::Vendas_Diego_Nogueira.Properties.Resources.salvar;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // lblCliente
            // 
            resources.ApplyResources(this.lblCliente, "lblCliente");
            this.lblCliente.Name = "lblCliente";
            // 
            // pnlProduto
            // 
            this.pnlProduto.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlProduto.Controls.Add(this.dtgLista);
            this.pnlProduto.Controls.Add(this.lblQuantidade);
            this.pnlProduto.Controls.Add(this.btnInserir);
            this.pnlProduto.Controls.Add(this.txtQuantidade);
            this.pnlProduto.Controls.Add(this.cbxProduto);
            this.pnlProduto.Controls.Add(this.btnExcluir_Item);
            this.pnlProduto.Controls.Add(this.lblTotal_Item);
            this.pnlProduto.Controls.Add(this.lblProduto);
            this.pnlProduto.Controls.Add(this.txtTotal);
            this.pnlProduto.Controls.Add(this.txtValorUnit);
            this.pnlProduto.Controls.Add(this.lblValorUnit);
            resources.ApplyResources(this.pnlProduto, "pnlProduto");
            this.pnlProduto.Name = "pnlProduto";
            // 
            // dtgLista
            // 
            this.dtgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgLista, "dtgLista");
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellContentDoubleClick);
            // 
            // btnInserir
            // 
            resources.ApplyResources(this.btnInserir, "btnInserir");
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.Image = global::Vendas_Diego_Nogueira.Properties.Resources.novo;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbxProduto, "cbxProduto");
            this.cbxProduto.ForeColor = System.Drawing.Color.Black;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Name = "cbxProduto";
            // 
            // btnExcluir_Item
            // 
            resources.ApplyResources(this.btnExcluir_Item, "btnExcluir_Item");
            this.btnExcluir_Item.BackColor = System.Drawing.Color.White;
            this.btnExcluir_Item.Image = global::Vendas_Diego_Nogueira.Properties.Resources.Fechar;
            this.btnExcluir_Item.Name = "btnExcluir_Item";
            this.btnExcluir_Item.UseVisualStyleBackColor = false;
            this.btnExcluir_Item.Click += new System.EventHandler(this.btnExcluir_Item_Click);
            // 
            // lblTotal_Item
            // 
            resources.ApplyResources(this.lblTotal_Item, "lblTotal_Item");
            this.lblTotal_Item.Name = "lblTotal_Item";
            // 
            // lblProduto
            // 
            resources.ApplyResources(this.lblProduto, "lblProduto");
            this.lblProduto.Name = "lblProduto";
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            // 
            // txtValorUnit
            // 
            resources.ApplyResources(this.txtValorUnit, "txtValorUnit");
            this.txtValorUnit.Name = "txtValorUnit";
            // 
            // lblValorUnit
            // 
            resources.ApplyResources(this.lblValorUnit, "lblValorUnit");
            this.lblValorUnit.Name = "lblValorUnit";
            // 
            // tbcVendasPag1
            // 
            this.tbcVendasPag1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcVendasPag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcVendasPag1.Controls.Add(this.gpxConsultaVendas);
            this.tbcVendasPag1.Controls.Add(this.dtgVenda);
            resources.ApplyResources(this.tbcVendasPag1, "tbcVendasPag1");
            this.tbcVendasPag1.Name = "tbcVendasPag1";
            // 
            // gpxConsultaVendas
            // 
            this.gpxConsultaVendas.Controls.Add(this.rdbData);
            this.gpxConsultaVendas.Controls.Add(this.rdbTodos);
            this.gpxConsultaVendas.Controls.Add(this.btnPesquisar);
            this.gpxConsultaVendas.Controls.Add(this.txtPesquisa);
            this.gpxConsultaVendas.Controls.Add(this.rdbFuncionario);
            this.gpxConsultaVendas.Controls.Add(this.rdbCliente);
            this.gpxConsultaVendas.Controls.Add(this.rdbVenda);
            this.gpxConsultaVendas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.gpxConsultaVendas, "gpxConsultaVendas");
            this.gpxConsultaVendas.Name = "gpxConsultaVendas";
            this.gpxConsultaVendas.TabStop = false;
            // 
            // rdbData
            // 
            resources.ApplyResources(this.rdbData, "rdbData");
            this.rdbData.Name = "rdbData";
            this.rdbData.TabStop = true;
            this.rdbData.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            resources.ApplyResources(this.rdbTodos, "rdbTodos");
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.TabStop = true;
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtPesquisa, "txtPesquisa");
            this.txtPesquisa.Name = "txtPesquisa";
            // 
            // rdbFuncionario
            // 
            resources.ApplyResources(this.rdbFuncionario, "rdbFuncionario");
            this.rdbFuncionario.Name = "rdbFuncionario";
            this.rdbFuncionario.TabStop = true;
            this.rdbFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdbCliente
            // 
            resources.ApplyResources(this.rdbCliente, "rdbCliente");
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.TabStop = true;
            this.rdbCliente.UseVisualStyleBackColor = true;
            // 
            // rdbVenda
            // 
            resources.ApplyResources(this.rdbVenda, "rdbVenda");
            this.rdbVenda.Name = "rdbVenda";
            this.rdbVenda.TabStop = true;
            this.rdbVenda.UseVisualStyleBackColor = true;
            // 
            // pnlCadastroVendas
            // 
            this.pnlCadastroVendas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCadastroVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroVendas.Controls.Add(this.btnExcluir);
            this.pnlCadastroVendas.Controls.Add(this.btnFechar);
            this.pnlCadastroVendas.Controls.Add(this.btnAlterar);
            this.pnlCadastroVendas.Controls.Add(this.btnNovo);
            resources.ApplyResources(this.pnlCadastroVendas, "pnlCadastroVendas");
            this.pnlCadastroVendas.Name = "pnlCadastroVendas";
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Image = global::Vendas_Diego_Nogueira.Properties.Resources.Fechar;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btn_Excluir);
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::Vendas_Diego_Nogueira.Properties.Resources.sair;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAlterar
            // 
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Image = global::Vendas_Diego_Nogueira.Properties.Resources.alterar;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            resources.ApplyResources(this.btnNovo, "btnNovo");
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Image = global::Vendas_Diego_Nogueira.Properties.Resources.novo;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmVendas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlCadastroVendas);
            this.Controls.Add(this.tbcCadastroVendas);
            this.MaximizeBox = false;
            this.Name = "frmVendas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            this.tbcCadastroVendas.ResumeLayout(false);
            this.tbcVendasPag0.ResumeLayout(false);
            this.pnlVenda.ResumeLayout(false);
            this.pnlVenda.PerformLayout();
            this.pnlProduto.ResumeLayout(false);
            this.pnlProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.tbcVendasPag1.ResumeLayout(false);
            this.gpxConsultaVendas.ResumeLayout(false);
            this.gpxConsultaVendas.PerformLayout();
            this.pnlCadastroVendas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.TabControl tbcCadastroVendas;
        private System.Windows.Forms.TabPage tbcVendasPag0;
        private System.Windows.Forms.TabPage tbcVendasPag1;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpxConsultaVendas;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbFuncionario;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbVenda;
        protected System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastroVendas;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnExcluir_Item;
        protected System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal_Item;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.ComboBox cbxProduto;
        protected System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel pnlVenda;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Panel pnlProduto;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.MaskedTextBox mskData;
    }
}

