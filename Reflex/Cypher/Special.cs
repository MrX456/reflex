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
 * Classe reponsável por alguns métodos especiais que 
 * só serão executados mediate ações específicas
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Reflex / Cypher / Special
 * @author MRX
 * Version : 1.0.0
 */

namespace Cypher
{
    public class Special
    {

        //Verificar se é aniversário do usuário
        public static bool IsBirthday(string birthday) 
        {
            string hoje = DateTime.Now.ToString("dd/MM");

            if (birthday.Substring(0, 5) == hoje)
                return true;
            else
                return false;
        }

        /*
         * Verificar o que o usuario está digitando e retornar
         * uma mensagem especifica
         */

        public static void VerificarStatusUsuario(string texto) 
        {
            if (texto.Contains("matar") || texto.Contains("suicidar") || texto.Contains("tirar minha vida")) 
            {
                Motivacao m = new Motivacao();
                string frase = m.FrasesEspeciais();
                MessageBox.Show(frase);
            }
        }
    }
}
