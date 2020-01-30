namespace Reflex
{
    partial class FrmCadastroUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            this.panFundo = new System.Windows.Forms.Panel();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.radFem);
            this.panFundo.Controls.Add(this.radMasc);
            this.panFundo.Controls.Add(this.lblSexo);
            this.panFundo.Controls.Add(this.lblDataNasc);
            this.panFundo.Controls.Add(this.txtDataNasc);
            this.panFundo.Controls.Add(this.lblSenha);
            this.panFundo.Controls.Add(this.txtSenha);
            this.panFundo.Controls.Add(this.lblLogin);
            this.panFundo.Controls.Add(this.txtLogin);
            this.panFundo.Controls.Add(this.lblNome);
            this.panFundo.Controls.Add(this.txtNome);
            this.panFundo.Controls.Add(this.btnLimpar);
            this.panFundo.Controls.Add(this.btnCadastrar);
            this.panFundo.Location = new System.Drawing.Point(230, 75);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(438, 347);
            this.panFundo.TabIndex = 0;
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radFem.Location = new System.Drawing.Point(321, 194);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(81, 20);
            this.radFem.TabIndex = 18;
            this.radFem.TabStop = true;
            this.radFem.Text = "Feminino";
            this.radFem.UseVisualStyleBackColor = true;
            this.radFem.CheckedChanged += new System.EventHandler(this.radFem_CheckedChanged);
            // 
            // radMasc
            // 
            this.radMasc.AutoSize = true;
            this.radMasc.Checked = true;
            this.radMasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMasc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radMasc.Location = new System.Drawing.Point(225, 194);
            this.radMasc.Name = "radMasc";
            this.radMasc.Size = new System.Drawing.Size(87, 20);
            this.radMasc.TabIndex = 17;
            this.radMasc.TabStop = true;
            this.radMasc.Text = "Masculino";
            this.radMasc.UseVisualStyleBackColor = true;
            this.radMasc.CheckedChanged += new System.EventHandler(this.radMasc_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSexo.Location = new System.Drawing.Point(221, 167);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(55, 20);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo *";
            this.toolDicas.SetToolTip(this.lblSexo, "Selecione seu sexo");
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDataNasc.Location = new System.Drawing.Point(37, 167);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(103, 20);
            this.lblDataNasc.TabIndex = 15;
            this.lblDataNasc.Text = "Nascimento *";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNasc.Location = new System.Drawing.Point(38, 190);
            this.txtDataNasc.Mask = "##/##/####";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(100, 26);
            this.txtDataNasc.TabIndex = 14;
            this.toolDicas.SetToolTip(this.txtDataNasc, "Digite sua data de nascimento");
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSenha.Location = new System.Drawing.Point(256, 101);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 20);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha *";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(260, 124);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(143, 26);
            this.txtSenha.TabIndex = 12;
            this.toolDicas.SetToolTip(this.txtSenha, "Digite a senha desejada");
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogin.Location = new System.Drawing.Point(34, 101);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(58, 20);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "Login *";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(38, 124);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(193, 26);
            this.txtLogin.TabIndex = 10;
            this.toolDicas.SetToolTip(this.txtLogin, "Digite o login desejado");
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNome.Location = new System.Drawing.Point(34, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 20);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(38, 62);
            this.txtNome.MaxLength = 80;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(365, 26);
            this.txtNome.TabIndex = 8;
            this.toolDicas.SetToolTip(this.txtNome, "Digite seu nome completo");
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(113, 282);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 30);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.toolDicas.SetToolTip(this.btnLimpar, "Limpar todos os campos");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(225, 282);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.toolDicas.SetToolTip(this.btnCadastrar, "Confirmar cadastro");
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastroUsuario";
            this.Text = "Novo Usuário";
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}