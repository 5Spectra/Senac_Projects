using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------1--------------
            /*
            decimal n1, n2, n3, total;

            Console.WriteLine("Vamos calcular a média de 3 números");
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Coloque segundo número");
            n2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Coloque terceiro número");
            n3 = Convert.ToDecimal(Console.ReadLine());

            total = (n1 + n2 + n3) / 3;
            
           Math.Round(total, 2); //declara o maximo de casas

            Console.WriteLine("A média é :");
            Console.WriteLine(total);
            Console.ReadLine();
             */
            //--------------2--------------
            /*
            decimal n1, n2, n3, total;

            Console.WriteLine("Vamos calcular a média das 3 provas");

            Console.WriteLine("Digite a primeira nota");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            n2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            n3 = Convert.ToDecimal(Console.ReadLine());

            total = (n1 + n2 + n3) / 3;
            Math.Round(total, 3);

            if (total >= 6)
            {
                Console.WriteLine("Você passou");
                Console.WriteLine("Sua media foi " + total);
                Console.WriteLine("Parabens");
            }
           //else {
                //Console.WriteLine("Reprovado");}
           //ou
            else if (total < 6)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Sua media foi " + total);
                Console.WriteLine("Não foi dessa vez");
            }
            Console.ReadLine();


            */
            //^^^^^^^^^^^1^^^^^^^^^^^
            /*
            double raizD, dc, a, b, c, d, dc2, x1, x2; ;

            Console.WriteLine("Digite o A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o C");
            c = Convert.ToDouble(Console.ReadLine());

            d = (b * b) + (-4 * a * c);
            dc = Convert.ToDouble(d);

            raizD = Math.Sqrt(dc);
            Math.Round(raizD, 3);

            dc2 = Convert.ToDouble(raizD);

            x1 = (-b + dc2) / 2;
            x2 = (-b - dc2) / 2;

            Console.WriteLine("O x1 é igual" + x1);
            Console.WriteLine("O x2 é igual" + x2);
            Console.WriteLine(raizD);

            Console.ReadLine();
            */

        }
    }
}
