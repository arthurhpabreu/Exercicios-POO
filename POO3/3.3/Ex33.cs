//
// nome do programa: Ex33
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 22/10/2017
// entrada(s): Nao tem
// saida(s): Imprime dados da conta
// para testar digite:
// Ex33.cs
// descricao: Sistema de contas, criacao, deposito, saque extrato e relatorio de contas por numero e titular.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        const int MAXCONTAS = 100; // número máximo de contas suportado
        public static Conta[] vetContas = new Conta[MAXCONTAS]; //vetor de contas
        public static int numContas = 0;
        
        static void Main(string[] args)
        {
            populaObjetodeContas();
            menu();
        }
        public static void menu()
        {
            Console.Clear();
            int op = 0, agencia,conta, tipoConta;
            string nome;
            Console.WriteLine("******** Menu ******** ");
            Console.WriteLine("1 - Criar uma nova conta");
            Console.WriteLine("2 - Excluir uma conta existente");
            Console.WriteLine("3 - Depositar em uma conta ");
            Console.WriteLine("4 - Sacar de em uma conta ");
            Console.WriteLine("5 - Imprimir o extrato de uma conta");
            Console.WriteLine("6 - Imprimir uma relação das contas existentes informando o número da conta e o nome do titular da conta");
            Console.WriteLine("7 - Sair do programa");
            Console.WriteLine("Digite a opcao desejada: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("Nome do Cliente: ");
                    nome = Console.ReadLine();
                    Console.Write("Agencia: ");
                    agencia = int.Parse(Console.ReadLine());
                    Console.Write("Tipo conta: ");
                    tipoConta = int.Parse(Console.ReadLine());

                    /*
                     * Tipo conta = 1 => Conta Corrente
                     * Tipo conta = 2 => Conta Poupança
                     */
                    if (tipoConta == 1)
                    {
                        numContas = 1;
                        while (Conta.verificaExistenciaConta(vetContas, numContas))
                        {
                            numContas++;
                            Console.WriteLine("Ja existe, virou "+numContas);

                        }
                        ContaCorrente contaCorrente = new ContaCorrente(nome,agencia,numContas,tipoConta, true);
                        vetContas[numContas-1] = contaCorrente;
                        
                        
                    }
                    else if (tipoConta == 2)
                    {
                        numContas = 1;
                        while (Conta.verificaExistenciaConta(vetContas, numContas))
                        {
                            numContas++;
                        }
                        ContaPoupanca contaPoupanca = new ContaPoupanca(nome, agencia, numContas, tipoConta, true);
                        vetContas[numContas-1] = contaPoupanca;
                    }
                    else
                    {
                        Console.WriteLine("Digite um tipo de conta Válido!");
                        Console.WriteLine("1 - Conta Corrente");
                        Console.WriteLine("2 - Conta Poupança");
                        voltaMenu();
                    }
                    Console.WriteLine("Conta criada com sucesso!");
                    voltaMenu();
                    break;
                case 2:
                    Console.WriteLine("Digite o numero da conta para excluíla");
                    conta = int.Parse(Console.ReadLine());
                    if (Conta.verificaExistenciaConta(vetContas, conta))
                    {
                        excluiConta(conta);
                        Console.WriteLine("Conta excluída com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Conta inexistente!");
                    }
                    voltaMenu();
                    break;
                case 3:
                    double valor;
                    Console.WriteLine("Digite o numero da conta:");
                    conta = int.Parse(Console.ReadLine());
                    if (Conta.verificaExistenciaConta(vetContas, conta))
                    {
                        Console.WriteLine("Digite um valor para depositar");
                        valor = double.Parse(Console.ReadLine());
                        if (valor > 0)
                        {
                            vetContas[conta - 1].Deposita(valor);
                            if (vetContas[conta - 1].TipoConta == 1)
                            {
                                vetContas[conta - 1].taxaPorOperacao(0.45);
                            }
                            Console.WriteLine("Deposito realizado!");
                        }
                        else
                        {
                            Console.WriteLine("Valor invalido!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Conta inexistente!");
                    }
                    voltaMenu();
                    break;
                case 4:
                    Console.WriteLine("Digite o numero da conta");
                    conta = int.Parse(Console.ReadLine());
                    if (Conta.verificaExistenciaConta(vetContas, conta))
                    {
                        Console.WriteLine("Digite o valor a ser sacado:");
                        valor = double.Parse(Console.ReadLine());
                        if (valor <= 0 || valor > vetContas[conta -1].Saldo)
                        {
                            Console.WriteLine("Você nao pode sacar esse valor!");
                        }
                        else
                        {
                            vetContas[conta - 1].Saca(valor);
                            if (vetContas[conta - 1].TipoConta == 1)
                            {
                                vetContas[conta - 1].taxaPorOperacao(0.45);
                            }
                            Console.WriteLine("Saque realizado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Conta inexistente");
                    }
                    voltaMenu();
                    break;
                case 5:
                    Console.WriteLine("Digite o numero da conta");
                    conta = int.Parse(Console.ReadLine());
                    if (Conta.verificaExistenciaConta(vetContas, conta))
                    {
                        GeradorDeExtrato geraExtrato = new GeradorDeExtrato();
						if (vetContas[conta - 1].TipoConta == 1)
                        {
                            vetContas[conta - 1].taxaPorOperacao(0.45);
                        }
                        geraExtrato.GeraExtrato(vetContas[conta - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Conta inexistente");
                    }
                    voltaMenu();
                    break;
                case 6:
                    imprimeRelacaoContasExistentes();
                    voltaMenu();
                    break;
                case 7:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Opcao invalida!");
                    voltaMenu();
                    break;
            }
        }
        static void voltaMenu()
        {
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            menu();
        }
        public static void imprimeRelacaoContasExistentes()
        {
            int cont = 0;
            for (int i = 0; i <= numContas; i++)
            {
                if (vetContas[i] != null)
                {
                    cont++;
                    Console.WriteLine("Numero: {0}\tTitular: {1}", vetContas[i].NumConta, vetContas[i].Nome);
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("Nao existe nenhuma conta");
            }
        }
        public static void populaObjetodeContas()
        {
            string dadosLinha = "";
            string line = "";
            string[] arrayDados = new string[5];
            if (Directory.Exists(Conta.path))
            {
                string[] arquivos = Directory.GetFiles(Conta.path);
                if (arquivos.Length != 0)
                {
                    foreach (var arq in arquivos)
                    {
                        StreamReader leArq = new StreamReader(arq);
                        while ((line = leArq.ReadLine()) != null)
                        {
                            dadosLinha = line;
                            arrayDados = dadosLinha.Split(';');
                            if (int.Parse(arrayDados[3]) == 1)
                            {
                                vetContas[int.Parse(arrayDados[2]) - 1] = new ContaCorrente(arrayDados[0],int.Parse(arrayDados[1]),int.Parse(arrayDados[2]),int.Parse(arrayDados[3]), double.Parse(arrayDados[4]));
                            }
                            else
                            {
                                vetContas[int.Parse(arrayDados[2]) - 1] = new ContaPoupanca(arrayDados[0], int.Parse(arrayDados[1]), int.Parse(arrayDados[2]), int.Parse(arrayDados[3]), double.Parse(arrayDados[4]));
                            }
                            numContas++;
                        }
                        leArq.Close();
                    }
                }
            }
        }

        public static void excluiConta(int conta)
        {
            vetContas[conta - 1] = null;
            string dadosLinha = "";
            string[] arrayDados = new string[5];
            if (Directory.Exists(Conta.path))
            {
                string[] arquivos = Directory.GetFiles(Conta.path);
                string line = "";
                if (arquivos.Length != 0)
                {
                    foreach (var arq in arquivos)
                    {
                        StreamReader leArq = new StreamReader(arq);
                        string[] novoArq = new string[File.ReadAllLines(arq).Length];
                        int count = 0;
                        while ((line = leArq.ReadLine()) != null)
                        {
                            dadosLinha = line;
                            arrayDados = dadosLinha.Split(';');
                            if (arrayDados[2] != Convert.ToString(conta))
                            {
                                novoArq[count] = dadosLinha;

                                count++;
                            }
                        }
                        leArq.Close();
                        StreamWriter grava = new StreamWriter(arq);
                        for (int i = 0; i < novoArq.Length; i++)
                        {
                            if (novoArq[i] != null)
                            {
                                grava.WriteLine(novoArq[i]);
                            }
                        }
                        grava.Close();
                    }
                }
            }
            populaObjetodeContas();
        }
    }
}
