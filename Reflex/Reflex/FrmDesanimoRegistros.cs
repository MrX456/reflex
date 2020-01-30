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
 * Formulário resposável por mostrar informações da tabela desanimo
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
 * Reflex / Application / FrmDesanimoRegistros
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmDesanimoRegistros : Form
    {

        private int maxCharsAcao;
        private string id;

        public FrmDesanimoRegistros(string id)
        {
            InitializeComponent();
            this.MostrarTodosDados(id);
            this.id = id;
        }

        private void MostrarTodosDados(string id)
        {
            DataTable dt = new DataTable();
            Controller_Desanimo ds = new Controller_Desanimo();
            dt = ds.GetDesanimoTodosRegistros(id);
            dgvDados.DataSource = dt;

            //Descriptografar dados
            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                try
                {
                    ArrayList decrypt = new ArrayList();
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[1].Value.ToString()));
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[2].Value.ToString()));
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[3].Value.ToString()));

                    row.Cells[1].Value = decrypt[0];
                    row.Cells[2].Value = decrypt[1];
                    row.Cells[3].Value = decrypt[2];
                }
                catch (Exception) { }
                finally
                {
                    //Titulo e largura das colunas
                    dgvDados.Columns[0].HeaderText = "Data registro";
                    dgvDados.Columns[1].HeaderText = "Motivo desânimo";
                    dgvDados.Columns[1].Width = 150;
                    dgvDados.Columns[2].HeaderText = "Pensamento";
                    dgvDados.Columns[2].Width = 150;
                    dgvDados.Columns[3].HeaderText = "Ação";
                    dgvDados.Columns[3].Width = 140;

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void MostrarDadosporData(string id, string data, string dataAmanha)
        {
            DataTable dt = new DataTable();
            Controller_Desanimo ds = new Controller_Desanimo();
            dt = ds.GetDesanimoporData(id, data, dataAmanha);
            dgvDados2.DataSource = dt;

            //Descriptografar dados
            foreach (DataGridViewRow row in dgvDados2.Rows)
            {
                try
                {
                    ArrayList decrypt = new ArrayList();
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[1].Value.ToString()));
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[2].Value.ToString()));
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[3].Value.ToString()));

                    row.Cells[1].Value = decrypt[0];
                    row.Cells[2].Value = decrypt[1];
                    row.Cells[3].Value = decrypt[2];
                }
                catch (Exception) { }
                finally
                {
                    //Titulo e largura das colunas
                    dgvDados2.Columns[0].HeaderText = "Data registro";
                    dgvDados2.Columns[1].HeaderText = "Motivo desânimo";
                    dgvDados2.Columns[1].Width = 150;
                    dgvDados2.Columns[2].HeaderText = "Pensamento";
                    dgvDados2.Columns[2].Width = 150;
                    dgvDados2.Columns[3].HeaderText = "Ação";
                    dgvDados2.Columns[3].Width = 140;

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void SetCampos(DataGridViewCellEventArgs e, DataGridView dgv, TextBox data, RichTextBox motivo, RichTextBox pensamento, RichTextBox acao)
        {
            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                data.Text = row.Cells["data_registro_desanimo"].Value.ToString();
                motivo.Text = row.Cells["motivo_desanimo"].Value.ToString();
                pensamento.Text = row.Cells["pensamento"].Value.ToString();
                acao.Text = row.Cells["acao"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void SetDefaultState(TextBox data, RichTextBox motivo, RichTextBox pensamento, RichTextBox acao) 
        {
            data.Text = null;
            motivo.Text = null;
            pensamento.Text = null;
            acao.Text = null;
        }

        #region - Aba Todos

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados, txtData, txtMotivo, txtPensamento, txtAcao);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Trim() != string.Empty)
            {
                Controller_Desanimo ds = new Controller_Desanimo();
                ds.AtualizarAcaoDesanimo(id, Misc.FormatData(txtData.Text), Criptografia.EncriptarCampo(txtAcao.Text));
                this.SetDefaultState(txtData, txtMotivo, txtPensamento, txtAcao);
                this.MostrarTodosDados(id);
                dgvDados2.DataSource = null;
            }
        }

        private void txtAcao_TextChanged(object sender, EventArgs e)
        {
            maxCharsAcao = 250 - txtAcao.Text.Length;
            lblCharCount.Text = "max " + maxCharsAcao + " chars";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Misc.ImportarDados(dgvDados);
        }

        #endregion

        #region - Aba Data

        private void btnPesquisarData_Click(object sender, EventArgs e)
        {
            try
            {
                //Data formatada para o sql yyyy-MM-dd
                string dataDesejada = DateTime.Parse(txtDataRegistro.Text).ToString("yyyy-MM-dd");
                //Precisamos da data seguinte a digitada pelo usuário pois a query possui um BETWEEN entre estas datas
                string amanha = DateTime.Parse(txtDataRegistro.Text).AddDays(1).ToString("yyyy-MM-dd");

                this.MostrarDadosporData(id, dataDesejada, amanha);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite uma data válida!");//tratar melhor
            }
        }

        private void dgvDados2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados2, txtData2, txtMotivo2, txtPensamento2, txtAcao2);
        }

        private void btnAtualizar2_Click(object sender, EventArgs e)
        {
            if (txtData2.Text.Trim() != string.Empty)
            {
                Controller_Desanimo ds = new Controller_Desanimo();
                ds.AtualizarAcaoDesanimo(id, Misc.FormatData(txtData2.Text), Criptografia.EncriptarCampo(txtAcao2.Text));
                this.SetDefaultState(txtData2, txtMotivo2, txtPensamento2, txtAcao2);
                this.MostrarTodosDados(id);
                dgvDados2.DataSource = null;
            }
        }

        private void txtAcao2_TextChanged(object sender, EventArgs e)
        {
            maxCharsAcao = 250 - txtAcao2.Text.Length;
            lblCharCount2.Text = "max " + maxCharsAcao + " chars";
        }

        private void btnExportar2_Click(object sender, EventArgs e)
        {
            Misc.ImportarDados(dgvDados2);
        }

        #endregion

    }
}
