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
 * Classe responsável pelas frases motivacionais
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

/*
 * Reflex / Cypher / Motivacao
 * @author MRX
 * Version : 1.0.0
 */

namespace Cypher
{
    public class Motivacao
    {

        ArrayList arrFrases = new ArrayList();

        public string AddFrasesAndSortOne () 
        {

            arrFrases.Add("Vencedor não é aquele que sempre vence, mas sim aquele que nunca para de lutar.");
            arrFrases.Add("Não tenha medo da mudança. Coisas boas se vão para que melhores possam vir.");
            arrFrases.Add("Às vezes você tem que levantar sozinho e seguir em frente...");
            arrFrases.Add("Nunca diga eu não consigo. Você consegue sim, basta ter força de vontade e fé.");
            arrFrases.Add("Jamais desista de ser feliz.");
            arrFrases.Add("No fim tudo dá certo, e se não deu certo é porque ainda não chegou ao fim.");
            arrFrases.Add("Tudo é possível. O impossível apenas demora mais...");
            arrFrases.Add("Esquece, levanta a cabeça. Segue em frente. Amanhã é um novo dia.");
            arrFrases.Add("Não desista nunca!");
            arrFrases.Add("Ninguém é igual a você, e isso pode ser sua grande arma.");
            arrFrases.Add("Seu maior medo também pode ser sua maior motivação.");

            //ArrayList Length = 11(0 to 10). Mais frases a serem adicionadas. Frases serão armazenadas no banco de dados futuramente

            //Escolher um item randômico
            Random rand = new Random();
            int escolha = rand.Next(arrFrases.Count);

            return (string)arrFrases[escolha];

        }

        public string HappyBirthDay() 
        {

            //Retornar mensagens de aniversário(Se for aniversário do usuário)
            arrFrases.Add("Felicidades para você, por este dia tão especial que é o seu aniversário.");
            arrFrases.Add("Com todas as minhas forças, eu te desejo um feliz aniversário!");
            arrFrases.Add("Parabéns por hoje, mas felicidades sempre.");
            arrFrases.Add("Desejo um feliz aniversário com muito amor, alegria e saúde. Parabéns!");
            arrFrases.Add("Todos os grandes desejos começam no coração. E de coração eu te desejo: Feliz Aniversário!");

            //ArrayList Length = 5(0 to 4).

            //Escolher um item randômico
            Random rand = new Random();
            int escolha = rand.Next(arrFrases.Count);

            return (string)arrFrases[escolha];

        }

        public string FrasesEspeciais() 
        {

            //Retornar mensagens especiais
            arrFrases.Add("Eu sou solidário com o que você está passando. Não estou sentindo a sua dor, mas quero te ajudar com isso");
            arrFrases.Add("Como você se sentiu quando pensou nisso? As pessoas que te amam vão sofrer! Tem gente que quer te ouvir");
            arrFrases.Add("Ando sentindo você pra baixo nos últimos tempos e queria saber se quer conversar comigo sobre o que está acontecendo");
            arrFrases.Add("Eu sei que dói, e na maior parte das vezes a gente acha que não vai mais aguentar, mas se você acreditar em si mesmo, você consegue. Seja forte, uma hora, cedo ou tarde, tudo isso vai passar... As coisas melhoram e você aprende a ser feliz! Apenas mantenha-se vivo!");

            //Escolher um item randômico
            Random rand = new Random();
            int escolha = rand.Next(arrFrases.Count);

            return (string)arrFrases[escolha];

        }
        
    }
}
