namespace Vendas_Diego_Nogueira
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.tbcCadastroProduto = new System.Windows.Forms.TabControl();
            this.tbcProdutoPag0 = new System.Windows.Forms.TabPage();
            this.cbxEmpresa = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbcProdutoPag1 = new System.Windows.Forms.TabPage();
            this.gpxConsultaProduto = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbDescricao = new System.Windows.Forms.RadioButton();
            this.pnlCadastroProduto = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.tbcCadastroProduto.SuspendLayout();
            this.tbcProdutoPag0.SuspendLayout();
            this.tbcProdutoPag1.SuspendLayout();
            this.gpxConsultaProduto.SuspendLayout();
            this.pnlCadastroProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.Name = "lblDescricao";
            // 
            // lblQuantidade
            // 
            resources.ApplyResources(this.lblQuantidade, "lblQuantidade");
            this.lblQuantidade.Name = "lblQuantidade";
            // 
            // lblEmpresa
            // 
            resources.ApplyResources(this.lblEmpresa, "lblEmpresa");
            this.lblEmpresa.Name = "lblEmpresa";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtDescricao, "txtDescricao");
            this.txtDescricao.Name = "txtDescricao";
            // 
            // lblValor
            // 
            resources.ApplyResources(this.lblValor, "lblValor");
            this.lblValor.Name = "lblValor";
            // 
            // txtQuantidade
            // 
            resources.ApplyResources(this.txtQuantidade, "txtQuantidade");
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtValor
            // 
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.Name = "txtValor";
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToResizeColumns = false;
            this.dtgLista.AllowUserToResizeRows = false;
            this.dtgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLista.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgLista, "dtgLista");
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.ShowCellErrors = false;
            this.dtgLista.ShowCellToolTips = false;
            this.dtgLista.ShowEditingIcon = false;
            this.dtgLista.ShowRowErrors = false;
            this.dtgLista.UseWaitCursor = true;
            this.dtgLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellDoubleClick);
            // 
            // tbcCadastroProduto
            // 
            this.tbcCadastroProduto.Controls.Add(this.tbcProdutoPag0);
            this.tbcCadastroProduto.Controls.Add(this.tbcProdutoPag1);
            resources.ApplyResources(this.tbcCadastroProduto, "tbcCadastroProduto");
            this.tbcCadastroProduto.Name = "tbcCadastroProduto";
            this.tbcCadastroProduto.SelectedIndex = 0;
            this.tbcCadastroProduto.Click += new System.EventHandler(this.frmCadastroProduto_Load);
            this.tbcCadastroProduto.Enter += new System.EventHandler(this.frmCadastroProduto_Load);
            // 
            // tbcProdutoPag0
            // 
            this.tbcProdutoPag0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcProdutoPag0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcProdutoPag0.Controls.Add(this.cbxEmpresa);
            this.tbcProdutoPag0.Controls.Add(this.btnCancelar);
            this.tbcProdutoPag0.Controls.Add(this.btnSalvar);
            this.tbcProdutoPag0.Controls.Add(this.txtDescricao);
            this.tbcProdutoPag0.Controls.Add(this.txtQuantidade);
            this.tbcProdutoPag0.Controls.Add(this.lblQuantidade);
            this.tbcProdutoPag0.Controls.Add(this.lblDescricao);
            this.tbcProdutoPag0.Controls.Add(this.txtValor);
            this.tbcProdutoPag0.Controls.Add(this.lblValor);
            this.tbcProdutoPag0.Controls.Add(this.lblEmpresa);
            resources.ApplyResources(this.tbcProdutoPag0, "tbcProdutoPag0");
            this.tbcProdutoPag0.Name = "tbcProdutoPag0";
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbxEmpresa, "cbxEmpresa");
            this.cbxEmpresa.FormattingEnabled = true;
            this.cbxEmpresa.Name = "cbxEmpresa";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Vendas_Diego_Nogueira.Properties.Resources.cancelar;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // tbcProdutoPag1
            // 
            this.tbcProdutoPag1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcProdutoPag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcProdutoPag1.Controls.Add(this.gpxConsultaProduto);
            this.tbcProdutoPag1.Controls.Add(this.dtgLista);
            resources.ApplyResources(this.tbcProdutoPag1, "tbcProdutoPag1");
            this.tbcProdutoPag1.Name = "tbcProdutoPag1";
            // 
            // gpxConsultaProduto
            // 
            this.gpxConsultaProduto.Controls.Add(this.btnPesquisar);
            this.gpxConsultaProduto.Controls.Add(this.txtPesquisa);
            this.gpxConsultaProduto.Controls.Add(this.rdbTodos);
            this.gpxConsultaProduto.Controls.Add(this.rdbDescricao);
            this.gpxConsultaProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.gpxConsultaProduto, "gpxConsultaProduto");
            this.gpxConsultaProduto.Name = "gpxConsultaProduto";
            this.gpxConsultaProduto.TabStop = false;
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
            // rdbTodos
            // 
            resources.ApplyResources(this.rdbTodos, "rdbTodos");
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.TabStop = true;
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbDescricao
            // 
            resources.ApplyResources(this.rdbDescricao, "rdbDescricao");
            this.rdbDescricao.Name = "rdbDescricao";
            this.rdbDescricao.TabStop = true;
            this.rdbDescricao.UseVisualStyleBackColor = true;
            // 
            // pnlCadastroProduto
            // 
            this.pnlCadastroProduto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCadastroProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroProduto.Controls.Add(this.btnExcluir);
            this.pnlCadastroProduto.Controls.Add(this.btnFechar);
            this.pnlCadastroProduto.Controls.Add(this.btnAlterar);
            this.pnlCadastroProduto.Controls.Add(this.btnNovo);
            resources.ApplyResources(this.pnlCadastroProduto, "pnlCadastroProduto");
            this.pnlCadastroProduto.Name = "pnlCadastroProduto";
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
            // frmCadastroProduto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlCadastroProduto);
            this.Controls.Add(this.tbcCadastroProduto);
            this.MaximizeBox = false;
            this.Name = "frmCadastroProduto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.tbcCadastroProduto.ResumeLayout(false);
            this.tbcProdutoPag0.ResumeLayout(false);
            this.tbcProdutoPag0.PerformLayout();
            this.tbcProdutoPag1.ResumeLayout(false);
            this.gpxConsultaProduto.ResumeLayout(false);
            this.gpxConsultaProduto.PerformLayout();
            this.pnlCadastroProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.TabControl tbcCadastroProduto;
        private System.Windows.Forms.TabPage tbcProdutoPag0;
        private System.Windows.Forms.TabPage tbcProdutoPag1;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpxConsultaProduto;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbDescricao;
        protected System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastroProduto;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbxEmpresa;
    }
}

