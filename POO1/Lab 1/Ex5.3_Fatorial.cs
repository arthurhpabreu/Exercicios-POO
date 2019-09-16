// Nome do programa: Ex5.3_Fatorial
// Programador(es): João Gontijo
// Data: 19/08/2017
// Entrada(s): Um número para fatorar
// Saida(s): Um número fatorado
// Para executar digite: csc.bat Ex5.3_Fatorial.cs Ex5.3_ClassFatorial.cs
// Para testar digite: Ex5.3_Fatorial.exe 4
// Descricao: Recebe um número e o fatora

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_3_Fatorial
{
  class Program
  {
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
			
			ClassFatorial fat = new ClassFatorial(); // Cria classe
			
			if (teste == true)
			{
				
			    num1 = int.Parse(args[0]); // Converte args
			
			    fat.fatorial(num1); // Chama a classe
			
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