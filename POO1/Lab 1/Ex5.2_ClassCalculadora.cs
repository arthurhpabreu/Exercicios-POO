using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_2_Calculadora
{
  class operadores
  {
	public void adicao (double num1, double num2) // Classe de adição
    {
		Console.Write("\n {0} + {1} = {2}\n", num1, num2, num1 + num2); // Faz a conta
		Console.ReadKey();
	}
	public void subtracao (double num1, double num2) // Classe de subtração
    {
		Console.Write("\n {0} - {1} = {2}\n", num1, num2, num1 - num2); // Faz a conta
		Console.ReadKey();
	}
	public void multiplicacao (double num1, double num2) // Classe de multiplicacao
    {
		Console.Write("\n {0} x {1} = {2}\n", num1, num2, num1 * num2); // Faz a conta
		Console.ReadKey();		
	}
	public void divisao (double num1, double num2) // Classe de divisão
    {
		Console.Write("\n {0} / {1} = {2}\n", num1, num2, num1 / num2); // Faz a conta
		Console.ReadKey();
	}
  }
}