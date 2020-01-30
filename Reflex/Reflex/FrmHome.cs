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
 * Formulário inicial da aplicação
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
 * Reflex / Application / FrmHome
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmHome : Form
    {
      
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            
            //Verificar se é aniversário do usuario
            Motivacao m = new Motivacao();
            if (Special.IsBirthday(lblNascimento.Text))
            {
                //Sortear uma frase de feliz aniversário
                MessageBox.Show(m.HappyBirthDay(), "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else 
            {
                //Sortear uma frase
                MessageBox.Show(m.AddFrasesAndSortOne(), "Motivação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
           
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirCadastroUsuario(this);
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirAtualizarUsuario(this, lblID.Text);
        }

        private void adicionarMetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirNovaMeta(this, lblID.Text);
        }

        private void meuProgressoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirMinhasMetas(this, lblID.Text);
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirDeletarMeta(this, lblID.Text);
        }

        private void comoVocêSeSenteHojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirSentimentoHoje(this, lblID.Text);
        }

        private void meusRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirSentimentoRegistros(this, lblID.Text);
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Window.abrirSentimentoDeletar(this, lblID.Text);
        }

        private void novaAlegriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirRegistrarAlegria(this, lblID.Text);
        }

        private void meusRegistrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Window.abrirRegistrosAlegria(this, lblID.Text);
        }

        private void removerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Window.abrirDeletarAlegria(this, lblID.Text);
        }

        private void registrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirRegistrarDesanimo(this, lblID.Text);
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirRegistrosDesanimo(this, lblID.Text);
        }

        private void removerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Window.abrirDeletarDesanimo(this, lblID.Text);
        }

        private void sobreOCVVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirSobreCVV(this);
        }

        private void visitarWebSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenCVVWebPage();
        }

        private void sobreOReflexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirSobre(this);
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenDocumentation();
        }

        private void atalhosDeTecladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirAtalhosTeclado(this);
        }

        private void relatarUmProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenRelatarProblema();
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenRepository();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirLicenca(this);
        }

        private void redesSociaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window.abrirRedesSociais(this);
        }

        private void verMensagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motivacao m = new Motivacao();
            MessageBox.Show(m.AddFrasesAndSortOne(), "Motivação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Window.abrirWarningSair(this);
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
