﻿/*
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
 * Formulário de exclusão alegria
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
 * Reflex / Application / FrmAlegriaDeletar
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmAlegriaDeletar : Form
    {

        private string id;

        public FrmAlegriaDeletar(string id)
        {
            InitializeComponent();
            this.MostrarDados(id);
            this.id = id;
        }

        private void MostrarDados(string id)
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

        private void SetCampos(DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvDados.Rows[e.RowIndex];

                txtData.Text = row.Cells["data_registro_alegria"].Value.ToString();
                txtMotivo.Text = row.Cells["descricao_alegria"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void SetDefaultState()
        {
            txtData.Text = null;
            txtMotivo.Text = null;
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SetCampos(e);
        }

        private void lblFecharAlert_Click(object sender, EventArgs e)
        {
            panAlert.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Trim() != string.Empty) 
            {
                Window.abrirWarningExcluirRegistro(id, Misc.FormatData(txtData.Text), "alegria");
                this.MostrarDados(id);
                this.SetDefaultState();
            }
        }
    }
}
