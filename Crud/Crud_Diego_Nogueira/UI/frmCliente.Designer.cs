namespace Crud_Diego_Nogueira
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlDescr = new System.Windows.Forms.Panel();
            this.lblObrigatorio = new System.Windows.Forms.Label();
            this.mskTelefoneCel = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCel = new System.Windows.Forms.Label();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTelefoneRes = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneRes = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.pnlDescr.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToResizeColumns = false;
            this.dtgLista.AllowUserToResizeRows = false;
            this.dtgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLista.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtgLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLista.Location = new System.Drawing.Point(12, 354);
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgLista.ShowCellErrors = false;
            this.dtgLista.ShowCellToolTips = false;
            this.dtgLista.ShowEditingIcon = false;
            this.dtgLista.ShowRowErrors = false;
            this.dtgLista.Size = new System.Drawing.Size(676, 235);
            this.dtgLista.TabIndex = 20;
            this.dtgLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellDoubleClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(388, 600);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 40);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(200, 600);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 40);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(12, 600);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 40);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlDescr
            // 
            this.pnlDescr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDescr.Controls.Add(this.lblObrigatorio);
            this.pnlDescr.Controls.Add(this.mskTelefoneCel);
            this.pnlDescr.Controls.Add(this.lblTelefoneCel);
            this.pnlDescr.Controls.Add(this.cbxUf);
            this.pnlDescr.Controls.Add(this.txtId);
            this.pnlDescr.Controls.Add(this.lblId);
            this.pnlDescr.Controls.Add(this.lblUF);
            this.pnlDescr.Controls.Add(this.mskCpf);
            this.pnlDescr.Controls.Add(this.label1);
            this.pnlDescr.Controls.Add(this.mskTelefoneRes);
            this.pnlDescr.Controls.Add(this.lblTelefoneRes);
            this.pnlDescr.Controls.Add(this.mskCep);
            this.pnlDescr.Controls.Add(this.txtNome);
            this.pnlDescr.Controls.Add(this.lblNome);
            this.pnlDescr.Controls.Add(this.lblEndereco);
            this.pnlDescr.Controls.Add(this.lblBairro);
            this.pnlDescr.Controls.Add(this.lblEmail);
            this.pnlDescr.Controls.Add(this.lblCidade);
            this.pnlDescr.Controls.Add(this.lblCep);
            this.pnlDescr.Controls.Add(this.txtEnd);
            this.pnlDescr.Controls.Add(this.txtBairro);
            this.pnlDescr.Controls.Add(this.txtEmail);
            this.pnlDescr.Controls.Add(this.txtCidade);
            this.pnlDescr.Location = new System.Drawing.Point(12, 12);
            this.pnlDescr.Name = "pnlDescr";
            this.pnlDescr.Size = new System.Drawing.Size(676, 336);
            this.pnlDescr.TabIndex = 38;
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblObrigatorio.Location = new System.Drawing.Point(407, 16);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(255, 13);
            this.lblObrigatorio.TabIndex = 34;
            this.lblObrigatorio.Text = "*Todos os campos são de preenchimento obrigatório";
            // 
            // mskTelefoneCel
            // 
            this.mskTelefoneCel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefoneCel.Location = new System.Drawing.Point(551, 245);
            this.mskTelefoneCel.Mask = "(99) 00000-0000";
            this.mskTelefoneCel.Name = "mskTelefoneCel";
            this.mskTelefoneCel.PromptChar = ' ';
            this.mskTelefoneCel.Size = new System.Drawing.Size(111, 20);
            this.mskTelefoneCel.TabIndex = 9;
            this.mskTelefoneCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefoneCel.Validated += new System.EventHandler(this.mskTelefoneCel_Validated);
            // 
            // lblTelefoneCel
            // 
            this.lblTelefoneCel.AutoSize = true;
            this.lblTelefoneCel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTelefoneCel.Location = new System.Drawing.Point(548, 229);
            this.lblTelefoneCel.Name = "lblTelefoneCel";
            this.lblTelefoneCel.Size = new System.Drawing.Size(84, 13);
            this.lblTelefoneCel.TabIndex = 33;
            this.lblTelefoneCel.Text = "Telefone Celular";
            // 
            // cbxUf
            // 
            this.cbxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxUf.ForeColor = System.Drawing.Color.Black;
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUf.Location = new System.Drawing.Point(23, 244);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(65, 21);
            this.cbxUf.TabIndex = 6;
            this.cbxUf.Validated += new System.EventHandler(this.cbxUf_Validated);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(22, 33);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.MaxLength = 9;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(122, 20);
            this.txtId.TabIndex = 0;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            this.txtId.Validated += new System.EventHandler(this.txtId_Validated);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblId.Location = new System.Drawing.Point(20, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "ID";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUF.Location = new System.Drawing.Point(20, 228);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 27;
            this.lblUF.Text = "UF";
            // 
            // mskCpf
            // 
            this.mskCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCpf.Location = new System.Drawing.Point(171, 33);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.PromptChar = ' ';
            this.mskCpf.Size = new System.Drawing.Size(103, 20);
            this.mskCpf.TabIndex = 1;
            this.mskCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCpf.Validated += new System.EventHandler(this.mskCpf_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(168, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPF";
            // 
            // mskTelefoneRes
            // 
            this.mskTelefoneRes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefoneRes.Location = new System.Drawing.Point(351, 245);
            this.mskTelefoneRes.Mask = "(99) 0000-0000";
            this.mskTelefoneRes.Name = "mskTelefoneRes";
            this.mskTelefoneRes.PromptChar = ' ';
            this.mskTelefoneRes.Size = new System.Drawing.Size(111, 20);
            this.mskTelefoneRes.TabIndex = 8;
            this.mskTelefoneRes.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefoneRes.Validated += new System.EventHandler(this.mskTelefoneRes_Validated);
            // 
            // lblTelefoneRes
            // 
            this.lblTelefoneRes.AutoSize = true;
            this.lblTelefoneRes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTelefoneRes.Location = new System.Drawing.Point(348, 229);
            this.lblTelefoneRes.Name = "lblTelefoneRes";
            this.lblTelefoneRes.Size = new System.Drawing.Size(107, 13);
            this.lblTelefoneRes.TabIndex = 19;
            this.lblTelefoneRes.Text = "Telefone Residencial";
            // 
            // mskCep
            // 
            this.mskCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCep.Location = new System.Drawing.Point(216, 245);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.PromptChar = ' ';
            this.mskCep.Size = new System.Drawing.Size(69, 20);
            this.mskCep.TabIndex = 7;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCep.Validated += new System.EventHandler(this.mskCep_Validated);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 81);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(639, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(20, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEndereco.Location = new System.Drawing.Point(20, 122);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = " Endereço";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBairro.Location = new System.Drawing.Point(20, 176);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = " Bairro";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(25, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCidade.Location = new System.Drawing.Point(348, 176);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCep.Location = new System.Drawing.Point(213, 227);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "CEP";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(23, 139);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnd.MaxLength = 80;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(639, 20);
            this.txtEnd.TabIndex = 3;
            this.txtEnd.Validated += new System.EventHandler(this.txtEnd_Validated);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(23, 193);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(262, 20);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.Validated += new System.EventHandler(this.txtBairro_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(28, 300);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(634, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(351, 193);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.MaxLength = 60;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(311, 20);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Validated += new System.EventHandler(this.txtCidade_Validated);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(576, 600);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(699, 647);
            this.Controls.Add(this.dtgLista);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlDescr);
            this.Controls.Add(this.btnExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.pnlDescr.ResumeLayout(false);
            this.pnlDescr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLista;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlDescr;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTelefoneRes;
        private System.Windows.Forms.Label lblTelefoneRes;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        protected System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbxUf;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCel;
        private System.Windows.Forms.Label lblTelefoneCel;
        private System.Windows.Forms.Label lblObrigatorio;
    }
}

