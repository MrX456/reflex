/*
 * Formulário de pergunta exclusão de registro todas tabelas
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * Reflex / Application / FrmWarningExcluirRegistro
 * @author MRX
 * Version : 1.0.0
 */


namespace Reflex
{
    partial class FrmWarningExcluirRegistro : Form
    {

        private string id;
        private string dataRegistro;
        private string tabela;

        public FrmWarningExcluirRegistro(string id, string dataRegistro, string tabela)
        {
            InitializeComponent();
            this.id = id;
            this.dataRegistro = dataRegistro;
            this.tabela = tabela;
        }

        private void btnSim_MouseEnter(object sender, EventArgs e)
        {
            btnSim.BackColor = Color.LimeGreen;
            btnSim.ForeColor = Color.White;
        }

        private void btnSim_MouseLeave(object sender, EventArgs e)
        {
            btnSim.BackColor = Color.Gainsboro;
            btnSim.ForeColor = Color.Gray;
        }

        private void btnNao_MouseEnter(object sender, EventArgs e)
        {
            btnNao.BackColor = Color.LimeGreen;
            btnNao.ForeColor = Color.White;
        }

        private void btnNao_MouseLeave(object sender, EventArgs e)
        {
            btnNao.BackColor = Color.Gainsboro;
            btnNao.ForeColor = Color.Gray;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (tabela == "meta")
            {
                Controller_Metas ms = new Controller_Metas();
                ms.DeletarMeta(id, dataRegistro);
                this.Dispose();
            }
            else if (tabela == "humor") 
            {
                Controller_Humor hs = new Controller_Humor();
                hs.DeletarHumor(id, dataRegistro);
                this.Dispose();
            }
            else if (tabela == "desanimo") 
            {
                Controller_Desanimo ds = new Controller_Desanimo();
                ds.DeletarDesanimo(id, dataRegistro);
                this.Dispose();
            }
            else if (tabela == "alegria") 
            {
                Controller_Alegria ds = new Controller_Alegria();
                ds.DeletarAlegria(id, dataRegistro);
                this.Dispose();
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
