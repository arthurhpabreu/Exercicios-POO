// Nome do programa: Ex5.2_Calculadora.cs
// Programador(es): João Gontijo
// Data: 18/08/2017
// Entrada(s): Um cálculo na linha de comando
// Saida(s): Imprime o resultado do cálculo
// Para executar digite: csc.bat Ex5.2_Calculadora.cs Ex5.2_ClassCalculadora.cs
// Para testar digite: Ex5.2_Calculadora.exe 2.5 x 3
// Descricao: Recebe um cálculo e o executa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_2_Calculadora
{
  class Program
  {
    static void Main(string[] args)
	{
		if (args.Length != 3)
		{
			Console.Write("\n QUANTIDADE DE PARÂMETROS INVÁLIDA! \n"); // Verificação de erro
			Console.ReadKey();
		}
		else
		{
			Console.Clear();
			
	        double num1;
			bool teste1 = double.TryParse(args[0], out num1); // Variável de erro
			
	        char operacao;
			bool teste2 = char.TryParse(args[1], out operacao); // Variável de erro
	        
	        double num2;
			bool teste3 = double.TryParse(args[2], out num2); // Variável de erro
			
			operadores oper = new operadores();
	        
			if (teste1 == true && teste2 == true && teste3 == true) // Teste de erro
			{
	            if (operacao == '+') // Condições
	            {
	            	oper.adicao(num1, num2); // Chama classe de adição
	            }
	            else if (operacao == '-') // Condições
	            {
	            	oper.subtracao(num1, num2); // Chama classe de subtração
	            }
	            else if (operacao == 'x' || operacao == 'X' || operacao == '*') // Condições
	            {
	            	oper.multiplicacao(num1, num2); // Chama classe de multiplicação
	            }
	            else if (operacao == '/' && (num2 != 0)) // Condições
	            {
	            	oper.divisao(num1, num2); // Chama classe de divisão
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