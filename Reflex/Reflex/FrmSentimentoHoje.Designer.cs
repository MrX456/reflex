namespace Reflex
{
    partial class FrmSentimentoHoje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSentimentoHoje));
            this.panFundo = new System.Windows.Forms.Panel();
            this.lblCharCount1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtResumoDia = new System.Windows.Forms.RichTextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.cboSentimento = new System.Windows.Forms.ComboBox();
            this.lblSentimento = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.lblCharCount1);
            this.panFundo.Controls.Add(this.btnRegistrar);
            this.panFundo.Controls.Add(this.txtResumoDia);
            this.panFundo.Controls.Add(this.lblDia);
            this.panFundo.Controls.Add(this.cboSentimento);
            this.panFundo.Controls.Add(this.lblSentimento);
            this.panFundo.Location = new System.Drawing.Point(218, 45);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(456, 394);
            this.panFundo.TabIndex = 0;
            // 
            // lblCharCount1
            // 
            this.lblCharCount1.AutoSize = true;
            this.lblCharCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount1.Location = new System.Drawing.Point(335, 310);
            this.lblCharCount1.Name = "lblCharCount1";
            this.lblCharCount1.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount1.TabIndex = 22;
            this.lblCharCount1.Text = "max 250 chars";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(177, 328);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 28);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.toolDicas.SetToolTip(this.btnRegistrar, "Registrar dados");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtResumoDia
            // 
            this.txtResumoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumoDia.Location = new System.Drawing.Point(42, 164);
            this.txtResumoDia.MaxLength = 250;
            this.txtResumoDia.Name = "txtResumoDia";
            this.txtResumoDia.Size = new System.Drawing.Size(369, 143);
            this.txtResumoDia.TabIndex = 15;
            this.txtResumoDia.Text = "";
            this.txtResumoDia.TextChanged += new System.EventHandler(this.txtResumoDia_TextChanged);
            this.txtResumoDia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtResumoDia_KeyUp);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDia.Location = new System.Drawing.Point(38, 141);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(150, 20);
            this.lblDia.TabIndex = 14;
            this.lblDia.Text = "Como foi seu dia ? *";
            // 
            // cboSentimento
            // 
            this.cboSentimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSentimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSentimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSentimento.FormattingEnabled = true;
            this.cboSentimento.Items.AddRange(new object[] {
            "Feliz",
            "Motivado",
            "Irritado",
            "Desanimado",
            "Triste",
            "Outro"});
            this.cboSentimento.Location = new System.Drawing.Point(42, 73);
            this.cboSentimento.Name = "cboSentimento";
            this.cboSentimento.Size = new System.Drawing.Size(158, 28);
            this.cboSentimento.TabIndex = 13;
            // 
            // lblSentimento
            // 
            this.lblSentimento.AutoSize = true;
            this.lblSentimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentimento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSentimento.Location = new System.Drawing.Point(38, 35);
            this.lblSentimento.Name = "lblSentimento";
            this.lblSentimento.Size = new System.Drawing.Size(221, 20);
            this.lblSentimento.TabIndex = 12;
            this.lblSentimento.Text = "Como você se sente agora ? *";
            // 
            // FrmSentimentoHoje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSentimentoHoje";
            this.Text = "Como você se sente hoje ?";
            this.Load += new System.EventHandler(this.FrmSentimentoHoje_Load);
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.Label lblSentimento;
        private System.Windows.Forms.ComboBox cboSentimento;
        private System.Windows.Forms.RichTextBox txtResumoDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCharCount1;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}