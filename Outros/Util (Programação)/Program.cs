using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace savepoint
{
    class Program
    {
        static int[] vida_total = new int [7];// sempre é um numero a menos
        static int[] xp_total = new int[7], level = new int[7];
        static string[] nome = new string[7];
        static int[] limiteinv = new int[7], total = new int[7];
        static int[] item25 = new int[7], item50 = new int[7], item75 = new int[7], itemarma = new int[7], item_armaencantada = new int[7], item_enchant = new int[7];
        static int n_player, soma;
        static int quant, chose;
        static string quantdo;
        static string file_name,file_local,data;
        static int[] recover = new int[67];

        static void Main(string[] args)
        {

            Console.WriteLine("\n" + "                Bem vindo ao programa de save do RPG do André");
            Console.ReadKey();
            Console.WriteLine("\n" + "O seu objetivo é  Salvar: \n\n-vida máxima \n-experiencia \n-level \n-itens \n-nome \n\n--De seu Personagem--\n\nCom suporte de 6 aventureiros por vez");
            Console.ReadKey();
//parte1
        menu1:
            do
            {
                Console.Clear();
                shownames();
                Console.WriteLine();
                Console.WriteLine("1 ao 6 - Escolhe o jogador | 7- Save | 8-Load");
                quantdo = Console.ReadLine();
            } while (quantdo == string.Empty);

            n_player = int.Parse(quantdo);
            n_player = n_player - 1;

            if (quantdo == "1") { goto playermenu; }
            else if (quantdo == "2") { goto playermenu; }
            else if (quantdo == "3") { goto playermenu; }
            else if (quantdo == "4") { goto playermenu; }
            else if (quantdo == "5") { goto playermenu; }
            else if (quantdo == "6") { goto playermenu; }
            else if (quantdo == "7") { save(); goto menu1; }
            else if (quantdo == "8") { load(); goto menu1; }
            else { goto menu1; }

        //parte2
        playermenu:
            upinv();
            Console.Clear();
            showplayer();
            do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty);
            chose = int.Parse(quantdo);

            if (chose == 0) { goto menu1; }
            else if (chose == 1) { aumentarxp(); levelcheck(); upinv(); goto playermenu; }
            else if (chose == 2) { Console.WriteLine("Quanto VIDA irá adicionar?"); do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty || quantdo.Contains("-")); quant = int.Parse(quantdo); vida_total[n_player] = vida_total[n_player] + quant; goto playermenu; }
            else if (chose == 3) { goto itemenuA; }          
            else if (chose == 4) { diminuirxp(); levelcheck(); upinv(); goto playermenu; }
            else if (chose == 5) { Console.WriteLine("Quanto VIDA irá remover?"); do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty || quantdo.Contains("-")); quant = int.Parse(quantdo); vida_total[n_player] = vida_total[n_player] - quant; goto playermenu; }
            else if (chose == 6) { goto itemenuR; }
            else if (chose == 7) { Console.Clear(); Console.WriteLine("Ele reamente morreu? | 1 - Sim | 2 - Não"); do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty); chose = int.Parse(quantdo); if (chose == 1) { morte(); goto playermenu; } else { goto playermenu; } }
            else if (chose == 8) { Console.Clear(); Console.WriteLine("Escreva o novo nome| não use " + "," + " |"); do { nome[n_player] = Console.ReadLine(); } while (nome[n_player] == string.Empty || nome[n_player].Contains(",") ); Console.WriteLine("Agora seu nome é: " + nome[n_player]); Console.ReadKey(); goto playermenu; }
            else if (chose == 10) { Console.Clear(); Console.WriteLine("Deseja realmente resetar o personagem | 1 - Sim | 2 - Não");do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty); chose = int.Parse(quantdo); if (chose == 1) { reset_player(); goto playermenu; }else { goto playermenu; } }
            else { goto playermenu; }

        itemenuR:
            upinv();
            Console.Clear();
            menuIrem();
            do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty);
            chose = int.Parse(quantdo);

            if (chose == 0) { goto playermenu; }
            else if (chose == 1) { ver(1); if (quant > item25[n_player]) { Console.WriteLine("Não a tantos itens"); Console.ReadKey(); goto itemenuR; } else { item25[n_player] = item25[n_player] - quant; totalinv(); goto itemenuR; } }
            else if (chose == 2) { ver(1); if (quant > item50[n_player]) { Console.WriteLine("Não a tantos itens"); Console.ReadKey(); goto itemenuR; } else { item50[n_player] = item50[n_player] - quant; totalinv(); goto itemenuR; } }
            else if (chose == 3) { ver(1); if (quant > item75[n_player]) { Console.WriteLine("Não a tantos itens"); Console.ReadKey(); goto itemenuR; } else { item75[n_player] = item75[n_player] - quant; totalinv(); goto itemenuR; } }
            else if (chose == 4) { ver(2); if (quant > itemarma[n_player]) { Console.WriteLine("Não a tantos itens"); Console.ReadKey(); goto itemenuR; } else { itemarma[n_player] = itemarma[n_player] - quant ; totalinv(); goto itemenuR; } }
            else if (chose == 5) { ver(1); if (quant > item_enchant[n_player]) { Console.WriteLine("Não a tantos itens"); Console.ReadKey(); goto itemenuR; } else { item_enchant[n_player] = item_enchant[n_player] - quant; totalinv(); goto itemenuR; } }
            else if (chose == 6) { ver(2); if (quant > item_armaencantada[n_player]) { Console.WriteLine("Não a tantos itens"); Console.ReadKey(); goto itemenuR; } else { item_armaencantada[n_player] = item_armaencantada[n_player] - quant; totalinv(); goto itemenuR; } }
            else if (chose == 7) { Console.Clear(); Console.WriteLine("Deseja realmente resetar os itens | 1 - Sim | 2 - Não"); do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty); chose = int.Parse(quantdo); if (chose == 1) { reset_itens(); totalinv(); goto itemenuR; } else { goto itemenuR; } }
            else { goto itemenuR; }

     itemenuA://point 
            Console.Clear();
            menuIadd();
            do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty);
            chose = int.Parse(quantdo);

            if (chose == 0) { goto playermenu; }
            else if (chose == 1) { ver(1); if (soma > limiteinv[n_player]) { Console.WriteLine("Número de espaços insuficientes"); Console.ReadKey(); goto itemenuA; } else { item25[n_player] = item25[n_player] + quant; totalinv(); goto itemenuA; } }
            else if (chose == 2) { ver(1); if (soma > limiteinv[n_player]) { Console.WriteLine("Número de espaços insuficientes"); Console.ReadKey(); goto itemenuA; } else { item50[n_player] = item50[n_player] + quant; totalinv(); goto itemenuA; } }
            else if (chose == 3) { ver(1); if (soma > limiteinv[n_player]) { Console.WriteLine("Número de espaços insuficientes"); Console.ReadKey(); goto itemenuA; } else { item75[n_player] = item75[n_player] + quant; totalinv(); goto itemenuA; } }
            else if (chose == 4) { ver(2); if (soma > limiteinv[n_player]) { Console.WriteLine("Número de espaços insuficientes"); Console.ReadKey(); goto itemenuA; } else { itemarma[n_player] = itemarma[n_player] + quant; totalinv(); goto itemenuA; } }
            else if (chose == 5) { ver(1); if (soma > limiteinv[n_player]) { Console.WriteLine("Número de espaços insuficientes"); Console.ReadKey(); goto itemenuA; } else { item_enchant[n_player] = item_enchant[n_player] + quant; totalinv(); goto itemenuA; } }
            else if (chose == 6) { ver(2); if (soma > limiteinv[n_player]) { Console.WriteLine("Número de espaços insuficientes"); Console.ReadKey(); goto itemenuA; } else { item_armaencantada[n_player] = item_armaencantada[n_player] + quant; totalinv(); goto itemenuA; } }
            else if (chose == 7) { if (itemarma[n_player] > 0 && item_enchant[n_player] > 0) { item_armaencantada[n_player] = item_armaencantada[n_player] + 2; item_enchant[n_player] = item_enchant[n_player] - 1; itemarma[n_player] = itemarma[n_player] - 2; totalinv(); goto itemenuA; } else { goto itemenuA; } }
            else if (chose == 8) { if (item_armaencantada[n_player] > 0 && item_enchant[n_player] > 0) { item_enchant[n_player] = item_enchant[n_player] - 1; totalinv(); goto itemenuA; } else { goto itemenuA; } }
            else { goto itemenuA; }

    }
        //------------------------------------------------------------------------------------------
        static void shownames()
        {
            Console.WriteLine("Player 1: " + nome[0] + "    |   " + "Player 4: " + nome[3]);
            Console.WriteLine();
            Console.WriteLine("Player 2: " + nome[1] + "    |   " + "Player 5: " + nome[4]);
            Console.WriteLine();
            Console.WriteLine("Player 3: " + nome[2] + "    |   " + "Player 6: " + nome[5]);
            Console.WriteLine();
        }

        //------------------------------------------------------------------------------------------
        static void menuIadd()
        {
            Console.Clear();
            showitens();
            Console.WriteLine("0 - Voltar             |   4 - Arma");
            Console.WriteLine("1 - Poção de cura 25PV |   5 - Encantament");
            Console.WriteLine("2 - Poção de cura 50PV |   6 - Arma Encantada");
            Console.WriteLine("3 - Poção de cura 75PV |   7 - Encantar uma arma");
            Console.WriteLine("       8 - Encantar uma arma já encantada");
        }
        //------------------------------------------------------------------------------------------
        static void menuIrem()
        {
            Console.Clear();
            showitens();
            Console.WriteLine("0 - Voltar             |   4 - Arma");
            Console.WriteLine("1 - Poção de cura 25PV |   5 - Encantamento");
            Console.WriteLine("2 - Poção de cura 50PV |   6 - Arma Encantada");
            Console.WriteLine("3 - Poção de cura 75PV |   7 - Resetar itens ");
        }

        //------------------------------------------------------------------------------------------
        static void totalinv()
        {
            total[n_player] = item25[n_player] + item50[n_player] + item75[n_player] + itemarma[n_player] + item_armaencantada[n_player] + item_enchant[n_player];
        }
        //------------------------------------------------------------------------------------------
        static void ver(int num) {

            Console.WriteLine("Quantas irá adicionar/remover?");
            do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty || quantdo.Contains("-"));
            quant = int.Parse(quantdo);
            quant = quant * num;
            totalinv();
            soma = total[n_player] + quant;
        }
        //------------------------------------------------------------------------------------------
        static void showplayer(){
            int skill = level[n_player] / 4;
            Console.WriteLine("|-----------------------------|" + "\n");
            Console.WriteLine("Nome:  " + nome[n_player] + "\n");
            Console.WriteLine("Vida:  " + vida_total[n_player] );
            Console.WriteLine("");
            Console.WriteLine("Exp:   " + xp_total[n_player] + "    |   Level: " + level[n_player]);
            Console.WriteLine();
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine();
            Console.WriteLine("0 - Voltar ao menu" + "\n");
            Console.WriteLine("1 - Adicionar XP | 2 - Adicionar Vida | 3 - Adicionar Item ");
            Console.WriteLine("4 - Remover XP   | 5 - Remover Vida   | 6 - Remover Item");
            Console.WriteLine();
            Console.WriteLine("7 - Morte   |  8 - Definir nome | 10 - Resetar o jogador");
        }
        //------------------------------------------------------------------------------------------
        static void upinv()
        {
            if (level[n_player] == 0) { limiteinv[n_player] = 8; }
            if (level[n_player] <= 4 && level[n_player] >= 1) { limiteinv[n_player] = 20; }
            if (level[n_player] <= 8 && level[n_player] >= 5) { limiteinv[n_player] = 22; }
            if (level[n_player] <= 12 && level[n_player] >= 9) { limiteinv[n_player] = 24; }
            if (level[n_player] <= 16 && level[n_player] >= 13) { limiteinv[n_player] = 27; }
            if (level[n_player] <= 20 && level[n_player] >= 17) { limiteinv[n_player] = 29; }
            if (level[n_player] <= 24 && level[n_player] >= 21) { limiteinv[n_player] = 31; }
            if (level[n_player] <= 28 && level[n_player] >= 25) { limiteinv[n_player] = 33; }
            if (level[n_player] <= 32 && level[n_player] >= 29) { limiteinv[n_player] = 35; }
            if (level[n_player] <= 36 && level[n_player] >= 33) { limiteinv[n_player] = 37; }
            if (level[n_player] <= 40 && level[n_player] >= 37) { limiteinv[n_player] = 40; }
        }
        //------------------------------------------------------------------------------------------
        static void showitens()
        {
            Console.WriteLine("     Maximo de itens: " + limiteinv[n_player] + "         Total: "+ total[n_player] + "\n");
            Console.WriteLine("||-------------------------------------------------|| " + "\n");
            Console.WriteLine("   Poções de 25:  " + item25[n_player] + "    |    Poções de 50: " + item50[n_player] + "\n");
            Console.WriteLine("   Armas normais: " + (itemarma[n_player] / 2) + "    |    Poções de 75: " + item75[n_player] + "\n");
            Console.WriteLine("   Encantamentos: " + item_enchant[n_player] + "    |"+ "\n");
            Console.WriteLine("   Armas Encantadas: " + (item_armaencantada[n_player] / 2) + " |" + "\n");
            Console.WriteLine("||-------------------------------------------------||" + "\n");        
        }
        //------------------------------------------------------------------------------------------
        static void aumentarxp()
        {
            Console.WriteLine("Quanto XP irá adicionar?");
            do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty || quantdo.Contains("-"));
            quant = int.Parse(quantdo);

            xp_total[n_player] += quant;
        }
        //------------------------------------------------------------------------------------------
        static void diminuirxp()
        {
            Console.WriteLine("Quanto XP irá remover?");
            do { quantdo = Console.ReadLine(); } while (quantdo == string.Empty || quantdo.Contains("-"));
            quant = int.Parse(quantdo);

            xp_total[n_player] -= quant;
        }
        //------------------------------------------------------------------------------------------
        static void levelcheck()
        {
            
            if (level[n_player] == 0  && xp_total[n_player] >= 300) { addlevel(); xp_total[n_player] -= 300; }
            if (level[n_player] == 1  && xp_total[n_player] >= 350) { addlevel(); xp_total[n_player] -= 350; }
            if (level[n_player] == 2  && xp_total[n_player] >= 400) { addlevel(); xp_total[n_player] -= 400; }
            if (level[n_player] == 3  && xp_total[n_player] >= 450) { addlevel(); xp_total[n_player] -= 450; }
            if (level[n_player] == 4  && xp_total[n_player] >= 500) { addlevel(); xp_total[n_player] -= 500; }
            if (level[n_player] == 5  && xp_total[n_player] >= 550) { addlevel(); xp_total[n_player] -= 550; }
            if (level[n_player] == 6  && xp_total[n_player] >= 600) { addlevel(); xp_total[n_player] -= 600; }
            if (level[n_player] == 7  && xp_total[n_player] >= 650) { addlevel(); xp_total[n_player] -= 650; }
            if (level[n_player] == 8  && xp_total[n_player] >= 700) { addlevel(); xp_total[n_player] -= 900; }
            if (level[n_player] == 9  && xp_total[n_player] >= 750) { addlevel(); xp_total[n_player] -= 750; }
            if (level[n_player] == 10 && xp_total[n_player] >= 850) { addlevel(); xp_total[n_player] -= 850; }
            if (level[n_player] == 11 && xp_total[n_player] >= 900) { addlevel(); xp_total[n_player] -= 900; }
            if (level[n_player] == 12 && xp_total[n_player] >= 950) { addlevel(); xp_total[n_player] -= 950; }
            if (level[n_player] == 13 && xp_total[n_player] >= 1000) { addlevel(); xp_total[n_player] -= 1000; }
            if (level[n_player] == 14 && xp_total[n_player] >= 1050) { addlevel(); xp_total[n_player] -= 1050; }
            if (level[n_player] == 15 && xp_total[n_player] >= 1100) { addlevel(); xp_total[n_player] -= 1100; }
            if (level[n_player] == 16 && xp_total[n_player] >= 1150) { addlevel(); xp_total[n_player] -= 1150; }
            if (level[n_player] == 17 && xp_total[n_player] >= 1150) { addlevel(); xp_total[n_player] -= 1150; }
            if (level[n_player] == 18 && xp_total[n_player] >= 1200) { addlevel(); xp_total[n_player] -= 1200; }
            if (level[n_player] == 19 && xp_total[n_player] >= 1250) { addlevel(); xp_total[n_player] -= 1250; }

            if (level[n_player] == 20 && xp_total[n_player] >= 1300) { addlevel(); xp_total[n_player] -= 1300; }
            if (level[n_player] == 21 && xp_total[n_player] >= 1350) { addlevel(); xp_total[n_player] -= 1350; }
            if (level[n_player] == 22 && xp_total[n_player] >= 1400) { addlevel(); xp_total[n_player] -= 1400; }
            if (level[n_player] == 23 && xp_total[n_player] >= 1450) { addlevel(); xp_total[n_player] -= 1450; }
            if (level[n_player] == 24 && xp_total[n_player] >= 1500) { addlevel(); xp_total[n_player] -= 1500; }
            if (level[n_player] == 25 && xp_total[n_player] >= 1550) { addlevel(); xp_total[n_player] -= 1550; }
            if (level[n_player] == 26 && xp_total[n_player] >= 1600) { addlevel(); xp_total[n_player] -= 1600; }
            if (level[n_player] == 27 && xp_total[n_player] >= 1650) { addlevel(); xp_total[n_player] -= 1650; }
            if (level[n_player] == 28 && xp_total[n_player] >= 1700) { addlevel(); xp_total[n_player] -= 1700; }
            if (level[n_player] == 29 && xp_total[n_player] >= 1750) { addlevel(); xp_total[n_player] -= 1750; }
            if (level[n_player] == 30 && xp_total[n_player] >= 1800) { addlevel(); xp_total[n_player] -= 1800; }
            if (level[n_player] == 31 && xp_total[n_player] >= 1850) { addlevel(); xp_total[n_player] -= 1850; }
            if (level[n_player] == 32 && xp_total[n_player] >= 1900) { addlevel(); xp_total[n_player] -= 1900; }
            if (level[n_player] == 33 && xp_total[n_player] >= 1950) { addlevel(); xp_total[n_player] -= 1950; }
            if (level[n_player] == 34 && xp_total[n_player] >= 2000) { addlevel(); xp_total[n_player] -= 2000; }
            if (level[n_player] == 35 && xp_total[n_player] >= 2050) { addlevel(); xp_total[n_player] -= 2050; }
            if (level[n_player] == 36 && xp_total[n_player] >= 2100) { addlevel(); xp_total[n_player] -= 2100; }
            if (level[n_player] == 37 && xp_total[n_player] >= 2150) { addlevel(); xp_total[n_player] -= 2150; }
            if (level[n_player] == 38 && xp_total[n_player] >= 2200) { addlevel(); xp_total[n_player] -= 2200; }
            if (level[n_player] == 39 && xp_total[n_player] >= 2400) { addlevel(); xp_total[n_player] -= xp_total[n_player]; }
            
        }
        //------------------------------------------------------------------------------------------

        static void addlevel() { level[n_player] += 1; }

        //------------------------------------------------------------------------------------------

        static void reset_itens() { item25[n_player] = 0; item50[n_player] = 0; item75[n_player] = 0; itemarma[n_player] = 0; item_armaencantada[n_player] = 0; item_enchant[n_player] = 0; }

        //------------------------------------------------------------------------------------------

        static void reset_player() { nome[n_player] = ""; vida_total[n_player] = 0; xp_total[n_player] = 0; level[n_player] = 0; limiteinv[n_player] = 0; reset_itens(); }

        //------------------------------------------------------------------------------------------
        static void morte()
        {
            level[n_player] -= 4;
            levelcheck();
            upinv();
            reset_itens();
        }
        //------------------------------------------------------------------------------------------








        //------------------------------------------------------------------------------------------
        static void save()
        {

            Console.WriteLine("Qual o nome do arquivo?  | 0 - Cancelar");
            do{ file_name = Console.ReadLine();
            } while (file_name == string.Empty);

            Console.WriteLine("Onde deseja salvar?  | 1 - Desktop C: | 0 - Cancelar");
            do{file_local = Console.ReadLine();
            } while (file_local == string.Empty);

            if (file_name == "0" || file_local == "0") { }
            else if (file_local == "1")
            {
                StreamWriter sw = new StreamWriter(@"C:\" + @"Users\Particular\Desktop\" + file_name + ".txt");

                sw.WriteLine(nome[0] + "," + nome[1] + "," + nome[2] + "," + nome[3] + "," + nome[4] + "," + nome[5] + "," + vida_total[0] + "," + vida_total[1] + "," + vida_total[2] + "," + vida_total[3] + "," + vida_total[4] + "," + vida_total[5] + "," + xp_total[0] + "," + xp_total[1] + "," + xp_total[2] + "," + xp_total[3] + "," + xp_total[4] + "," + xp_total[5] + "," + level[0] + "," + level[1] + "," + level[2] + "," + level[3] + "," + level[4] + "," + level[5] + "," + limiteinv[0] + "," + limiteinv[1] + "," + limiteinv[2] + "," + limiteinv[3] + "," + limiteinv[4] + "," + limiteinv[5] + "," + item25[0] + "," + item25[1] + "," + item25[2] + "," + item25[3] + "," + item25[4] + "," + item25[5] + "," + item50[0] + "," + item50[1] + "," + item50[2] + "," + item50[3] + "," + item50[4] + "," + item50[5] + "," + item75[0] + "," + item75[1] + "," + item75[2] + "," + item75[3] + "," + item75[4] + "," + item75[5] + "," + itemarma[0] + "," + itemarma[1] + "," + itemarma[2] + "," + itemarma[3] + "," + itemarma[4] + "," + itemarma[5] + "," + item_armaencantada[0] + "," + item_armaencantada[1] + "," + item_armaencantada[2] + "," + item_armaencantada[3] + "," + item_armaencantada[4] + "," + item_armaencantada[5] + "," + item_enchant[0] + "," + item_enchant[1] + "," + item_enchant[2] + "," + item_enchant[3] + "," + item_enchant[4] + "," + item_enchant[5]);

                sw.Flush();
                sw.Close();
                Console.WriteLine("Salvo com sucesso");
                Console.ReadKey();
            }
            else
            {
                StreamWriter sw = new StreamWriter(@file_local + "\\" + file_name + ".txt");

                sw.WriteLine(nome[0] + "," + nome[1] + "," + nome[2] + "," + nome[3] + "," + nome[4] + "," + nome[5] + "," + vida_total[0] + "," + vida_total[1] + "," + vida_total[2] + "," + vida_total[3] + "," + vida_total[4] + "," + vida_total[5] + "," + xp_total[0] + "," + xp_total[1] + "," + xp_total[2] + "," + xp_total[3] + "," + xp_total[4] + "," + xp_total[5] + "," + level[0] + "," + level[1] + "," + level[2] + "," + level[3] + "," + level[4] + "," + level[5] + "," + limiteinv[0] + "," + limiteinv[1] + "," + limiteinv[2] + "," + limiteinv[3] + "," + limiteinv[4] + "," + limiteinv[5] + "," + item25[0] + "," + item25[1] + "," + item25[2] + "," + item25[3] + "," + item25[4] + "," + item25[5] + "," + item50[0] + "," + item50[1] + "," + item50[2] + "," + item50[3] + "," + item50[4] + "," + item50[5] + "," + item75[0] + "," + item75[1] + "," + item75[2] + "," + item75[3] + "," + item75[4] + "," + item75[5] + "," + itemarma[0] + "," + itemarma[1] + "," + itemarma[2] + "," + itemarma[3] + "," + itemarma[4] + "," + itemarma[5] + "," + item_armaencantada[0] + "," + item_armaencantada[1] + "," + item_armaencantada[2] + "," + item_armaencantada[3] + "," + item_armaencantada[4] + "," + item_armaencantada[5] + "," + item_enchant[0] + "," + item_enchant[1] + "," + item_enchant[2] + "," + item_enchant[3] + "," + item_enchant[4] + "," + item_enchant[5]);

                sw.Flush();
                sw.Close();
                Console.WriteLine("Salvo com sucesso");
                Console.ReadKey();
            }
        }
        //------------------------------------------------------------------------------------------
        static void load()
        {

            Console.WriteLine("Qual o nome do arquivo?  | 0 - Cancelar");
            do{file_name = Console.ReadLine();
            } while(file_name == string.Empty);

            Console.WriteLine("Onde está o arquivo?  | 1 - Desktop C: | 0 - Cancelar");
            do{file_local = Console.ReadLine();
            } while (file_local == string.Empty);

            if (file_name == "0" || file_local == "0") { }
            else if (file_local == "1")
            {
                StreamReader sr = new StreamReader(@"C:\" + @"Users\Particular\Desktop\" + file_name + ".txt");
                data = sr.ReadLine();

                loadsplit();

                Console.WriteLine("Jogo carregado com sucesso");
                Console.ReadKey();
            }
            else {
                StreamReader sr = new StreamReader(@file_local + "\\" + file_name + ".txt");
                data = sr.ReadLine();

                loadsplit();

                Console.WriteLine("Jogo carregado com sucesso");
                Console.ReadKey();
            }
        }
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        static void loadsplit() {

            string[] values = data.Split(',');

            for (int x = 6; x < 66 ;x++) {
                recover[x] = int.Parse(values[x]);
            }

            //strings: nomes
            nome[0] = values[0];
            nome[1] = values[1];
            nome[2] = values[2];
            nome[3] = values[3];
            nome[4] = values[4];
            nome[5] = values[5];

            //ints: vidas
            vida_total[0] = recover[6];
            vida_total[1] = recover[7];
            vida_total[2] = recover[8];
            vida_total[3] = recover[9];
            vida_total[4] = recover[10];
            vida_total[5] = recover[11];

            //ints: xp
            xp_total[0] = recover[12];
            xp_total[1] = recover[13];
            xp_total[2] = recover[14];
            xp_total[3] = recover[15];
            xp_total[4] = recover[16];
            xp_total[5] = recover[17];

       //ints: level
            level[0] = recover[18];
            level[1] = recover[19];
            level[2] = recover[20];
            level[3] = recover[21];
            level[4] = recover[22];
            level[5] = recover[23];

            //int: invmax
            limiteinv[0] = recover[24];
            limiteinv[1] = recover[25];
            limiteinv[2] = recover[26];
            limiteinv[3] = recover[27];
            limiteinv[4] = recover[28];
            limiteinv[5] = recover[29];

            //ints: item25
            item25[0] = recover[30];
            item25[1] = recover[31];
            item25[2] = recover[32];
            item25[3] = recover[33];
            item25[4] = recover[34];
            item25[5] = recover[35];

            //ints: item50
            item50[0] = recover[36];
            item50[1] = recover[37];
            item50[2] = recover[38];
            item50[3] = recover[39];
            item50[4] = recover[40];
            item50[5] = recover[41];

            //ints: item75
            item75[0] = recover[42];
            item75[1] = recover[43];
            item75[2] = recover[44];
            item75[3] = recover[45];
            item75[4] = recover[46];
            item75[5] = recover[47];

            //ints: itemarma
            itemarma[0] = recover[48];
            itemarma[1] = recover[49];
            itemarma[2] = recover[50];
            itemarma[3] = recover[51];
            itemarma[4] = recover[52];
            itemarma[5] = recover[53];

            //ints: item_armaencantada
            item_armaencantada[0] = recover[54];
            item_armaencantada[1] = recover[55];
            item_armaencantada[2] = recover[56];
            item_armaencantada[3] = recover[57];
            item_armaencantada[4] = recover[58];
            item_armaencantada[5] = recover[59];

            //ints: item_enchant
            item_enchant[0] = recover[61];
            item_enchant[1] = recover[62];
            item_enchant[2] = recover[63];
            item_enchant[3] = recover[64];
            item_enchant[4] = recover[65];
            item_enchant[5] = recover[66];
        }
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------

    }
}
