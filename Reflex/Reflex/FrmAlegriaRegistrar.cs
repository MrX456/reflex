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
 * Formulário registrar alegria
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
 * Reflex / Application / FrmAlegriaRegistrar
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmAlegriaRegistrar : Form
    {

        private int maxCharsDescricao;
        private string id;

        public FrmAlegriaRegistrar(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private Alegria SetAlegria(string descricao, string idUsuario)
        {
            Alegria a = new Alegria();
            a.IdUsuario = idUsuario;
            a.DescricaoAlegria = Criptografia.EncriptarCampo(descricao);

            return a;
        }

        private void SetDefaultState() 
        {
            txtDescricao.Text = null;
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            maxCharsDescricao = 250 - txtDescricao.Text.Length;
            lblCharCount.Text = "max " + maxCharsDescricao + " chars";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Controller_Validacao.ValidarAlegria(txtDescricao.Text)) 
            {
                Alegria a = this.SetAlegria(txtDescricao.Text, id);
                Controller_Alegria ds = new Controller_Alegria();
                ds.AddAlegria(a);
                this.SetDefaultState();
            }
        }
    }
}
