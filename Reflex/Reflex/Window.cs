/*
 * Reflex - Software de auto ajuda.
 * Copyright (C) 2020  Quantum Comp IT Solutions
 
 * Este arquivo é parte do programa Reflex
 * Reflex é um software livre; você pode redistribuí-lo e/ou
 * modificá-lo dentro dos termos da Licença Pública Geral GNU como
 * publicada pela Free Software Foundation (FSF); na versão 3 da
 * Licença, ou qualquer versão posterior.

 * Este programa é distribuído na esperança de que possa ser útil,
 * mas SEM NENHUMA GARANTIA; sem uma garantia implícita de ADEQUAÇÃO
 * a qualquer MERCADO ou APLICAÇÃO EM PARTICULAR. Veja a
 * Licença Pública Geral GNU para maiores detalhes.

 * Você deve ter recebido uma cópia da Licença Pública Geral GNU junto
 * com este programa, Se não, veja <https://www.gnu.org/licenses/gpl-3.0.txt>.
 */

/*
 * Classe responsável pela instância de novas janelas
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Reflex / Application / Window
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public class Window
    {
        public static void abrirLogin()
        {
            Application.Run(new FrmLogin());
        }

        public static void abrirHome() 
        {
            FrmHome h = new FrmHome();
            h.Show();
        }

        public static void abrirCadastroUsuario(Form f) 
        {
            foreach (Form form in Application.OpenForms) 
            {
                if (form.GetType() == typeof(FrmCadastroUsuario)) 
                {
                    form.Activate();
                    return;
                }
            }

            FrmCadastroUsuario u = new FrmCadastroUsuario();
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirAtualizarUsuario(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmAtualizarUsuario))
                {
                    form.Activate();
                    return;
                }
            }

            FrmAtualizarUsuario u = new FrmAtualizarUsuario(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirNovaMeta(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmNovaMeta))
                {
                    form.Activate();
                    return;
                }
            }

            FrmNovaMeta u = new FrmNovaMeta(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirMinhasMetas(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmMeuProgresso))
                {
                    form.Activate();
                    return;
                }
            }

            FrmMeuProgresso u = new FrmMeuProgresso(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirDeletarMeta(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmDeletarMeta))
                {
                    form.Activate();
                    return;
                }
            }

            FrmDeletarMeta u = new FrmDeletarMeta(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirSentimentoHoje(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmSentimentoHoje))
                {
                    form.Activate();
                    return;
                }
            }

            FrmSentimentoHoje u = new FrmSentimentoHoje(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirSentimentoRegistros(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmSentimentoRegistros))
                {
                    form.Activate();
                    return;
                }
            }

            FrmSentimentoRegistros u = new FrmSentimentoRegistros(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirSentimentoDeletar(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmSentimentoDeletar))
                {
                    form.Activate();
                    return;
                }
            }

            FrmSentimentoDeletar u = new FrmSentimentoDeletar(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirRegistrarAlegria(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmAlegriaRegistrar))
                {
                    form.Activate();
                    return;
                }
            }

            FrmAlegriaRegistrar u = new FrmAlegriaRegistrar(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirRegistrosAlegria(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmAlegriaRegistros))
                {
                    form.Activate();
                    return;
                }
            }

            FrmAlegriaRegistros u = new FrmAlegriaRegistros(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirDeletarAlegria(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmAlegriaDeletar))
                {
                    form.Activate();
                    return;
                }
            }

            FrmAlegriaDeletar u = new FrmAlegriaDeletar(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirRegistrarDesanimo(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmDesanimoRegistrar))
                {
                    form.Activate();
                    return;
                }
            }

            FrmDesanimoRegistrar u = new FrmDesanimoRegistrar(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirRegistrosDesanimo(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmDesanimoRegistros))
                {
                    form.Activate();
                    return;
                }
            }

            FrmDesanimoRegistros u = new FrmDesanimoRegistros(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirDeletarDesanimo(Form f, string id)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FrmDesanimoDeletar))
                {
                    form.Activate();
                    return;
                }
            }

            FrmDesanimoDeletar u = new FrmDesanimoDeletar(id);
            u.MdiParent = f;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        public static void abrirSobre(Form f)
        {
            using (FrmSobre box = new FrmSobre())
            {
                box.ShowDialog(f);
            }
        }

        public static void abrirSobreCVV(Form f)
        {
            using (FrmSobreCVV box = new FrmSobreCVV())
            {
                box.ShowDialog(f);
            }
        }

        public static void abrirAtalhosTeclado(Form f)
        {
            using (FrmAtalhosTeclado box = new FrmAtalhosTeclado())
            {
                box.ShowDialog(f);
            }
        }

        public static void abrirLicenca(Form f)
        {
            using (FrmLicencaGPL box = new FrmLicencaGPL())
            {
                box.ShowDialog(f);
            }
        }

        public static void abrirRedesSociais(Form f)
        {
            using (FrmSocialMedia box = new FrmSocialMedia())
            {
                box.ShowDialog(f);
            }
        }

        #region - Dialogs

        public static void abrirWarningLoginInvalido()
        {
            using (FrmWarningLoginInvalido box = new FrmWarningLoginInvalido())
            {
                box.ShowDialog();
            }
        }

        public static void abrirWarningValidacao(string item)
        {
            using (FrmWarningValidacao box = new FrmWarningValidacao())
            {
                box.lblMsgOne.Text = "Erro de " + item;
                box.lblMsgTwo.Text = item + " inválido !";
                box.ShowDialog();
            }
        }

        public static void abrirCadastroOK()
        {
            using (FrmWarningCadastroOk box = new FrmWarningCadastroOk())
            {
                box.ShowDialog();
            }
        }

        public static void abrirOperacaoInvalida()
        {
            using (FrmWarningOperacaoInvalida box = new FrmWarningOperacaoInvalida())
            {
                box.ShowDialog();
            }
        }

        public static void abrirOperacaoOK()
        {
            using (FrmWarningOK box = new FrmWarningOK())
            {
                box.ShowDialog();
            }
        }

        public static void abrirDadosAtualizados()
        {
            using (FrmWarningDadosAtualizados box = new FrmWarningDadosAtualizados())
            {
                box.ShowDialog();
            }
        }

        public static void abrirMetaRealizada()
        {
            using (FrmWarningMetaRealizada box = new FrmWarningMetaRealizada())
            {
                box.ShowDialog();
            }
        }

        public static void abrirAtualizacaoDesanimo()
        {
            using (FrmWarningAtualizacaoDesanimoAlegria box = new FrmWarningAtualizacaoDesanimoAlegria())
            {
                box.ShowDialog();
            }
        }

        public static void abrirDadosExcluidos()
        {
            using (FrmWarningDadosExcluidosOK box = new FrmWarningDadosExcluidosOK())
            {
                box.ShowDialog();
            }
        }

        //Passar id para o construtor
        public static void abrirWarningExcluir(string id)
        {
            using (FrmWarningExcluir box = new FrmWarningExcluir(id))
            {
                box.ShowDialog();
            }
        }

        public static void abrirWarningExcluirRegistro(string id, string dataRegistro, string tabela)
        {
            using (FrmWarningExcluirRegistro box = new FrmWarningExcluirRegistro(id, dataRegistro, tabela))
            {
                box.ShowDialog();
            }
        }

        public static void abrirWarningSair(Form f) 
        {
            using (FrmWarningSair box = new FrmWarningSair()) 
            {
                box.ShowDialog(f);
            }
        }

        #endregion
    }
}
