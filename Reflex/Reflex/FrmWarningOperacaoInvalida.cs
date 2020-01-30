/*
 * Formulário de operação inválida
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * Reflex / Application / FrmWarningOperacaoInvalida
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    partial class FrmWarningOperacaoInvalida : Form
    {
        public FrmWarningOperacaoInvalida()
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
