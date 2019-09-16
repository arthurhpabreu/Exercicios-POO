// Nome do programa: Ex5.1_Saldo.cs
// Programador(es): João Gontijo
// Data: 24/08/2017
// Entrada(s): Opção no menu, Deposito, Saque
// Saida(s): Mostrar saldo
// Para executar digite: csc.bat Ex5.1_Saldo.cs Ex5.1_ClassSaldo.cs
// Para testar digite: Ex5.1_Saldo.exe
// Descricao: Um programa que registra e altera o saldo de uma pessoa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_1_Saldo
{
  class Program
  {
	static void Main(string[] args)
	{
		double saldo = 0; // Variáveis
		string suporte;
		int opcao = 0;
		
		ClassSaldo conta = new ClassSaldo(); // Criar classe
		
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
					
					saldo = conta.depositar(saldo); // Chama classe de depósito
					
					break;
					
					case 2:
					
					saldo = conta.sacar(saldo); // Chama classe de saque
					
					break;
					
					case 3:
					
					conta.imprimirSaldo(saldo); // Chama classe de imprimir na tela
					
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