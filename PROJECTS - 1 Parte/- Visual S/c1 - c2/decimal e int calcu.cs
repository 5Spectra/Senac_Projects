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
            decimal n1, n2, tota;
            int total;
            inico:
            Console.WriteLine("n1");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("n2");
            n2 = Convert.ToDecimal(Console.ReadLine());

            tota = n1 / n2;
            total = Convert.ToInt32(tota);

            Console.WriteLine("Inteiro: " + total + "\nDecimal: " + tota);

            Console.ReadLine();
            goto inico;
        }
    }
}
