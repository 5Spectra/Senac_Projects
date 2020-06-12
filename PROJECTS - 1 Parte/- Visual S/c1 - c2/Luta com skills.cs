using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
/*-------------------------------------------------------
RPG de turnos testes
2 skills

1 - dano entre 1 e 3
2 - dano entre 4 e 6 dois usos

Boss 1 skill

1 - dano entre 1 mas tem chance critica 2x o dano
--------------------------------------------------------*/

            //variaveis

            int sua_vida = 20, boss_life = 40, usos = 3;
            int sua_skill, dano, critico;
            Random RN = new Random();
        denovo:
            if (sua_vida <= 0)
            { //derrota
                Console.WriteLine("Defeat");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("Vida do Boss: "+ boss_life);
            Console.WriteLine("Sua vida: "+ sua_vida + "\n");
            do
            {
                sem_usos:
                Console.WriteLine("Dano entre 1-3 | Dano entre 4-6 restam " + usos + " usos");
                Console.WriteLine("Skill - 1 | Skill - 2");
                Console.WriteLine("Digite o numero da sua skill");
                sua_skill = Convert.ToInt32(Console.ReadLine());

                if (sua_skill == 1)
                {
                    dano = RN.Next(1, 3);
                    boss_life = boss_life - dano;
                    Console.WriteLine("Você deu: " + dano + " de dano\n");
                }
                else if (sua_skill == 2 && usos > 0)
                {
                    dano = RN.Next(4, 6);
                    boss_life = boss_life - dano;
                    usos = usos - 1;
                    Console.WriteLine("Você deu: " + dano + " de dano\n");
                }
                else if (usos <= 0)
                {
                    Console.WriteLine("Não pode usar mais essa skill");
                    goto sem_usos;
                }
                else
                {
                    Console.WriteLine("Skill invalida");
                }
            } while (sua_skill < 1 || 2 < sua_skill);

            if (boss_life <= 0)
            { //vitoria
                Console.WriteLine("Vitoria");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (boss_life > 0)
            { //boss ataca
                Console.WriteLine("Boss ataque");
                critico = RN.Next(1, 10);
                dano = 1;
                if (critico < 6)
                { //não critou
                    sua_vida = sua_vida - dano;
                    Console.WriteLine("Deu: " + dano + " de dano\n");
                }
                else
                { //critou
                    dano = dano * 2;
                    sua_vida = sua_vida - dano;
                    Console.WriteLine("Deu: " + dano + " de dano\n");
                }
                    goto denovo;
                }
            }
        }
    }
