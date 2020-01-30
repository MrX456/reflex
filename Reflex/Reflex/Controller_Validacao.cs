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
 * Classe responsável por fazer as validações para registro dos dados
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Reflex / Controller / Validacao
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public sealed class Controller_Validacao
    {

        public static bool ValidarUsuario(string nome, string login, string senha, string nascimento) 
        {
            if (nome.Trim() == String.Empty || nome.Length > 80) 
            {
                Window.abrirWarningValidacao("Campo nome");
                return false;
            }
            if (login.Trim() == String.Empty || login.Length > 20)
            {
                Window.abrirWarningValidacao("Campo login");
                return false;
            }
            if (senha.Trim() == String.Empty || senha.Length > 15)
            {
                Window.abrirWarningValidacao("Campo senha");
                return false;
            }
            if (nascimento.Trim().EndsWith("/"))
            {
                Window.abrirWarningValidacao("Campo Nascimento");
                return false;
            }
            return true;
        }

        public static bool ValidarMeta(string descricao, string motivo) 
        {
            if (descricao.Trim() == String.Empty || descricao.Length > 250)
            {
                Window.abrirWarningValidacao("Campo meta");
                return false;
            }
            if (motivo.Trim() == String.Empty || motivo.Length > 250)
            {
                Window.abrirWarningValidacao("Campo motivo");
                return false;
            }
            return true;
        }

        public static bool ValidarHumor(string resumoDia) 
        {
            if (resumoDia.Trim() == String.Empty || resumoDia.Length > 250) 
            {
                Window.abrirWarningValidacao("Campo resumo dia");
                return false;
            }
            return true;
        }

        public static bool ValidarDesanimo(string motivo, string pensamento)
        {
            if (motivo.Trim() == String.Empty || motivo.Length > 250)
            {
                Window.abrirWarningValidacao("Campo motivo");
                return false;
            }
            if (pensamento.Trim() == String.Empty || pensamento.Length > 250)
            {
                Window.abrirWarningValidacao("Campo pensamento");
                return false;
            }
            return true;
        }

        public static bool ValidarAlegria(string descricao)
        {
            if (descricao.Trim() == String.Empty || descricao.Length > 250)
            {
                Window.abrirWarningValidacao("Campo descrição");
                return false;
            }
            return true;
        }
    }
}
