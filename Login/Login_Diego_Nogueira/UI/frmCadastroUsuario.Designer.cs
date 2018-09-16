namespace CamadaInterface
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.pnlDescr = new System.Windows.Forms.Panel();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlDescr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDescr
            // 
            this.pnlDescr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDescr.Controls.Add(this.lblConfirmaSenha);
            this.pnlDescr.Controls.Add(this.txtConfirmaSenha);
            this.pnlDescr.Controls.Add(this.txtId);
            this.pnlDescr.Controls.Add(this.lblId);
            this.pnlDescr.Controls.Add(this.txtNome);
            this.pnlDescr.Controls.Add(this.lblNome);
            this.pnlDescr.Controls.Add(this.lblLogin);
            this.pnlDescr.Controls.Add(this.lblSenha);
            this.pnlDescr.Controls.Add(this.lblEmail);
            this.pnlDescr.Controls.Add(this.txtLogin);
            this.pnlDescr.Controls.Add(this.txtSenha);
            this.pnlDescr.Location = new System.Drawing.Point(12, 12);
            this.pnlDescr.Name = "pnlDescr";
            this.pnlDescr.Size = new System.Drawing.Size(540, 201);
            this.pnlDescr.TabIndex = 37;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(21, 162);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(104, 16);
            this.lblConfirmaSenha.TabIndex = 31;
            this.lblConfirmaSenha.Text = "Confirma Senha:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(131, 159);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmaSenha.MaxLength = 30;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(380, 22);
            this.txtConfirmaSenha.TabIndex = 3;
            this.txtConfirmaSenha.Validated += new System.EventHandler(this.txtConfirmaSenha_Validated_1);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(131, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(115, 22);
            this.txtId.TabIndex = 15;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblId.Location = new System.Drawing.Point(85, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 16);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "ID:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 51);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(380, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(69, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLogin.Location = new System.Drawing.Point(69, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 16);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenha.Location = new System.Drawing.Point(69, 129);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(290, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(131, 87);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.MaxLength = 45;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(380, 22);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Validated += new System.EventHandler(this.txtLogin_Validated_1);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(131, 123);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(380, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Validated += new System.EventHandler(this.txtSenha_Validated_1);
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
            this.btnAlterar.Location = new System.Drawing.Point(298, 228);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 40);
            this.btnAlterar.TabIndex = 6;
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
            this.btnBuscar.Location = new System.Drawing.Point(155, 228);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 40);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNovo.Location = new System.Drawing.Point(12, 228);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 40);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            this.btnExcluir.Location = new System.Drawing.Point(441, 228);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(563, 280);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.pnlDescr);
            this.Controls.Add(this.btnExcluir);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.pnlDescr.ResumeLayout(false);
            this.pnlDescr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlDescr;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        protected System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
    }
}