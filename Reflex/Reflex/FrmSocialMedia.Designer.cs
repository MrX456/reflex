namespace Reflex
{
    partial class FrmSocialMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocialMedia));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panFundo = new System.Windows.Forms.Panel();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.picYoutube = new System.Windows.Forms.PictureBox();
            this.picInstagram = new System.Windows.Forms.PictureBox();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.picFacebook = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Siga a Quantum Comp nas redes sociais para mais novidades";
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panFundo.Controls.Add(this.picGitHub);
            this.panFundo.Controls.Add(this.picYoutube);
            this.panFundo.Controls.Add(this.picInstagram);
            this.panFundo.Controls.Add(this.picTwitter);
            this.panFundo.Controls.Add(this.picFacebook);
            this.panFundo.Controls.Add(this.lblTitle);
            this.panFundo.Location = new System.Drawing.Point(0, 41);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(385, 91);
            this.panFundo.TabIndex = 1;
            // 
            // picGitHub
            // 
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGitHub.Image = global::Reflex.Properties.Resources.github;
            this.picGitHub.Location = new System.Drawing.Point(239, 45);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(21, 19);
            this.picGitHub.TabIndex = 5;
            this.picGitHub.TabStop = false;
            this.toolDicas.SetToolTip(this.picGitHub, "Github");
            this.picGitHub.Click += new System.EventHandler(this.picGitHub_Click);
            // 
            // picYoutube
            // 
            this.picYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picYoutube.Image = global::Reflex.Properties.Resources.youtube;
            this.picYoutube.Location = new System.Drawing.Point(212, 45);
            this.picYoutube.Name = "picYoutube";
            this.picYoutube.Size = new System.Drawing.Size(21, 19);
            this.picYoutube.TabIndex = 4;
            this.picYoutube.TabStop = false;
            this.toolDicas.SetToolTip(this.picYoutube, "Youtube");
            this.picYoutube.Click += new System.EventHandler(this.picYoutube_Click);
            // 
            // picInstagram
            // 
            this.picInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInstagram.Image = global::Reflex.Properties.Resources.instagram;
            this.picInstagram.Location = new System.Drawing.Point(185, 45);
            this.picInstagram.Name = "picInstagram";
            this.picInstagram.Size = new System.Drawing.Size(21, 19);
            this.picInstagram.TabIndex = 3;
            this.picInstagram.TabStop = false;
            this.toolDicas.SetToolTip(this.picInstagram, "Instagram");
            this.picInstagram.Click += new System.EventHandler(this.picInstagram_Click);
            // 
            // picTwitter
            // 
            this.picTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTwitter.Image = global::Reflex.Properties.Resources.twitter;
            this.picTwitter.Location = new System.Drawing.Point(158, 45);
            this.picTwitter.Name = "picTwitter";
            this.picTwitter.Size = new System.Drawing.Size(21, 19);
            this.picTwitter.TabIndex = 2;
            this.picTwitter.TabStop = false;
            this.toolDicas.SetToolTip(this.picTwitter, "Twitter");
            this.picTwitter.Click += new System.EventHandler(this.picTwitter_Click);
            // 
            // picFacebook
            // 
            this.picFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacebook.Image = global::Reflex.Properties.Resources.facebook;
            this.picFacebook.Location = new System.Drawing.Point(131, 45);
            this.picFacebook.Name = "picFacebook";
            this.picFacebook.Size = new System.Drawing.Size(21, 19);
            this.picFacebook.TabIndex = 1;
            this.picFacebook.TabStop = false;
            this.toolDicas.SetToolTip(this.picFacebook, "Facebook");
            this.picFacebook.Click += new System.EventHandler(this.picFacebook_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(88, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(199, 13);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "Powered By Quantum Comp IT Solutions";
            // 
            // FrmSocialMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(384, 142);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.panFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSocialMedia";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quantum Comp  IT Solutions ";
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.PictureBox picFacebook;
        private System.Windows.Forms.PictureBox picGitHub;
        private System.Windows.Forms.PictureBox picYoutube;
        private System.Windows.Forms.PictureBox picInstagram;
        private System.Windows.Forms.PictureBox picTwitter;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.ToolTip toolDicas;

    }
}
