// Nome do programa: Ex3.8_Saldo.cs
// Programador(es): João Gontijo
// Data: 24/08/2017
// Entrada(s): Opção no menu, Deposito, Saque
// Saida(s): Mostrar saldo
// Para executar digite: csc.bat Ex3.8_Saldo.cs
// Para testar digite: Ex3.8_Saldo.exe
// Descricao: Um programa que registra e altera o saldo de uma pessoa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_8_Saldo
{
  class Program
  {
	static void depositar (ref double saldo) // Método de deposito
	{
		string auxTeste; // Variáveis
		double auxDeposito;
		
		Console.Write("\n Digite o valor à depositar: "); // Valor à depositar
		auxTeste = Console.ReadLine();
		
		bool teste = double.TryParse(auxTeste, out auxDeposito); // Teste de erro
		
		
		
		if (teste == true && auxDeposito > 0)
		{ 
			saldo += auxDeposito; // Alterar o saldo
		}
		else
		{
			Console.Write("\n VALOR INVÁLIDO!\n"); // Imformar erro
			Console.ReadKey();
			
		}
	}
	static void sacar (ref double saldo) // Método de saque
	{
		string auxTeste; // Variáveis
		double auxSaque;
		
		Console.Write("\n Digite o valor à sacar: "); // Solicitar valor
		auxTeste = Console.ReadLine();
		
		bool teste = double.TryParse(auxTeste, out auxSaque); // Teste de erro
		
		
		
		if (teste == true && auxSaque < saldo)		
		{ 
			saldo -= auxSaque; // Alterar saldo
		}
		else
		{
			Console.Write("\n VALOR INVÁLIDO!\n"); // Informar erro
			Console.ReadKey();
			
		}
	}
	static void imprimirSaldo (ref double saldo) // Método para informar saldo
	{
		Console.Write("\n Seu saldo é de {0} reais\n", saldo); // Informar saldo
		Console.ReadKey();
		
	}
	static void Main(string[] args)
	{
		double saldo = 0; // Variáveis
		string suporte;
		int opcao = 0;
		
		while (opcao != 4) // Repetição
		{
		    
			
			Console.Write("\n 1. Depositar\n 2. Sacar\n 3. Imprimir saldo\n 4. Sair\n Digite sua opção: "); // Menu
		    suporte = Console.ReadLine();
			
			
		    
		    bool teste = int.TryParse(suporte, out opcao); // Teste de erro
		    
		    if (teste == true)
		    {
		    	switch(opcao)
				{
					case 1:
					
					depositar(ref saldo); // Chama método de depósito
					
					break;
					
					case 2:
					
					sacar(ref saldo); // Chama método de saque
					
					break;
					
					case 3:
					
					imprimirSaldo(ref saldo); // Chama método de imprimir na tela
					
					break;
					
					case 4: // Usado para evitar mensagem de erro
					break;
					
					default:
					
					Console.Write("\n ERRO OPÇÃO INVÁLIDA!\n"); // Informa erro
				    Console.ReadKey();
					
				    
				    break;
				}
		    }
			else
			{
				Console.Write("\n ERRO OPÇÃO INVÁLIDA!\n"); // Informa erro
				Console.ReadKey();
				
			}
		}	
	}
  }
}