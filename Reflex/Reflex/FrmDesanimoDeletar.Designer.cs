namespace Reflex
{
    partial class FrmDesanimoDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesanimoDeletar));
            this.panFundo = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtAcao = new System.Windows.Forms.RichTextBox();
            this.lblAcao = new System.Windows.Forms.Label();
            this.txtPensamento = new System.Windows.Forms.RichTextBox();
            this.lblPensamento = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.panAlert = new System.Windows.Forms.Panel();
            this.lblFecharAlert = new System.Windows.Forms.Label();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.btnExcluir);
            this.panFundo.Controls.Add(this.txtData);
            this.panFundo.Controls.Add(this.lblData);
            this.panFundo.Controls.Add(this.dgvDados);
            this.panFundo.Controls.Add(this.txtAcao);
            this.panFundo.Controls.Add(this.lblAcao);
            this.panFundo.Controls.Add(this.txtPensamento);
            this.panFundo.Controls.Add(this.lblPensamento);
            this.panFundo.Controls.Add(this.txtMotivo);
            this.panFundo.Controls.Add(this.lblMotivo);
            this.panFundo.Location = new System.Drawing.Point(85, 31);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(704, 428);
            this.panFundo.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(302, 376);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 28);
            this.btnExcluir.TabIndex = 58;
            this.btnExcluir.Text = "Excluir";
            this.toolDicas.SetToolTip(this.btnExcluir, "Excluir dados");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(70, 205);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 56;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Location = new System.Drawing.Point(66, 182);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 55;
            this.lblData.Text = "Data";
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(61, 66);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(583, 108);
            this.dgvDados.TabIndex = 54;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // txtAcao
            // 
            this.txtAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcao.Location = new System.Drawing.Point(375, 291);
            this.txtAcao.MaxLength = 250;
            this.txtAcao.Name = "txtAcao";
            this.txtAcao.ReadOnly = true;
            this.txtAcao.Size = new System.Drawing.Size(264, 53);
            this.txtAcao.TabIndex = 53;
            this.txtAcao.Text = "";
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAcao.Location = new System.Drawing.Point(371, 268);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(190, 20);
            this.lblAcao.TabIndex = 52;
            this.lblAcao.Text = "O que fez para melhorar *";
            // 
            // txtPensamento
            // 
            this.txtPensamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensamento.Location = new System.Drawing.Point(70, 284);
            this.txtPensamento.MaxLength = 250;
            this.txtPensamento.Name = "txtPensamento";
            this.txtPensamento.ReadOnly = true;
            this.txtPensamento.Size = new System.Drawing.Size(268, 63);
            this.txtPensamento.TabIndex = 51;
            this.txtPensamento.Text = "";
            // 
            // lblPensamento
            // 
            this.lblPensamento.AutoSize = true;
            this.lblPensamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensamento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPensamento.Location = new System.Drawing.Point(66, 261);
            this.lblPensamento.Name = "lblPensamento";
            this.lblPensamento.Size = new System.Drawing.Size(259, 20);
            this.lblPensamento.TabIndex = 50;
            this.lblPensamento.Text = "O que pensou em fazer a respeito *";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(375, 205);
            this.txtMotivo.MaxLength = 250;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(263, 60);
            this.txtMotivo.TabIndex = 49;
            this.txtMotivo.Text = "";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo.Location = new System.Drawing.Point(371, 182);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(250, 20);
            this.lblMotivo.TabIndex = 48;
            this.lblMotivo.Text = "Conte o motivo do seu desânimo *";
            // 
            // panAlert
            // 
            this.panAlert.BackColor = System.Drawing.Color.Pink;
            this.panAlert.Controls.Add(this.lblFecharAlert);
            this.panAlert.Controls.Add(this.lblWarningOne);
            this.panAlert.Location = new System.Drawing.Point(85, 31);
            this.panAlert.Name = "panAlert";
            this.panAlert.Size = new System.Drawing.Size(704, 36);
            this.panAlert.TabIndex = 57;
            // 
            // lblFecharAlert
            // 
            this.lblFecharAlert.AutoSize = true;
            this.lblFecharAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFecharAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharAlert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecharAlert.Location = new System.Drawing.Point(688, 0);
            this.lblFecharAlert.Name = "lblFecharAlert";
            this.lblFecharAlert.Size = new System.Drawing.Size(13, 15);
            this.lblFecharAlert.TabIndex = 2;
            this.lblFecharAlert.Text = "x";
            this.lblFecharAlert.Click += new System.EventHandler(this.lblFecharAlert_Click);
            // 
            // lblWarningOne
            // 
            this.lblWarningOne.AutoSize = true;
            this.lblWarningOne.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarningOne.Location = new System.Drawing.Point(42, 12);
            this.lblWarningOne.Name = "lblWarningOne";
            this.lblWarningOne.Size = new System.Drawing.Size(238, 13);
            this.lblWarningOne.TabIndex = 0;
            this.lblWarningOne.Text = "Atenção, estas ações não poderão ser desfeitas.";
            // 
            // FrmDesanimoDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panAlert);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDesanimoDeletar";
            this.Text = "Remover Desânimo";
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panAlert.ResumeLayout(false);
            this.panAlert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RichTextBox txtAcao;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.RichTextBox txtPensamento;
        private System.Windows.Forms.Label lblPensamento;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Panel panAlert;
        private System.Windows.Forms.Label lblFecharAlert;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}