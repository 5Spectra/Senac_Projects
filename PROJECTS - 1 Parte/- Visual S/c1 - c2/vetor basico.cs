using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //^^^^^^^^^^^^^^^^1^^^^^^^^^^^^^^^^
            /*
            Random RandomNumber = new Random();
            int sortx, sorty;
            int x, y;

            sortx = RandomNumber.Next(0, 2);
            sorty = RandomNumber.Next(0, 2);

            Console.WriteLine("Digite o primeiro n°");
                x = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Digite o primeiro n°");
                y = Convert.ToInt32 (Console.ReadLine());

            if (sortx == x && sorty == y)
            {
                Console.WriteLine("\n Acertou \n");
            }
            else
            {
                Console.WriteLine("\n Errouuuu \n");
                Console.WriteLine("Estava em: " + sortx + " " + sorty);
            }

            Console.ReadLine();
            */

            //----------------1----------------
            /*
            string[,] ve = new string[2, 2];
            int x, y;

            ve[0, 0] = "Acertou";
            ve[0, 1] = "Agua";
            ve[1, 0] = "Agua";
            ve[1, 1] = "Agua";

            Console.WriteLine("Digite o primeiro n°");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro n°");
            y = Convert.ToInt32(Console.ReadLine());

            if ( x == 0 && y == 0)
            {
                Console.WriteLine("\n Acertou \n");
            }
            else
            {
                Console.WriteLine("\n Errouuuu \n");
                Console.WriteLine("Estava em: " + ve[0, 0]);
            }
            Console.ReadLine();
            */

            //~~~~~~~~~~~~~~~~~~~~1~~~~~~~~~~~~~~~~~~~~~~

            string[] batalha = new string[10];

            for (int x = 0; x < 10; x++)
            {
                batalha[x] = "Agua";
            }

            Random numeroRandomico = new Random();
            int num = numeroRandomico.Next(9);

            batalha[num] = "Pow";

             inicio:
            Console.Clear();

            Console.WriteLine("Bem vindo ao jogo batalha naval!");
            Console.WriteLine("Digite um numero");
            string palpite = Console.ReadLine();

            if (batalha[Convert.ToInt32(palpite)] == "Pow")
            {
                Console.WriteLine("Voce ganhou");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Voce perdeu!");
                Console.ReadLine();
                goto inicio;
            }



        }
    }
}
