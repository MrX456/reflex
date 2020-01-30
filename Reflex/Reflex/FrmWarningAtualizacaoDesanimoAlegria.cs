/*
 * Formulário de de confirmação de atualização desanimo e alegria
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * Reflex / Application / FrmWarningAtualizacaoDesanimoAlegria
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    partial class FrmWarningAtualizacaoDesanimoAlegria : Form
    {
        public FrmWarningAtualizacaoDesanimoAlegria()
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
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
