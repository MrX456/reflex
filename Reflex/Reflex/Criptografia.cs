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
 * Classe responsável por encriptar e decriptar dados.
 * Diversos dados inseridos no banco devem ser encriptados,
 * para operações de atualização estes dados devem ser retornados
 * decriptados e depois encriptados novamente para serem guardados.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cypher;

/*
 * Reflex / Application / Criptografia
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public class Criptografia
    {
        private const string chave = "Gtr34";
        static Crypto cripto;

        public static string EncriptarCampo(string campo) 
        {
            cripto = new Crypto(CryptProvider.RC2);
            cripto.Key = chave;

            //Retornar valor encriptado
            return cripto.Encrypt(campo);
        }

        public static string DecriptarCampo(string campo) 
        {
            cripto = new Crypto(CryptProvider.RC2);
            cripto.Key = chave;

            //Retornar valor decriptado
            return cripto.Decrypt(campo);
        }
    }
}
