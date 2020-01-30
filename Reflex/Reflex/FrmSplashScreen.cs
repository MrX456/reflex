/*
 * Splash screen da aplicação
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

/*
 * Reflex / Application / FrmSplashScreen
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public partial class FrmSplashScreen : Form
    {

        Thread t;

        public FrmSplashScreen()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private void Carregar() 
        {
            if (pbLoading.Value < 100)
            {
                pbLoading.Value += 2;

                if (pbLoading.Value == 10) 
                {
                    lblStatus.Text = "carregando dados...";
                    lblStatus.BackColor = Color.Transparent;
                }

                if (pbLoading.Value == 40)
                {
                    lblStatus.Text = "carregando componentes...";
                    lblStatus.BackColor = Color.Transparent;
                }

                if (pbLoading.Value == 80)
                {
                    lblStatus.Text = "carregando preferências...";
                    lblStatus.BackColor = Color.Transparent;
                }
                //Transição de imagem
                if (pbLoading.Value == 50) 
                {
                    this.BackgroundImage = Properties.Resources.image_2;
                }

            }
            else 
            {
                //Abrir formlário principal
                timeLoad.Enabled = false;

                t = new Thread(Window.abrirLogin);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                this.Close();
            }
        }

        private void timeLoad_Tick(object sender, EventArgs e)
        {
            this.Carregar();
        }
    }
}
