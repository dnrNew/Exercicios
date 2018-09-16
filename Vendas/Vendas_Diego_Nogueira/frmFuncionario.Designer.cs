namespace Vendas_Diego_Nogueira
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.tbcCadastroFuncionario = new System.Windows.Forms.TabControl();
            this.tbcFuncionarioPag0 = new System.Windows.Forms.TabPage();
            this.txtconfSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbcFuncionarioPag1 = new System.Windows.Forms.TabPage();
            this.gpxConsultaFuncionario = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbUsuario = new System.Windows.Forms.RadioButton();
            this.rdbCpf = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.pnlCadastroFuncionario = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.tbcCadastroFuncionario.SuspendLayout();
            this.tbcFuncionarioPag0.SuspendLayout();
            this.tbcFuncionarioPag1.SuspendLayout();
            this.gpxConsultaFuncionario.SuspendLayout();
            this.pnlCadastroFuncionario.SuspendLayout();
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
            // tbcCadastroFuncionario
            // 
            this.tbcCadastroFuncionario.Controls.Add(this.tbcFuncionarioPag0);
            this.tbcCadastroFuncionario.Controls.Add(this.tbcFuncionarioPag1);
            resources.ApplyResources(this.tbcCadastroFuncionario, "tbcCadastroFuncionario");
            this.tbcCadastroFuncionario.Name = "tbcCadastroFuncionario";
            this.tbcCadastroFuncionario.SelectedIndex = 0;
            this.tbcCadastroFuncionario.Click += new System.EventHandler(this.frmFuncionario_Load);
            this.tbcCadastroFuncionario.Enter += new System.EventHandler(this.frmFuncionario_Load);
            // 
            // tbcFuncionarioPag0
            // 
            this.tbcFuncionarioPag0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcFuncionarioPag0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcFuncionarioPag0.Controls.Add(this.txtconfSenha);
            this.tbcFuncionarioPag0.Controls.Add(this.label2);
            this.tbcFuncionarioPag0.Controls.Add(this.txtUsuario);
            this.tbcFuncionarioPag0.Controls.Add(this.lblUsuario);
            this.tbcFuncionarioPag0.Controls.Add(this.txtSenha);
            this.tbcFuncionarioPag0.Controls.Add(this.lblSenha);
            this.tbcFuncionarioPag0.Controls.Add(this.lblData);
            this.tbcFuncionarioPag0.Controls.Add(this.dtpNascimento);
            this.tbcFuncionarioPag0.Controls.Add(this.txtEmail);
            this.tbcFuncionarioPag0.Controls.Add(this.lblEmail);
            this.tbcFuncionarioPag0.Controls.Add(this.mskCpf);
            this.tbcFuncionarioPag0.Controls.Add(this.label1);
            this.tbcFuncionarioPag0.Controls.Add(this.cbxEstado);
            this.tbcFuncionarioPag0.Controls.Add(this.lblEstado);
            this.tbcFuncionarioPag0.Controls.Add(this.btnCancelar);
            this.tbcFuncionarioPag0.Controls.Add(this.btnSalvar);
            this.tbcFuncionarioPag0.Controls.Add(this.txtNome);
            this.tbcFuncionarioPag0.Controls.Add(this.txtEndereco);
            this.tbcFuncionarioPag0.Controls.Add(this.lblEndereco);
            this.tbcFuncionarioPag0.Controls.Add(this.lblNome);
            this.tbcFuncionarioPag0.Controls.Add(this.txtCidade);
            this.tbcFuncionarioPag0.Controls.Add(this.lblCidade);
            this.tbcFuncionarioPag0.Controls.Add(this.mskTelefone);
            this.tbcFuncionarioPag0.Controls.Add(this.lblTelefone);
            resources.ApplyResources(this.tbcFuncionarioPag0, "tbcFuncionarioPag0");
            this.tbcFuncionarioPag0.Name = "tbcFuncionarioPag0";
            // 
            // txtconfSenha
            // 
            resources.ApplyResources(this.txtconfSenha, "txtconfSenha");
            this.txtconfSenha.Name = "txtconfSenha";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.Name = "lblSenha";
            // 
            // lblData
            // 
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.Name = "lblData";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Checked = false;
            resources.ApplyResources(this.dtpNascimento, "dtpNascimento");
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.TabStop = false;
            this.dtpNascimento.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // mskCpf
            // 
            this.mskCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.mskCpf, "mskCpf");
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // tbcFuncionarioPag1
            // 
            this.tbcFuncionarioPag1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbcFuncionarioPag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbcFuncionarioPag1.Controls.Add(this.gpxConsultaFuncionario);
            this.tbcFuncionarioPag1.Controls.Add(this.dtgLista);
            resources.ApplyResources(this.tbcFuncionarioPag1, "tbcFuncionarioPag1");
            this.tbcFuncionarioPag1.Name = "tbcFuncionarioPag1";
            // 
            // gpxConsultaFuncionario
            // 
            this.gpxConsultaFuncionario.Controls.Add(this.rdbTodos);
            this.gpxConsultaFuncionario.Controls.Add(this.btnPesquisar);
            this.gpxConsultaFuncionario.Controls.Add(this.txtPesquisa);
            this.gpxConsultaFuncionario.Controls.Add(this.rdbUsuario);
            this.gpxConsultaFuncionario.Controls.Add(this.rdbCpf);
            this.gpxConsultaFuncionario.Controls.Add(this.rdbNome);
            this.gpxConsultaFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.gpxConsultaFuncionario, "gpxConsultaFuncionario");
            this.gpxConsultaFuncionario.Name = "gpxConsultaFuncionario";
            this.gpxConsultaFuncionario.TabStop = false;
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
            resources.ApplyResources(this.txtPesquisa, "txtPesquisa");
            this.txtPesquisa.Name = "txtPesquisa";
            // 
            // rdbUsuario
            // 
            resources.ApplyResources(this.rdbUsuario, "rdbUsuario");
            this.rdbUsuario.Name = "rdbUsuario";
            this.rdbUsuario.TabStop = true;
            this.rdbUsuario.UseVisualStyleBackColor = true;
            // 
            // rdbCpf
            // 
            resources.ApplyResources(this.rdbCpf, "rdbCpf");
            this.rdbCpf.Name = "rdbCpf";
            this.rdbCpf.TabStop = true;
            this.rdbCpf.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            resources.ApplyResources(this.rdbNome, "rdbNome");
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.TabStop = true;
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // pnlCadastroFuncionario
            // 
            this.pnlCadastroFuncionario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCadastroFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroFuncionario.Controls.Add(this.btnExcluir);
            this.pnlCadastroFuncionario.Controls.Add(this.btnFechar);
            this.pnlCadastroFuncionario.Controls.Add(this.btnAlterar);
            this.pnlCadastroFuncionario.Controls.Add(this.btnNovo);
            resources.ApplyResources(this.pnlCadastroFuncionario, "pnlCadastroFuncionario");
            this.pnlCadastroFuncionario.Name = "pnlCadastroFuncionario";
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
            // frmFuncionario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlCadastroFuncionario);
            this.Controls.Add(this.tbcCadastroFuncionario);
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.tbcCadastroFuncionario.ResumeLayout(false);
            this.tbcFuncionarioPag0.ResumeLayout(false);
            this.tbcFuncionarioPag0.PerformLayout();
            this.tbcFuncionarioPag1.ResumeLayout(false);
            this.gpxConsultaFuncionario.ResumeLayout(false);
            this.gpxConsultaFuncionario.PerformLayout();
            this.pnlCadastroFuncionario.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tbcCadastroFuncionario;
        private System.Windows.Forms.TabPage tbcFuncionarioPag0;
        private System.Windows.Forms.TabPage tbcFuncionarioPag1;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpxConsultaFuncionario;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbUsuario;
        private System.Windows.Forms.RadioButton rdbCpf;
        private System.Windows.Forms.RadioButton rdbNome;
        protected System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCadastroFuncionario;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtconfSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}

