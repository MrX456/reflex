namespace Cypher
{
    partial class FrmExcecao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtException = new System.Windows.Forms.RichTextBox();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.lblCopiar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEmail.Location = new System.Drawing.Point(18, 247);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "qci.suporte@gmail.com";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(18, 226);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(215, 13);
            this.lblText.TabIndex = 18;
            this.lblText.Text = "Se desejar envie esta amostra de erro para :";
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Image = global::Cypher.Properties.Resources.copy_to_clipboard;
            this.btnCopy.Location = new System.Drawing.Point(323, 217);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(68, 72);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeb.Image = global::Cypher.Properties.Resources.internet;
            this.btnWeb.Location = new System.Drawing.Point(250, 217);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(67, 72);
            this.btnWeb.TabIndex = 16;
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 16);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "O seguinte problema foi encontrado :";
            // 
            // txtException
            // 
            this.txtException.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtException.Location = new System.Drawing.Point(17, 59);
            this.txtException.Name = "txtException";
            this.txtException.ReadOnly = true;
            this.txtException.Size = new System.Drawing.Size(374, 152);
            this.txtException.TabIndex = 14;
            this.txtException.Text = "";
            // 
            // lblCopiar
            // 
            this.lblCopiar.AutoSize = true;
            this.lblCopiar.Location = new System.Drawing.Point(339, 293);
            this.lblCopiar.Name = "lblCopiar";
            this.lblCopiar.Size = new System.Drawing.Size(37, 13);
            this.lblCopiar.TabIndex = 20;
            this.lblCopiar.Text = "Copiar";
            // 
            // FrmExcecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(408, 315);
            this.Controls.Add(this.lblCopiar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtException);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExcecao";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Problema Encontrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtException;
        private System.Windows.Forms.ToolTip toolDicas;
        private System.Windows.Forms.Label lblCopiar;

    }
}
