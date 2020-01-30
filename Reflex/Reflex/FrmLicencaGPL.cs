/*
 * Formulário exibição licença GPL3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

/*
 * Reflex / Application / FrmLicencaGPL
 * @author MRX
 * Version : 1.0.0
 */


namespace Reflex
{
    partial class FrmLicencaGPL : Form
    {
        public FrmLicencaGPL()
        {
            InitializeComponent();
            this.PreencherLicenca();
            
        }

        private void PreencherLicenca() 
        {
            try
            {
                txtLicenca.Text = File.ReadAllText(@"COPYING.txt").ToString();
            }
            catch (Exception e) 
            {
                throw e;
            }
        }
    }
}
