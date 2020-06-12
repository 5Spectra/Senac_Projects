using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static decimal operacao (decimal numero)
        {
            decimal p = ((((2 * (numero * numero)) / 2) + 13) - 10) / 2;
            return p;
        }
        static void Main(string[] args)
        {
            //-----------------1---------------------

            decimal n1, n2;


            Console.WriteLine("Escreva o 1º numero");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Escreva o 2º numero");
            n2 = Convert.ToDecimal (Console.ReadLine());

            n1 = operacao(n1);

            n2 = operacao(n2);

            //descobrir se x é maior ou menor que y

            if (n1 < n2) {
                Console.WriteLine("\nO 1º primeiro numero é MENOR que o 2º \n");
            }
            else if (n1 > n2){
                Console.WriteLine("\nO 1º primeiro numero é MAIOR que o 2º \n");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("\nO 1º e o 2º são iguais \n");
            }


            Console.WriteLine("1º número: " + n1 + "\n" + "2º número: " + n2);
            Console.ReadLine();










        }
    }
}
