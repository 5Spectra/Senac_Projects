using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static decimal operacaoLouca(decimal numero)
        {
            decimal p = ((((2 * (numero * numero)) / 2) + 13) - 10) / 2;
            return p;
        }

        static decimal imprime()
        {
            Console.WriteLine("Digite um numero");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());
            return n1;
        }

        static void resolve(decimal num1, decimal num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("O primeiro numero e maior " + num1);
            }
            else
            {
                Console.WriteLine("O primeiro segundo e maior " + num2);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            decimal n1 = imprime();
            n1 =  operacaoLouca(n1);
            
            decimal n2 = imprime();
            n2 = operacaoLouca(n2);

            resolve(n1, n2);
            
        }
    }
}
