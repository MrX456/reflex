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
 * Formulário resposável por mostrar registros sentimentos
 * e exportação dos dados se desejado
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
 * Reflex / Application / FrmSentimentoRegistros
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmSentimentoRegistros : Form
    {

        private string id;

        public FrmSentimentoRegistros(string id)
        {
            InitializeComponent();
            this.MostrarTodosDados(id);
            this.id = id;
        }

        private void MostrarTodosDados(string id)
        {
            DataTable dt = new DataTable();
            Controller_Humor hs = new Controller_Humor();
            dt = hs.GetHumorTodosRegistros(id);
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
                    dgvDados.Columns[1].HeaderText = "Sentimento";
                    dgvDados.Columns[1].Width = 100;
                    dgvDados.Columns[2].HeaderText = "Resumo Dia";
                    dgvDados.Columns[2].Width = 260;

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void MostrarDadosporSentimento(string id, string sentimento, DataGridView dgv)
        {
            DataTable dt = new DataTable();
            Controller_Humor hs = new Controller_Humor();
            dt = hs.GetHumorporSentimento(id, sentimento);
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
                    dgv.Columns[1].HeaderText = "Sentimento";
                    dgv.Columns[1].Width = 100;
                    dgv.Columns[2].HeaderText = "Resumo Dia";
                    dgv.Columns[2].Width = 260;

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void MostrarDadosporData(string id, string data, string dataAmanha, DataGridView dgv)
        {
            DataTable dt = new DataTable();
            Controller_Humor hs = new Controller_Humor();
            dt = hs.GetHumorporData(id, data, dataAmanha);
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
                    dgv.Columns[1].HeaderText = "Sentimento";
                    dgv.Columns[1].Width = 100;
                    dgv.Columns[2].HeaderText = "Resumo Dia";
                    dgv.Columns[2].Width = 260;

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void SetCampos(DataGridViewCellEventArgs e, DataGridView dgv, RichTextBox dia)
        {
            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                dia.Text = row.Cells["resumo_dia"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void FrmSentimentoRegistros_Load(object sender, EventArgs e)
        {
            cboSentimento.SelectedIndex = 0;
        }

        #region - Exportar dados DataGridViews para excel

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

        #endregion

        private void btnPesquisarSentimento_Click(object sender, EventArgs e)
        {
            this.MostrarDadosporSentimento(id, Criptografia.EncriptarCampo(cboSentimento.SelectedItem.ToString()), dgvDados2);
        }

        private void dgvDados2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados2, txtResumoDia);
        }

        private void btnPesquisarData_Click(object sender, EventArgs e)
        {
            try 
            {
                //Data formatada para o sql yyyy-MM-dd
                string dataDesejada = DateTime.Parse(txtDataRegistro.Text).ToString("yyyy-MM-dd");
                //Precisamos da data seguinte a digitada pelo usuário pois a query possui um BETWEEN entre estas datas
                string amanha = DateTime.Parse(txtDataRegistro.Text).AddDays(1).ToString("yyyy-MM-dd");

                this.MostrarDadosporData(id, dataDesejada, amanha, dgvDados3);
            }
            catch (Exception) 
            {
                MessageBox.Show("Digite uma data válida!");//tratar melhor
            }
        }

        private void dgvDados3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados3, txtResumoDia2);
        }

        
    }
}
