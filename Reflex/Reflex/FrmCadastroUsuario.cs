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
 * Formulário responsável pelo cadastro de novos usuários
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

/*
 * Reflex / Application / FrmCadastroUsuario
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmCadastroUsuario : Form
    {

        private string sexo = "Masculino";

        public FrmCadastroUsuario()
        {
            InitializeComponent();
            txtNome.Select();
        }

        private Usuario SetUsuario(string nome, string login, string senha, string nascimento, string sexo) 
        {
            Usuario u = new Usuario();
            u.Nome = nome;
            u.Login = login;
            u.Senha = Criptografia.EncriptarCampo(senha);
            u.Nascimento = nascimento;
            u.Sexo = sexo;

            return u;
        }

        private void SetDefaultState() 
        {
            txtNome.Text = null;
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtDataNasc.Text = null;
            radMasc.Select();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.SetDefaultState();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Controller_Validacao.ValidarUsuario(txtNome.Text, txtLogin.Text, txtSenha.Text, txtDataNasc.Text)) 
            {
                Usuario u = new Usuario();
                u = this.SetUsuario(txtNome.Text, txtLogin.Text, txtSenha.Text, txtDataNasc.Text, sexo);
                Controller_Usuarios us = new Controller_Usuarios();
                us.CadastrarUsuario(u);
            }

        }

        private void radMasc_CheckedChanged(object sender, EventArgs e)
        {
            sexo = radMasc.Text;
        }

        private void radFem_CheckedChanged(object sender, EventArgs e)
        {
            sexo = radFem.Text;
        }
    }
}
