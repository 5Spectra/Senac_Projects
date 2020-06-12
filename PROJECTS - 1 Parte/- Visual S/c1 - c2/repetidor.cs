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
            int vezes;
            string nome;


            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("\nQuantas vezes deseja imprimir na tela");
            vezes = Convert.ToInt32(Console.ReadLine());

            for (int x = 1;x <= vezes; x++){
                Console.WriteLine("Seu nome " + nome);
            }


            Console.ReadLine();
        }
    }
}
