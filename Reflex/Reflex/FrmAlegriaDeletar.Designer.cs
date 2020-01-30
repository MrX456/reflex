namespace Reflex
{
    partial class FrmAlegriaDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlegriaDeletar));
            this.panFundo = new System.Windows.Forms.Panel();
            this.panAlert = new System.Windows.Forms.Panel();
            this.lblFecharAlert = new System.Windows.Forms.Label();
            this.lblWarningOne = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
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
            this.panFundo.Controls.Add(this.dgvDados);
            this.panFundo.Controls.Add(this.lblData);
            this.panFundo.Controls.Add(this.lblDescricao);
            this.panFundo.Controls.Add(this.txtMotivo);
            this.panFundo.Location = new System.Drawing.Point(165, 47);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(553, 403);
            this.panFundo.TabIndex = 2;
            // 
            // panAlert
            // 
            this.panAlert.BackColor = System.Drawing.Color.Pink;
            this.panAlert.Controls.Add(this.lblFecharAlert);
            this.panAlert.Controls.Add(this.lblWarningOne);
            this.panAlert.Location = new System.Drawing.Point(0, 0);
            this.panAlert.Name = "panAlert";
            this.panAlert.Size = new System.Drawing.Size(553, 36);
            this.panAlert.TabIndex = 62;
            // 
            // lblFecharAlert
            // 
            this.lblFecharAlert.AutoSize = true;
            this.lblFecharAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFecharAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharAlert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecharAlert.Location = new System.Drawing.Point(537, 0);
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
            this.btnExcluir.Location = new System.Drawing.Point(227, 358);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 28);
            this.btnExcluir.TabIndex = 61;
            this.btnExcluir.Text = "Excluir";
            this.toolDicas.SetToolTip(this.btnExcluir, "Excluir dados");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(106, 190);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 60;
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(76, 47);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(400, 108);
            this.dgvDados.TabIndex = 58;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Location = new System.Drawing.Point(102, 167);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 59;
            this.lblData.Text = "Data";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDescricao.Location = new System.Drawing.Point(102, 233);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(128, 20);
            this.lblDescricao.TabIndex = 56;
            this.lblDescricao.Text = "Motivo da alegria";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(106, 266);
            this.txtMotivo.MaxLength = 250;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(347, 76);
            this.txtMotivo.TabIndex = 57;
            this.txtMotivo.Text = "";
            // 
            // FrmAlegriaDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlegriaDeletar";
            this.Text = "Remover Alegria";
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
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panAlert;
        private System.Windows.Forms.Label lblFecharAlert;
        private System.Windows.Forms.Label lblWarningOne;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}