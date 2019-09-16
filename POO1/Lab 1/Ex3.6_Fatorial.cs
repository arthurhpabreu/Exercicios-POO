// Nome do programa: Ex3.6_Fatorial
// Programador(es): João Gontijo
// Data: 19/08/2017
// Entrada(s): Um número para fatorar
// Saida(s): Um número fatorado
// Para executar digite: csc.bat Ex3.6_Fatorial.cs
// Para testar digite: Ex3.6_Fatorial.exe 4
// Descricao: Recebe um número e o fatora

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_6_Fatorial
{
  class Program
  {
	static void fatorial (int num1) // Método de fatoração
	{
		int mostrar = num1;
		
		for (int i = num1 - 1; i > 1; i--) // Fatoração
		{
			num1 *= i;
		}
		
		if (num1 == 0)
		{
			Console.Write("\n {0}! = {1}\n", mostrar, 1); // Imprime resultado
		    Console.ReadKey();
		}
		else
		{
			Console.Write("\n {0}! = {1}\n", mostrar, num1); // Imprime resultado
		    Console.ReadKey();
		}
	}
    static void Main(string[] args)
	{
		if (args.Length != 1)
		{
			Console.Write("\n PARÂMETRO INVÁLIDO!\n"); // Erro de parâmetro
			Console.ReadKey();
		}
		else
		{
			int num1;
			bool teste = int.TryParse(args[0], out num1); // Verificação de erro
			
			if (teste == true)
			{
				
			    num1 = int.Parse(args[0]); // Converte args
			
			    fatorial(num1); // Chama o método
			
			}
			else 
			{
				Console.Write("\n PARÂMETRO INVÁLIDO!\n"); // Erro de parâmetro
			    Console.ReadKey();
			}
		}
	}
  }
}