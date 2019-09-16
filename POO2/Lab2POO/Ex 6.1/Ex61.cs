// programa: Arquivos
// programadores: Daniel Jorge, Robert Victor, João Gontijo, Breno Vieira, Arthur Henrique
// data: 24/09/2017 
// descricao: exemplo de programa para manipular arquivo
// entrada(s): digitar para selecionar opção do menu
// saida(s): informação ou ação solicitada pelo menu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicios
{
    class Ex61
    {
        static void Main(string[] args)
        {
            int op;
            string receptor, novoNome;
            string dir = Environment.CurrentDirectory;
            ConsoleKeyInfo k = new ConsoleKeyInfo();
                Console.Clear();
                Menu();
                k = Console.ReadKey();
                receptor = Convert.ToString(k.KeyChar);
                if (int.TryParse(receptor, out op))
                {
                    op = int.Parse(receptor);

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n1. Excluir o arquivo");
                            Console.WriteLine("--------------------------------------");
                            if (File.Exists(dir + @"\" +args[0]))
                            {
                                File.Delete(dir + @"\" + args[0]);                                
                                Console.WriteLine("\nArquivo excluido com sucesso - Pressione qualquer tecla para sair");
                            }

                            else
                            {
                                Console.WriteLine("\nArquivo inexistente - Pressione qualquer tecla para sair");
                            }

                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n2. Renomear o arquivo");
                            Console.WriteLine("--------------------------------------");
                            Console.Write("\nDigite o nome do arquivo a ser renomeado: ");
                            if (File.Exists(dir + @"\" + args[0]))
                            {
                                Console.Write("\nDigite o novo nome do arquivo: ");
                                novoNome = Console.ReadLine();
                                File.Move(dir + @"\" + args[0], dir + @"\" + novoNome);
                                Console.WriteLine("\nNome do arquivo alterado com sucesso - Pressione qualquer tecla para sair");
                            }

                            else
                            {
                                Console.WriteLine("\nArquivo inexistente - Pressione qualquer tecla para sair");
                            }

                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("\n3. Copiar um arquivo");
                            Console.WriteLine("--------------------------------------");
                        Console.Write("\nDigite o nome da cópia do arquivo: ");
                        novoNome = Console.ReadLine();
                        if (!string.Equals(args[0], novoNome))
                        {
                            File.Copy(args[0], novoNome);
                            Console.Write("\nArquivo copiado com sucesso - Pressione qualquer tecla para sair");
                        }
                            break;

                        case 4:
                        Console.Clear();
                            Console.WriteLine("\n4. Sair do programa");
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("\nPressione qualquer tecla para sair");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção digitada inválida - Pressione qualquer tecla para sair");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("\nOpção digitada inválida - Pressione qualquer tecla para sair");
                }
                Console.ReadKey();


        }

        static void Menu()
        {
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine("\n1. Excluir o arquivo");
            Console.WriteLine("\n2. Renomear o arquivo");
            Console.WriteLine("\n3. Copiar o arquivo");
            Console.WriteLine("\n4. Sair do programa");
        }
    }
}
