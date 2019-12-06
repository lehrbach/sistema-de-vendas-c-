using System;
using System.Collections.Generic;
using System.Text;

namespace MenuConsole
{
    public class produto
    {
        int codigo;
        string descricao;
        float precocompra;
        float precovendas;
        float quantidadeestoque;
        Fornecedor fornecedor;

        public static void DesenharMenu()
        {
            bool desenhaMenuproduto = true;

            while (desenhaMenuproduto)
            {
                produto novoFornecedor = new produto();

                Console.Clear();

                mainMenu.DesenhaGrade(" CADASTRO DE PRODUTO ", ConsoleColor.DarkGreen);
                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.WriteLine("");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'C' = CADASTRAR PRODUTO     ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'L' = LISTAR PRODUTO        ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'D' = DELETAR PRODUTO       ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'V' = VOLTAR AO MENU        ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("     DIGITE UMA OPÇÃO : ");
                var opcao = Console.ReadLine();

                switch (opcao.ToUpper())
                {

                    case "C":


                        break;

                    case "L":

                        break;
                    case "D":

                        break;
                    case "V":
                        desenhaMenuproduto = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
