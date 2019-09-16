using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_3_Fatorial
{
  class ClassFatorial
  {
	public void fatorial (int num1) // Classe de fatoração
	{
		int mostrar = num1;
		
		for (int i = num1 - 1; i > 1; i--) // Fatoração
		{
			num1 *= i; // Cálculo
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
  }
}