using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vida_dos_inimigos
{
    class Program
    {
        static int[] vida = new int[20];
        static int[] limit = new int[20];
        static int escolha, opc;

        static void Main(string[] args)
        {
            int vezes, x;
            int rece_dado, rece_vida;
            string resp;

        start:
            Console.Clear();
            allvetor();
            do {
                Console.WriteLine("Quantos inimigos são?");
                vezes = Convert.ToInt32(Console.ReadLine().Trim());
            } while (vezes < 0 || vezes > 20);

            vezes = vezes - 1;

            for (x = 0; x <= vezes; x++)
            {
            loop:
                Console.WriteLine("\nDigite o HP do inimigo nº " + (x + 1));//a contagem começa do zero, não do 1
                vida[x] = Convert.ToInt32(Console.ReadLine());
                if (vida[x] > -1) { }
                else { goto loop; }
            }


        menu:
            Console.Clear();
            maxlife();
            Console.WriteLine("|--------------------------------------------------------|" + "\n");
            showlivetable();
            Console.WriteLine("|--------------------------------------------------------|" + "\n");
            Console.WriteLine("0 - Fim da batalha   |   1 a 20 - Número do inimigo");
            do {
                resp = Console.ReadLine();
            }while (resp == string.Empty) ;
            escolha = int.Parse(resp);
            escolha = escolha - 1;

            if (vezes >= escolha)
            {
                escolha = escolha + 1;

                if (escolha == 0) { goto start; }
                else if (escolha <= 20 && escolha >= 1)
                {
                    escolha = escolha - 1;

                here:
                    Console.Clear();
                    Console.WriteLine("Vida: " + vida[escolha]);
                   Console.WriteLine("1 - Voltar   |   2 - Reduzir Vida    |   3 - Aumentar Vida");
                    do{
                        resp = Console.ReadLine();
                    } while (resp == string.Empty);
                    opc = int.Parse(resp);

                    if (opc == 1) { goto menu; }
                    else if (opc == 2)
                    {
                        Console.WriteLine("\n" + "Quanto dano recebeu?");
                        do {resp = Console.ReadLine();} while (resp == string.Empty);

                        rece_dado = int.Parse(resp);
                        contadd(rece_dado);
                    }
                    else if (opc == 3)
                    {//
                        Console.WriteLine("\n" + "Quanto curou?");
                        do { resp = Console.ReadLine(); } while (resp == string.Empty);
                        rece_vida = int.Parse(resp);
                        int soma = vida[escolha] + rece_vida;
                        if (limit[escolha] < soma)
                        {
                            int dife = soma - limit[escolha]; contred(rece_vida, dife);
                        }
                        else { contred(rece_vida, 0); }
                    }
                    else { } goto here; }//

                else { goto menu; }
            } else { goto menu; }


        }


        static void vidasver() {
            Console.WriteLine(vida[0] + " " + vida[1] + " " + vida[2] + " " + vida[3] + " " + vida[4] + " " + vida[5] + " " + vida[6] + " " + vida[7] + " " + vida[8] + " " + vida[9] + " " + vida[10] + " " + vida[11] + " " + vida[12] + " " + vida[13] + " " + vida[14] + " " + vida[15] + " " + vida[16] + " " + vida[17] + " " + vida[18] + " " + vida[19]);
            Console.ReadKey();
        }

        static void allvetor()
        {
            for (int x = 0; x < 20; x++)
            {
                vida[x] = 0;
            }

        }

        static void contadd(int reduzir)
        {
            vida[escolha] = vida[escolha] - reduzir;
        }
        static void contred(int aumentar, int amais)
        {
            vida[escolha] = (vida[escolha] + aumentar) - amais;
        }


        static void showlivetable()
        {
            Console.WriteLine("1°  - " + vida[0] + "  |  2°  - " + vida[1] + "  |  3°  - " + vida[2] + "  |  4°  - " + vida[3] + "\n");
            Console.WriteLine("5°  - " + vida[4] + "  |  6°  - " + vida[5] + "  |  7°  - " + vida[6] + "  |  8°  - " + vida[7] + "\n");
            Console.WriteLine("9°  - " + vida[8] + "  |  10° - " + vida[9] + "  |  11° - " + vida[10] + "  |  12° - " + vida[11] + "\n");
            Console.WriteLine("13° - " + vida[12] + "  |  14° - " + vida[13] + "  |  15° - " + vida[14] + "  |  16° - " + vida[15]  + "\n");
            Console.WriteLine("17° - " + vida[16] + "  |  18° - " + vida[17] + "  |  19° - " + vida[18] + "  |  20° - " + vida[19] + "\n");
        }



        static void maxlife()
        {
            for (int x = 0; x <= 19; x++) { limit[x] = vida[x]; }
        }





    }
}
