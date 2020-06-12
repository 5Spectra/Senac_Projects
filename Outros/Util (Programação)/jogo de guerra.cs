using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
 /*-------------------
  2 players
  2 exercitos
  Comida = pao
  comida inicial = 100
  exercito inicial = 10
  atacar rouba pães 1 pão a cada 2 soldados da defesa mortos
  1 comida = soldado
  no final do dia a comida é dobrada
  Defender 1 soldado = 1,5
  Desconhece o inimigo (ou deveria não tenho controle)
  --------------------*/
            string player1, player2, player1name, player2name, regra, vez;
            int exerp1, exerp2, qexer1 = 0, qexer2 = 0;
            int paop1, paop2, pao, turno = 1;
            int sobr1, sobr2, roubo1, roubo2;
            Random RN = new Random();


            exerp1 = RN.Next(15, 40);
            exerp2 = RN.Next(15, 40);
            paop1 = RN.Next(40, 80);
            paop2 = RN.Next(40, 80);

            Console.WriteLine("Bem vindo ao jogo Guerra Nada Visual\n");
            Console.ReadKey();
        menu:
            Console.WriteLine("As condições de vitoria são:\n-Não deixe seus pães chegarem a 0\n-Não deixe seu exercito chegar a 0\n");
            Console.WriteLine("Começar digite 1 |  Ver as regras digite 2");
            regra = Console.ReadLine();
            switch (regra)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("Bem vindo a jogo Guerra Nada Visual\n");
                    goto menu;
                case "2":
                    Console.Clear(); Console.WriteLine("Como jogar:");
                    Console.WriteLine("-Isso é um jogo de turno de 2 players");
                    Console.WriteLine("-Escolha se irá atacar ou não\n-Se atacar escolha quantos soldados enviar");
                    Console.WriteLine("-Produza soldados ao custo de pães\n-Encerre seu turno");
                    Console.WriteLine("\n-Em seguida irá rolar a embate\nO pão é multiplicado por 2 antes do embate\n-No final descubra quantos pães você roubou ou perdeu\n-Seus soldados serão divididos por 2 ao fim do turno");
                    Console.WriteLine("\nAperte qualquer tecla para voltar"); Console.ReadKey(); Console.Clear(); goto menu;
                case "1":
                    Console.Clear(); goto start;
            }

        start:
            Console.Clear();
            Console.WriteLine("Player 1 digite seu nome");
            player1name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Player 2 digite seu nome");
            player2name = Console.ReadLine();

        //começo
        temp1:
            Console.WriteLine("\nTurno número: " + turno); Console.ReadKey();
            Console.Clear(); Console.WriteLine("Preparado " + player1name); Console.ReadKey(); Console.Clear();//tempinho do player1

        player1menu:
            Console.Clear();
            Console.WriteLine("Vez do: " + player1name);
            Console.WriteLine("\nSoldados " + exerp1 + "\nPães " + paop1 + "\nSelecionados: " + qexer1);
            Console.WriteLine("\n1 - Atacar |  2 - Defender |  3 - Produzir Soldados |  4 - Encerrar vez");
            player1 = Console.ReadLine();
            switch (player1)
            {
                case "1":
                    Console.WriteLine("-Atacar é selecionar unidades para a fortaleza inimiga\n");
                    Console.WriteLine("Vai atacar quantos irá levar?");
                    qexer1 = Convert.ToInt32(Console.ReadLine());

                    if (qexer1 > exerp1) { Console.WriteLine("Não a soldados suficientes / Produza mais"); qexer1 = 0; Console.ReadKey(); goto player1menu; }
                    else { Console.WriteLine("Foram selecionados: " + qexer1); Console.ReadKey(); exerp1 = exerp1 - qexer1; goto player1menu; }

                case "2":
                    Console.WriteLine("-Defender é não envia tropas\n");
                    Console.WriteLine(player1name + " irá defender");
                    exerp1 = exerp1 + qexer1;
                    qexer1 = 0;
                    Console.ReadKey();
                    goto player1menu;

                case "3":
                    Console.WriteLine("Quantos soldados deseja produzir? / 2 pão = 1 soldado ");
                    pao = Convert.ToInt32(Console.ReadLine());
                    if (pao > paop1) { Console.WriteLine("Não a pães suficentes"); Console.ReadKey(); goto player1menu; }
                    else
                    {
                        exerp1 = exerp1 + pao; paop1 = paop1 - (pao * 2);
                        Console.WriteLine("Foram produzidos " + pao + " Soldados"); Console.ReadKey(); goto player1menu;
                    }

                case "4":
                    Console.WriteLine("Encerra sua vez? | 1 - sim | 2 - não");
                    vez = Console.ReadLine();
                    if (vez == "1") { goto temp2; }
                    else if (vez == "2") { goto player1menu; }
                    else { goto player1menu; }

                default:
                    goto player1menu;
            }

        temp2:
            Console.Clear(); Console.WriteLine("Preparado " + player2name); Console.ReadKey(); Console.Clear();//tempinho do player2
        player2menu:
            Console.Clear();
            Console.WriteLine("Vez do: " + player2name);
            Console.WriteLine("\nSoldados " + exerp2 + "\nPães " + paop2 + "\nSelecionados: " + qexer2);
            Console.WriteLine("\n1 - Atacar |  2 - Defender |  3 - Produzir Soldados |  4 - Encerrar vez");
            player2 = Console.ReadLine();
            switch (player2)
            {
                case "1":
                    Console.WriteLine("-Atacar é selecionar unidades para a fortaleza inimiga\n");
                    Console.WriteLine("Vai atacar quantos irá levar?");
                    qexer2 = Convert.ToInt32(Console.ReadLine());

                    if (qexer2 > exerp2) { Console.WriteLine("Não a soldados suficientes / Produza mais"); qexer2 = 0; Console.ReadKey(); goto player2menu; }
                    else { Console.WriteLine("Foram selecionados: " + qexer2); Console.ReadKey(); exerp2 = exerp2 - qexer2; goto player2menu; }

                case "2":
                    Console.WriteLine("-Defender é não envia tropas\n");
                    Console.WriteLine(player2name + " irá defender");
                    exerp2 = exerp2 + qexer2;
                    qexer2 = 0;
                    Console.ReadKey();
                    goto player2menu;

                case "3":
                    Console.WriteLine("Quantos soldados deseja produzir? / 2 pão = 1 soldado ");
                    pao = Convert.ToInt32(Console.ReadLine());
                    if (pao > paop2) { Console.WriteLine("Não a pães suficentes"); Console.ReadKey(); goto player2menu; }
                    else if (pao > 50) { Console.WriteLine("Acima do limite"); Console.ReadKey(); goto player2menu; }
                    else
                    {
                        exerp2 = exerp2 + pao; paop2 = paop2 - (pao * 2);
                        Console.WriteLine("Foram produzidos " + pao + " Soldados"); Console.ReadKey(); goto player2menu;
                    }
                case "4":
                    Console.WriteLine("Encerra sua vez? | 1 - sim | 2 - não");
                    vez = Console.ReadLine();
                    if (vez == "1") { goto guerra; }
                    else if (vez == "2") { goto player2menu; }
                    else { goto player2menu; }

                default:
                    goto player2menu;
            }

        guerra:
            Console.Clear();
            paop1 = paop1 * 2;
            paop2 = paop2 * 2;

            int matou1, matou2;

            sobr1 = exerp1 - qexer2;
            sobr2 = exerp2 - qexer1;

            matou1 = qexer1;
            matou2 = qexer2;

            roubo1 = qexer2 / 2;
            roubo2 = qexer1 / 2;


            //balanceamento
            matou1 = qexer1; matou2 = qexer2;
            qexer1 = 0; qexer2 = 0;

            //Relatorio
            Console.WriteLine(player1name + " Relatorio\n");
            Console.ReadKey();
            Console.WriteLine(paop1 + " = Pães Remancentes");
            Console.WriteLine(qexer1 + " = Soldados que voltarão do ataque");
            Console.WriteLine(sobr1 + " = Soldados Sobreviveram\n");
            Console.WriteLine(matou1 + " = matou do inimigo / de " + exerp2);
            Console.WriteLine(roubo2 + " = Pães Roubados");
            Console.ReadKey();

            Console.Clear();
            Console.ReadKey();
            Console.WriteLine(player2name + " Relatorio\n");
            Console.ReadKey();
            Console.WriteLine(paop2 + " = Pães Remancentes");
            Console.WriteLine(qexer2 + " = Soldados que voltarão do ataque");
            Console.WriteLine(sobr2 + " = Soldados Sobreviveram\n");
            Console.WriteLine(matou2 + " = matou do inimigo / de " + exerp1);
            Console.WriteLine(roubo1 + " = Pães Roubados");
            Console.ReadKey();
            Console.Clear();

            //roubos reajuste
            exerp1 = sobr1 / 2;
            exerp2 = sobr2 / 2;

            paop1 = paop1 + roubo1;
            paop2 = paop2 + roubo2;

            paop1 = paop1 - roubo2;
            paop2 = paop2 - roubo1;


            //vitoria?
            //condição soldados
            if (sobr1 < 1 && sobr2 > 0) { Console.WriteLine(player1name + " Venceu | " + player2name + " Não tem mais soldados" + "\n\nTotal de Turnos: " + turno); Console.ReadKey(); Environment.Exit(0); }
            else if (sobr2 < 1 && sobr1 > 0) { Console.WriteLine(player2name + " Venceu | " + player1name + " Não tem mais soldados" + "\n\nTotal de Turnos: " + turno); Console.ReadKey(); Environment.Exit(0); }
            //condição comida
            else if (paop1 < 1 && paop2 > 0) { Console.WriteLine(player1name + " Venceu | " + player2name + " Não tem mais pães" + "\n\nTotal de Turnos: " + turno); Console.ReadKey(); Environment.Exit(0); }
            else if (paop2 < 1 && paop1 > 0) { Console.WriteLine(player2name + " Venceu | " + player1name + " Não tem mais pães" + "\n\nTotal de Turnos: " + turno); Console.ReadKey(); Environment.Exit(0); }
            //condição de empate
            else if (paop1 < 1 && paop2 < 1) { Console.WriteLine(player1name + player2name + " Empataram" + " Ambos não tem mais pães para continuarem" + "\nTurnos: " + turno); Console.ReadKey(); Environment.Exit(0); }
            else if (sobr1 < 1 && sobr2 < 1) { Console.WriteLine(player1name + player2name + " Empataram" + " Ambos não tem mais soldados para lutar" + "\nTurnos: " + turno); Console.ReadKey(); Environment.Exit(0); }
            else { Console.WriteLine(" Fim da Turno\n Não houve vencedor\n Proximo Turno"); Console.ReadKey(); turno = turno + 1; goto temp1; }





        }
    }
}