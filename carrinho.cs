using System;
using System.Collections.Generic;
using System.Text;

namespace MenuConsole
{
   public class carrinho
    {
        Cliente cliente;
        vendedor vendedor;
        produto listaproduto ;
        produto codigo;

        public static void DesenharMenu()
        {
            bool desenhaMenucarrinho = true;

            while (desenhaMenucarrinho)
            {
                carrinho novoCarrinho = new carrinho();

                Console.Clear();
                mainMenu.DesenhaGrade(" REALIZAR VENDAS ", ConsoleColor.Magenta);
                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CODIGO PRODUTO          ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'2' = TOTAL COMPRAS           ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'3' = COMISSAO                ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'V' = VOLTAR AO MENU          ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚══════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.WriteLine("     DIGITE UMA OPÇÃO : ");
    
                var opcao = Console.ReadLine();

                switch (opcao.ToUpper())
                {
                    case "1":
                            
                        break;

                    case "2":

                        break;
                    case "3":

                        break;
                    case "V":
                        desenhaMenucarrinho = false;
                        break;
                    default:
                        break;

                }

            }

        }        

    }
}
