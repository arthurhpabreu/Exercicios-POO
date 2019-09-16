// Nome do programa: Ex3.5_Calculadora.cs
// Programador(es): João Gontijo
// Data: 18/08/2017
// Entrada(s): Um cálculo na linha de comando
// Saida(s): Imprime o resultado do cálculo
// Para executar digite: csc.bat Ex3.5_Calculadora.cs
// Para testar digite: Ex3.5_Calculadora.exe 2.5 x 3
// Descricao: Recebe um cálculo e o executa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_5_Calculadora
{
  class Program
  {
	static void adicao (double num1, double num2) // Módulo de adição
    {
		Console.Write("\n {0} + {1} = {2}\n", num1, num2, num1 + num2);
		Console.ReadKey();
	}
	static void subtracao (double num1, double num2) // Módulo de subtração
    {
		Console.Write("\n {0} - {1} = {2}\n", num1, num2, num1 - num2);
		Console.ReadKey();
	}
	static void multiplicacao (double num1, double num2) // Módulo de multiplicacao
    {
		Console.Write("\n {0} x {1} = {2}\n", num1, num2, num1 * num2);
		Console.ReadKey();		
	}
	static void divisao (double num1, double num2) // Módulo de divisão
    {
		Console.Write("\n {0} / {1} = {2}\n", num1, num2, num1 / num2);
		Console.ReadKey();
	}
    static void Main(string[] args)
	{
		if (args.Length != 3)
		{
			Console.Write("\n QUANTIDADE DE PARÂMETROS INVÁLIDA! \n"); // Verificação de erro
			Console.ReadKey();
		}
		else
		{
	        double num1;
			bool teste1 = double.TryParse(args[0], out num1); // Variável de erro
			
	        char operacao;
			bool teste2 = char.TryParse(args[1], out operacao); // Variável de erro
	        
	        double num2;
			bool teste3 = double.TryParse(args[2], out num2); // Variável de erro
	        
			if (teste1 == true && teste2 == true && teste3 == true) // Teste de erro
			{
	            if (operacao == '+') // Condições
	            {
	            	adicao(num1, num2); // Chama método de adição
	            }
	            else if (operacao == '-') // Condições
	            {
	            	subtracao(num1, num2); // Chama método de subtração
	            }
	            else if (operacao == 'x' || operacao == 'X' || operacao == '*') // Condições
	            {
	            	multiplicacao(num1, num2); // Chama método de multiplicação
	            }
	            else if (operacao == '/' && (num2 != 0)) // Condições
	            {
	            	divisao(num1, num2); // Chama método de divisão
	            }
	            else
	            {
	            	Console.Write("\n Cálculo inválido\n"); // Imprime resposta ao erro
	            	Console.ReadKey();
	            }
			}
			else
			{
			Console.Write("\n ERRO DE PARÂMETRO! \n"); // Verificação de erro
			Console.ReadKey();
		    }
		}
	}
  }
}