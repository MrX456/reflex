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
 * Formulário de registro de desanimo
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
 * Reflex / Application / FrmDesanimoRegistrar
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmDesanimoRegistrar : Form
    {

        private int maxCharsMotivo;
        private int maxCharsPensamento;
        private int maxCharsAcao;
        private string id;

        public FrmDesanimoRegistrar(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private Desanimo SetDesanimo(string motivo, string pensamento, string acao, string idUsuario) 
        {
            Desanimo d = new Desanimo();
            d.IdUsuario = idUsuario;
            d.Motivo = Criptografia.EncriptarCampo(motivo);
            d.Pensamento = Criptografia.EncriptarCampo(pensamento);
            d.Acao = Criptografia.EncriptarCampo(acao);

            return d;
        }

        private void SetDefaultState() 
        {
            txtMotivo.Text = null;
            txtPensamento.Text = null;
            txtAcao.Text = null;
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            maxCharsMotivo = 250 - txtMotivo.Text.Length;
            lblCharCount.Text = "max " + maxCharsMotivo + " chars";
        }

        private void txtPensamento_TextChanged(object sender, EventArgs e)
        {
            maxCharsPensamento = 250 - txtPensamento.Text.Length;
            lblCharCount1.Text = "max " + maxCharsPensamento + " chars";
        }

        private void txtAcao_TextChanged(object sender, EventArgs e)
        {
            maxCharsAcao = 250 - txtAcao.Text.Length;
            lblCharCount2.Text = "max " + maxCharsAcao + " chars";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Controller_Validacao.ValidarDesanimo(txtMotivo.Text, txtPensamento.Text)) 
            {
                Desanimo d = this.SetDesanimo(txtMotivo.Text, txtPensamento.Text, txtAcao.Text, id);
                Controller_Desanimo ds = new Controller_Desanimo();
                ds.AddDesanimo(d);
                this.SetDefaultState();
            }
        }

        private void txtMotivo_KeyUp(object sender, KeyEventArgs e)
        {
            Special.VerificarStatusUsuario(txtMotivo.Text);
        }

        private void txtPensamento_KeyUp(object sender, KeyEventArgs e)
        {
            Special.VerificarStatusUsuario(txtPensamento.Text);
        }

        private void txtAcao_KeyUp(object sender, KeyEventArgs e)
        {
            Special.VerificarStatusUsuario(txtAcao.Text);
        }
    }
}
