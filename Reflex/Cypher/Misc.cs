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
 * Classe responsável por métodos diversos
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

/*
 * Reflex / Cypher / Misc
 * @author MRX
 * Version : 1.0.0
 */

namespace Cypher
{
    public class Misc
    {
        public static void ImportarDados(DataGridView dgv) 
        {
            Microsoft.Office.Interop.Excel.Application xCellApp = new Microsoft.Office.Interop.Excel.Application();

            try
            {
                if (dgv.Rows.Count > 0)
                {
                    xCellApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dgv.Columns.Count + 1; i++)
                    {
                        xCellApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            if (dgv.Columns[j].HeaderText == "data_registro_meta")
                            {

                                DateTime dt = Convert.ToDateTime(dgv.Rows[i].Cells[j].Value.ToString());
                                xCellApp.Cells[i + 2, j + 1] = dt.ToString("MM/dd/yyyy");


                            }
                            else
                            {
                                xCellApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    xCellApp.Columns.AutoFit();

                    xCellApp.Visible = true;
                }

            }
            catch (Exception ex)
            {
                AbrirFormExcecao(PrintStackTrace(ex));
                xCellApp.Quit();
            }
        }

        public static void OpenRelatarProblema() 
        {
            try
            {
                System.Diagnostics.Process.Start(@"index.html");
            }
            catch (Exception e)
            {
                AbrirFormExcecao(PrintStackTrace(e));
                
            }
        }

        public static void OpenCVVWebPage() 
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.cvv.org.br/");
            }
            catch (Exception)
            {
                //Tratar corretamente
                
            }
        }

        public static void OpenRepository() 
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/MrX456/reflex");
            }
            catch (Exception)
            {
                //Tratar corretamente
                
            }
        }

        public static void OpenSocialFacebook()
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/quantumcomp.itsolutions/?");
            }
            catch (Exception)
            {
                //Tratar corretamente
                
            }
        }

        public static void OpenSocialTwitter()
        {
            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/quantumcompit");
            }
            catch (Exception)
            {
                //Tratar corretamente
                
            }
        }

        public static void OpenSocialInstagram()
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.instagram.com/quantumcompitsolutions/");
            }
            catch (Exception)
            {
                //Tratar corretamente
                
            }
        }

        public static void OpenSocialYoutube()
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCW5kvY7x53LG1CZGtsoqdpw/featured");
            }
            catch (Exception)
            {
                //Tratar corretamente
                
            }
        }

        public static void OpenSocialGithub()
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/MrX456");
            }
            catch (Exception)
            {
                //Tratar corretamente
                
            }
        }

        public static void OpenDocumentation()
        {
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Reflex - Documentos\\documentação_reflex_1.0.0.pdf";
                System.Diagnostics.Process.Start(docPath);
            }
            catch (Exception e)
            {
                AbrirFormExcecao(PrintStackTrace(e));

            }
        }

        public static string FormatData(string data) 
        {
            //Para fazer a atualização de dados, exclusão ou pesquisa é necessária a data no formato ano-mes-dia hh:MM:ss(Metas, Humor[apenas exclusão])
            try
            {
                string format = data.Substring(5, 6).Replace('/', ' ').Trim() + "-" + data.Substring(2, 3).Replace('/', ' ').Trim()
                        + "-" + data.Substring(0, 2) + data.Substring(10);
                return format;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public static string PrintStackTrace(Exception ex)
        {
            var stringBuilder = new StringBuilder();

            while (ex != null)
            {
                stringBuilder.AppendLine(ex.Message);
                stringBuilder.AppendLine(ex.StackTrace);

                ex = ex.InnerException;
            }

            return stringBuilder.ToString();
        }

        public static void AbrirFormExcecao(string exMessage) 
        {
            using (FrmExcecao box = new FrmExcecao(exMessage))
            {
                box.ShowDialog();
            }
        }
    }
}
