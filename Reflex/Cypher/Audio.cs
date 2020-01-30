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
 * Classe reponsável pela excução da música no Form Sobre
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

/*
 * Reflex / Cypher / Audio
 * @author MRX
 * Version : 1.0.0
 */

namespace Cypher
{
    public class Audio
    {

        static SoundPlayer about = new SoundPlayer(@"assets.media\about.wav");

        public static void PlaySobre() 
        {
            about.Play();
        }

        public static void StopSobre()
        {
            about.Stop();
        }
    }
}
