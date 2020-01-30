/*
 * Reflex - Software de auto ajuda.
 * Copyright (C) 2020  Quantum Comp IT Solutions
 
 * Este arquivo é parte do programa Reflex
 * Reflex é um software livre; você pode redistribuí-lo e/ou
 * modificá-lo dentro dos termos da Licença Pública Geral GNU como
 * publicada pela Free Software Foundation (FSF); na versão 3 da
 * Licença, ou qualquer versão posterior.

 * Este programa é distribuído na esperança de que possa ser útil,
 * mas SEM NENHUMA GARANTIA; sem uma garantia implícita de ADEQUAÇÃO
 * a qualquer MERCADO ou APLICAÇÃO EM PARTICULAR. Veja a
 * Licença Pública Geral GNU para maiores detalhes.

 * Você deve ter recebido uma cópia da Licença Pública Geral GNU junto
 * com este programa, Se não, veja <https://www.gnu.org/licenses/gpl-3.0.txt>.
 */

/*
 * Formulário de metas registradas
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cypher;
using DAL;
using System.Data.SQLite;
using System.Collections;

/*
 * Reflex / Application / FrmMeuProgresso
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmMeuProgresso : Form
    {
        string id;

        public FrmMeuProgresso(string id)
        {
            InitializeComponent();
            this.MostrarTodosDados(id);
            this.MostrarDadosporStatus(id, "Realizada", dgvDados2);
            this.MostrarDadosporStatus(id, "Em aberto", dgvDados3);
            this.id = id;
        }


        private void MostrarTodosDados(string id)
        {
            DataTable dt = new DataTable();
            Controller_Metas ms = new Controller_Metas();
            dt = ms.GetTodasMetas(id);
            dgvDados.DataSource = dt;

            //Descriptografar dados
            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                try
                {
                    ArrayList decrypt = new ArrayList();
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[1].Value.ToString()));
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[2].Value.ToString()));

                    row.Cells[1].Value = decrypt[0];
                    row.Cells[2].Value = decrypt[1];
                }
                catch (Exception) { }
                finally
                {
                    //Titulo e largura das colunas
                    dgvDados.Columns[0].HeaderText = "Data registro";
                    dgvDados.Columns[1].HeaderText = "Meta estabelecida";
                    dgvDados.Columns[1].Width = 170;
                    dgvDados.Columns[2].HeaderText = "Motivo";
                    dgvDados.Columns[2].Width = 170;
                    dgvDados.Columns[3].HeaderText = "Status";

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void MostrarDadosporStatus(string id, string status, DataGridView dgv)
        {
            DataTable dt = new DataTable();
            Controller_Metas ms = new Controller_Metas();
            dt = ms.GetMetasporStatus(id, status);
            dgv.DataSource = dt;

            //Descriptografar dados
            foreach (DataGridViewRow row in dgv.Rows)
            {
                try
                {
                    ArrayList decrypt = new ArrayList();
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[1].Value.ToString()));
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[2].Value.ToString()));

                    row.Cells[1].Value = decrypt[0];
                    row.Cells[2].Value = decrypt[1];
                }
                catch (Exception) { }
                finally
                {
                    //Titulo e largura das colunas
                    dgv.Columns[0].HeaderText = "Data registro";
                    dgv.Columns[1].HeaderText = "Meta estabelecida";
                    dgv.Columns[1].Width = 170;
                    dgv.Columns[2].HeaderText = "Motivo";
                    dgv.Columns[2].Width = 170;
                    dgv.Columns[3].HeaderText = "Status";

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void SetCampos(DataGridViewCellEventArgs e, DataGridView dgv, RichTextBox meta, RichTextBox motivo, TextBox data, TextBox status)
        {
            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                meta.Text = row.Cells["descricao_meta"].Value.ToString();
                motivo.Text = row.Cells["motivo_meta"].Value.ToString();
                data.Text = row.Cells["data_registro_meta"].Value.ToString();
                status.Text = row.Cells["status_meta"].Value.ToString();
            }
            catch (Exception) 
            { 

            }
        }

        private void SetDefaultState() 
        {
            txtData.Text = null;
            txtData2.Text = null;
            txtData3.Text = null;
            txtMotivo.Text = null;
            txtMotivo2.Text = null;
            txtMotivo3.Text = null;
            txtMeta.Text = null;
            txtMeta2.Text = null;
            txtMeta3.Text = null;
            txtStatus.Text = null;
        }

        private void FrmMeuProgresso_Load(object sender, EventArgs e)
        {
            cboRealizacao.SelectedIndex = 0;
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados , txtMeta, txtMotivo, txtData, txtStatus);
        }

        private void dgvDados2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados2, txtMeta2, txtMotivo2, txtData2, null);
        }

        private void dgvDados3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados3, txtMeta3, txtMotivo3, txtData3, null);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Misc.ImportarDados(dgvDados);
        }

        private void btnExportar2_Click(object sender, EventArgs e)
        {
            Misc.ImportarDados(dgvDados2);
        }

        private void btnExportar3_Click(object sender, EventArgs e)
        {
            Misc.ImportarDados(dgvDados3);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cboRealizacao.SelectedIndex == 1)
            {


                if (txtData3.Text.Trim() != string.Empty) 
                {
                    Controller_Metas ms = new Controller_Metas();
                    ms.AtualizarStatusMeta(id, Misc.FormatData(txtData3.Text));
                    this.MostrarTodosDados(id);
                    this.MostrarDadosporStatus(id, "Realizada", dgvDados2);
                    this.MostrarDadosporStatus(id, "Em aberto", dgvDados3);
                    this.SetDefaultState();
                }
            }
        }
        
    }
}
