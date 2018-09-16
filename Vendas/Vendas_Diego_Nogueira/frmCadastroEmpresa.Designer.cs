namespace Vendas_Diego_Nogueira
{
    partial class frmCadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEmpresa));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.tbcCadastroEmpresa = new System.Windows.Forms.TabControl();
            this.tbcEmpresaPag0 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbcEmpresaPag1 = new System.Windows.Forms.TabPage();
            this.gpxConsultaEmpresa = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbCidade = new System.Windows.Forms.RadioButton();
            this.rdbEndereco = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.pnlCadastroEmpresa = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.tbcCadastroEmpresa.SuspendLayout();
            this.tbcEmpresaPag0.SuspendLayout();
            this.tbcEmpresaPag1.SuspendLayout();
            this.gpxConsultaEmpresa.SuspendLayout();
            this.pnlCadastroEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // lblEndereco
            // 
            resources.ApplyResources(this.lblEndereco, "lblEndereco");
            this.lblEndereco.Name = "lblEndereco";
            // 
            // lblSite
            // 
            resources.ApplyResources(this.lblSite, "lblSite");
            this.lblSite.Name = "lblSite";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // lblCidade
            // 
            resources.ApplyResources(this.lblCidade, "lblCidade");
            this.lblCidade.Name = "lblCidade";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtEndereco, "txtEndereco");
            this.txtEndereco.Name = "txtEndereco";
            // 
            // txtSite
            // 
            resources.ApplyResources(this.txtSite, "txtSite");
            this.txtSite.Name = "txtSite";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.txtCidade.Name = "txtCidade";
            // 
            // mskTelefone
            // 
            this.mskTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.mskTelefone, "mskTelefone");
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.ResetOnPrompt = false;
            this.mskTelefone.ResetOnSpace = false;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.Name = "lblTelefone";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToDeleteRows = false;
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
            // tbcCadastroEmpresa
            // 
            this.tbcCadastroEmpresa.Controls.Add(this.tbcEmpresaPag0);
            this.tbcCadastroEmpresa.Controls.Add(this.tbcEmpresaPag1);
            resources.ApplyResources(this.tbcCadastroEmpresa, "tbcCadastroEmpresa");
            this.tbcCadastroEmpresa.Name = "tbcCadastroEmpresa";
            this.tbcCadastroEmpresa.SelectedIndex = 0;
            this.tbcCadastroEmpresa.Click += new System.EventHandler(this.frmCadastroEmpresa_Load);
            this.tbcCadastroEmpresa.Enter += new System.EventHandler(this.frmCadastroEmpresa_Load);
            // 
            // tbcEmpresaPag0
            // 
            this.tbcEmpresaPag0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcEmpresaPag0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcEmpresaPag0.Controls.Add(this.btnCancelar);
            this.tbcEmpresaPag0.Controls.Add(this.btnSalvar);
            this.tbcEmpresaPag0.Controls.Add(this.txtNome);
            this.tbcEmpresaPag0.Controls.Add(this.txtEndereco);
            this.tbcEmpresaPag0.Controls.Add(this.lblEndereco);
            this.tbcEmpresaPag0.Controls.Add(this.lblNome);
            this.tbcEmpresaPag0.Controls.Add(this.txtCidade);
            this.tbcEmpresaPag0.Controls.Add(this.lblCidade);
            this.tbcEmpresaPag0.Controls.Add(this.txtEmail);
            this.tbcEmpresaPag0.Controls.Add(this.lblEmail);
            this.tbcEmpresaPag0.Controls.Add(this.mskTelefone);
            this.tbcEmpresaPag0.Controls.Add(this.lblTelefone);
            this.tbcEmpresaPag0.Controls.Add(this.txtSite);
            this.tbcEmpresaPag0.Controls.Add(this.lblSite);
            resources.ApplyResources(this.tbcEmpresaPag0, "tbcEmpresaPag0");
            this.tbcEmpresaPag0.Name = "tbcEmpresaPag0";
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
            // tbcEmpresaPag1
            // 
            this.tbcEmpresaPag1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcEmpresaPag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcEmpresaPag1.Controls.Add(this.gpxConsultaEmpresa);
            this.tbcEmpresaPag1.Controls.Add(this.dtgLista);
            resources.ApplyResources(this.tbcEmpresaPag1, "tbcEmpresaPag1");
            this.tbcEmpresaPag1.Name = "tbcEmpresaPag1";
            // 
            // gpxConsultaEmpresa
            // 
            resources.ApplyResources(this.gpxConsultaEmpresa, "gpxConsultaEmpresa");
            this.gpxConsultaEmpresa.Controls.Add(this.rdbTodos);
            this.gpxConsultaEmpresa.Controls.Add(this.btnPesquisar);
            this.gpxConsultaEmpresa.Controls.Add(this.txtPesquisa);
            this.gpxConsultaEmpresa.Controls.Add(this.rdbCidade);
            this.gpxConsultaEmpresa.Controls.Add(this.rdbEndereco);
            this.gpxConsultaEmpresa.Controls.Add(this.rdbNome);
            this.gpxConsultaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpxConsultaEmpresa.Name = "gpxConsultaEmpresa";
            this.gpxConsultaEmpresa.TabStop = false;
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
            // rdbCidade
            // 
            resources.ApplyResources(this.rdbCidade, "rdbCidade");
            this.rdbCidade.Name = "rdbCidade";
            this.rdbCidade.TabStop = true;
            this.rdbCidade.UseVisualStyleBackColor = true;
            // 
            // rdbEndereco
            // 
            resources.ApplyResources(this.rdbEndereco, "rdbEndereco");
            this.rdbEndereco.Name = "rdbEndereco";
            this.rdbEndereco.TabStop = true;
            this.rdbEndereco.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            resources.ApplyResources(this.rdbNome, "rdbNome");
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.TabStop = true;
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // pnlCadastroEmpresa
            // 
            this.pnlCadastroEmpresa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCadastroEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroEmpresa.Controls.Add(this.btnExcluir);
            this.pnlCadastroEmpresa.Controls.Add(this.btnFechar);
            this.pnlCadastroEmpresa.Controls.Add(this.btnAlterar);
            this.pnlCadastroEmpresa.Controls.Add(this.btnNovo);
            resources.ApplyResources(this.pnlCadastroEmpresa, "pnlCadastroEmpresa");
            this.pnlCadastroEmpresa.Name = "pnlCadastroEmpresa";
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
            // frmCadastroEmpresa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlCadastroEmpresa);
            this.Controls.Add(this.tbcCadastroEmpresa);
            this.MaximizeBox = false;
            this.Name = "frmCadastroEmpresa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmCadastroEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.tbcCadastroEmpresa.ResumeLayout(false);
            this.tbcEmpresaPag0.ResumeLayout(false);
            this.tbcEmpresaPag0.PerformLayout();
            this.tbcEmpresaPag1.ResumeLayout(false);
            this.gpxConsultaEmpresa.ResumeLayout(false);
            this.gpxConsultaEmpresa.PerformLayout();
            this.pnlCadastroEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.TabControl tbcCadastroEmpresa;
        private System.Windows.Forms.TabPage tbcEmpresaPag0;
        private System.Windows.Forms.TabPage tbcEmpresaPag1;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpxConsultaEmpresa;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbCidade;
        private System.Windows.Forms.RadioButton rdbEndereco;
        private System.Windows.Forms.RadioButton rdbNome;
        protected System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastroEmpresa;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}

