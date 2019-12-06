using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MenuConsole
{
    public class funcionario
    {
        public static object listafuncionario;
        int codigo;
        string nome;
        string cpf;
        string contato;

        public static void DesenharMenu()
        {
            bool desenhaMenufuncionario = true;

            while (desenhaMenufuncionario)
            {
                funcionario novofuncionario = new funcionario();

                Console.Clear();

                mainMenu.DesenhaGrade(" CADASTRO DE FUNCIONARIO ", ConsoleColor.Magenta);
                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'C' = CADASTRAR FUNCIONARIO   ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'L' = LISTAR FUNCIONARIO      ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'E' = EXCLUIR FUNCIONARIO     ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'X' = CALCULAR COMISSAO       ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'V' = VOLTAR AO MENU          ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚══════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("     DIGITE UMA OPÇÃO : ");
                var opcao = Console.ReadLine();

                switch (opcao.ToUpper())
                {
                    case "C":
                        Console.WriteLine("");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> Nome do Funcionario: ");
                        novofuncionario.nome = Console.ReadLine();

                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> contato do Funcionario: ");
                        novofuncionario.contato = Console.ReadLine();

                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> Código do Funcionario: ");
                        novofuncionario.codigo = Convert.ToInt32(Console.ReadLine());

                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> Cpf do Funcionario: ");
                        novofuncionario.cpf = Console.ReadLine();

                        //chamar algum método para cadastrar
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("===== funcionario Cadastrado =======");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Código: {0}", novofuncionario.codigo);
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Nome: {0}", novofuncionario.nome);
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Contato: {0}", novofuncionario.contato);
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Cpf: {0}", novofuncionario.cpf);
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("================================");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("Precione tecla para voltar.");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);

                        string path = @"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\cadastro-funcionarios.txt";
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(novofuncionario.codigo + "codigo: " + novofuncionario.codigo);
                            sw.WriteLine(novofuncionario.codigo + "nome: " + novofuncionario.nome);
                            sw.WriteLine(novofuncionario.codigo + "contato: " + novofuncionario.contato);
                            sw.WriteLine(novofuncionario.codigo + "cpf:" + novofuncionario.cpf);
                            sw.WriteLine("                                                      ");
                        }

                        Console.ReadKey();
                        break;

                    case "L":

                        int counter = 0;
                        string line;

                        // Read the file and display it line by line.  
                        System.IO.StreamReader file =
                            new System.IO.StreamReader(@"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\cadastro-funcionarios.txt");
                        while ((line = file.ReadLine()) != null)
                        {
                            System.Console.WriteLine(line);

                            counter++;
                        }


                        System.Console.WriteLine("Funcionarios cadastrados: ", counter);
                        file.Close();
                        // Suspend the screen.  
                        System.Console.ReadLine();
                        List<Cliente> lista = new List<Cliente>();

                        break;
                    

                    case "V":
                        desenhaMenufuncionario = false;
                        break;

                        
                }
                Console.WriteLine("");
            }
        }
    }

}
