namespace Reflex
{
    partial class FrmAlegriaRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlegriaRegistros));
            this.panFundo = new System.Windows.Forms.Panel();
            this.panGuias = new System.Windows.Forms.TabControl();
            this.tabTodos = new System.Windows.Forms.TabPage();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.btnExportar2 = new System.Windows.Forms.Button();
            this.txtMotivo2 = new System.Windows.Forms.RichTextBox();
            this.lblMotivo2 = new System.Windows.Forms.Label();
            this.dgvDados2 = new System.Windows.Forms.DataGridView();
            this.btnPesquisarData = new System.Windows.Forms.Button();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataRegistro = new System.Windows.Forms.MaskedTextBox();
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
            this.panFundo.Location = new System.Drawing.Point(165, 47);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(553, 403);
            this.panFundo.TabIndex = 2;
            // 
            // panGuias
            // 
            this.panGuias.Controls.Add(this.tabTodos);
            this.panGuias.Controls.Add(this.tabData);
            this.panGuias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGuias.Location = new System.Drawing.Point(0, 0);
            this.panGuias.Name = "panGuias";
            this.panGuias.SelectedIndex = 0;
            this.panGuias.Size = new System.Drawing.Size(553, 403);
            this.panGuias.TabIndex = 0;
            // 
            // tabTodos
            // 
            this.tabTodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabTodos.Controls.Add(this.txtData);
            this.tabTodos.Controls.Add(this.lblData);
            this.tabTodos.Controls.Add(this.btnExportar);
            this.tabTodos.Controls.Add(this.dgvDados);
            this.tabTodos.Controls.Add(this.txtMotivo);
            this.tabTodos.Controls.Add(this.lblDescricao);
            this.tabTodos.Location = new System.Drawing.Point(4, 22);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodos.Size = new System.Drawing.Size(545, 377);
            this.tabTodos.TabIndex = 0;
            this.tabTodos.Text = "Todos";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(102, 158);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 55;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Location = new System.Drawing.Point(98, 135);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 54;
            this.lblData.Text = "Data";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar.Location = new System.Drawing.Point(200, 331);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 30);
            this.btnExportar.TabIndex = 53;
            this.btnExportar.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar, "Exportar dados");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(72, 15);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(400, 108);
            this.dgvDados.TabIndex = 52;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(102, 234);
            this.txtMotivo.MaxLength = 250;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(347, 76);
            this.txtMotivo.TabIndex = 51;
            this.txtMotivo.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDescricao.Location = new System.Drawing.Point(98, 201);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(128, 20);
            this.lblDescricao.TabIndex = 50;
            this.lblDescricao.Text = "Motivo da alegria";
            // 
            // tabData
            // 
            this.tabData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabData.Controls.Add(this.txtData2);
            this.tabData.Controls.Add(this.btnExportar2);
            this.tabData.Controls.Add(this.txtMotivo2);
            this.tabData.Controls.Add(this.lblMotivo2);
            this.tabData.Controls.Add(this.dgvDados2);
            this.tabData.Controls.Add(this.btnPesquisarData);
            this.tabData.Controls.Add(this.lblDataNasc);
            this.tabData.Controls.Add(this.txtDataRegistro);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(545, 377);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Data";
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(417, 258);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(67, 20);
            this.txtData2.TabIndex = 69;
            this.txtData2.Visible = false;
            // 
            // btnExportar2
            // 
            this.btnExportar2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar2.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar2.Location = new System.Drawing.Point(201, 312);
            this.btnExportar2.Name = "btnExportar2";
            this.btnExportar2.Size = new System.Drawing.Size(150, 30);
            this.btnExportar2.TabIndex = 54;
            this.btnExportar2.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar2, "Exportar dados");
            this.btnExportar2.UseVisualStyleBackColor = false;
            this.btnExportar2.Click += new System.EventHandler(this.btnExportar2_Click);
            // 
            // txtMotivo2
            // 
            this.txtMotivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo2.Location = new System.Drawing.Point(64, 202);
            this.txtMotivo2.MaxLength = 250;
            this.txtMotivo2.Name = "txtMotivo2";
            this.txtMotivo2.ReadOnly = true;
            this.txtMotivo2.Size = new System.Drawing.Size(347, 76);
            this.txtMotivo2.TabIndex = 68;
            this.txtMotivo2.Text = "";
            // 
            // lblMotivo2
            // 
            this.lblMotivo2.AutoSize = true;
            this.lblMotivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo2.Location = new System.Drawing.Point(60, 169);
            this.lblMotivo2.Name = "lblMotivo2";
            this.lblMotivo2.Size = new System.Drawing.Size(128, 20);
            this.lblMotivo2.TabIndex = 67;
            this.lblMotivo2.Text = "Motivo da alegria";
            // 
            // dgvDados2
            // 
            this.dgvDados2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados2.Location = new System.Drawing.Point(64, 62);
            this.dgvDados2.Name = "dgvDados2";
            this.dgvDados2.Size = new System.Drawing.Size(400, 81);
            this.dgvDados2.TabIndex = 66;
            this.toolDicas.SetToolTip(this.dgvDados2, "Clique sobre um registro para ver detalhes");
            this.dgvDados2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados2_CellClick);
            // 
            // btnPesquisarData
            // 
            this.btnPesquisarData.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPesquisarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarData.Location = new System.Drawing.Point(176, 33);
            this.btnPesquisarData.Name = "btnPesquisarData";
            this.btnPesquisarData.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarData.TabIndex = 65;
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
            this.lblDataNasc.Location = new System.Drawing.Point(61, 7);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(54, 20);
            this.lblDataNasc.TabIndex = 64;
            this.lblDataNasc.Text = "Data *";
            // 
            // txtDataRegistro
            // 
            this.txtDataRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRegistro.Location = new System.Drawing.Point(65, 30);
            this.txtDataRegistro.Mask = "##/##/####";
            this.txtDataRegistro.Name = "txtDataRegistro";
            this.txtDataRegistro.Size = new System.Drawing.Size(100, 26);
            this.txtDataRegistro.TabIndex = 63;
            this.toolDicas.SetToolTip(this.txtDataRegistro, "Digite uma data");
            // 
            // FrmAlegriaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlegriaRegistros";
            this.Text = "Alegria Registros ";
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
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnPesquisarData;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataRegistro;
        private System.Windows.Forms.Button btnExportar2;
        private System.Windows.Forms.RichTextBox txtMotivo2;
        private System.Windows.Forms.Label lblMotivo2;
        private System.Windows.Forms.DataGridView dgvDados2;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}