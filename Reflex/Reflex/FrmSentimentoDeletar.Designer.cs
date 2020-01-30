namespace Reflex
{
    partial class FrmSentimentoDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSentimentoDeletar));
            this.panFundo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResumoDia = new System.Windows.Forms.RichTextBox();
            this.txtSentimento = new System.Windows.Forms.TextBox();
            this.lblSentimento = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.panAlert = new System.Windows.Forms.Panel();
            this.lblFecharAlert = new System.Windows.Forms.Label();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.label1);
            this.panFundo.Controls.Add(this.txtResumoDia);
            this.panFundo.Controls.Add(this.txtSentimento);
            this.panFundo.Controls.Add(this.lblSentimento);
            this.panFundo.Controls.Add(this.txtData);
            this.panFundo.Controls.Add(this.lblData);
            this.panFundo.Controls.Add(this.dgvDados);
            this.panFundo.Controls.Add(this.panAlert);
            this.panFundo.Controls.Add(this.btnExcluir);
            this.panFundo.Location = new System.Drawing.Point(154, 43);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(576, 394);
            this.panFundo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(97, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Resumo do Dia";
            // 
            // txtResumoDia
            // 
            this.txtResumoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumoDia.Location = new System.Drawing.Point(101, 274);
            this.txtResumoDia.Name = "txtResumoDia";
            this.txtResumoDia.ReadOnly = true;
            this.txtResumoDia.Size = new System.Drawing.Size(369, 69);
            this.txtResumoDia.TabIndex = 45;
            this.txtResumoDia.Text = "";
            // 
            // txtSentimento
            // 
            this.txtSentimento.BackColor = System.Drawing.SystemColors.Control;
            this.txtSentimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSentimento.Location = new System.Drawing.Point(345, 220);
            this.txtSentimento.Name = "txtSentimento";
            this.txtSentimento.ReadOnly = true;
            this.txtSentimento.Size = new System.Drawing.Size(179, 26);
            this.txtSentimento.TabIndex = 44;
            // 
            // lblSentimento
            // 
            this.lblSentimento.AutoSize = true;
            this.lblSentimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentimento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSentimento.Location = new System.Drawing.Point(341, 197);
            this.lblSentimento.Name = "lblSentimento";
            this.lblSentimento.Size = new System.Drawing.Size(91, 20);
            this.lblSentimento.TabIndex = 43;
            this.lblSentimento.Text = "Sentimento";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(45, 220);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 42;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Location = new System.Drawing.Point(41, 197);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 41;
            this.lblData.Text = "Data";
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(35, 51);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(504, 143);
            this.dgvDados.TabIndex = 40;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // panAlert
            // 
            this.panAlert.BackColor = System.Drawing.Color.Pink;
            this.panAlert.Controls.Add(this.lblFecharAlert);
            this.panAlert.Controls.Add(this.lblWarningOne);
            this.panAlert.Location = new System.Drawing.Point(0, 0);
            this.panAlert.Name = "panAlert";
            this.panAlert.Size = new System.Drawing.Size(576, 36);
            this.panAlert.TabIndex = 39;
            // 
            // lblFecharAlert
            // 
            this.lblFecharAlert.AutoSize = true;
            this.lblFecharAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFecharAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharAlert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecharAlert.Location = new System.Drawing.Point(560, 0);
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
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(235, 349);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 28);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.toolDicas.SetToolTip(this.btnExcluir, "Excluir dados");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmSentimentoDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSentimentoDeletar";
            this.Text = "Remover Registro Humor";
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panAlert.ResumeLayout(false);
            this.panAlert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panAlert;
        private System.Windows.Forms.Label lblFecharAlert;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtSentimento;
        private System.Windows.Forms.Label lblSentimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResumoDia;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}