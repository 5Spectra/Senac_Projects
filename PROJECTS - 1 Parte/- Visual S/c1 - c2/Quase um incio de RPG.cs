using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livrojogo
{
    class Program
    {
        static string nome = "";
        static string origem = "";
        static int raca = 0;
        static int hp = 0, exp = 0,level = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo ao grande Dragon Cave" + "\n");
            Console.WriteLine("Diga seu nome nobre guerreiro");
            nome = Console.ReadLine();
            Console.WriteLine("De onde tus es?");
            origem = Console.ReadLine();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Qual sua raça? \n Pera = 1 \n Maça = 2 \n Laranja = 3 \n Melacia = 4");
                Console.WriteLine("Digite o numero de sua raça");
                raca = Convert.ToInt32(Console.ReadLine());

                switch (raca)
                {
                    case 1:
                        Console.WriteLine("Você é uma Pera");
                        break;

                    case 2:
                        Console.WriteLine("Você é uma Maça");
                        break;

                    case 3:
                        Console.WriteLine("Você é uma Laranja");
                        break;

                    case 4:
                        Console.WriteLine("Você é uma Melacia");
                        break;

                    default:
                        Console.WriteLine("Raça invalida \nvoce será redirecionado a escolha");
                        break;
                }
                Console.ReadKey();
            } while (raca < 1 || raca > 3);

            MudaHp();
            Console.WriteLine(nome + "\n" + origem + raca + hp + exp + level);

            Console.ReadLine();
        }

        static void MudaHp()
        {
            if (raca == 1)
                hp = 50;
            if (raca == 2)
                hp = 150;
            if (raca == 3) 
                hp = 100;
            if (raca == 4) 
                hp = 250;




        }

    }
}
