using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------1--------------
            /*
            string resp;
            //cria um label
             inicio:
            Console.WriteLine("1 - sim");
            Console.WriteLine("2 - não");
            resp = Console.ReadLine();
             if (resp != "1") {
                Console.Clear();
                goto inicio;
           */
            //--------------2--------------
            /*
            Random Rnumber = new Random();

            int numero = Rnumber.Next(0,15);
             
            Console.WriteLine(numero);
            Console.ReadLine();
            */

            //--------------3--------------
            /*
            int num;
            Random RandomNumber = new Random();
            int sorteado;
            string resp;


        inicio:
            sorteado = RandomNumber.Next(0, 20);
            Console.WriteLine("Digite seu chute");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != sorteado)//se errou
            {
                Console.WriteLine("Você errou \nQuer tentar novamente");
                Console.WriteLine("1 - Sim \n2 - Não");
                resp = Console.ReadLine();
                if (resp == "1")
                {
                    Console.Clear();
                    goto inicio;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            if (num == sorteado) //se acertou
            {
                Console.WriteLine("Você conseguio");
                Console.ReadLine();

            }
            */
            //^^^^^^^^^^^^^^^^^^^^1^^^^^^^^^^^^^^^^^^^^
            /*
            int num;
            Random RandomNumber = new Random();
            int sorteado;
            string resp;


        inicio:
            sorteado = RandomNumber.Next(0, 10);
            Console.WriteLine("Digite seu chute");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= sorteado)//se colocou maior
            {
                Console.WriteLine("Muito alto");
                goto inicio;
            }
            else if (num <= sorteado)//se colocou menor
            {
                Console.WriteLine("Muito baixo");
                goto inicio;
            }

            else if (num == sorteado) //se acertou
            {
                Console.WriteLine("Você conseguio \nQuer tentar novamente");
                Console.WriteLine("1 - Sim \n2 - Não");
                resp = Console.ReadLine();
                if (resp != "2")
                {
                    Console.Clear();
                    goto inicio;
                }

            }
            */
            //-------------------4-------------------

            int num;
            int resul;
            string PI;

            Console.WriteLine("Digite um número \nVamos descobrir se é par ou impar");
            num = Convert.ToInt32(Console.ReadLine());

            resul = num % 2;
            if (resul == 0)
            {
                PI = "Par";
            }
            else
            {
                PI = "Ímpar";
            }
            Console.WriteLine("O numero é: " + PI);
            Console.ReadLine();










    }
    }
    }