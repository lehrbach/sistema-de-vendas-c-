using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
namespace MenuConsole
{
    public class Cliente
    {
        private static object reader;
        public string codigo;
        public string nome;
        public string idade;
        public string line = null;

       

        public static void DesenharMenu()
        {
            bool desenhaMenuCliente = true;

            while (desenhaMenuCliente)
            {
                Cliente novoCliente = new Cliente();
               
                  

                Console.Clear();

                mainMenu.DesenhaGrade(" CADASTRO DE CLIENTE ", ConsoleColor.Magenta);
                Console.SetCursorPosition(1,0);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════╗");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("║'C' = CADASTRAR CLIENTE       ║");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("║'L' = LISTAR CLIENTE          ║");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("║'D' = DELETAR CLIENTE         ║");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("║'P' = PESQUISAR CLIENTE       ║");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("║'V' = VOLTAR AO MENU          ║");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.Write("╚══════════════════════════════╝");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                Console.WriteLine("     DIGITE UMA OPÇÃO : ");
                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                var opcao = Console.ReadLine();

                switch (opcao.ToUpper())
                {
                    case "C":
                        Console.WriteLine("");
                        Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                        Console.Write("=> Nome do Cliente: ");
                        novoCliente.nome = Console.ReadLine();

                        Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                        Console.Write("=> Idade do Cliente: ");
                        novoCliente.idade = Console.ReadLine();

                        Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                        Console.Write("=> Código do Cliente: ");
                        novoCliente.codigo = Console.ReadLine();

                        //chamar algum método para cadastrar
                       
                            Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                            Console.Write("===== Cliente Cadastrado =======");
                            Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                            Console.Write("nome:  {0}", novoCliente.nome);
                            Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                            Console.Write("idade: {0}", novoCliente.idade);
                            Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                            Console.Write("codigo:{0}", novoCliente.codigo);
                            Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                            Console.Write("================================");
                            Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                            Console.Write("Precione tecla para voltar.");
                            Console.SetCursorPosition(5, cursorX + Console.CursorTop);

                           
                            string path = @"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\sistema_vendas\SISTEMA DE VENDAS\bancoDados-clientes.txt";
                            using (StreamWriter sw = File.AppendText(path))
                            {
                                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                                sw.WriteLine(novoCliente.codigo + "|" + "nome:" + novoCliente.nome);
                                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                                sw.WriteLine(novoCliente.codigo + "|" + "idade:" + novoCliente.idade);
                                Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                                sw.WriteLine(novoCliente.codigo + "|" + "codigo:" + novoCliente.codigo);
                                sw.WriteLine("                                                      ");
                            }
                        
                        Console.ReadKey();
                        break;

                    case "L":
                        int counter = 0;
                        string line;

                        // Leia o arquivo e exiba-o linha por linha.  
                        StreamReader file = new StreamReader(@"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\sistema_vendas\SISTEMA DE VENDAS\bancoDados-clientes.txt");
                        while ((line = file.ReadLine()) != null)
                        {
                            Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                            System.Console.WriteLine(line);
                            
                            counter++;
                        }
                        Console.SetCursorPosition(5, cursorY + Console.CursorTop);
                        System.Console.WriteLine("Clientes cadastrados: ", counter);
                        file.Close();
                        // Suspender a tela.  
                        System.Console.ReadLine();
                        List<Cliente> lista = new List<Cliente>();
                        break;
                    case "D":
                       
                            string texto;
                            int line_number = 0;
                            int line_delete = 0;

                            
                                using (StreamReader reader = new StreamReader(@"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\sistema_vendas
                            \SISTEMA DE VENDAS\bancoDados-clientes2.txt"))
                                using (StreamReader write = new StreamReader(@"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\sistema_vendas
                            \SISTEMA DE VENDAS\bancoDados-clientes3.txt"))
    
                                    Console.WriteLine("DIGITE O CODIGO DE REGISTRO DE CLIENTE");
                                line_delete = Convert.ToInt32(Console.ReadLine());
                             
                            
                        
                       
                       

                        break;
                        
                    
                   case "P":
                        Console.WriteLine("");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("=> Codigo: ");
                        
                        string cod = Console.ReadLine();

                        StreamReader re = File.OpenText(@"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\sistema_vendas\SISTEMA DE VENDAS\bancoDados-clientes.txt");
                        string input = re.ReadToEnd();
                        string linha;
                        
                      
                            System.IO.StreamReader arquivo =
                             new System.IO.StreamReader(@"C:\Users\halla\OneDrive\Área de Trabalho\sistema_vendas\sistema_vendas\SISTEMA DE VENDAS\bancoDados-clientes.txt");
                             while ((linha = arquivo.ReadLine()) != null)
                        {
                            if (linha.IndexOf(cod) >-1) {
                                System.Console.WriteLine(linha);
                            }
                        }
                    
                        re.Close();
                        arquivo.Close();
                        System.Console.ReadLine();
                        break;

                    case "V":
                        desenhaMenuCliente = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
