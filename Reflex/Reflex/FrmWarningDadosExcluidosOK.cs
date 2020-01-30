/*
 * Formulário de confirmação exclusão de usuário
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * Reflex / Application / FrmWarningDadosExcluidosOK
 * @author MRX
 * Version : 1.0.0
 */


namespace Reflex
{
    partial class FrmWarningDadosExcluidosOK : Form
    {
        public FrmWarningDadosExcluidosOK()
        {
            InitializeComponent();
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.LimeGreen;
            btnOk.ForeColor = Color.White;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.Gainsboro;
            btnOk.ForeColor = Color.Gray;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
