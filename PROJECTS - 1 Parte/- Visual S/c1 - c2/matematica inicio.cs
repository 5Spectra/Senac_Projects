using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Danilo
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------1--------------
            /*
            string nome;

            Console.WriteLine("Digite seu nome");

            nome = Console.ReadLine();

            Console.WriteLine("seu nome é:");
            Console.WriteLine(nome);
            Console.ReadLine();
            */
            //--------------2--------------
            /*
           Int32 num1; 
           Int32 num2;
           Int32 total;
           //ou
           Int32 num1, num2, total;

           Console.WriteLine("Digite 1º numero");
           num1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Digite 2º numero");
           num2 = Int32.Parse(Console.ReadLine());

           total = num1 + num2;
           Console.WriteLine("Total da conta");
           Console.WriteLine(total);
           Console.ReadLine();
           */

            //--------------3--------------
            /*
            string nome;
            string senha;

            Console.WriteLine("Seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("sua senha:");
            senha = Console.ReadLine();

            if (nome == "abc" && senha == "123")
            {
                Console.WriteLine("Welcome");
                Console.ReadLine();
            }
            */

            //~~~~~~~~~~^Desafios^~~~~~~~~~
            //D1
            /*
            Int32 num1;
            Int32 num2;
            Int32 num3;
            Int32 num4;
            Int32 total;

            Console.WriteLine("1º numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2º numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3º numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4º numero");
            num4 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2 + num3 + num4;
            Console.WriteLine("Total da conta");
            Console.WriteLine(total);
            Console.ReadLine();
            */

            //D2
            /*
            Int32 num1;
            Int32 num2;
            Int32 num3;
            Int32 total;

            Console.WriteLine("1º numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2º numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3º numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            total = num1 * num2 * num3;
            Console.WriteLine("Total da conta");
            Console.WriteLine(total);
            Console.ReadLine();
            */

            //D3
            /*
            Int32 num1;
            Int32 num2;
            Int32 num3;
            Int32 total;

            Console.WriteLine("1º numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2º numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3º numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            total = num1 - num2 - num3;
            Console.WriteLine("Total da conta");
            Console.WriteLine(total);
            Console.ReadLine();
            */

            //D4
            /*
            decimal num1,num2;
            decimal total;

            Console.WriteLine("1º numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2º numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            total = num1 / num2;
            Console.WriteLine("Total da conta");
            Console.WriteLine(total);
            Console.ReadLine();
            */

            //D5
            /*
            Int32 num1;
            Int32 total;

            Console.WriteLine("1º numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            total = num1 * num1;
            Console.WriteLine("Total da conta");
            Console.WriteLine(total);
            Console.ReadLine();
            */

            //D6
            /*
            decimal num1,num2, total;
            string nome;

            Console.WriteLine("Seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Coloque um numero");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Coloque um numero");
            num2 = Convert.ToDecimal(Console.ReadLine());

            total = num1 + num2;
            Console.WriteLine("Resultado");
            Console.WriteLine(total);
            Console.WriteLine("Obrigado " + nome);
            Console.ReadLine();
            }
            */

            //~~~~~~~~~~^COMPLETE^~~~~~~~~~~
            //4
            //
            decimal n1, n2, n3, n4, total;
            Int32 u1;
            string oper;

            Console.WriteLine("quantos numeros voce quer?");
            Console.WriteLine("1 2 3 4");
            u1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que operação você quer:");
            Console.WriteLine("* para (multiplicar)\n- para menos\n+ para somar\n/ para dividir");
            oper = Console.ReadLine();

            if (u1 == 1)
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                total = n1;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }

            else if (u1 == 2 && oper == "*")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                total = n1 * n2;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 2 && oper == "-")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                total = n1 - n2;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 2 && oper == "+")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                total = n1 + n2;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 2 && oper == "/")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                total = n1 / n2;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }

            else if (u1 == 3 && oper == "+")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                total = n1;
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                total = n1 + n2 + n3;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 3 && oper == "*")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                total = n1;
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                total = n1 * n2 * n3;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 3 && oper == "-")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                total = n1;
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                total = n1 - n2 - n3;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 3 && oper == "/")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                total = n1;
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                total = n1 / n2 / n3;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }

            else if (u1 == 4 && oper =="+" )
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n4 = Convert.ToDecimal(Console.ReadLine());
                total = n1 + n2 + n3 + n4;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 4 && oper == "-")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n4 = Convert.ToDecimal(Console.ReadLine());
                total = n1 - n2 - n3 - n4;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 4 && oper == "/")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n4 = Convert.ToDecimal(Console.ReadLine());
                total = n1 / n2 / n3 / n4;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }
            else if (u1 == 4 && oper == "*")
            {
                Console.WriteLine("Coloque um numero");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n3 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Coloque um numero");
                n4 = Convert.ToDecimal(Console.ReadLine());
                total = n1 * n2 * n3 * n4;
                Console.WriteLine("Resultado");
                Console.WriteLine(total);
                Console.ReadLine();
            }

        }
            //

        }
    }

