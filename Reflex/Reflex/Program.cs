/*
 * #KobeForever
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Reflex
{
    static class Program
    {

        static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool iniciar = false;
            mutex = new Mutex(true, Application.ProductName.ToString(), out iniciar);

            if (iniciar)
            {
                //Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmSplashScreen());
            }
            else 
            {
                MessageBox.Show("Uma instância da aplicação " + Application.ProductName.ToString() + " já está em execução. Não é possivel iniciar nova instância!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
