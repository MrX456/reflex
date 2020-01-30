/*
 * Formulario de encerramento da aplicação
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * Reflex / Application / FrmWarningSair
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    partial class FrmWarningSair : Form
    {
        public FrmWarningSair()
        {
            InitializeComponent();

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
            Application.Exit();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
