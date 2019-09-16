// programa: Ex41
// programadores: Daniel Jorge, Robert Victor, João Gontijo, Arthur Henrique, Breno Vieira
// data: 24/09/2017 
// descricao: exemplo de programa utilizando classes, para simular uma empresa com classe vendedor e administrador.
// entrada(s): digitar para selecionar opção do menu
// saida(s): informação ou ação solicitada pelo menu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex41
    {
        const int MAXFUNC = 100;
         static Vendedores[] vetVendedores = new Vendedores[MAXFUNC];
        static Administrativos[] vetAdministrativos = new Administrativos[MAXFUNC];
        static void Main(string[] args)
        {
            int op = 0, n;
            string receptor, nome, rg;
            double salfixo, x;
            char tipo;
            do
            {
                Console.Clear();
                Menu();
                receptor = Console.ReadLine();
                if (int.TryParse(receptor, out op))
                {
                    op = int.Parse(receptor);
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n1. Incluir funcionário");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\nDigite o nome do novo funcionário: ");
                            nome = Console.ReadLine();
                            Console.Write("\nDigite o rg do novo funcionário:");
                            rg = Console.ReadLine();
                            Console.Write("\nDigite o salário fixo do novo funcionário: ");
                            receptor = Console.ReadLine();
                            if (double.TryParse(receptor, out salfixo))
                            {
                                salfixo = double.Parse(receptor);
                                Console.Write("\nDigite o tipo do funcionário - V para vendedor, A para administrativo: ");
                                receptor = Console.ReadLine();
                                receptor = receptor.ToUpper();
                                if (char.TryParse(receptor, out tipo))
                                {
                                    tipo = char.Parse(receptor);
                                    switch (tipo)
                                    {
                                        case 'V':
                                            vetVendedores[Vendedores.contador - 1] = new Vendedores(nome, rg, salfixo);
                                            Console.WriteLine("\nVendedor incluído \nNº do vendedor: {0} Pressione qualquer tecla para sair", Vendedores.contador);
                                            Vendedores.contador++;
                                            break;

                                        case 'A':
                                            vetAdministrativos[Administrativos.contador - 1] = new Administrativos(nome, rg, salfixo);
                                            Console.WriteLine("\nAdministrador inclúido \nNº do administrador: {0} Pressione qualquer tecla para sair", Administrativos.contador);
                                            Administrativos.contador++;
                                            break;

                                        default:
                                            Console.WriteLine("\nTipo inválido - Pressione qualquer tecla para sair");
                                            break;
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("\nTipo inválido - Pressione qualquer tecla para sair");
                                }
                            }

                            else
                            {
                                Console.WriteLine("\nValor digitado inválido - Pressione qualquer tecla para sair");
                            }
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n2. Alterar dados de um funcionário");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\nDigite o tipo do funcionário - V para vendedor, A para administrador: ");
                            receptor = Console.ReadLine();
                            receptor = receptor.ToUpper();
                            if (char.TryParse(receptor, out tipo))
                            {
                                tipo = char.Parse(receptor);
                                switch (tipo)
                                {
                                    case 'V':
                                        Console.Write("\nDigite o número do vendedor: ");
                                        receptor = Console.ReadLine();
                                        if (int.TryParse(receptor, out n))
                                        {
                                            n = int.Parse(receptor);
                                            if (n < Vendedores.contador)
                                            {
                                                Console.Write("\nDigite o nome do funcionário: ");
                                                vetVendedores[n - 1].Nome = Console.ReadLine();
                                                Console.Write("\nDigite o rg do funcionário:");
                                                vetVendedores[n - 1].Rg = Console.ReadLine();
                                                Console.Write("\nDigite o salário fixo do funcionário: ");
                                                receptor = Console.ReadLine();
                                                if (double.TryParse(receptor, out salfixo))
                                                {
                                                    vetVendedores[n - 1].SalFixo = double.Parse(receptor);
                                                    Console.WriteLine("\nDados alterados - Pressione qualquer tecla para sair");
                                                }

                                                else
                                                {
                                                    Console.WriteLine("\nValor digitado inválido - Pressione qualquer tecla para sair");
                                                }
                                            }

                                            else
                                            {
                                                Console.WriteLine("\nValor digitado inválido - Pressione qualquer tecla para sair");
                                            }                                            
                                           
                                        }

                                        else
                                        {
                                            Console.WriteLine("\nNúmero inválido - Pressione qualquer tecla para sair");
                                        }
                                        break;

                                    case 'A':
                                        Console.Write("\nDigite o número do administrador: ");
                                        receptor = Console.ReadLine();
                                        if (int.TryParse(receptor, out n))
                                        {
                                            n = int.Parse(receptor);
                                            if (n < Administrativos.contador)
                                            {
                                                Console.Write("\nDigite o nome do funcionário: ");
                                                vetAdministrativos[n - 1].Nome = Console.ReadLine();
                                                Console.Write("\nDigite o rg do funcionário:");
                                                vetAdministrativos[n - 1].Rg = Console.ReadLine();
                                                Console.Write("\nDigite o salário fixo do funcionário: ");
                                                receptor = Console.ReadLine();
                                                if (double.TryParse(receptor, out salfixo))
                                                {
                                                    vetAdministrativos[n - 1].SalFixo = double.Parse(receptor);
                                                    Console.WriteLine("\nDados alterados - Pressione qualquer tecla para sair");
                                                }

                                                else
                                                {
                                                    Console.WriteLine("\nValor digitado inválido - Pressione qualquer tecla para sair");
                                                }
                                            }

                                            else
                                            {
                                                Console.WriteLine("\nValor digitado inválido - Pressione qualquer tecla para sair");
                                            }
                                        }

                                        else
                                        {
                                            Console.WriteLine("\nNúmero inválido- Pressione qualquer tecla para sair");
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("\nTipo inválido - Pressione qualquer tecla para sair");
                                        break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("\nTipo inválido - Pressione qualquer tecla para sair");
                            }
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("\n3. Adicionar vendas para um Vendedor");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\nDigite o número do vendedor: ");
                            receptor = Console.ReadLine();
                            if (int.TryParse(receptor, out n))
                            {
                                n = int.Parse(receptor);
                                if (n < Vendedores.contador)
                                {
                                    Console.Write("\nDigite o total de vendas em R$: ");
                                    receptor = Console.ReadLine();
                                    if (double.TryParse(receptor, out x))
                                    {
                                        x = double.Parse(receptor);
                                        if (x > 0)
                                        {
                                            vetVendedores[n - 1].Acumula(x);
                                            Console.WriteLine("\nVenda registrada - Pressione qualquer tecla para sair");
                                        }

                                        else
                                        {
                                            Console.WriteLine("\nO valor da venda deve ser superior a 0 - Pressione qualquer tecla para sair");
                                        }
                                        
                                    }

                                    else
                                    {
                                        Console.WriteLine("\nValor inválido - Pressione qualquer tecla para sair");
                                    }
                                }

                                else

                                {
                                    Console.WriteLine("\nNúmero de vendedor inválido - Pressione qualquer tecla para sair");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNúmero de vendedor inválido - Pressione qualquer tecla para sair");
                            }
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("\n4. Adicionar horas extras para um Administrador");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\nDigite o número do administrador: ");
                            receptor = Console.ReadLine();
                            if (int.TryParse(receptor, out n))
                            {
                                n = int.Parse(receptor);

                                if (n < Administrativos.contador)
                                {
                                    Console.Write("\nDigite quantas horas extras deseja adicionar: ");
                                    receptor = Console.ReadLine();
                                    if (int.TryParse(receptor, out n))
                                    {
                                        n = int.Parse(receptor);
                                        vetAdministrativos[n - 1].Acumula(n);
                                        Console.WriteLine("\nHora extra adicionada - Pressione qualquer tecla para sair");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Número de horas inválidas - Pressione qualquer tecla para sair");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("\nNúmero do administrador inválido - Pressione qualquer tecla para sair");
                                }
                            }

                            else
                            {
                                Console.WriteLine("\nNúmero do administrador inválido - Pressione qualquer tecla para sair");
                            }
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("\n5. Excluir um funcionário");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\nDigite o tipo do funcionário - V para vendedor, A para administrativo: ");
                            receptor = Console.ReadLine();
                            receptor = receptor.ToUpper();
                            if (char.TryParse(receptor, out tipo))
                            {
                                tipo = char.Parse(receptor);
                                switch (tipo)
                                {
                                    case 'A':
                                        Console.Write("\nDigite o número de administrativo: ");
                                        receptor = Console.ReadLine();
                                        if (int.TryParse(receptor, out n))
                                        {
                                            n = int.Parse(receptor);

                                            if (n < Administrativos.contador)
                                            {
                                                vetAdministrativos[n - 1].Nome = null;
                                                vetAdministrativos[n - 1].Rg = null;
                                                vetAdministrativos[n - 1].SalFixo = 0;
                                                Console.WriteLine("\nFuncionário excluido - Pressione qualquer tecla para sair");
                                            }

                                            else
                                            {
                                                Console.WriteLine("\nNúmero administrativo inválido - Pressione qualquer tecla para sair");
                                            }
                                        }

                                        else
                                        {
                                            Console.WriteLine("\nNúmero administrativo inválido - Pressione qualquer tecla para sair");
                                        }


                                        break;

                                    case 'V':
                                        Console.Write("\nDigite o número de vendedor: ");
                                        receptor = Console.ReadLine();
                                        if (int.TryParse(receptor, out n))
                                        {
                                            n = int.Parse(receptor);
                                            if (n < Vendedores.contador)
                                            {
                                                vetVendedores[n - 1].Nome = null;
                                                vetVendedores[n - 1].Rg = null;
                                                vetVendedores[n - 1].SalFixo = 0;
                                                Console.WriteLine("\nFuncionario excluido - Pressione qualquer tecla para sair");
                                            }

                                            else
                                            {
                                                Console.WriteLine("\nNúmero de vendedor inválido - Pressione qualquer tecla para sair");
                                            }

                                        }

                                        else
                                        {
                                            Console.WriteLine("\nNúmero de vendedor inválido - Pressione qualquer tecla para sair");
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("\nTipo inválido - Pressione qualquer tecla para sair");
                                        break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("\nTipo inválido - Pressione qualquer tecla para sair");
                            }
                            Console.ReadKey();
                            break;

                        case 6:
                            Console.Clear();
                            Console.WriteLine("\n6. Imprimir todas as informações de um funcionário");
                            Console.WriteLine("------------------------------------------");
                            Console.Write("\nDigite o tipo do funcionário - V para vendedor, A para administrativo: ");
                            receptor = Console.ReadLine();
                            receptor = receptor.ToUpper();
                            if (char.TryParse(receptor, out tipo))
                            {
                                tipo = char.Parse(receptor);
                                switch (tipo)
                                {
                                    case 'A':
                                        Console.Write("\nDigite o número do funcionário administrativo: ");
                                        receptor = Console.ReadLine();
                                        if (int.TryParse(receptor, out n))
                                        {
                                            n = int.Parse(receptor);

                                            if (n < Administrativos.contador)
                                            {
                                                Console.WriteLine("\nNome: {0}", vetAdministrativos[n-1].Nome);
                                                Console.WriteLine("\nRG: {0}", vetAdministrativos[n - 1].Rg);
                                                Console.WriteLine("\nSalário fixo: {0}\n", vetAdministrativos[n - 1].SalFixo);
                                                vetAdministrativos[n - 1].ExibeSal();                                              
                                            }

                                            else
                                            {
                                                Console.WriteLine("\nNúmero administrativo inválido - Pressione qualquer tecla para sair");
                                            }

                                        }

                                        else
                                        {
                                            Console.WriteLine("\nNúmero administrativo inválido - Pressione qualquer tecla para sair");
                                        }
                                                break;

                                    case 'V':
                                        Console.Write("\nDigite o número de vendedor: ");
                                        receptor = Console.ReadLine();
                                        if (int.TryParse(receptor, out n))
                                        {
                                            n = int.Parse(receptor);

                                            if (n < Vendedores.contador)
                                            {
                                                Console.WriteLine("\nNome: {0}", vetVendedores[n - 1].Nome);
                                                Console.WriteLine("\nRG: {0}", vetVendedores[n - 1].Rg);
                                                Console.WriteLine("\nSalário fixo: {0}\n", vetVendedores[n-1].SalFixo);
                                                vetVendedores[n - 1].ExibeSal();                                               
                                            }

                                            else
                                            {
                                                Console.WriteLine("\nNúmero de vendedor inválido - Pressione qualquer tecla para sair");
                                            }
                                        }

                                        else
                                        {
                                            Console.WriteLine("\nNúmero de vendedor inválido - Pressione qualquer tecla para sair");
                                        }
                                        break;  

										default:
                                        Console.WriteLine("Tipo inválido - Pressione qualquer tecla para sair");
                                        break;     
									
                                }
                             }

                            else
                            {
                                Console.WriteLine("\nTipo inválido - Pressione qualquer tecla para sair");
                            }
                            Console.ReadKey();
                            break;

                        case 7:
                            Console.Clear();
                            Console.WriteLine("\n7. Imprimir relação de todos os funcionários");
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("\nVendedores");
                            for (int i = 0; i < Vendedores.contador - 1; i++)
                            {
                                Console.WriteLine("\nNome: {0}", vetVendedores[i].Nome);
                                Console.WriteLine("\nRG: {0}", vetVendedores[i].Rg);
                                Console.WriteLine("\nSalário fixo: {0}\n", vetVendedores[i].SalFixo);
                                vetVendedores[i].ExibeSal();
                            }
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("\nAdministradores");
                            for (int i = 0; i < Administrativos.contador - 1; i++)
                            {
                                Console.WriteLine("\nNome: {0}", vetAdministrativos[i].Nome);
                                Console.WriteLine("\nRG: {0}", vetAdministrativos[i].Rg);
                                Console.WriteLine("\nSalário fixo: {0}\n", vetAdministrativos[i].SalFixo);
                                vetAdministrativos[i].ExibeSal();
                            }
                            Console.ReadKey();
                            break;

                        case 8:
                            Console.Clear();
                            Console.WriteLine("\n8. Sair do programa");
                            Console.WriteLine("------------------------------------------");
							Console.WriteLine("Pressione qualquer tecla para sair");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Opção inválida - Pressione qualquer tecla para sair");
                            Console.ReadKey();
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("\nOpção em formato inválido - Pressione qualquer tecla para sair");
                }
            }

            while (op != 8);
        }

        static void Menu ()
        {
            Console.WriteLine("\nMENU DE OPÇÕES");
            Console.WriteLine("\n1. Incluir funcionário");
            Console.WriteLine("\n2. Alterar dados de um funcionário");
            Console.WriteLine("\n3. Adicionar vendas para um Vendedor");
            Console.WriteLine("\n4. Adicionar hora extra para um Administrador");
            Console.WriteLine("\n5. Excluir funcionário");
            Console.WriteLine("\n6. Imprimir todas as informações de um funcionário");
            Console.WriteLine("\n7. Imprimir a relação de todos os funcionários do sistema");
            Console.WriteLine("\n8. Sair do programa");
        }

    }
}
