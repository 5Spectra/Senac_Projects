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
            Console.WriteLine("Seja bem vindo ao mundo de Calabouços e Dragões");
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("De onde você vem?");
            origem = Console.ReadLine();
            do
            {
                Console.WriteLine("Qual sua classe?\n1 - Bárbaro\n2 - Ranger\n3 - Mago");
                classe = int.Parse(Console.ReadLine());
                switch (classe)
                {
                    case 1:
                        Console.WriteLine("Você é um BÁRBARO");
                        break;
                    case 2:
                        Console.WriteLine("Você é um RANGER");
                        break;
                    case 3:
                        Console.WriteLine("Você é um MAGO");
                        break;
                    default:
                        Console.WriteLine("Opção inválida\n\n");
                        break;
                }
                Console.ReadKey();
            } while (classe < 1 || classe > 3);

            MudaHP("inicia", 0);

            ExibirFicha();
            Console.ReadKey();

            Console.Clear();

            Titulo();
            Console.WriteLine("Você está em uma floresta escura, iluminada apenas pela luz da lua.\nVocê escuta um barulho vindo do arbusto. Você:");
            Console.WriteLine("1 - Corre sem olhar para trás.");
            Console.WriteLine("2 - Vai até o arbusto verificar.");
            Console.WriteLine("3 - Começa a chorar pois lembra que tem medo do escuro.");

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

        /*Método CorreSemOlhar()*/
        static void CorreSemOlhar()
        {
            Console.WriteLine();
            Console.WriteLine("Você correu para longe e se salvou do perigo. Por pensar rápido, ganha 20 pontos de experiência.");
            MudarXP(20);
            ExibirFicha();

        }

        /// <summary>
        /// Método MudarXP(int valor)
        ///nesse método é acrecentado xp para o personagem, e também verificado se o nível de xp atingiu o limite para subir de level, caso sim adiciona um level para o personagem
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
        /// Método Chorar()
        /// </summary>
        static void Chorar()
        {
            Console.WriteLine("Você chorou, fez alguns grunhidos e barulhos estranhos o que fez o dragão branco de duas cabeças de olhos azuis acordar.");
            Console.WriteLine("Você não teve tempo de se defender e tomou um ataque crítico perdendo 200 HP.");
            ExibirFicha();
            MudaHP("dano", 200);
            ExibirFicha();

        }

        /// <summary>
        /// Método VerArbusto()
        /// </summary>
        static void VerArbusto()
        {
            Console.WriteLine("Você mexeu no arbusto e descobriu que existe um dragão adormecido. Com seu barulho ele acordou.");
            Console.WriteLine("Prepare-se, a batalha vai começar. \nÉ HORA DO DUELO!!!");
            int HPInimigo = 100;
            int dado = 0;
            Random r = new Random();

            while (HPInimigo > 0)
            {
                Console.WriteLine("Inimigo: Dragão");
                Console.WriteLine("HP atual: " + HPInimigo);
                Console.WriteLine("Pressione qualquer botão para rolar o dado");
                Console.ReadKey();
                dado = r.Next(1, 21);
                Console.WriteLine("O número sorteado foi: " + dado);

                if (dado >= 15)
                {
                    Console.WriteLine("Dano Crítico.");
                    HPInimigo = HPInimigo - 100;
                }

                if (dado >= 5 && dado <= 14)
                {
                    Console.WriteLine("Dano médio.");
                    HPInimigo = HPInimigo - 50;
                }

                if (dado <= 4)
                {
                    Console.WriteLine("Dano Mínimo.");
                    HPInimigo = HPInimigo - 20;
                }

                if (HPInimigo <= 0)
                {
                    Console.WriteLine("PARABÉNS!!! VOCÊ MATOU O DRAGÃOZORD!!!");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("O dragão desferiu uma poderosa bola de fogo coberta de gelo.");
                Console.WriteLine("Pressione qualquer botão para rolar o dado");
                Console.ReadKey();

                dado = r.Next(1, 21);
                Console.WriteLine("Você tirou: " + dado);

                if (dado >= 15)
                {
                    Console.WriteLine("Você conseguiu fugir.");
                }

                if (dado >= 5 && dado <= 14)
                {
                    Console.WriteLine("Você recebeu uma ataque leve.");
                    MudaHP("dano", 30);
                }

                if (dado <= 4)
                {
                    Console.WriteLine("Você recebeu uma ataque forte.");
                    MudaHP("dano", 50);
                }
            }
        }


        /// <summary>
        /// Método ExibirFicha()
        ///esse método exibe a ficha atualizada do personagem, com as propriedades: nome, origem, classe, xp, hp e level
        /// </summary>
        static void ExibirFicha()
        {
            Console.WriteLine();
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Origem: " + origem);

            if (classe == 1)
            {
                Console.WriteLine("Classe: Bárbaro");
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
        /// Método Titulo()
        ///esse método serve para configurar a barra de título do meu jogo e apresentar na tela o título inicial do jogo
        /// </summary>
        static void Titulo()
        {
            Console.Title = "Calabouços & Dragões";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("==========================================================");
            Console.WriteLine("================== CALABOUÇOS & DRAGÕES ==================");
            Console.WriteLine("==========================================================");
            Console.WriteLine();
            Console.ResetColor();
        }
        /// <summary>
        /// Método MudaHP( string tipo, int valor)
        ///Este método serve para trabalhar as funcionalidades referentes ao HP, seja inicialização, dano ou adição de HP.
        ///Este método espera 2 parâmetros:
        ///Tipo --> tipo da ação a ser realizada podendo ser 3: "inicia", "dano" ou "adiciona"
        ///Valor --> valor a ser subtraído em caso de "dano", ou adicionado em caso de "adiciona", em caso de "inicia" valor é irrelevante
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
        ///Método VerVida()
        ///Esse método verifica se o jogador está vivo, caso ele tenha perdido todo o hp, é mostrado uma mensagem e encerrado o jogo.
        /// </summary>

        static void VerVida()
        {
            if (hp <= 0)
            {
                Console.Clear();
                ExibirFicha();
                Console.WriteLine();
                Console.WriteLine("Sua jornada foi gloriosa. Bardos irão cantar sobre suas aventuras. Finalmente sua busca encerrou e você encontrará o dencanso em Valhalla.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}