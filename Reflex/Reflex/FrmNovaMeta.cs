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
 * Formulário de criação de nova meta
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
 * Reflex / Application / FrmNovaMeta
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmNovaMeta : Form
    {

        private int maxCharsMeta;
        private int maxCharsMotivo;
        private string id;

        public FrmNovaMeta(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private Meta SetMeta(string descricao, string motivo, string idUsuario) 
        {
            Meta m = new Meta();
            m.MetaDescricao = Criptografia.EncriptarCampo(descricao);
            m.Motivo = Criptografia.EncriptarCampo(motivo);
            m.IdUsuario = idUsuario;

            return m;

        }

        private void SetDefaultState() 
        {
            txtNovaMeta.Text = null;
            txtMotivoMeta.Text = null;
        }

        private void txtNovaMeta_TextChanged(object sender, EventArgs e)
        {
            maxCharsMeta = 250 - txtNovaMeta.Text.Length;
            lblCharCount1.Text = "max " + maxCharsMeta + " chars";
        }

        private void txtMotivoMeta_TextChanged_1(object sender, EventArgs e)
        {
            maxCharsMotivo = 250 - txtMotivoMeta.Text.Length;
            lblCharCount2.Text = "max " + maxCharsMotivo + " chars";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Controller_Validacao.ValidarMeta(txtNovaMeta.Text, txtMotivoMeta.Text))
            {
                Meta m = this.SetMeta(txtNovaMeta.Text, txtMotivoMeta.Text, id);
                Controller_Metas ms = new Controller_Metas();
                ms.AddNovaMeta(m);
                this.SetDefaultState();
            }
        }

    }
}
