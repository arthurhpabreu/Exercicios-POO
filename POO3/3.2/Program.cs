// programa: Program.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Programa principal para imprimir extratos de uma conta escolhida pelo usuario
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static GeradorDeExtrato extratos;
        static void ContaCorrente()
        {
            ContaCorrente corrente = new ContaCorrente();
            corrente.Saldo = 1000;
            extratos.ImprimeExtratoBasico(corrente);
        }
        static void ContaPoupanca()
        {
            ContaPoupanca poupanca = new ContaPoupanca();
            poupanca.Saldo = 2000;
            extratos.ImprimeExtratoBasico(poupanca);
        }
        static void Main(string[] args)
        {
            extratos = new GeradorDeExtrato();
            int opcao, repetidor = 1;
            while(repetidor !=0)
            {
                Console.Write("Menu:\n1-Conta Corrente\n2-Conta Poupança\n3-Sair\nQual a opção desejada:");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(opcao)
                {
                    case 1:
                        ContaCorrente();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        ContaPoupanca();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        repetidor = 0;
                        break;
                    default:
                        Console.Write("Erro, opção invalida, digite algo para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
