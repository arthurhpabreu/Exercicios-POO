// Nome do programa: Ex3.7_Conversor.cs
// Programador(es): João Gontijo
// Data: 21/08/2017
// Entrada(s): Uma temperatura em Celsius ou Fahrenheit
// Saida(s): A temperatura converitda para Celsius ou Fahrenheit
// Para executar digite: csc.bat Ex3.7_Conversor.cs
// Para testar digite: Ex3.7_Conversor.exe 10 c
// Descricao: Conversor de temperaturas, Celsius e Fahrenheit

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_7_Conversor
{
  class Program
  {
	static void conversor (string num1, string char1) // Método de converção
	{
		double temp = double.Parse(num1); // Variáveis
		char tipo = char.Parse(char1);// Variáveis
		
		if ((tipo == 'f' || tipo == 'F') && temp > -459.76)
		{
			Console.Write("\n {0} graus Fahrenheit = {1} graus Celsius\n", temp, (temp - 32) / 1.8); // Converção de F para C
			Console.ReadKey();
		}
		else if ((tipo == 'c' || tipo == 'C') && temp > -273.15)
		{
			Console.Write("\n {0} graus Celsius = {1} graus Fahrenheit\n", temp, (temp * 1.8) + 32); // Converção de C para F
			Console.ReadKey();
		}
		else 
		{
			Console.Write("\n TEMPERATURA INVÁLIDA\n"); // Mensagem de erro
			Console.ReadKey();
		}		
	}
	static void Main(string[] args)
	{
		if (args.Length != 2)
		{
			Console.Write("\n NÚMERO DE PARÂMETROS INVÁLIDO!\n"); // Verificador de entradas
			Console.ReadKey();
		}
		else
		{	
			double temp;
			bool teste = double.TryParse(args[0], out temp); // Verificar se é possivel a converção
			
		    char tipo;
			bool teste2 = char.TryParse(args[1], out tipo); // Verificar se é possivel a converção
			
			if (teste == true && teste2 == true)
			{
				conversor(args[0], args[1]); // Chamar o método
			}
		    else 
		    {
		    	Console.Write("\n TEMPERATURA INVÁLIDA\n"); // Mensagem de erro
		    	Console.ReadKey();
		    }
		}
	}
  }
}