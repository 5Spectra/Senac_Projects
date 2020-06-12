using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLivroJogosDigi
{
    class Program
    {
        static string nome = "";
        static string origem = "";
        static int classe = 0;
        static int hp = 0;
        static int xp = 0;
        static int level = 0;

        static void Main(string[] args)
        {

            int opcao = 0;

            Titulo();
            Console.WriteLine("Seja bem vindo ao mundo de Calabou�os e Drag�es");
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("De onde voc� vem?");
            origem = Console.ReadLine();
            do
            {
                Console.WriteLine("Qual sua classe?\n1 - B�rbaro\n2 - Ranger\n3 - Mago");
                classe = int.Parse(Console.ReadLine());
                switch (classe)
                {
                    case 1:
                        Console.WriteLine("Voc� � um B�RBARO");
                        break;
                    case 2:
                        Console.WriteLine("Voc� � um RANGER");
                        break;
                    case 3:
                        Console.WriteLine("Voc� � um MAGO");
                        break;
                    default:
                        Console.WriteLine("Op��o inv�lida\n\n");
                        break;
                }
                Console.ReadKey();
            } while (classe < 1 || classe > 3);

            MudaHP("inicia", 0);

            ExibirFicha();
            Console.ReadKey();

            Console.Clear();

            Titulo();
            Console.WriteLine("Voc� est� em uma floresta escura, iluminada apenas pela luz da lua.\nVoc� escuta um barulho vindo do arbusto. Voc�:");
            Console.WriteLine("1 - Corre sem olhar para tr�s.");
            Console.WriteLine("2 - Vai at� o arbusto verificar.");
            Console.WriteLine("3 - Come�a a chorar pois lembra que tem medo do escuro.");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CorreSemOlhar();
            }
            if (opcao == 2)
            {
                VerArbusto();
            }
            if (opcao == 3)
            {
                Chorar();
            }

            Console.ReadKey();
        }

        /*M�todo CorreSemOlhar()*/
        static void CorreSemOlhar()
        {
            Console.WriteLine();
            Console.WriteLine("Voc� correu para longe e se salvou do perigo. Por pensar r�pido, ganha 20 pontos de experi�ncia.");
            MudarXP(20);
            ExibirFicha();

        }

        /// <summary>
        /// M�todo MudarXP(int valor)
        ///nesse m�todo � acrecentado xp para o personagem, e tamb�m verificado se o n�vel de xp atingiu o limite para subir de level, caso sim adiciona um level para o personagem
        /// </summary>
        static void MudarXP(int valor)
        {
            xp = xp + valor;

            if (classe == 1 && xp >= 100)
            {
                level = level + 1;
                xp = xp - 100;
            }

            if (classe == 2 && xp >= 70)
            {
                level = level + 1;
                xp = xp - 70;
            }

            if (classe == 3 && xp >= 50)
            {
                level = level + 1;
                xp = xp - 50;
            }
        }

        /// <summary>
        /// M�todo Chorar()
        /// </summary>
        static void Chorar()
        {
            Console.WriteLine("Voc� chorou, fez alguns grunhidos e barulhos estranhos o que fez o drag�o branco de duas cabe�as de olhos azuis acordar.");
            Console.WriteLine("Voc� n�o teve tempo de se defender e tomou um ataque cr�tico perdendo 200 HP.");
            ExibirFicha();
            MudaHP("dano", 200);
            ExibirFicha();

        }

        /// <summary>
        /// M�todo VerArbusto()
        /// </summary>
        static void VerArbusto()
        {
            Console.WriteLine("Voc� mexeu no arbusto e descobriu que existe um drag�o adormecido. Com seu barulho ele acordou.");
            Console.WriteLine("Prepare-se, a batalha vai come�ar. \n� HORA DO DUELO!!!");
            int HPInimigo = 100;
            int dado = 0;
            Random r = new Random();

            while (HPInimigo > 0)
            {
                Console.WriteLine("Inimigo: Drag�o");
                Console.WriteLine("HP atual: " + HPInimigo);
                Console.WriteLine("Pressione qualquer bot�o para rolar o dado");
                Console.ReadKey();
                dado = r.Next(1, 21);
                Console.WriteLine("O n�mero sorteado foi: " + dado);

                if (dado >= 15)
                {
                    Console.WriteLine("Dano Cr�tico.");
                    HPInimigo = HPInimigo - 100;
                }

                if (dado >= 5 && dado <= 14)
                {
                    Console.WriteLine("Dano m�dio.");
                    HPInimigo = HPInimigo - 50;
                }

                if (dado <= 4)
                {
                    Console.WriteLine("Dano M�nimo.");
                    HPInimigo = HPInimigo - 20;
                }

                if (HPInimigo <= 0)
                {
                    Console.WriteLine("PARAB�NS!!! VOC� MATOU O DRAG�OZORD!!!");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("O drag�o desferiu uma poderosa bola de fogo coberta de gelo.");
                Console.WriteLine("Pressione qualquer bot�o para rolar o dado");
                Console.ReadKey();

                dado = r.Next(1, 21);
                Console.WriteLine("Voc� tirou: " + dado);

                if (dado >= 15)
                {
                    Console.WriteLine("Voc� conseguiu fugir.");
                }

                if (dado >= 5 && dado <= 14)
                {
                    Console.WriteLine("Voc� recebeu uma ataque leve.");
                    MudaHP("dano", 30);
                }

                if (dado <= 4)
                {
                    Console.WriteLine("Voc� recebeu uma ataque forte.");
                    MudaHP("dano", 50);
                }
            }
        }


        /// <summary>
        /// M�todo ExibirFicha()
        ///esse m�todo exibe a ficha atualizada do personagem, com as propriedades: nome, origem, classe, xp, hp e level
        /// </summary>
        static void ExibirFicha()
        {
            Console.WriteLine();
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Origem: " + origem);

            if (classe == 1)
            {
                Console.WriteLine("Classe: B�rbaro");
            }
            else if (classe == 2)
            {
                Console.WriteLine("Classe: Ranger");
            }
            else
            {
                Console.WriteLine("Classe: Mago");
            }

            Console.WriteLine("XP: " + xp);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine();
        }

        /// <summary>
        /// M�todo Titulo()
        ///esse m�todo serve para configurar a barra de t�tulo do meu jogo e apresentar na tela o t�tulo inicial do jogo
        /// </summary>
        static void Titulo()
        {
            Console.Title = "Calabou�os & Drag�es";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("==========================================================");
            Console.WriteLine("================== CALABOU�OS & DRAG�ES ==================");
            Console.WriteLine("==========================================================");
            Console.WriteLine();
            Console.ResetColor();
        }
        /// <summary>
        /// M�todo MudaHP( string tipo, int valor)
        ///Este m�todo serve para trabalhar as funcionalidades referentes ao HP, seja inicializa��o, dano ou adi��o de HP.
        ///Este m�todo espera 2 par�metros:
        ///Tipo --> tipo da a��o a ser realizada podendo ser 3: "inicia", "dano" ou "adiciona"
        ///Valor --> valor a ser subtra�do em caso de "dano", ou adicionado em caso de "adiciona", em caso de "inicia" valor � irrelevante
        /// </summary>
        static void MudaHP(string tipo, int valor)
        {
            if (tipo == "inicia")
            {
                if (classe == 1)
                    hp = 100;
                if (classe == 2)
                    hp = 150;
                if (classe == 3)
                    hp = 50;
            }

            if (tipo == "dano")
            {
                hp = hp - valor;
                VerVida();
            }

            if (tipo == "adiciona")
            {
                hp = hp + valor;
            }
        }

        /// <summary>
        ///M�todo VerVida()
        ///Esse m�todo verifica se o jogador est� vivo, caso ele tenha perdido todo o hp, � mostrado uma mensagem e encerrado o jogo.
        /// </summary>

        static void VerVida()
        {
            if (hp <= 0)
            {
                Console.Clear();
                ExibirFicha();
                Console.WriteLine();
                Console.WriteLine("Sua jornada foi gloriosa. Bardos ir�o cantar sobre suas aventuras. Finalmente sua busca encerrou e voc� encontrar� o dencanso em Valhalla.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}