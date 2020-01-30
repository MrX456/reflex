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
 * Formulário de registros alegria
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
 * Reflex / Application / FrmAlegriaRegistros
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmAlegriaRegistros : Form
    {

        private string id;

        public FrmAlegriaRegistros(string id)
        {
            InitializeComponent();
            this.MostrarTodosDados(id);
            this.id = id;
        }

        private void MostrarTodosDados(string id)
        {
            DataTable dt = new DataTable();
            Controller_Alegria ds = new Controller_Alegria();
            dt = ds.GetAlegriaTodosRegistros(id);
            dgvDados.DataSource = dt;

            //Descriptografar dados
            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                try
                {
                    ArrayList decrypt = new ArrayList();
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[1].Value.ToString()));
                   
                    row.Cells[1].Value = decrypt[0];
                }
                catch (Exception) { }
                finally
                {
                    //Titulo e largura das colunas
                    dgvDados.Columns[0].HeaderText = "Data registro";
                    dgvDados.Columns[1].HeaderText = "Descrição alegria";
                    dgvDados.Columns[1].Width = 250;
                   
                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void MostrarDadosporData(string id, string data, string dataAmanha) 
        {
            DataTable dt = new DataTable();
            Controller_Alegria ds = new Controller_Alegria();
            dt = ds.GetAlegriaporData(id, data, dataAmanha);
            dgvDados2.DataSource = dt;

            //Descriptografar dados
            foreach (DataGridViewRow row in dgvDados2.Rows)
            {
                try
                {
                    ArrayList decrypt = new ArrayList();
                    decrypt.Add(Criptografia.DecriptarCampo(row.Cells[1].Value.ToString()));

                    row.Cells[1].Value = decrypt[0];
                }
                catch (Exception) { }
                finally
                {
                    //Titulo e largura das colunas
                    dgvDados2.Columns[0].HeaderText = "Data registro";
                    dgvDados2.Columns[1].HeaderText = "Descrição alegria";
                    dgvDados2.Columns[1].Width = 250;

                    ConnectionFactory.DisposeConnection();
                }
            }
        }

        private void SetCampos(DataGridViewCellEventArgs e, DataGridView dgv, TextBox data, RichTextBox descricao)
        {
            try
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                data.Text = row.Cells["data_registro_alegria"].Value.ToString();
                descricao.Text = row.Cells["descricao_alegria"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados, txtData, txtMotivo);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Misc.ImportarDados(dgvDados);
        }

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
                MessageBox.Show("Digite uma data válida!");
            }
        }

        private void dgvDados2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e, dgvDados2, txtData2, txtMotivo2);
        }

        private void btnExportar2_Click(object sender, EventArgs e)
        {
            Misc.ImportarDados(dgvDados2);
        }

        
    }
}
