namespace Vendas_Diego_Nogueira
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.tbcCadastroCliente = new System.Windows.Forms.TabControl();
            this.tbcClientePag0 = new System.Windows.Forms.TabPage();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbcClientePag1 = new System.Windows.Forms.TabPage();
            this.gpxConsultaCliente = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbCidade = new System.Windows.Forms.RadioButton();
            this.rdbEndereco = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.pnlCadastroCliente = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.tbcCadastroCliente.SuspendLayout();
            this.tbcClientePag0.SuspendLayout();
            this.tbcClientePag1.SuspendLayout();
            this.gpxConsultaCliente.SuspendLayout();
            this.pnlCadastroCliente.SuspendLayout();
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
            this.dtgLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellDoubleClick);
            // 
            // tbcCadastroCliente
            // 
            this.tbcCadastroCliente.Controls.Add(this.tbcClientePag0);
            this.tbcCadastroCliente.Controls.Add(this.tbcClientePag1);
            resources.ApplyResources(this.tbcCadastroCliente, "tbcCadastroCliente");
            this.tbcCadastroCliente.Name = "tbcCadastroCliente";
            this.tbcCadastroCliente.SelectedIndex = 0;
            this.tbcCadastroCliente.Click += new System.EventHandler(this.frmCadastroCliente_Load);
            this.tbcCadastroCliente.Enter += new System.EventHandler(this.frmCadastroCliente_Load);
            // 
            // tbcClientePag0
            // 
            this.tbcClientePag0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcClientePag0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcClientePag0.Controls.Add(this.cbxEstado);
            this.tbcClientePag0.Controls.Add(this.lblEstado);
            this.tbcClientePag0.Controls.Add(this.btnCancelar);
            this.tbcClientePag0.Controls.Add(this.btnSalvar);
            this.tbcClientePag0.Controls.Add(this.txtNome);
            this.tbcClientePag0.Controls.Add(this.txtEndereco);
            this.tbcClientePag0.Controls.Add(this.lblEndereco);
            this.tbcClientePag0.Controls.Add(this.lblNome);
            this.tbcClientePag0.Controls.Add(this.txtCidade);
            this.tbcClientePag0.Controls.Add(this.lblCidade);
            this.tbcClientePag0.Controls.Add(this.mskTelefone);
            this.tbcClientePag0.Controls.Add(this.lblTelefone);
            resources.ApplyResources(this.tbcClientePag0, "tbcClientePag0");
            this.tbcClientePag0.Name = "tbcClientePag0";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbxEstado, "cbxEstado");
            this.cbxEstado.ForeColor = System.Drawing.Color.Black;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            resources.GetString("cbxEstado.Items"),
            resources.GetString("cbxEstado.Items1"),
            resources.GetString("cbxEstado.Items2"),
            resources.GetString("cbxEstado.Items3"),
            resources.GetString("cbxEstado.Items4"),
            resources.GetString("cbxEstado.Items5"),
            resources.GetString("cbxEstado.Items6"),
            resources.GetString("cbxEstado.Items7"),
            resources.GetString("cbxEstado.Items8"),
            resources.GetString("cbxEstado.Items9"),
            resources.GetString("cbxEstado.Items10"),
            resources.GetString("cbxEstado.Items11"),
            resources.GetString("cbxEstado.Items12"),
            resources.GetString("cbxEstado.Items13"),
            resources.GetString("cbxEstado.Items14"),
            resources.GetString("cbxEstado.Items15"),
            resources.GetString("cbxEstado.Items16"),
            resources.GetString("cbxEstado.Items17"),
            resources.GetString("cbxEstado.Items18"),
            resources.GetString("cbxEstado.Items19"),
            resources.GetString("cbxEstado.Items20"),
            resources.GetString("cbxEstado.Items21"),
            resources.GetString("cbxEstado.Items22"),
            resources.GetString("cbxEstado.Items23"),
            resources.GetString("cbxEstado.Items24"),
            resources.GetString("cbxEstado.Items25"),
            resources.GetString("cbxEstado.Items26")});
            this.cbxEstado.Name = "cbxEstado";
            // 
            // lblEstado
            // 
            resources.ApplyResources(this.lblEstado, "lblEstado");
            this.lblEstado.Name = "lblEstado";
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
            // tbcClientePag1
            // 
            this.tbcClientePag1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcClientePag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcClientePag1.Controls.Add(this.gpxConsultaCliente);
            this.tbcClientePag1.Controls.Add(this.dtgLista);
            resources.ApplyResources(this.tbcClientePag1, "tbcClientePag1");
            this.tbcClientePag1.Name = "tbcClientePag1";
            // 
            // gpxConsultaCliente
            // 
            this.gpxConsultaCliente.Controls.Add(this.rdbTodos);
            this.gpxConsultaCliente.Controls.Add(this.btnPesquisar);
            this.gpxConsultaCliente.Controls.Add(this.txtPesquisa);
            this.gpxConsultaCliente.Controls.Add(this.rdbCidade);
            this.gpxConsultaCliente.Controls.Add(this.rdbEndereco);
            this.gpxConsultaCliente.Controls.Add(this.rdbNome);
            this.gpxConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.gpxConsultaCliente, "gpxConsultaCliente");
            this.gpxConsultaCliente.Name = "gpxConsultaCliente";
            this.gpxConsultaCliente.TabStop = false;
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
            // pnlCadastroCliente
            // 
            this.pnlCadastroCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCadastroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroCliente.Controls.Add(this.btnExcluir);
            this.pnlCadastroCliente.Controls.Add(this.btnFechar);
            this.pnlCadastroCliente.Controls.Add(this.btnAlterar);
            this.pnlCadastroCliente.Controls.Add(this.btnNovo);
            resources.ApplyResources(this.pnlCadastroCliente, "pnlCadastroCliente");
            this.pnlCadastroCliente.Name = "pnlCadastroCliente";
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
            // frmCadastroCliente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlCadastroCliente);
            this.Controls.Add(this.tbcCadastroCliente);
            this.MaximizeBox = false;
            this.Name = "frmCadastroCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.tbcCadastroCliente.ResumeLayout(false);
            this.tbcClientePag0.ResumeLayout(false);
            this.tbcClientePag0.PerformLayout();
            this.tbcClientePag1.ResumeLayout(false);
            this.gpxConsultaCliente.ResumeLayout(false);
            this.gpxConsultaCliente.PerformLayout();
            this.pnlCadastroCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.TabControl tbcCadastroCliente;
        private System.Windows.Forms.TabPage tbcClientePag0;
        private System.Windows.Forms.TabPage tbcClientePag1;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpxConsultaCliente;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbCidade;
        private System.Windows.Forms.RadioButton rdbEndereco;
        private System.Windows.Forms.RadioButton rdbNome;
        protected System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastroCliente;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}

