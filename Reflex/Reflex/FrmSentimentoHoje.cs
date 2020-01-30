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
 * Formulário responsável pelos registros do sentimento do usuário hoje
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
 * Reflex / Application / FrmSentimentoHoje
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmSentimentoHoje : Form
    {

        private int maxCharsDia;
        private string id;

        public FrmSentimentoHoje(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private Humor SetHumor(string sentimento ,string resumoDia,string idUsuario) 
        {
            Humor h = new Humor();
            h.SentimentoAgora = Criptografia.EncriptarCampo(sentimento);
            h.ResumoDia = Criptografia.EncriptarCampo(resumoDia);
            h.IdUsuario = idUsuario;
            return h;
        }

        private void SetDefaultState()
        {
            cboSentimento.SelectedIndex = 0;
            txtResumoDia.Text = null;
        }

        private void FrmSentimentoHoje_Load(object sender, EventArgs e)
        {
            cboSentimento.SelectedIndex = 0;
        }

        private void txtResumoDia_TextChanged(object sender, EventArgs e)
        {
            maxCharsDia = 250 - txtResumoDia.Text.Length;
            lblCharCount1.Text = "max " + maxCharsDia + " chars";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Controller_Validacao.ValidarHumor(txtResumoDia.Text))
            {
                Humor h = this.SetHumor(cboSentimento.SelectedItem.ToString(), txtResumoDia.Text, id);
                Controller_Humor hs = new Controller_Humor();
                hs.AddHumorHoje(h);
                this.SetDefaultState();
            }
        }

        private void txtResumoDia_KeyUp(object sender, KeyEventArgs e)
        {
            Special.VerificarStatusUsuario(txtResumoDia.Text);
        }
    }
}
