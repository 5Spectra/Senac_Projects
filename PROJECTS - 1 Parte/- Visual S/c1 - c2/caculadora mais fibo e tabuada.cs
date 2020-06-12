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
            string tipo;
            decimal n1, n2, vezes;
            decimal total;
        inicio:
            Console.WriteLine("1 - soma\n2 - menos\n3 - divisão\n4 - multiplicação\n5 - quadrado\n6 - tabuada\n7 - sequencia fibonacci");
            tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1": //soma
                    Console.WriteLine("Digite o número");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Mais o número");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    total = n1 + n2;
                    Console.WriteLine(total);
                    break;

                case "2": //menos
                    Console.WriteLine("Digite o número");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Menos o número");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    total = n1 - n2;
                    Console.WriteLine(total);
                    break;

                case "3": //divisão
                    Console.WriteLine("Digite o número");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Dividido por");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    total = n1 / n2;
                    Console.WriteLine(total);
                    break;

                case "4": //multiplicação
                    Console.WriteLine("Digite o número");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Quantas Vezes");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    total = n1 * n2;
                    Console.WriteLine(total);
                    break;

                case "5": //quadrado
                    Console.WriteLine("Digite número para descobrir seu quadrado");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    total = n1 * n1;
                    Console.WriteLine(total);
                    break;

                case "6": //tabuada
                    Console.WriteLine("Digite os número que deseja");
                    n1 = Convert.ToDecimal(Console.ReadLine());
                    for (vezes = 0; vezes <= 10; vezes++)
                    {
                        total = n1 * vezes;
                        Console.WriteLine(n1 + " x " + vezes + " = " + total);
                    }
                    break;

                case "7": //sequencia fibonacci
                    int[] beringela = new int[15];

                    Console.WriteLine("");
                    for (int x = 0; x <= 10; x++)
                    {
                        if (x > 2)
                        {
                            beringela[x] = beringela[x - 1] + beringela[x - 2];
                            Console.WriteLine(beringela[x]);
                        }
                        else
                        {
                            beringela[x] = x;
                            Console.WriteLine(beringela[x]);
                        }
                    }

                    Console.ReadLine();
                    break;
            }
                   Console.ReadLine();
                    goto inicio;









        }
    }
}
