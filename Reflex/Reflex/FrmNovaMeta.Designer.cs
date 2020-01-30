namespace Reflex
{
    partial class FrmNovaMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovaMeta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCharCount2 = new System.Windows.Forms.Label();
            this.lblCharCount1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtMotivoMeta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovaMeta = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblCharCount2);
            this.panel1.Controls.Add(this.lblCharCount1);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.txtMotivoMeta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNovaMeta);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Location = new System.Drawing.Point(146, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 401);
            this.panel1.TabIndex = 0;
            // 
            // lblCharCount2
            // 
            this.lblCharCount2.AutoSize = true;
            this.lblCharCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount2.Location = new System.Drawing.Point(391, 307);
            this.lblCharCount2.Name = "lblCharCount2";
            this.lblCharCount2.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount2.TabIndex = 22;
            this.lblCharCount2.Text = "max 250 chars";
            // 
            // lblCharCount1
            // 
            this.lblCharCount1.AutoSize = true;
            this.lblCharCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount1.Location = new System.Drawing.Point(391, 162);
            this.lblCharCount1.Name = "lblCharCount1";
            this.lblCharCount1.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount1.TabIndex = 21;
            this.lblCharCount1.Text = "max 250 chars";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(235, 340);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 28);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.toolDicas.SetToolTip(this.btnRegistrar, "Registrar dados");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtMotivoMeta
            // 
            this.txtMotivoMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoMeta.Location = new System.Drawing.Point(98, 205);
            this.txtMotivoMeta.MaxLength = 250;
            this.txtMotivoMeta.Name = "txtMotivoMeta";
            this.txtMotivoMeta.Size = new System.Drawing.Size(369, 99);
            this.txtMotivoMeta.TabIndex = 19;
            this.txtMotivoMeta.Text = "";
            this.txtMotivoMeta.TextChanged += new System.EventHandler(this.txtMotivoMeta_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(94, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Por que você estipulou esta meta ? *";
            // 
            // txtNovaMeta
            // 
            this.txtNovaMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaMeta.Location = new System.Drawing.Point(98, 60);
            this.txtNovaMeta.MaxLength = 250;
            this.txtNovaMeta.Name = "txtNovaMeta";
            this.txtNovaMeta.Size = new System.Drawing.Size(369, 99);
            this.txtNovaMeta.TabIndex = 17;
            this.txtNovaMeta.Text = "";
            this.txtNovaMeta.TextChanged += new System.EventHandler(this.txtNovaMeta_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDescricao.Location = new System.Drawing.Point(94, 37);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(224, 20);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Qual meta deseja adicionar ? *";
            // 
            // FrmNovaMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNovaMeta";
            this.Text = "Nova Meta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtNovaMeta;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox txtMotivoMeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCharCount2;
        private System.Windows.Forms.Label lblCharCount1;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}