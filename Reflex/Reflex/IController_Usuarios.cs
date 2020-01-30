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
 * Interface responsável por encapsular os métodos da tabela usuários
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cypher;
using System.Data;
using System.Data.SQLite;

/*
 * Reflex / IController / Usuarios
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public interface IController_Usuarios
    {

        void Login(string login, string senha, Form f);

        void CadastrarUsuario(Usuario u);

        SQLiteDataReader GetDadosUsuario(string id);

        void AtualizarDadosUsuario(Usuario u);

        void DeletarUsuario(string id);

    }
}
