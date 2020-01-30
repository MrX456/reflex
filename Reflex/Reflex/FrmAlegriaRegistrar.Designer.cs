namespace Reflex
{
    partial class FrmAlegriaRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlegriaRegistrar));
            this.panFundo = new System.Windows.Forms.Panel();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.lblCharCount);
            this.panFundo.Controls.Add(this.btnRegistrar);
            this.panFundo.Controls.Add(this.txtDescricao);
            this.panFundo.Controls.Add(this.lblDescricao);
            this.panFundo.Location = new System.Drawing.Point(165, 47);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(553, 403);
            this.panFundo.TabIndex = 1;
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount.Location = new System.Drawing.Point(380, 277);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount.TabIndex = 25;
            this.lblCharCount.Text = "max 250 chars";
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
            this.btnRegistrar.Text = "Registrar";
            this.toolDicas.SetToolTip(this.btnRegistrar, "Registrar dados");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(109, 91);
            this.txtDescricao.MaxLength = 250;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(347, 183);
            this.txtDescricao.TabIndex = 16;
            this.txtDescricao.Text = "";
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtMotivo_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDescricao.Location = new System.Drawing.Point(105, 56);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(252, 20);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descreva o motivo de sua alegria *";
            // 
            // FrmAlegriaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlegriaRegistrar";
            this.Text = "Registrar Alegria";
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}