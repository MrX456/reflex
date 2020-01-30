namespace Reflex
{
    partial class FrmDesanimoRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesanimoRegistros));
            this.panFundo = new System.Windows.Forms.Panel();
            this.panGuias = new System.Windows.Forms.TabControl();
            this.tabTodos = new System.Windows.Forms.TabPage();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.txtAcao = new System.Windows.Forms.RichTextBox();
            this.lblAcao = new System.Windows.Forms.Label();
            this.txtPensamento = new System.Windows.Forms.RichTextBox();
            this.lblPensamento = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.btnExportar2 = new System.Windows.Forms.Button();
            this.btnAtualizar2 = new System.Windows.Forms.Button();
            this.btnPesquisarData = new System.Windows.Forms.Button();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados2 = new System.Windows.Forms.DataGridView();
            this.lblCharCount2 = new System.Windows.Forms.Label();
            this.txtAcao2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPensamento2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotivo2 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            this.panGuias.SuspendLayout();
            this.tabTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).BeginInit();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.panGuias);
            this.panFundo.Location = new System.Drawing.Point(86, 22);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(704, 428);
            this.panFundo.TabIndex = 0;
            // 
            // panGuias
            // 
            this.panGuias.Controls.Add(this.tabTodos);
            this.panGuias.Controls.Add(this.tabData);
            this.panGuias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGuias.Location = new System.Drawing.Point(0, 0);
            this.panGuias.Name = "panGuias";
            this.panGuias.SelectedIndex = 0;
            this.panGuias.Size = new System.Drawing.Size(704, 428);
            this.panGuias.TabIndex = 0;
            // 
            // tabTodos
            // 
            this.tabTodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabTodos.Controls.Add(this.btnExportar);
            this.tabTodos.Controls.Add(this.btnAtualizar);
            this.tabTodos.Controls.Add(this.txtData);
            this.tabTodos.Controls.Add(this.lblData);
            this.tabTodos.Controls.Add(this.dgvDados);
            this.tabTodos.Controls.Add(this.lblCharCount);
            this.tabTodos.Controls.Add(this.txtAcao);
            this.tabTodos.Controls.Add(this.lblAcao);
            this.tabTodos.Controls.Add(this.txtPensamento);
            this.tabTodos.Controls.Add(this.lblPensamento);
            this.tabTodos.Controls.Add(this.txtMotivo);
            this.tabTodos.Controls.Add(this.lblMotivo);
            this.tabTodos.Location = new System.Drawing.Point(4, 22);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodos.Size = new System.Drawing.Size(696, 402);
            this.tabTodos.TabIndex = 0;
            this.tabTodos.Text = "Todos";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar.Location = new System.Drawing.Point(275, 366);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 30);
            this.btnExportar.TabIndex = 48;
            this.btnExportar.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar, "Exportar dados");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(362, 321);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(105, 28);
            this.btnAtualizar.TabIndex = 26;
            this.btnAtualizar.Text = "Atualizar";
            this.toolDicas.SetToolTip(this.btnAtualizar, "Atualizar dados");
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(57, 160);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 47;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Location = new System.Drawing.Point(53, 137);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 46;
            this.lblData.Text = "Data";
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(48, 21);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(583, 108);
            this.dgvDados.TabIndex = 45;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount.Location = new System.Drawing.Point(550, 321);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount.TabIndex = 42;
            this.lblCharCount.Text = "max 250 chars";
            // 
            // txtAcao
            // 
            this.txtAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcao.Location = new System.Drawing.Point(362, 265);
            this.txtAcao.MaxLength = 250;
            this.txtAcao.Name = "txtAcao";
            this.txtAcao.Size = new System.Drawing.Size(264, 53);
            this.txtAcao.TabIndex = 41;
            this.txtAcao.Text = "";
            this.txtAcao.TextChanged += new System.EventHandler(this.txtAcao_TextChanged);
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAcao.Location = new System.Drawing.Point(358, 242);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(190, 20);
            this.lblAcao.TabIndex = 40;
            this.lblAcao.Text = "O que fez para melhorar *";
            // 
            // txtPensamento
            // 
            this.txtPensamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensamento.Location = new System.Drawing.Point(57, 239);
            this.txtPensamento.MaxLength = 250;
            this.txtPensamento.Name = "txtPensamento";
            this.txtPensamento.ReadOnly = true;
            this.txtPensamento.Size = new System.Drawing.Size(268, 63);
            this.txtPensamento.TabIndex = 39;
            this.txtPensamento.Text = "";
            // 
            // lblPensamento
            // 
            this.lblPensamento.AutoSize = true;
            this.lblPensamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensamento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPensamento.Location = new System.Drawing.Point(53, 216);
            this.lblPensamento.Name = "lblPensamento";
            this.lblPensamento.Size = new System.Drawing.Size(259, 20);
            this.lblPensamento.TabIndex = 38;
            this.lblPensamento.Text = "O que pensou em fazer a respeito *";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(362, 160);
            this.txtMotivo.MaxLength = 250;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(263, 60);
            this.txtMotivo.TabIndex = 37;
            this.txtMotivo.Text = "";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo.Location = new System.Drawing.Point(358, 137);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(250, 20);
            this.lblMotivo.TabIndex = 36;
            this.lblMotivo.Text = "Conte o motivo do seu desânimo *";
            // 
            // tabData
            // 
            this.tabData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabData.Controls.Add(this.btnExportar2);
            this.tabData.Controls.Add(this.btnAtualizar2);
            this.tabData.Controls.Add(this.btnPesquisarData);
            this.tabData.Controls.Add(this.lblDataNasc);
            this.tabData.Controls.Add(this.txtDataRegistro);
            this.tabData.Controls.Add(this.txtData2);
            this.tabData.Controls.Add(this.label1);
            this.tabData.Controls.Add(this.dgvDados2);
            this.tabData.Controls.Add(this.lblCharCount2);
            this.tabData.Controls.Add(this.txtAcao2);
            this.tabData.Controls.Add(this.label5);
            this.tabData.Controls.Add(this.txtPensamento2);
            this.tabData.Controls.Add(this.label6);
            this.tabData.Controls.Add(this.txtMotivo2);
            this.tabData.Controls.Add(this.label7);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(696, 402);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            // 
            // btnExportar2
            // 
            this.btnExportar2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar2.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar2.Location = new System.Drawing.Point(125, 366);
            this.btnExportar2.Name = "btnExportar2";
            this.btnExportar2.Size = new System.Drawing.Size(150, 30);
            this.btnExportar2.TabIndex = 49;
            this.btnExportar2.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar2, "Exportar dados");
            this.btnExportar2.UseVisualStyleBackColor = false;
            this.btnExportar2.Click += new System.EventHandler(this.btnExportar2_Click);
            // 
            // btnAtualizar2
            // 
            this.btnAtualizar2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar2.Location = new System.Drawing.Point(374, 340);
            this.btnAtualizar2.Name = "btnAtualizar2";
            this.btnAtualizar2.Size = new System.Drawing.Size(105, 28);
            this.btnAtualizar2.TabIndex = 63;
            this.btnAtualizar2.Text = "Atualizar";
            this.toolDicas.SetToolTip(this.btnAtualizar2, "Atualizar dados");
            this.btnAtualizar2.UseVisualStyleBackColor = false;
            this.btnAtualizar2.Click += new System.EventHandler(this.btnAtualizar2_Click);
            // 
            // btnPesquisarData
            // 
            this.btnPesquisarData.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPesquisarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarData.Location = new System.Drawing.Point(173, 30);
            this.btnPesquisarData.Name = "btnPesquisarData";
            this.btnPesquisarData.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarData.TabIndex = 62;
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
            this.lblDataNasc.Location = new System.Drawing.Point(58, 4);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(54, 20);
            this.lblDataNasc.TabIndex = 61;
            this.lblDataNasc.Text = "Data *";
            // 
            // txtDataRegistro
            // 
            this.txtDataRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRegistro.Location = new System.Drawing.Point(62, 27);
            this.txtDataRegistro.Mask = "##/##/####";
            this.txtDataRegistro.Name = "txtDataRegistro";
            this.txtDataRegistro.Size = new System.Drawing.Size(100, 26);
            this.txtDataRegistro.TabIndex = 60;
            this.toolDicas.SetToolTip(this.txtDataRegistro, "Digite uma data");
            // 
            // txtData2
            // 
            this.txtData2.BackColor = System.Drawing.SystemColors.Control;
            this.txtData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Location = new System.Drawing.Point(69, 198);
            this.txtData2.Name = "txtData2";
            this.txtData2.ReadOnly = true;
            this.txtData2.Size = new System.Drawing.Size(179, 26);
            this.txtData2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(65, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Data";
            // 
            // dgvDados2
            // 
            this.dgvDados2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados2.Location = new System.Drawing.Point(60, 59);
            this.dgvDados2.Name = "dgvDados2";
            this.dgvDados2.Size = new System.Drawing.Size(583, 108);
            this.dgvDados2.TabIndex = 57;
            this.toolDicas.SetToolTip(this.dgvDados2, "Clique sobre um registro para ver detalhes");
            this.dgvDados2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados2_CellClick);
            // 
            // lblCharCount2
            // 
            this.lblCharCount2.AutoSize = true;
            this.lblCharCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCharCount2.Location = new System.Drawing.Point(562, 340);
            this.lblCharCount2.Name = "lblCharCount2";
            this.lblCharCount2.Size = new System.Drawing.Size(76, 13);
            this.lblCharCount2.TabIndex = 54;
            this.lblCharCount2.Text = "max 250 chars";
            // 
            // txtAcao2
            // 
            this.txtAcao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcao2.Location = new System.Drawing.Point(374, 284);
            this.txtAcao2.MaxLength = 250;
            this.txtAcao2.Name = "txtAcao2";
            this.txtAcao2.Size = new System.Drawing.Size(264, 53);
            this.txtAcao2.TabIndex = 53;
            this.txtAcao2.Text = "";
            this.txtAcao2.TextChanged += new System.EventHandler(this.txtAcao2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(370, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "O que fez para melhorar *";
            // 
            // txtPensamento2
            // 
            this.txtPensamento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensamento2.Location = new System.Drawing.Point(69, 277);
            this.txtPensamento2.MaxLength = 250;
            this.txtPensamento2.Name = "txtPensamento2";
            this.txtPensamento2.ReadOnly = true;
            this.txtPensamento2.Size = new System.Drawing.Size(268, 63);
            this.txtPensamento2.TabIndex = 51;
            this.txtPensamento2.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(65, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "O que pensou em fazer a respeito *";
            // 
            // txtMotivo2
            // 
            this.txtMotivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo2.Location = new System.Drawing.Point(374, 198);
            this.txtMotivo2.MaxLength = 250;
            this.txtMotivo2.Name = "txtMotivo2";
            this.txtMotivo2.ReadOnly = true;
            this.txtMotivo2.Size = new System.Drawing.Size(263, 60);
            this.txtMotivo2.TabIndex = 49;
            this.txtMotivo2.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(370, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Conte o motivo do seu desânimo *";
            // 
            // FrmDesanimoRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDesanimoRegistros";
            this.Text = "Desânimo Registros";
            this.panFundo.ResumeLayout(false);
            this.panGuias.ResumeLayout(false);
            this.tabTodos.ResumeLayout(false);
            this.tabTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.TabControl panGuias;
        private System.Windows.Forms.TabPage tabTodos;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.RichTextBox txtAcao;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.RichTextBox txtPensamento;
        private System.Windows.Forms.Label lblPensamento;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDados2;
        private System.Windows.Forms.Label lblCharCount2;
        private System.Windows.Forms.RichTextBox txtAcao2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtPensamento2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtMotivo2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPesquisarData;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataRegistro;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAtualizar2;
        private System.Windows.Forms.Button btnExportar2;
        private System.Windows.Forms.ToolTip toolDicas;

    }
}