/*
 * Formulário midias sociais 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Cypher;

/*
 * Reflex / Application / FrmSocialMedia
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    partial class FrmSocialMedia : Form
    {
        public FrmSocialMedia()
        {
            InitializeComponent();
        }

        private void picFacebook_Click(object sender, EventArgs e)
        {
            Misc.OpenSocialFacebook();
        }

        private void picTwitter_Click(object sender, EventArgs e)
        {
            Misc.OpenSocialTwitter();
        }

        private void picInstagram_Click(object sender, EventArgs e)
        {
            Misc.OpenSocialInstagram();
        }

        private void picYoutube_Click(object sender, EventArgs e)
        {
            Misc.OpenSocialYoutube();
        }

        private void picGitHub_Click(object sender, EventArgs e)
        {
            Misc.OpenSocialGithub();
        }
    }
}
