namespace Reflex
{
    partial class FrmSentimentoRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSentimentoRegistros));
            this.panFundo = new System.Windows.Forms.Panel();
            this.panGuias = new System.Windows.Forms.TabControl();
            this.tabTodos = new System.Windows.Forms.TabPage();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tabSentimento = new System.Windows.Forms.TabPage();
            this.btnPesquisarSentimento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResumoDia = new System.Windows.Forms.RichTextBox();
            this.cboSentimento = new System.Windows.Forms.ComboBox();
            this.lblSentimento = new System.Windows.Forms.Label();
            this.btnExportar2 = new System.Windows.Forms.Button();
            this.dgvDados2 = new System.Windows.Forms.DataGridView();
            this.tabDataRegistro = new System.Windows.Forms.TabPage();
            this.btnPesquisarData = new System.Windows.Forms.Button();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResumoDia2 = new System.Windows.Forms.RichTextBox();
            this.btnExportar3 = new System.Windows.Forms.Button();
            this.dgvDados3 = new System.Windows.Forms.DataGridView();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            this.panGuias.SuspendLayout();
            this.tabTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tabSentimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).BeginInit();
            this.tabDataRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados3)).BeginInit();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.panGuias);
            this.panFundo.Location = new System.Drawing.Point(145, 44);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(578, 394);
            this.panFundo.TabIndex = 0;
            // 
            // panGuias
            // 
            this.panGuias.Controls.Add(this.tabTodos);
            this.panGuias.Controls.Add(this.tabSentimento);
            this.panGuias.Controls.Add(this.tabDataRegistro);
            this.panGuias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGuias.Location = new System.Drawing.Point(0, 0);
            this.panGuias.Name = "panGuias";
            this.panGuias.SelectedIndex = 0;
            this.panGuias.Size = new System.Drawing.Size(578, 394);
            this.panGuias.TabIndex = 0;
            // 
            // tabTodos
            // 
            this.tabTodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabTodos.Controls.Add(this.btnExportar);
            this.tabTodos.Controls.Add(this.dgvDados);
            this.tabTodos.Location = new System.Drawing.Point(4, 22);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodos.Size = new System.Drawing.Size(570, 368);
            this.tabTodos.TabIndex = 0;
            this.tabTodos.Text = "Todos Registros";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar.Location = new System.Drawing.Point(212, 316);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 30);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar, "Exportar dados para planilha");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(33, 34);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(504, 257);
            this.dgvDados.TabIndex = 0;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            // 
            // tabSentimento
            // 
            this.tabSentimento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabSentimento.Controls.Add(this.btnPesquisarSentimento);
            this.tabSentimento.Controls.Add(this.label1);
            this.tabSentimento.Controls.Add(this.txtResumoDia);
            this.tabSentimento.Controls.Add(this.cboSentimento);
            this.tabSentimento.Controls.Add(this.lblSentimento);
            this.tabSentimento.Controls.Add(this.btnExportar2);
            this.tabSentimento.Controls.Add(this.dgvDados2);
            this.tabSentimento.Location = new System.Drawing.Point(4, 22);
            this.tabSentimento.Name = "tabSentimento";
            this.tabSentimento.Padding = new System.Windows.Forms.Padding(3);
            this.tabSentimento.Size = new System.Drawing.Size(570, 368);
            this.tabSentimento.TabIndex = 1;
            this.tabSentimento.Text = "Como você se sentiu";
            // 
            // btnPesquisarSentimento
            // 
            this.btnPesquisarSentimento.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPesquisarSentimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarSentimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarSentimento.Location = new System.Drawing.Point(212, 48);
            this.btnPesquisarSentimento.Name = "btnPesquisarSentimento";
            this.btnPesquisarSentimento.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarSentimento.TabIndex = 18;
            this.btnPesquisarSentimento.Text = "Pesquisar";
            this.btnPesquisarSentimento.UseVisualStyleBackColor = false;
            this.btnPesquisarSentimento.Click += new System.EventHandler(this.btnPesquisarSentimento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(101, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Resumo do Dia";
            // 
            // txtResumoDia
            // 
            this.txtResumoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumoDia.Location = new System.Drawing.Point(105, 220);
            this.txtResumoDia.Name = "txtResumoDia";
            this.txtResumoDia.ReadOnly = true;
            this.txtResumoDia.Size = new System.Drawing.Size(369, 84);
            this.txtResumoDia.TabIndex = 16;
            this.txtResumoDia.Text = "";
            // 
            // cboSentimento
            // 
            this.cboSentimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSentimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSentimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSentimento.FormattingEnabled = true;
            this.cboSentimento.Items.AddRange(new object[] {
            "Feliz",
            "Motivado",
            "Irritado",
            "Desanimado",
            "Triste",
            "Outro"});
            this.cboSentimento.Location = new System.Drawing.Point(33, 44);
            this.cboSentimento.Name = "cboSentimento";
            this.cboSentimento.Size = new System.Drawing.Size(158, 28);
            this.cboSentimento.TabIndex = 15;
            // 
            // lblSentimento
            // 
            this.lblSentimento.AutoSize = true;
            this.lblSentimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentimento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSentimento.Location = new System.Drawing.Point(29, 11);
            this.lblSentimento.Name = "lblSentimento";
            this.lblSentimento.Size = new System.Drawing.Size(158, 20);
            this.lblSentimento.TabIndex = 14;
            this.lblSentimento.Text = "Como você sentiu ? *";
            // 
            // btnExportar2
            // 
            this.btnExportar2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar2.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar2.Location = new System.Drawing.Point(212, 310);
            this.btnExportar2.Name = "btnExportar2";
            this.btnExportar2.Size = new System.Drawing.Size(150, 30);
            this.btnExportar2.TabIndex = 3;
            this.btnExportar2.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar2, "Exportar dados para planilha");
            this.btnExportar2.UseVisualStyleBackColor = false;
            this.btnExportar2.Click += new System.EventHandler(this.btnExportar2_Click);
            // 
            // dgvDados2
            // 
            this.dgvDados2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados2.Location = new System.Drawing.Point(33, 90);
            this.dgvDados2.Name = "dgvDados2";
            this.dgvDados2.Size = new System.Drawing.Size(504, 93);
            this.dgvDados2.TabIndex = 2;
            this.toolDicas.SetToolTip(this.dgvDados2, "Clique sobre um registro para ver detalhes");
            this.dgvDados2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados2_CellClick);
            // 
            // tabDataRegistro
            // 
            this.tabDataRegistro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabDataRegistro.Controls.Add(this.btnPesquisarData);
            this.tabDataRegistro.Controls.Add(this.lblDataNasc);
            this.tabDataRegistro.Controls.Add(this.txtDataRegistro);
            this.tabDataRegistro.Controls.Add(this.label2);
            this.tabDataRegistro.Controls.Add(this.txtResumoDia2);
            this.tabDataRegistro.Controls.Add(this.btnExportar3);
            this.tabDataRegistro.Controls.Add(this.dgvDados3);
            this.tabDataRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabDataRegistro.Name = "tabDataRegistro";
            this.tabDataRegistro.Size = new System.Drawing.Size(570, 368);
            this.tabDataRegistro.TabIndex = 2;
            this.tabDataRegistro.Text = "Data";
            // 
            // btnPesquisarData
            // 
            this.btnPesquisarData.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPesquisarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarData.Location = new System.Drawing.Point(145, 43);
            this.btnPesquisarData.Name = "btnPesquisarData";
            this.btnPesquisarData.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarData.TabIndex = 24;
            this.btnPesquisarData.Text = "Pesquisar";
            this.toolDicas.SetToolTip(this.btnPesquisarData, "Realizar pesquisa");
            this.btnPesquisarData.UseVisualStyleBackColor = false;
            this.btnPesquisarData.Click += new System.EventHandler(this.btnPesquisarData_Click);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDataNasc.Location = new System.Drawing.Point(30, 17);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(54, 20);
            this.lblDataNasc.TabIndex = 23;
            this.lblDataNasc.Text = "Data *";
            // 
            // txtDataRegistro
            // 
            this.txtDataRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRegistro.Location = new System.Drawing.Point(34, 40);
            this.txtDataRegistro.Mask = "##/##/####";
            this.txtDataRegistro.Name = "txtDataRegistro";
            this.txtDataRegistro.Size = new System.Drawing.Size(100, 26);
            this.txtDataRegistro.TabIndex = 22;
            this.toolDicas.SetToolTip(this.txtDataRegistro, "Digite uma data");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(101, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Resumo do Dia";
            // 
            // txtResumoDia2
            // 
            this.txtResumoDia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumoDia2.Location = new System.Drawing.Point(105, 229);
            this.txtResumoDia2.Name = "txtResumoDia2";
            this.txtResumoDia2.ReadOnly = true;
            this.txtResumoDia2.Size = new System.Drawing.Size(369, 84);
            this.txtResumoDia2.TabIndex = 20;
            this.txtResumoDia2.Text = "";
            // 
            // btnExportar3
            // 
            this.btnExportar3.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar3.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar3.Location = new System.Drawing.Point(212, 319);
            this.btnExportar3.Name = "btnExportar3";
            this.btnExportar3.Size = new System.Drawing.Size(150, 30);
            this.btnExportar3.TabIndex = 19;
            this.btnExportar3.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar3, "Exportar dados para planilha");
            this.btnExportar3.UseVisualStyleBackColor = false;
            this.btnExportar3.Click += new System.EventHandler(this.btnExportar3_Click);
            // 
            // dgvDados3
            // 
            this.dgvDados3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados3.Location = new System.Drawing.Point(34, 72);
            this.dgvDados3.Name = "dgvDados3";
            this.dgvDados3.Size = new System.Drawing.Size(504, 131);
            this.dgvDados3.TabIndex = 18;
            this.toolDicas.SetToolTip(this.dgvDados3, "Clique sobre um registro para ver detalhes");
            this.dgvDados3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados3_CellClick);
            // 
            // FrmSentimentoRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSentimentoRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Humor Registros";
            this.Load += new System.EventHandler(this.FrmSentimentoRegistros_Load);
            this.panFundo.ResumeLayout(false);
            this.panGuias.ResumeLayout(false);
            this.tabTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tabSentimento.ResumeLayout(false);
            this.tabSentimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).EndInit();
            this.tabDataRegistro.ResumeLayout(false);
            this.tabDataRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.TabControl panGuias;
        private System.Windows.Forms.TabPage tabTodos;
        private System.Windows.Forms.TabPage tabSentimento;
        private System.Windows.Forms.TabPage tabDataRegistro;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolTip toolDicas;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnExportar2;
        private System.Windows.Forms.DataGridView dgvDados2;
        private System.Windows.Forms.ComboBox cboSentimento;
        private System.Windows.Forms.Label lblSentimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResumoDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtResumoDia2;
        private System.Windows.Forms.Button btnExportar3;
        private System.Windows.Forms.DataGridView dgvDados3;
        private System.Windows.Forms.Button btnPesquisarSentimento;
        private System.Windows.Forms.Button btnPesquisarData;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataRegistro;
    }
}