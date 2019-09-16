// Programa: Conta
// Programadores: João Gontijo, Daniel Jorge, Robert Victor, Breno Vieira, Arthur Hentirque
// Data: 22/09/2017
// Descrição: Programa usando classes para simular várias contas bancarias
// Entradas: 1 a 7 para as opções 8 para sair
// Saidas: Informação ou ação soliciatada pelo menu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string auxTeste, nome;

            int opcao = 0,conta;

            double valor;

            Conta[] vetorConta = new Conta[100];

            while (opcao != 8)
            {
                Console.Clear();

                Console.Write("\n 1 - Criar conta\n 2 - Excluir conta existente\n 3 - Depositar em uma conta\n 4 - Sacar em uma conta\n 5 - Imprimir saldo da conta\n 6 - Imprimir a relação das contas existentes listando o número e o nome do titular da conta\n 7 - Mostrar informações de uma conta\n 8 - Sair\n\n  Digite sua opção: ");
                auxTeste = Console.ReadLine();

                bool teste = int.TryParse(auxTeste, out opcao);

                if (teste == true && opcao > 0 || opcao < 8)
                {
                    switch (opcao)
                    {
                        case 1: // Criar Conta
                            Console.Clear();

                            Console.Write(" Para criar sua conta, digite seu nome: ");
                            nome = Console.ReadLine();
                            
                            vetorConta[Conta.contador] = new Conta(1, Conta.contador + 1, nome);

                            Console.Write("\n Nome: {2}\n Nº da conta: {0}\n Agência: {1}", vetorConta[Conta.contador].NumConta, vetorConta[Conta.contador].Agencia, vetorConta[Conta.contador].Titular);

                            Console.ReadKey();

                            Conta.contador++;
                            break;

                        case 2: // Excluir conta existente
                            Console.Clear();

                            Console.Write(" Digite o número da conta que deseija excluir: ");
                            conta = int.Parse(Console.ReadLine());

                            Console.Write("\n\n Confirme a exclusão (S/N): ");
                            char confirmação = char.Parse(Console.ReadLine());

                            if (confirmação == 's' || confirmação == 'S')
                            {
                                if (conta <= Conta.contador && conta > 0)
                                {
                                    vetorConta[conta - 1].excluirConta();
                                    Console.Write("\n\n Conta excluída com sucesso");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Write("\n Conta inexistente"); // Erro
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Write("\n Conta não excluída"); // Erro / Confirmação negada
                                Console.ReadKey();
                            }                           
                            break;
                        case 3: // Depositar em uma conta
                            Console.Clear();

                            Console.Write(" Digite o número da conta que deseija depositar: ");
                            conta = int.Parse(Console.ReadLine());

                            if (conta <= Conta.contador && conta > 0)
                            {
                                Console.Write("\n\n Digite o valor à depositar: ");
                                valor = double.Parse(Console.ReadLine());

                                if (valor > 0)
                                {
                                    vetorConta[conta - 1].depositar(valor);
                                    Console.Write("\n Valor depositado com suceeso");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Write("\n\n Valor Inválido"); // Erro
                                    Console.ReadKey();
                                }                                
                            }
                            else
                            {
                                Console.Write("\n Conta inexistente"); // Erro
                                Console.ReadKey();
                            }

                            break;
                        case 4: // Sacar em uma conta
                            Console.Clear();

                            Console.Write(" Digite o número da conta que deseija sacar: ");
                            conta = int.Parse(Console.ReadLine());

                            if (conta <= Conta.contador && conta > 0)
                            {
                                Console.Write("\n\n Digite o valor à sacar: ");
                                valor = double.Parse(Console.ReadLine());

                                if (valor < vetorConta[conta - 1].Saldo)
                                {
                                    vetorConta[conta - 1].sacar(valor);

                                    Console.Write("\n Valor retirado com suceeso");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Write("\n\n Saldo inválido"); // Erro
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Write("\n Conta inexistente"); // Erro
                                Console.ReadKey();
                            }
                            break;
                        case 5: // Imprimir saldo da conta
                            Console.Clear();

                            Console.Write(" Digite o número da conta que deseija verificar o saldo: ");
                            conta = int.Parse(Console.ReadLine());

                            if (conta <= Conta.contador && conta > 0)
                            {
                                Console.Write("\n O saldo da conta {0} é de R${1}", conta, vetorConta[conta - 1].Saldo);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("\n Conta inexistente"); // Erro
                                Console.ReadKey();
                            }
                            break;
                        case 6: // Imprimir a relação das contas existentes listando o número e o nome do titular da conta
                            Console.Clear();

                            for (int i = 0; i < Conta.contador; i++)
                            {
                                if (vetorConta[i].NumConta > 0)
                                {
                                    Console.Write("\n\n Nome: {0}\n Nº da conta:{1}", vetorConta[i].Titular, vetorConta[i].Agencia);
                                }
                                else
                                {
                                    Console.Write("\n Não possui contas no sistema"); // Erro
                                }
                            }

                            Console.ReadKey();
                            break;
                        case 7: // Mostrar informações de uma conta
                            Console.Clear();

                            Console.Write(" Digite o número da conta que deseija verificar as informações: ");
                            conta = int.Parse(Console.ReadLine());

                            if (conta <= Conta.contador && conta > 0)
                            {
                                Console.Write("\n Nome: {0}\n Nº da conta:{1}\n Agência:{2}\n Saldo: R${3}", vetorConta[conta - 1].Titular, vetorConta[conta - 1].Agencia, vetorConta[conta - 1].NumConta, vetorConta[conta - 1].Saldo);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("\n Conta inexistente"); // Erro
                                Console.ReadKey();
                            }
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write(" Opção inválida"); // Erro
                    opcao = 0;
                }

            }
        }
    }
}
