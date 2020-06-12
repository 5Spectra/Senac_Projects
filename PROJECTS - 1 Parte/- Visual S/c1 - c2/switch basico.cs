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
            //------------------1------------------
            /*
            string voto;

            Console.WriteLine("Escolha seu personagem favorito");
            Console.WriteLine("\n1 - Micky");
            Console.WriteLine("2 - Pica Pau");
            Console.WriteLine("3 - Tom");
            voto = Console.ReadLine();

            switch (voto)
            {
                case "1":
                    Console.WriteLine("Você escolheu o Micky");
                    break;
                case "2":
                    Console.WriteLine("Você escolheu o Pica Pau");
                    break;
                case "3":
                    Console.WriteLine("Você escolheu o Tom");
                    break;
                default:
                    Console.WriteLine("Escolha algo valido");
                    break;
            }
                Console.ReadLine();
            */

            //com if
            /*
            if (voto == "1") {
                Console.WriteLine("Micky wins");
                Console.ReadLine();
            }
            else if (voto == "2") {
                Console.WriteLine("Pica Pau");
                Console.ReadLine();
            }
            else if (voto == "3") {
                Console.WriteLine("Tom");
                Console.ReadLine();
            }
             */

            //------------------2------------------
            string pizza, menu, bebida;

            Console.WriteLine("Escolha seu a pizza desejada");
        comeco:
            Console.WriteLine("\n1 - Pizza Americana");
            Console.WriteLine("2 - Pizza Frango");
            Console.WriteLine("3 - Pizza Calabresa");
            Console.WriteLine("4 - Pizza 4 Queijos");
            pizza = Console.ReadLine();

            switch (pizza)
            {
                case "1":
                    Console.WriteLine("Você escolheu - Pizza Americana - 29,99 $");
                    Console.WriteLine("molho, mussarela, bacon, milho, ovos e orégano");
                    break;
                case "2":
                    Console.WriteLine("Você escolheu - Pizza Frango - 29,99 $");
                    Console.WriteLine("Molho, mussarela, frango e orégano");
                    break;
                case "3":
                    Console.WriteLine("Você escolheu - Pizza Calabresa - 29,99 $");
                    Console.WriteLine("Molho, mussarela, calabresa, catupiry e orégano");
                    break;
                case "4":
                    Console.WriteLine("Você escolheu - Pizza 4 Queijos - 29,99 $");
                    Console.WriteLine("Molho, mussarela, provolone, parmesão, catupiry e orégano.");
                    break;
                default:
                    Console.WriteLine("Não possuimos o que você está procurando");
                    Console.WriteLine("Quer voltar ao menu?\n\n1-Sim\n2-Não\n");
                    menu = Console.ReadLine();
                                if (menu == "1") {
                                  goto comeco; }
                                else if (menu == "2"){
                                Environment.Exit(0);}
                                break;
                                }
            Console.WriteLine("\nObrigado pela preferencia");
            Console.ReadLine();



        }
    }
}
