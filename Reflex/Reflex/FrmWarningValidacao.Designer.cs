﻿namespace Reflex
{
    partial class FrmWarningValidacao
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
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblMsgTwo = new System.Windows.Forms.Label();
            this.lblMsgOne = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFechar.Location = new System.Drawing.Point(269, 10);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(16, 18);
            this.lblFechar.TabIndex = 16;
            this.lblFechar.Text = "x";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // lblMsgTwo
            // 
            this.lblMsgTwo.AutoSize = true;
            this.lblMsgTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTwo.ForeColor = System.Drawing.Color.Gray;
            this.lblMsgTwo.Location = new System.Drawing.Point(75, 51);
            this.lblMsgTwo.Name = "lblMsgTwo";
            this.lblMsgTwo.Size = new System.Drawing.Size(57, 13);
            this.lblMsgTwo.TabIndex = 14;
            this.lblMsgTwo.Text = "Message";
            // 
            // lblMsgOne
            // 
            this.lblMsgOne.AutoSize = true;
            this.lblMsgOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgOne.ForeColor = System.Drawing.Color.Gray;
            this.lblMsgOne.Location = new System.Drawing.Point(75, 28);
            this.lblMsgOne.Name = "lblMsgOne";
            this.lblMsgOne.Size = new System.Drawing.Size(32, 13);
            this.lblMsgOne.TabIndex = 13;
            this.lblMsgOne.Text = "Title";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.ForeColor = System.Drawing.Color.Gray;
            this.btnOk.Location = new System.Drawing.Point(206, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btnOk_MouseLeave);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Reflex.Properties.Resources.close;
            this.picIcon.Location = new System.Drawing.Point(22, 28);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(39, 36);
            this.picIcon.TabIndex = 15;
            this.picIcon.TabStop = false;
            // 
            // FrmWarningValidacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(288, 114);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblMsgTwo);
            this.Controls.Add(this.lblMsgOne);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWarningValidacao";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Validação";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Label lblMsgTwo;
        public System.Windows.Forms.Label lblMsgOne;

    }
}
