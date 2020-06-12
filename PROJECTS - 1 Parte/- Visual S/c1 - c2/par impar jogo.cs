using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomNumber = new Random();
            int result, sort, n;
            string pim, win;
            string p1;

            sort = RandomNumber.Next(0, 10);
            Console.WriteLine("Escolha um número");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jogador escolha quer par ou impar");
            p1 = Console.ReadLine();

            result = (sort + n) % 2;

            if (result == 0)
            {
                pim = "Par";
            }
            else
            {
                pim = "Impar";
            }


            if (pim == "Par" && p1 == "par"){
                win = "Jogador";
            }

else if (pim == "Impar" && p1 == "impar")
            {
                win = "Jogador";
            }
            else
            {
                win = "Maquina";
            }

            Console.WriteLine("\nO numero é: " + pim);
            Console.WriteLine("Seu numero é : " + n +"\nO do computador : " + sort + "\n");
            Console.WriteLine("O vencedor : " + win);
            Console.ReadLine();
        }
    }
}
