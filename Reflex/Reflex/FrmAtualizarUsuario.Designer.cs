namespace Reflex
{
    partial class FrmAtualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtualizarUsuario));
            this.panGuias = new System.Windows.Forms.Panel();
            this.panTab = new System.Windows.Forms.TabControl();
            this.tabAtualizar = new System.Windows.Forms.TabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
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
            this.tabDeletar = new System.Windows.Forms.TabPage();
            this.panAlert = new System.Windows.Forms.Panel();
            this.lblFecharAlert = new System.Windows.Forms.Label();
            this.lblWarningTwo = new System.Windows.Forms.Label();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblID2 = new System.Windows.Forms.Label();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.txtLogin2 = new System.Windows.Forms.TextBox();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panGuias.SuspendLayout();
            this.panTab.SuspendLayout();
            this.tabAtualizar.SuspendLayout();
            this.tabDeletar.SuspendLayout();
            this.panAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGuias
            // 
            this.panGuias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panGuias.Controls.Add(this.panTab);
            this.panGuias.Location = new System.Drawing.Point(184, 65);
            this.panGuias.Name = "panGuias";
            this.panGuias.Size = new System.Drawing.Size(508, 362);
            this.panGuias.TabIndex = 0;
            // 
            // panTab
            // 
            this.panTab.Controls.Add(this.tabAtualizar);
            this.panTab.Controls.Add(this.tabDeletar);
            this.panTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.panTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTab.Location = new System.Drawing.Point(0, 0);
            this.panTab.Name = "panTab";
            this.panTab.SelectedIndex = 0;
            this.panTab.Size = new System.Drawing.Size(508, 362);
            this.panTab.TabIndex = 0;
            // 
            // tabAtualizar
            // 
            this.tabAtualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabAtualizar.Controls.Add(this.lblID);
            this.tabAtualizar.Controls.Add(this.txtID);
            this.tabAtualizar.Controls.Add(this.btnAtualizar);
            this.tabAtualizar.Controls.Add(this.radFem);
            this.tabAtualizar.Controls.Add(this.radMasc);
            this.tabAtualizar.Controls.Add(this.lblSexo);
            this.tabAtualizar.Controls.Add(this.lblDataNasc);
            this.tabAtualizar.Controls.Add(this.txtDataNasc);
            this.tabAtualizar.Controls.Add(this.lblSenha);
            this.tabAtualizar.Controls.Add(this.txtSenha);
            this.tabAtualizar.Controls.Add(this.lblLogin);
            this.tabAtualizar.Controls.Add(this.txtLogin);
            this.tabAtualizar.Controls.Add(this.lblNome);
            this.tabAtualizar.Controls.Add(this.txtNome);
            this.tabAtualizar.Location = new System.Drawing.Point(4, 22);
            this.tabAtualizar.Name = "tabAtualizar";
            this.tabAtualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtualizar.Size = new System.Drawing.Size(500, 336);
            this.tabAtualizar.TabIndex = 0;
            this.tabAtualizar.Text = "Meus Dados";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblID.Location = new System.Drawing.Point(57, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 20);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "Meu ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(61, 42);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(72, 26);
            this.txtID.TabIndex = 29;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(194, 279);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 30);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "Atualizar dados";
            this.toolDicas.SetToolTip(this.btnAtualizar, "Atulaizar meus dados");
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radFem.Location = new System.Drawing.Point(351, 234);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(81, 20);
            this.radFem.TabIndex = 27;
            this.radFem.TabStop = true;
            this.radFem.Text = "Feminino";
            this.radFem.UseVisualStyleBackColor = true;
            // 
            // radMasc
            // 
            this.radMasc.AutoSize = true;
            this.radMasc.Checked = true;
            this.radMasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMasc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radMasc.Location = new System.Drawing.Point(255, 234);
            this.radMasc.Name = "radMasc";
            this.radMasc.Size = new System.Drawing.Size(87, 20);
            this.radMasc.TabIndex = 26;
            this.radMasc.TabStop = true;
            this.radMasc.Text = "Masculino";
            this.radMasc.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSexo.Location = new System.Drawing.Point(251, 207);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(55, 20);
            this.lblSexo.TabIndex = 25;
            this.lblSexo.Text = "Sexo *";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDataNasc.Location = new System.Drawing.Point(67, 207);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(93, 20);
            this.lblDataNasc.TabIndex = 24;
            this.lblDataNasc.Text = "Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNasc.Location = new System.Drawing.Point(68, 230);
            this.txtDataNasc.Mask = "##/##/####";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(100, 26);
            this.txtDataNasc.TabIndex = 23;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSenha.Location = new System.Drawing.Point(282, 144);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 20);
            this.lblSenha.TabIndex = 22;
            this.lblSenha.Text = "Senha *";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(286, 167);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(143, 26);
            this.txtSenha.TabIndex = 21;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogin.Location = new System.Drawing.Point(60, 144);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(58, 20);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Login *";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(64, 167);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(193, 26);
            this.txtLogin.TabIndex = 19;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNome.Location = new System.Drawing.Point(57, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 20);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome *";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(61, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(365, 26);
            this.txtNome.TabIndex = 10;
            // 
            // tabDeletar
            // 
            this.tabDeletar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDeletar.Controls.Add(this.panAlert);
            this.tabDeletar.Controls.Add(this.btnExcluir);
            this.tabDeletar.Controls.Add(this.lblID2);
            this.tabDeletar.Controls.Add(this.txtID2);
            this.tabDeletar.Controls.Add(this.lblLogin2);
            this.tabDeletar.Controls.Add(this.txtLogin2);
            this.tabDeletar.Location = new System.Drawing.Point(4, 22);
            this.tabDeletar.Name = "tabDeletar";
            this.tabDeletar.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeletar.Size = new System.Drawing.Size(500, 336);
            this.tabDeletar.TabIndex = 1;
            this.tabDeletar.Text = "Danger Zone";
            // 
            // panAlert
            // 
            this.panAlert.BackColor = System.Drawing.Color.Pink;
            this.panAlert.Controls.Add(this.lblFecharAlert);
            this.panAlert.Controls.Add(this.lblWarningTwo);
            this.panAlert.Controls.Add(this.lblWarningOne);
            this.panAlert.Location = new System.Drawing.Point(-4, 0);
            this.panAlert.Name = "panAlert";
            this.panAlert.Size = new System.Drawing.Size(508, 51);
            this.panAlert.TabIndex = 36;
            // 
            // lblFecharAlert
            // 
            this.lblFecharAlert.AutoSize = true;
            this.lblFecharAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFecharAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharAlert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecharAlert.Location = new System.Drawing.Point(486, 12);
            this.lblFecharAlert.Name = "lblFecharAlert";
            this.lblFecharAlert.Size = new System.Drawing.Size(13, 15);
            this.lblFecharAlert.TabIndex = 2;
            this.lblFecharAlert.Text = "x";
            this.toolDicas.SetToolTip(this.lblFecharAlert, "Fechar aviso");
            this.lblFecharAlert.Click += new System.EventHandler(this.lblFecharAlert_Click);
            // 
            // lblWarningTwo
            // 
            this.lblWarningTwo.AutoSize = true;
            this.lblWarningTwo.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarningTwo.Location = new System.Drawing.Point(42, 25);
            this.lblWarningTwo.Name = "lblWarningTwo";
            this.lblWarningTwo.Size = new System.Drawing.Size(288, 13);
            this.lblWarningTwo.TabIndex = 1;
            this.lblWarningTwo.Text = "também serão excluidos. Esta ação não poderá ser desfeita";
            // 
            // lblWarningOne
            // 
            this.lblWarningOne.AutoSize = true;
            this.lblWarningOne.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarningOne.Location = new System.Drawing.Point(42, 12);
            this.lblWarningOne.Name = "lblWarningOne";
            this.lblWarningOne.Size = new System.Drawing.Size(334, 13);
            this.lblWarningOne.TabIndex = 0;
            this.lblWarningOne.Text = "Atenção, se você excluir seu usuário, todos seus dados cadastrados ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(197, 258);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 30);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "Excluir usuário";
            this.toolDicas.SetToolTip(this.btnExcluir, "Excluir dados do usuário");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblID2.Location = new System.Drawing.Point(94, 76);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(61, 20);
            this.lblID2.TabIndex = 34;
            this.lblID2.Text = "Meu ID";
            // 
            // txtID2
            // 
            this.txtID2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID2.Location = new System.Drawing.Point(98, 99);
            this.txtID2.Name = "txtID2";
            this.txtID2.ReadOnly = true;
            this.txtID2.Size = new System.Drawing.Size(72, 26);
            this.txtID2.TabIndex = 33;
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogin2.Location = new System.Drawing.Point(94, 145);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(48, 20);
            this.lblLogin2.TabIndex = 32;
            this.lblLogin2.Text = "Login";
            // 
            // txtLogin2
            // 
            this.txtLogin2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin2.Location = new System.Drawing.Point(98, 168);
            this.txtLogin2.Name = "txtLogin2";
            this.txtLogin2.ReadOnly = true;
            this.txtLogin2.Size = new System.Drawing.Size(193, 26);
            this.txtLogin2.TabIndex = 31;
            // 
            // FrmAtualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panGuias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAtualizarUsuario";
            this.Text = "Atualizar Meus Dados";
            this.panGuias.ResumeLayout(false);
            this.panTab.ResumeLayout(false);
            this.tabAtualizar.ResumeLayout(false);
            this.tabAtualizar.PerformLayout();
            this.tabDeletar.ResumeLayout(false);
            this.tabDeletar.PerformLayout();
            this.panAlert.ResumeLayout(false);
            this.panAlert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGuias;
        private System.Windows.Forms.TabControl panTab;
        private System.Windows.Forms.TabPage tabAtualizar;
        private System.Windows.Forms.TabPage tabDeletar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.Label lblLogin2;
        private System.Windows.Forms.TextBox txtLogin2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panAlert;
        private System.Windows.Forms.Label lblFecharAlert;
        private System.Windows.Forms.Label lblWarningTwo;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}