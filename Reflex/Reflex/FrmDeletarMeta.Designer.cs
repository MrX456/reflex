namespace Reflex
{
    partial class FrmDeletarMeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeletarMeta));
            this.panFundo = new System.Windows.Forms.Panel();
            this.panAlert = new System.Windows.Forms.Panel();
            this.lblFecharAlert = new System.Windows.Forms.Label();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblRealizacao = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMeta = new System.Windows.Forms.RichTextBox();
            this.lblMeta = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            this.panAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.panAlert);
            this.panFundo.Controls.Add(this.btnExcluir);
            this.panFundo.Controls.Add(this.txtData);
            this.panFundo.Controls.Add(this.lblData);
            this.panFundo.Controls.Add(this.txtStatus);
            this.panFundo.Controls.Add(this.lblRealizacao);
            this.panFundo.Controls.Add(this.txtMotivo);
            this.panFundo.Controls.Add(this.lblMotivo);
            this.panFundo.Controls.Add(this.txtMeta);
            this.panFundo.Controls.Add(this.lblMeta);
            this.panFundo.Controls.Add(this.dgvDados);
            this.panFundo.Location = new System.Drawing.Point(109, 64);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(652, 375);
            this.panFundo.TabIndex = 0;
            // 
            // panAlert
            // 
            this.panAlert.BackColor = System.Drawing.Color.Pink;
            this.panAlert.Controls.Add(this.lblFecharAlert);
            this.panAlert.Controls.Add(this.lblWarningOne);
            this.panAlert.Location = new System.Drawing.Point(0, 0);
            this.panAlert.Name = "panAlert";
            this.panAlert.Size = new System.Drawing.Size(652, 36);
            this.panAlert.TabIndex = 38;
            // 
            // lblFecharAlert
            // 
            this.lblFecharAlert.AutoSize = true;
            this.lblFecharAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFecharAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharAlert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecharAlert.Location = new System.Drawing.Point(636, 0);
            this.lblFecharAlert.Name = "lblFecharAlert";
            this.lblFecharAlert.Size = new System.Drawing.Size(13, 15);
            this.lblFecharAlert.TabIndex = 2;
            this.lblFecharAlert.Text = "x";
            this.lblFecharAlert.Click += new System.EventHandler(this.lblFecharAlert_Click);
            // 
            // lblWarningOne
            // 
            this.lblWarningOne.AutoSize = true;
            this.lblWarningOne.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarningOne.Location = new System.Drawing.Point(42, 12);
            this.lblWarningOne.Name = "lblWarningOne";
            this.lblWarningOne.Size = new System.Drawing.Size(238, 13);
            this.lblWarningOne.TabIndex = 0;
            this.lblWarningOne.Text = "Atenção, estas ações não poderão ser desfeitas.";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(261, 331);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 30);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir meta";
            this.toolDicas.SetToolTip(this.btnExcluir, "Excluir dados");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(35, 304);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 36;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Location = new System.Drawing.Point(31, 281);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 35;
            this.lblData.Text = "Data";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(467, 304);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(151, 26);
            this.txtStatus.TabIndex = 34;
            // 
            // lblRealizacao
            // 
            this.lblRealizacao.AutoSize = true;
            this.lblRealizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizacao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRealizacao.Location = new System.Drawing.Point(463, 281);
            this.lblRealizacao.Name = "lblRealizacao";
            this.lblRealizacao.Size = new System.Drawing.Size(96, 20);
            this.lblRealizacao.TabIndex = 33;
            this.lblRealizacao.Text = "Status meta";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(350, 205);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(268, 64);
            this.txtMotivo.TabIndex = 32;
            this.txtMotivo.Text = "";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo.Location = new System.Drawing.Point(346, 182);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(55, 20);
            this.lblMotivo.TabIndex = 31;
            this.lblMotivo.Text = "Motivo";
            // 
            // txtMeta
            // 
            this.txtMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeta.Location = new System.Drawing.Point(35, 205);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.ReadOnly = true;
            this.txtMeta.Size = new System.Drawing.Size(268, 64);
            this.txtMeta.TabIndex = 30;
            this.txtMeta.Text = "";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMeta.Location = new System.Drawing.Point(31, 182);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(139, 20);
            this.lblMeta.TabIndex = 29;
            this.lblMeta.Text = "Meta estabelecida";
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(35, 66);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(583, 110);
            this.dgvDados.TabIndex = 28;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // FrmDeletarMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDeletarMeta";
            this.Text = "Remover Meta";
            this.panFundo.ResumeLayout(false);
            this.panFundo.PerformLayout();
            this.panAlert.ResumeLayout(false);
            this.panAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblRealizacao;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.RichTextBox txtMeta;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panAlert;
        private System.Windows.Forms.Label lblFecharAlert;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}