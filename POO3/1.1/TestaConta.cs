// programa: TestaConta.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Programa principal para executar ações de um banco
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    class TestaConta
    {
        static void Main(string[] args)
        {
            int d, option;
            double valor;
            Console.Write("\nNova conta deve ser criada - Digite o dia de aniversário: ");
            d = int.Parse(Console.ReadLine());
            if (d > 31 || d < 1)
            {
                while (d > 31 || d < 1)
                {
                    Console.WriteLine("\nDia inválido - Dia deve ser maior que 0 e menor que 31");
                    Console.Write("\nDigite o dia de aniversário: ");
                    d = int.Parse(Console.ReadLine());
                }
            }

            Conta c = new ContaPoupança(d);

            do
            {
                Console.Clear();
                Menu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Console.Clear();
                        Console.Write("\nDigite o valor a ser sacado: ");
                        valor = double.Parse(Console.ReadLine());
                        c.Saque(ref valor);
                        if (valor == -1)
                        {
                            Console.WriteLine("\nImpossível efetuar saque maior que o saldo disponível - Pressione qualquer tecla para sair");
                        }

                        else
                        {
                            Console.WriteLine("Saque efetuado com sucesso - Pressione qualquer tecla para sair");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Digite um valor para ser depositado: ");
                        valor = double.Parse(Console.ReadLine());
                        c.Deposito(ref valor);
                        if (valor == -1)
                        {
                            Console.WriteLine("\nImpossível efetuar depósito menor que 1 - Pressione qualquer tecla para sair");
                        }

                        else
                        {
                            Console.WriteLine("Depósito efetuado com sucesso - Pressione qualquer tecla para sair");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        c.ExibeExtrato();
                        Console.ReadKey();
                        break;
            
                    case 4:
                        break;
               
                    default:
                        break;
                }
            }
            while (option != 4);

        }

        static void Menu()
        {
            Console.WriteLine("MENU DE OPÇÕES");
            Console.WriteLine("\n1- Efetuar saque");
            Console.WriteLine("\n2- Efetuar depósito");
            Console.WriteLine("\n3- Imprimir extrato");
        }
    }
}
