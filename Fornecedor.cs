using System;
using System.Collections.Generic;
using System.Text;

namespace MenuConsole
{
    class Fornecedor
    {
        int codigo;
        string razaoSocial;
        string contato;


        public static void DesenharMenu()
        {
            bool desenhaMenuFornecedor = true;

            while (desenhaMenuFornecedor)
            {
                Fornecedor novoFornecedor = new Fornecedor();

                Console.Clear();

                mainMenu.DesenhaGrade(" CADASTRO DE FORNECEDOR ", ConsoleColor.DarkGreen);
                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.White;
                
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.WriteLine("");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'C' = CADASTRAR FORNECEDOR  ║");
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

                        Console.WriteLine("");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> Razão social do Fornecedor: ");
                        novoFornecedor.razaoSocial = Console.ReadLine();
                        Console.WriteLine("");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> codigo do Fornecedor:");
                        novoFornecedor.codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> contato do fornecedor:");
                        novoFornecedor.contato = Console.ReadLine();


                        //chamar algum método para cadastrar
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("===== Fornecedor Cadastrado =======");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Razao Social: {0}", novoFornecedor.razaoSocial);
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Codigo: {0}", novoFornecedor.codigo);
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Contato: {0}", novoFornecedor.contato);
                        Console.Write("================================");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Precione tecla para voltar.");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.ReadKey();

                        break;
                    case "V":
                        desenhaMenuFornecedor = false;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("");
            }
        } 
    }
}
