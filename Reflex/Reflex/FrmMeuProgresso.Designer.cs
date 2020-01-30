namespace Reflex
{
    partial class FrmMeuProgresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeuProgresso));
            this.panFundo = new System.Windows.Forms.Panel();
            this.panGuias = new System.Windows.Forms.TabControl();
            this.tabTodos = new System.Windows.Forms.TabPage();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblRealizacao = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMeta = new System.Windows.Forms.RichTextBox();
            this.lblMeta = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tabRealizadas = new System.Windows.Forms.TabPage();
            this.btnExportar2 = new System.Windows.Forms.Button();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.lblData2 = new System.Windows.Forms.Label();
            this.txtMotivo2 = new System.Windows.Forms.RichTextBox();
            this.lblMotivo2 = new System.Windows.Forms.Label();
            this.txtMeta2 = new System.Windows.Forms.RichTextBox();
            this.lblMeta2 = new System.Windows.Forms.Label();
            this.dgvDados2 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabEmAberto = new System.Windows.Forms.TabPage();
            this.btnExportar3 = new System.Windows.Forms.Button();
            this.txtData3 = new System.Windows.Forms.TextBox();
            this.lblData3 = new System.Windows.Forms.Label();
            this.txtMotivo3 = new System.Windows.Forms.RichTextBox();
            this.lblMotivo3 = new System.Windows.Forms.Label();
            this.txtMeta3 = new System.Windows.Forms.RichTextBox();
            this.lblMeta3 = new System.Windows.Forms.Label();
            this.dgvDados3 = new System.Windows.Forms.DataGridView();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cboRealizacao = new System.Windows.Forms.ComboBox();
            this.lblRealizacao2 = new System.Windows.Forms.Label();
            this.toolDicas = new System.Windows.Forms.ToolTip(this.components);
            this.panFundo.SuspendLayout();
            this.panGuias.SuspendLayout();
            this.tabTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tabRealizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).BeginInit();
            this.tabEmAberto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados3)).BeginInit();
            this.SuspendLayout();
            // 
            // panFundo
            // 
            this.panFundo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panFundo.Controls.Add(this.panGuias);
            this.panFundo.Location = new System.Drawing.Point(106, 49);
            this.panFundo.Name = "panFundo";
            this.panFundo.Size = new System.Drawing.Size(660, 401);
            this.panFundo.TabIndex = 1;
            // 
            // panGuias
            // 
            this.panGuias.Controls.Add(this.tabTodos);
            this.panGuias.Controls.Add(this.tabRealizadas);
            this.panGuias.Controls.Add(this.tabEmAberto);
            this.panGuias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGuias.Location = new System.Drawing.Point(0, 0);
            this.panGuias.Name = "panGuias";
            this.panGuias.SelectedIndex = 0;
            this.panGuias.Size = new System.Drawing.Size(660, 401);
            this.panGuias.TabIndex = 0;
            // 
            // tabTodos
            // 
            this.tabTodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabTodos.Controls.Add(this.txtData);
            this.tabTodos.Controls.Add(this.lblData);
            this.tabTodos.Controls.Add(this.txtStatus);
            this.tabTodos.Controls.Add(this.lblRealizacao);
            this.tabTodos.Controls.Add(this.txtMotivo);
            this.tabTodos.Controls.Add(this.lblMotivo);
            this.tabTodos.Controls.Add(this.txtMeta);
            this.tabTodos.Controls.Add(this.lblMeta);
            this.tabTodos.Controls.Add(this.btnExportar);
            this.tabTodos.Controls.Add(this.dgvDados);
            this.tabTodos.Location = new System.Drawing.Point(4, 22);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodos.Size = new System.Drawing.Size(652, 375);
            this.tabTodos.TabIndex = 0;
            this.tabTodos.Text = "Todas metas";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(34, 270);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 27;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData.Location = new System.Drawing.Point(30, 247);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 26;
            this.lblData.Text = "Data";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(466, 270);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(151, 26);
            this.txtStatus.TabIndex = 25;
            // 
            // lblRealizacao
            // 
            this.lblRealizacao.AutoSize = true;
            this.lblRealizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizacao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRealizacao.Location = new System.Drawing.Point(462, 247);
            this.lblRealizacao.Name = "lblRealizacao";
            this.lblRealizacao.Size = new System.Drawing.Size(96, 20);
            this.lblRealizacao.TabIndex = 24;
            this.lblRealizacao.Text = "Status meta";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(349, 171);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(268, 64);
            this.txtMotivo.TabIndex = 21;
            this.txtMotivo.Text = "";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo.Location = new System.Drawing.Point(345, 148);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(55, 20);
            this.lblMotivo.TabIndex = 20;
            this.lblMotivo.Text = "Motivo";
            // 
            // txtMeta
            // 
            this.txtMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeta.Location = new System.Drawing.Point(34, 171);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.ReadOnly = true;
            this.txtMeta.Size = new System.Drawing.Size(268, 64);
            this.txtMeta.TabIndex = 19;
            this.txtMeta.Text = "";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMeta.Location = new System.Drawing.Point(30, 148);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(139, 20);
            this.lblMeta.TabIndex = 18;
            this.lblMeta.Text = "Meta estabelecida";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar.Location = new System.Drawing.Point(260, 330);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 30);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar, "Exportar dados");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(34, 32);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(583, 110);
            this.dgvDados.TabIndex = 1;
            this.toolDicas.SetToolTip(this.dgvDados, "Clique sobre um registro para ver detalhes");
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // tabRealizadas
            // 
            this.tabRealizadas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabRealizadas.Controls.Add(this.btnExportar2);
            this.tabRealizadas.Controls.Add(this.txtData2);
            this.tabRealizadas.Controls.Add(this.lblData2);
            this.tabRealizadas.Controls.Add(this.txtMotivo2);
            this.tabRealizadas.Controls.Add(this.lblMotivo2);
            this.tabRealizadas.Controls.Add(this.txtMeta2);
            this.tabRealizadas.Controls.Add(this.lblMeta2);
            this.tabRealizadas.Controls.Add(this.dgvDados2);
            this.tabRealizadas.Controls.Add(this.lblTitle);
            this.tabRealizadas.Location = new System.Drawing.Point(4, 22);
            this.tabRealizadas.Name = "tabRealizadas";
            this.tabRealizadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabRealizadas.Size = new System.Drawing.Size(652, 375);
            this.tabRealizadas.TabIndex = 1;
            this.tabRealizadas.Text = "Realizadas";
            // 
            // btnExportar2
            // 
            this.btnExportar2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar2.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar2.Location = new System.Drawing.Point(250, 327);
            this.btnExportar2.Name = "btnExportar2";
            this.btnExportar2.Size = new System.Drawing.Size(150, 30);
            this.btnExportar2.TabIndex = 34;
            this.btnExportar2.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar2, "Exportar dados");
            this.btnExportar2.UseVisualStyleBackColor = false;
            this.btnExportar2.Click += new System.EventHandler(this.btnExportar2_Click);
            // 
            // txtData2
            // 
            this.txtData2.BackColor = System.Drawing.SystemColors.Control;
            this.txtData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Location = new System.Drawing.Point(34, 268);
            this.txtData2.Name = "txtData2";
            this.txtData2.ReadOnly = true;
            this.txtData2.Size = new System.Drawing.Size(179, 26);
            this.txtData2.TabIndex = 33;
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData2.Location = new System.Drawing.Point(30, 245);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(44, 20);
            this.lblData2.TabIndex = 32;
            this.lblData2.Text = "Data";
            // 
            // txtMotivo2
            // 
            this.txtMotivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo2.Location = new System.Drawing.Point(349, 175);
            this.txtMotivo2.Name = "txtMotivo2";
            this.txtMotivo2.ReadOnly = true;
            this.txtMotivo2.Size = new System.Drawing.Size(268, 64);
            this.txtMotivo2.TabIndex = 31;
            this.txtMotivo2.Text = "";
            // 
            // lblMotivo2
            // 
            this.lblMotivo2.AutoSize = true;
            this.lblMotivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo2.Location = new System.Drawing.Point(345, 152);
            this.lblMotivo2.Name = "lblMotivo2";
            this.lblMotivo2.Size = new System.Drawing.Size(55, 20);
            this.lblMotivo2.TabIndex = 30;
            this.lblMotivo2.Text = "Motivo";
            // 
            // txtMeta2
            // 
            this.txtMeta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeta2.Location = new System.Drawing.Point(34, 175);
            this.txtMeta2.Name = "txtMeta2";
            this.txtMeta2.ReadOnly = true;
            this.txtMeta2.Size = new System.Drawing.Size(268, 64);
            this.txtMeta2.TabIndex = 29;
            this.txtMeta2.Text = "";
            // 
            // lblMeta2
            // 
            this.lblMeta2.AutoSize = true;
            this.lblMeta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMeta2.Location = new System.Drawing.Point(30, 152);
            this.lblMeta2.Name = "lblMeta2";
            this.lblMeta2.Size = new System.Drawing.Size(139, 20);
            this.lblMeta2.TabIndex = 28;
            this.lblMeta2.Text = "Meta estabelecida";
            // 
            // dgvDados2
            // 
            this.dgvDados2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados2.Location = new System.Drawing.Point(34, 26);
            this.dgvDados2.Name = "dgvDados2";
            this.dgvDados2.Size = new System.Drawing.Size(583, 110);
            this.dgvDados2.TabIndex = 20;
            this.toolDicas.SetToolTip(this.dgvDados2, "Clique sobre um registro para ver detalhes");
            this.dgvDados2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados2_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(16, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 20);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Parabéns você realizou as seguintes metas";
            // 
            // tabEmAberto
            // 
            this.tabEmAberto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabEmAberto.Controls.Add(this.btnExportar3);
            this.tabEmAberto.Controls.Add(this.txtData3);
            this.tabEmAberto.Controls.Add(this.lblData3);
            this.tabEmAberto.Controls.Add(this.txtMotivo3);
            this.tabEmAberto.Controls.Add(this.lblMotivo3);
            this.tabEmAberto.Controls.Add(this.txtMeta3);
            this.tabEmAberto.Controls.Add(this.lblMeta3);
            this.tabEmAberto.Controls.Add(this.dgvDados3);
            this.tabEmAberto.Controls.Add(this.lblTitle2);
            this.tabEmAberto.Controls.Add(this.btnAtualizar);
            this.tabEmAberto.Controls.Add(this.cboRealizacao);
            this.tabEmAberto.Controls.Add(this.lblRealizacao2);
            this.tabEmAberto.Location = new System.Drawing.Point(4, 22);
            this.tabEmAberto.Name = "tabEmAberto";
            this.tabEmAberto.Size = new System.Drawing.Size(652, 375);
            this.tabEmAberto.TabIndex = 2;
            this.tabEmAberto.Text = "Em aberto";
            // 
            // btnExportar3
            // 
            this.btnExportar3.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExportar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar3.Image = global::Reflex.Properties.Resources.page_white_excel;
            this.btnExportar3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportar3.Location = new System.Drawing.Point(249, 327);
            this.btnExportar3.Name = "btnExportar3";
            this.btnExportar3.Size = new System.Drawing.Size(150, 30);
            this.btnExportar3.TabIndex = 42;
            this.btnExportar3.Text = "Exportar para Planilha";
            this.toolDicas.SetToolTip(this.btnExportar3, "Exportar dados");
            this.btnExportar3.UseVisualStyleBackColor = false;
            this.btnExportar3.Click += new System.EventHandler(this.btnExportar3_Click);
            // 
            // txtData3
            // 
            this.txtData3.BackColor = System.Drawing.SystemColors.Control;
            this.txtData3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData3.Location = new System.Drawing.Point(33, 275);
            this.txtData3.Name = "txtData3";
            this.txtData3.ReadOnly = true;
            this.txtData3.Size = new System.Drawing.Size(179, 26);
            this.txtData3.TabIndex = 41;
            // 
            // lblData3
            // 
            this.lblData3.AutoSize = true;
            this.lblData3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblData3.Location = new System.Drawing.Point(29, 252);
            this.lblData3.Name = "lblData3";
            this.lblData3.Size = new System.Drawing.Size(44, 20);
            this.lblData3.TabIndex = 40;
            this.lblData3.Text = "Data";
            // 
            // txtMotivo3
            // 
            this.txtMotivo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo3.Location = new System.Drawing.Point(348, 182);
            this.txtMotivo3.Name = "txtMotivo3";
            this.txtMotivo3.ReadOnly = true;
            this.txtMotivo3.Size = new System.Drawing.Size(268, 64);
            this.txtMotivo3.TabIndex = 39;
            this.txtMotivo3.Text = "";
            // 
            // lblMotivo3
            // 
            this.lblMotivo3.AutoSize = true;
            this.lblMotivo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMotivo3.Location = new System.Drawing.Point(344, 159);
            this.lblMotivo3.Name = "lblMotivo3";
            this.lblMotivo3.Size = new System.Drawing.Size(55, 20);
            this.lblMotivo3.TabIndex = 38;
            this.lblMotivo3.Text = "Motivo";
            // 
            // txtMeta3
            // 
            this.txtMeta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeta3.Location = new System.Drawing.Point(33, 182);
            this.txtMeta3.Name = "txtMeta3";
            this.txtMeta3.ReadOnly = true;
            this.txtMeta3.Size = new System.Drawing.Size(268, 64);
            this.txtMeta3.TabIndex = 37;
            this.txtMeta3.Text = "";
            // 
            // lblMeta3
            // 
            this.lblMeta3.AutoSize = true;
            this.lblMeta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMeta3.Location = new System.Drawing.Point(29, 159);
            this.lblMeta3.Name = "lblMeta3";
            this.lblMeta3.Size = new System.Drawing.Size(139, 20);
            this.lblMeta3.TabIndex = 36;
            this.lblMeta3.Text = "Meta estabelecida";
            // 
            // dgvDados3
            // 
            this.dgvDados3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados3.Location = new System.Drawing.Point(33, 33);
            this.dgvDados3.Name = "dgvDados3";
            this.dgvDados3.Size = new System.Drawing.Size(583, 110);
            this.dgvDados3.TabIndex = 35;
            this.toolDicas.SetToolTip(this.dgvDados3, "Clique sobre um registro para ver detalhes");
            this.dgvDados3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados3_CellClick);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle2.Location = new System.Drawing.Point(15, 10);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(184, 20);
            this.lblTitle2.TabIndex = 34;
            this.lblTitle2.Text = "Minhas metas em aberto";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(512, 275);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(105, 28);
            this.btnAtualizar.TabIndex = 25;
            this.btnAtualizar.Text = "Atualizar";
            this.toolDicas.SetToolTip(this.btnAtualizar, "Atualizar dados");
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cboRealizacao
            // 
            this.cboRealizacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRealizacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRealizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRealizacao.FormattingEnabled = true;
            this.cboRealizacao.Items.AddRange(new object[] {
            "não",
            "sim"});
            this.cboRealizacao.Location = new System.Drawing.Point(427, 275);
            this.cboRealizacao.Name = "cboRealizacao";
            this.cboRealizacao.Size = new System.Drawing.Size(79, 28);
            this.cboRealizacao.TabIndex = 24;
            // 
            // lblRealizacao2
            // 
            this.lblRealizacao2.AutoSize = true;
            this.lblRealizacao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizacao2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRealizacao2.Location = new System.Drawing.Point(423, 252);
            this.lblRealizacao2.Name = "lblRealizacao2";
            this.lblRealizacao2.Size = new System.Drawing.Size(159, 20);
            this.lblRealizacao2.TabIndex = 23;
            this.lblRealizacao2.Text = "Realizou esta meta ?";
            // 
            // FrmMeuProgresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(879, 462);
            this.Controls.Add(this.panFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMeuProgresso";
            this.Text = "Meu Progresso";
            this.Load += new System.EventHandler(this.FrmMeuProgresso_Load);
            this.panFundo.ResumeLayout(false);
            this.panGuias.ResumeLayout(false);
            this.tabTodos.ResumeLayout(false);
            this.tabTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tabRealizadas.ResumeLayout(false);
            this.tabRealizadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).EndInit();
            this.tabEmAberto.ResumeLayout(false);
            this.tabEmAberto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFundo;
        private System.Windows.Forms.TabControl panGuias;
        private System.Windows.Forms.TabPage tabTodos;
        private System.Windows.Forms.TabPage tabRealizadas;
        private System.Windows.Forms.TabPage tabEmAberto;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.RichTextBox txtMeta;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblRealizacao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cboRealizacao;
        private System.Windows.Forms.Label lblRealizacao2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.RichTextBox txtMotivo2;
        private System.Windows.Forms.Label lblMotivo2;
        private System.Windows.Forms.RichTextBox txtMeta2;
        private System.Windows.Forms.Label lblMeta2;
        private System.Windows.Forms.DataGridView dgvDados2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExportar2;
        private System.Windows.Forms.TextBox txtData3;
        private System.Windows.Forms.Label lblData3;
        private System.Windows.Forms.RichTextBox txtMotivo3;
        private System.Windows.Forms.Label lblMotivo3;
        private System.Windows.Forms.RichTextBox txtMeta3;
        private System.Windows.Forms.Label lblMeta3;
        private System.Windows.Forms.DataGridView dgvDados3;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Button btnExportar3;
        private System.Windows.Forms.ToolTip toolDicas;
    }
}