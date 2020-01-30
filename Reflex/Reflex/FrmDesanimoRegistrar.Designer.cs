namespace Reflex
{
    partial class FrmDesanimoRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesanimoRegistrar));
            this.panFundo = new System.Windows.Forms.Panel();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblCharCount1 = new System.Windows.Forms.Label();
            this.lblCharCount2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtAcao = new System.Windows.Forms.RichTextBox();
            this.lblAcao = new System.Windows.Forms.Label();
            this.txtPensamento = new System.Windows.Forms.RichTextBox();
            this.lblPensamento = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.panFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.lblCharCount);
            this.panFundo.Controls.Add(this.lblCharCount1);
            this.panFundo.Controls.Add(this.lblCharCount2);
            this.panFundo.Controls.Add(this.btnRegistrar);
            this.panFundo.Controls.Add(this.txtAcao);
            this.panFundo.Controls.Add(this.lblAcao);
            this.panFundo.Controls.Add(this.txtPensamento);
            this.panFundo.Controls.Add(this.lblPensamento);
            this.panFundo.Controls.Add(this.txtMotivo);
            this.panFundo.Controls.Add(this.lblMotivo);
            this.panFundo.Location = new System.Drawing.Point(168, 47);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(553, 403);
            this.panFundo.TabIndex = 0;
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount.Location = new System.Drawing.Point(380, 111);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount.TabIndex = 25;
            this.lblCharCount.Text = "max 250 chars";
            // 
            // lblCharCount1
            // 
            this.lblCharCount1.AutoSize = true;
            this.lblCharCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount1.Location = new System.Drawing.Point(380, 214);
            this.lblCharCount1.Name = "lblCharCount1";
            this.lblCharCount1.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount1.TabIndex = 24;
            this.lblCharCount1.Text = "max 250 chars";
            // 
            // lblCharCount2
            // 
            this.lblCharCount2.AutoSize = true;
            this.lblCharCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount2.Location = new System.Drawing.Point(380, 313);
            this.lblCharCount2.Name = "lblCharCount2";
            this.lblCharCount2.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount2.TabIndex = 23;
            this.lblCharCount2.Text = "max 250 chars";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(235, 349);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 28);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar dados";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtAcao
            // 
            this.txtAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcao.Location = new System.Drawing.Point(109, 250);
            this.txtAcao.MaxLength = 250;
            this.txtAcao.Name = "txtAcao";
            this.txtAcao.Size = new System.Drawing.Size(347, 60);
            this.txtAcao.TabIndex = 20;
            this.txtAcao.Text = "";
            this.txtAcao.TextChanged += new System.EventHandler(this.txtAcao_TextChanged);
            this.txtAcao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAcao_KeyUp);
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAcao.Location = new System.Drawing.Point(105, 227);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(190, 20);
            this.lblAcao.TabIndex = 19;
            this.lblAcao.Text = "O que fez para melhorar *";
            // 
            // txtPensamento
            // 
            this.txtPensamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensamento.Location = new System.Drawing.Point(109, 148);
            this.txtPensamento.MaxLength = 250;
            this.txtPensamento.Name = "txtPensamento";
            this.txtPensamento.Size = new System.Drawing.Size(347, 63);
            this.txtPensamento.TabIndex = 18;
            this.txtPensamento.Text = "";
            this.txtPensamento.TextChanged += new System.EventHandler(this.txtPensamento_TextChanged);
            this.txtPensamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPensamento_KeyUp);
            // 
            // lblPensamento
            // 
            this.lblPensamento.AutoSize = true;
            this.lblPensamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensamento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPensamento.Location = new System.Drawing.Point(105, 125);
            this.lblPensamento.Name = "lblPensamento";
            this.lblPensamento.Size = new System.Drawing.Size(259, 20);
            this.lblPensamento.TabIndex = 17;
            this.lblPensamento.Text = "O que pensou em fazer a respeito *";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(109, 48);
            this.txtMotivo.MaxLength = 250;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(347, 60);
            this.txtMotivo.TabIndex = 16;
            this.txtMotivo.Text = "";
            this.txtMotivo.TextChanged += new System.EventHandler(this.txtMotivo_TextChanged);
            this.txtMotivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMotivo_KeyUp);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo.Location = new System.Drawing.Point(105, 25);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(250, 20);
            this.lblMotivo.TabIndex = 13;
            this.lblMotivo.Text = "Conte o motivo do seu desânimo *";
            // 
            // FrmDesanimoRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDesanimoRegistrar";
            this.Text = "Registrar Desânimo";
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.RichTextBox txtAcao;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.RichTextBox txtPensamento;
        private System.Windows.Forms.Label lblPensamento;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblCharCount1;
        private System.Windows.Forms.Label lblCharCount2;
    }
}