/*
 * Formulário sobre o CVV
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

/*
 * Reflex / Application / FrmSobreCVV
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    partial class FrmSobreCVV : Form
    {
        public FrmSobreCVV()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
