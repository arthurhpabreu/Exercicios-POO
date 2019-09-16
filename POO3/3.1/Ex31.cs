// programa: Ex31.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Programa principal para executar funções de uma empresa e prover registros de entrada e saida
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31
{
    class Ex31
    {
        const int nFunc = 100;

        static void Main(string[] args)
        {
            Funcionario[] f = new Funcionario[nFunc];
            int op, matricula;
            string nome, receptor;
            char tipo;
            ControleDePonto controle = new ControleDePonto();
            do
            {
                Console.Clear();
                Menu();
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        if (Funcionario.contador <= 100)
                        {
                            Console.Write("\nDigite o nome do funcionário: ");
                            nome = Console.ReadLine();
                            Console.Write("Selecione o tipo de funcionário - G para gerente, T para telefonista: ");
                            receptor = Console.ReadLine();
                            tipo = char.Parse(receptor.ToUpper());

                            switch (tipo)
                            {
                                case 'G':
                                    f[Funcionario.contador - 1] = new Gerente();
                                    f[Funcionario.contador - 1].Nome = nome;
                                    Console.WriteLine("\nGerente incluído, sua matrícula é {0} - Pressione qualquer tecla para sair", Funcionario.contador);
                                    Funcionario.contador++;
                                    break;

                                case 'T':
                                    f[Funcionario.contador - 1] = new Telefonista();
                                    f[Funcionario.contador - 1].Nome = nome;
                                    Console.WriteLine("\nTelefonista incluída, sua matrícula é {0} - Pressione qualquer tecla para sair", Funcionario.contador);
                                    Funcionario.contador++;
                                    break;

                                default:
                                    Console.WriteLine("\nTipo de funcionário inválido - Pressione qualquer tecla para sair");
                                    break;
                            }
                        }

                        else
                        {
                            Console.WriteLine("\nLimite de funcionários já foi atingido - Pressione qualquer tecla para sair");
                        }
                        break;

                    case 2:
                        Console.Write("\nDigite o número de matrícula do funcionário: ");
                        matricula = int.Parse(Console.ReadLine());
                        if (matricula > 0 && matricula <= Funcionario.contador)
                        {
                            if (!f[matricula - 1].Trabalhando)
                            {
                                controle.Entrada(f[matricula - 1]);
                            }

                            else
                            {
                                Console.WriteLine("\nFuncionário já está em serviço - Pressione qualquer tecla para sair");
                            }
                        }

                        else
                        {
                            Console.WriteLine("\nNúmero de matrícula inválido - Pressione qualquer tecla para sair");
                        }
                        break;

                    case 3:
                        Console.Write("\nDigite o número de matrícula do funcionário: ");
                        matricula = int.Parse(Console.ReadLine());
                        if (matricula > 0 && matricula <= Funcionario.contador)
                        {
                            if (f[matricula - 1].Trabalhando)
                            {
                                controle.Saida(f[matricula - 1]);
                            }

                            else
                            {
                                Console.WriteLine("\nFuncionário não está em serviço - Pressione qualquer tecla para sair");
                            }
                        }

                        else
                        {
                            Console.WriteLine("\nNúmero de matrícula inválido - Pressione qualquer tecla para sair");
                        }

                        break;

                    case 4:
                        for (int i = 1; i < Funcionario.contador; i++)
                        {
                            Console.WriteLine("FUNCIONÁRIO: {0}\nCARGO: {1}", f[i - 1].Nome, f[i-1].ToString());
                            for (int x = 0; x < f[i - 1].historicoE.Count; x++)
                            {
                                Console.WriteLine("\nENTRADA: {0}",  f[i - 1].historicoE.ElementAt(x));
                                Console.WriteLine("\nSAÍDA: {0}", f[i - 1].historicoS.ElementAt(x));
                            }

                            Console.WriteLine("\n----------------------------------------------\n");
                            
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nPressione qualquer tecla para sair");
                        break;

                    default:
                        Console.WriteLine("Opção inválida - Pressione qualquer tecla para sair");
                        break;
                }

                Console.ReadKey();
            } while (op != 5);
        }

        static void Menu()
        {
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine("\n1- Incluir novo Funcionário");
            Console.WriteLine("\n2- Registrar entrada do funcionário");
            Console.WriteLine("\n3- Registrar saída do funcionário");
            Console.WriteLine("\n4- Exibir histórico de ponto dos funcionários");
            Console.WriteLine("\n5- Sair do programa");
        }
    }
}
