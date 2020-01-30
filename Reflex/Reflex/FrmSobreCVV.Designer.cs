namespace Reflex
{
    partial class FrmSobreCVV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobreCVV));
            this.btnFechar = new System.Windows.Forms.Button();
            this.panTexto = new System.Windows.Forms.Panel();
            this.lblLineFour = new System.Windows.Forms.Label();
            this.lblLineThree = new System.Windows.Forms.Label();
            this.lblLineTwo = new System.Windows.Forms.Label();
            this.lblLineOne = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(130, 142);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 30);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.toolDicas.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panTexto
            // 
            this.panTexto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panTexto.Controls.Add(this.lblLineFour);
            this.panTexto.Controls.Add(this.lblLineThree);
            this.panTexto.Controls.Add(this.lblLineTwo);
            this.panTexto.Controls.Add(this.lblLineOne);
            this.panTexto.Controls.Add(this.lblTitle);
            this.panTexto.Location = new System.Drawing.Point(12, 12);
            this.panTexto.Name = "panTexto";
            this.panTexto.Size = new System.Drawing.Size(324, 101);
            this.panTexto.TabIndex = 10;
            // 
            // lblLineFour
            // 
            this.lblLineFour.AutoSize = true;
            this.lblLineFour.Location = new System.Drawing.Point(-5, 73);
            this.lblLineFour.Name = "lblLineFour";
            this.lblLineFour.Size = new System.Drawing.Size(223, 13);
            this.lblLineFour.TabIndex = 4;
            this.lblLineFour.Text = " telefone, email e chat 24 horas todos os dias.";
            // 
            // lblLineThree
            // 
            this.lblLineThree.AutoSize = true;
            this.lblLineThree.Location = new System.Drawing.Point(-2, 60);
            this.lblLineThree.Name = "lblLineThree";
            this.lblLineThree.Size = new System.Drawing.Size(316, 13);
            this.lblLineThree.TabIndex = 3;
            this.lblLineThree.Text = "as pessoas que querem e precisam conversar, sob total sigilo por ";
            // 
            // lblLineTwo
            // 
            this.lblLineTwo.AutoSize = true;
            this.lblLineTwo.Location = new System.Drawing.Point(-2, 47);
            this.lblLineTwo.Name = "lblLineTwo";
            this.lblLineTwo.Size = new System.Drawing.Size(327, 13);
            this.lblLineTwo.TabIndex = 2;
            this.lblLineTwo.Text = "prevenção do suicídio, atendendo voluntária e gratuitamente todas ";
            // 
            // lblLineOne
            // 
            this.lblLineOne.AutoSize = true;
            this.lblLineOne.Location = new System.Drawing.Point(3, 34);
            this.lblLineOne.Name = "lblLineOne";
            this.lblLineOne.Size = new System.Drawing.Size(318, 13);
            this.lblLineOne.TabIndex = 1;
            this.lblLineOne.Text = "O CVV – Centro de Valorização da Vida realiza apoio emocional e ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(55, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Centro de Valorização da Vida";
            // 
            // FrmSobreCVV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(349, 184);
            this.Controls.Add(this.panTexto);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSobreCVV";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre o CVV";
            this.panTexto.ResumeLayout(false);
            this.panTexto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panTexto;
        private System.Windows.Forms.Label lblLineFour;
        private System.Windows.Forms.Label lblLineThree;
        private System.Windows.Forms.Label lblLineTwo;
        private System.Windows.Forms.Label lblLineOne;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolDicas;

    }
}
