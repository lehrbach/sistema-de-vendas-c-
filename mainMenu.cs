using System;
using System.Collections.Generic;
using System.Text;


namespace MenuConsole
{
    public static class mainMenu
    {

        public static void DesenhaGrade(string nomeSistema, ConsoleColor cor)
        {
            int larguraTela = Console.WindowWidth;
            int alturaTela = Console.WindowHeight;

            string bEsquerda = "";
            string bCentral = "";
            string bDireita = "";
            string linha = "";

            Console.ForegroundColor = cor;
            for (int i = 0; i < alturaTela; i++)
            {
                if (i == 0)
                {
                    //string nomeSistema = " SISTEMA IFMT - Campus São Vicente ";
                    int meio = larguraTela / 2;
                    int parteEsqquerda = meio - (nomeSistema.Length / 2);
                    int parteDireita = larguraTela - nomeSistema.Length - parteEsqquerda;

                    bEsquerda = new string('▒', parteEsqquerda);
                    bCentral = nomeSistema;
                    bDireita = new string('▒', parteDireita);
                    linha = bEsquerda + bCentral + bDireita;
                    Console.Write(linha);
                }
                else if (i == alturaTela - 1)
                {
                    bCentral = new string('▒', larguraTela);

                    linha = bCentral;
                    Console.Write(linha);
                }
                else
                {
                    bEsquerda = new string('▒', 1);
                    bCentral = new string(' ', larguraTela - 2);
                    bDireita = new string('▒', 1);
                    linha = bEsquerda + bCentral + bDireita;
                    Console.Write(linha);
                }
            }

        }

        public static void Desenhar()
        {
            

            //MEDIDAS DA TELA
            //Console.WriteLine("L: {0} - A:{1}", larguraTela, alturaTela);

            bool exibeMenuMain = true;
            while (exibeMenuMain)
            {

                DesenhaGrade(" SISTEMA IFMT - Campus São Vicente ", ConsoleColor.Red);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.Write( "");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write( " ╔════════════════ MENU PRINCIPAL ═══════════════╗    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( " ║ 1 CLIENTES                                    ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY); 
                Console.Write( " ║ 2 PRODUTOS                                    ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( " ║ 3 FUNCIONARIO                                 ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( " ║ 4 FORNECEDORES                                ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( " ║ 5 VENDAS                                      ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( " ║ 6 SAIR                                        ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( " ╚═══════════════════════════════════════════════╝    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( "                                                      ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write( "DIGITE UMA OPÇÃO :");


                //OPÇÃO DO MENU
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Cliente.DesenharMenu(); //cliente
                        Console.Clear();
                        break;
                    case "2":
                        produto.DesenharMenu(); //produtos
                        break;

                    case "3":
                        funcionario.DesenharMenu();// funcionario
                        Console.Clear();
                        break;

                    case "4":
                        Fornecedor.DesenharMenu(); //fornecedor
                        Console.Clear();
                        break;
                    case "5":
                        carrinho.DesenharMenu(); //sistema de vendas
                        Console.Clear();
                        break;
                    case "6":
                        exibeMenuMain = false;
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
