using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_4_Conversor
{
  class ClassConversor
  {
	public void conversor (double temp, char tipo) // Classe de converção
	{
		
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
  }
}