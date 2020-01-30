namespace Reflex
{
    partial class FrmLicencaGPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicencaGPL));
            this.panFundo = new System.Windows.Forms.Panel();
            this.txtLicenca = new System.Windows.Forms.RichTextBox();
            this.panFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.txtLicenca);
            this.panFundo.Location = new System.Drawing.Point(13, 13);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(343, 315);
            this.panFundo.TabIndex = 0;
            // 
            // txtLicenca
            // 
            this.txtLicenca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLicenca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLicenca.Location = new System.Drawing.Point(0, 0);
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.ReadOnly = true;
            this.txtLicenca.Size = new System.Drawing.Size(343, 315);
            this.txtLicenca.TabIndex = 0;
            this.txtLicenca.Text = "";
            // 
            // FrmLicencaGPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(368, 340);
            this.Controls.Add(this.panFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLicencaGPL";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Licença GPL3";
            this.panFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.RichTextBox txtLicenca;

    }
}
