﻿namespace Reflex
{
    partial class FrmWarningExcluirRegistro
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblMsgTwo = new System.Windows.Forms.Label();
            this.lblMsgOne = new System.Windows.Forms.Label();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFechar.Location = new System.Drawing.Point(251, 0);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(16, 18);
            this.lblFechar.TabIndex = 17;
            this.lblFechar.Text = "x";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Reflex.Properties.Resources.questionflat;
            this.picIcon.Location = new System.Drawing.Point(13, 27);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(36, 36);
            this.picIcon.TabIndex = 16;
            this.picIcon.TabStop = false;
            // 
            // lblMsgTwo
            // 
            this.lblMsgTwo.AutoSize = true;
            this.lblMsgTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTwo.ForeColor = System.Drawing.Color.Gray;
            this.lblMsgTwo.Location = new System.Drawing.Point(66, 50);
            this.lblMsgTwo.Name = "lblMsgTwo";
            this.lblMsgTwo.Size = new System.Drawing.Size(170, 13);
            this.lblMsgTwo.TabIndex = 15;
            this.lblMsgTwo.Text = "Deseja excluir estes dados ?";
            // 
            // lblMsgOne
            // 
            this.lblMsgOne.AutoSize = true;
            this.lblMsgOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgOne.ForeColor = System.Drawing.Color.Gray;
            this.lblMsgOne.Location = new System.Drawing.Point(66, 27);
            this.lblMsgOne.Name = "lblMsgOne";
            this.lblMsgOne.Size = new System.Drawing.Size(94, 13);
            this.lblMsgOne.TabIndex = 14;
            this.lblMsgOne.Text = "Excluir dados ?";
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNao.ForeColor = System.Drawing.Color.Gray;
            this.btnNao.Location = new System.Drawing.Point(195, 88);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(56, 23);
            this.btnNao.TabIndex = 13;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            this.btnNao.MouseEnter += new System.EventHandler(this.btnNao_MouseEnter);
            this.btnNao.MouseLeave += new System.EventHandler(this.btnNao_MouseLeave);
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSim.ForeColor = System.Drawing.Color.Gray;
            this.btnSim.Location = new System.Drawing.Point(133, 88);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(56, 23);
            this.btnSim.TabIndex = 12;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            this.btnSim.MouseEnter += new System.EventHandler(this.btnSim_MouseEnter);
            this.btnSim.MouseLeave += new System.EventHandler(this.btnSim_MouseLeave);
            // 
            // FrmWarningExcluirRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(269, 122);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblMsgTwo);
            this.Controls.Add(this.lblMsgOne);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWarningExcluirRegistro";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Excluir";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblMsgTwo;
        private System.Windows.Forms.Label lblMsgOne;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Button btnSim;

    }
}
