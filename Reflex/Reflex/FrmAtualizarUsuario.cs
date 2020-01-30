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
 * Formulário responsável pela atualização dos dados e exclusao de usuário
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

/*
 * Reflex / Application / FrmAtualizarUsuario
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmAtualizarUsuario : Form
    {

        private string sexo;
        //Vamos trazer o id de outro form para o construtor
        public FrmAtualizarUsuario(string id)
        {
            InitializeComponent();
            //Passar id como parâmetro para fazer query
            this.SetCampos(id);
        }

        private Usuario SetUsuario(string id, string nome, string login, string senha, string nascimento, string sexo)
        {
            Usuario u = new Usuario();
            u.IdUsuario = id;
            u.Nome = nome;
            u.Login = login;
            u.Senha = Criptografia.EncriptarCampo(senha);
            u.Nascimento = nascimento;
            u.Sexo = sexo;

            return u;
        }

        private void SetCampos(string id) 
        {

            try
            {
                Controller_Usuarios us = new Controller_Usuarios();
                SQLiteDataReader r = us.GetDadosUsuario(id);

                txtID.Text = r[0].ToString();
                txtNome.Text = r[1].ToString();
                txtLogin.Text = r[2].ToString();
                txtSenha.Text = Criptografia.DecriptarCampo(r[3].ToString()); //Decriptar dado
                txtDataNasc.Text = r[4].ToString();
                //Sexo
                if (r[5].ToString() == "Masculino")
                {
                    sexo = "Masculino";
                    radMasc.Select();
                }
                else
                {
                    sexo = "Feminino";
                    radFem.Select();
                }

                txtID2.Text = r[0].ToString();
                txtLogin2.Text = r[2].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        private void lblFecharAlert_Click(object sender, EventArgs e)
        {
            panAlert.Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (Controller_Validacao.ValidarUsuario(txtNome.Text, txtLogin.Text, txtSenha.Text, txtDataNasc.Text))
            {
                Usuario u = new Usuario();
                u = this.SetUsuario(txtID.Text, txtNome.Text, txtLogin.Text, txtSenha.Text, txtDataNasc.Text, sexo);
                Controller_Usuarios us = new Controller_Usuarios();
                us.AtualizarDadosUsuario(u);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Passar id para fazer exclusão(Excluira primeiro todos os registros de todas as tabelas deste usuário)
            Window.abrirWarningExcluir(txtID2.Text);
        }
    }
}
