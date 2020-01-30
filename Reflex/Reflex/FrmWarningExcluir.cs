/*
 * Formulário de pergunta exclusão de usuario
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * Reflex / Application / FrmWarningExcluir
 * @author MRX
 * Version : 1.0.0
 */


namespace Reflex
{
    partial class FrmWarningExcluir : Form
    {

        private string id;
      
        public FrmWarningExcluir(string id)
        {
            InitializeComponent();
            this.id = id;
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

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Excluir todos registros do usuario primero para deletá-lo da base de dados
            Controller_Metas ms = new Controller_Metas();
            ms.DeletarTodasMetas(id);
            Controller_Humor hs = new Controller_Humor();
            hs.DeletarHumorTodosRegistros(id);
            Controller_Alegria bs = new Controller_Alegria();
            bs.DeletarAlegriaTodosRegistros(id);
            Controller_Desanimo ds = new Controller_Desanimo();
            ds.DeletarDesanimoTodosRegistros(id);
            Controller_Usuarios us = new Controller_Usuarios();
            us.DeletarUsuario(id);
        }
    }
}
