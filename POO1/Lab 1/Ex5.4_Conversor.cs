// Nome do programa: Ex5.4_Conversor.cs
// Programador(es): João Gontijo
// Data: 21/08/2017
// Entrada(s): Uma temperatura em Celsius ou Fahrenheit
// Saida(s): A temperatura converitda para Celsius ou Fahrenheit
// Para executar digite: csc.bat Ex5.4_Conversor.cs Ex5.4_ClassConversor.cs
// Para testar digite: Ex5.4_Conversor.exe
// Descricao: Conversor de temperaturas, Celsius e Fahrenheit

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_4_Conversor
{
  class Program
  {
	static void Main(string[] args)
	{
		Console.Clear();
		// Variáveis
		int opcao = 0;
		double temperatura;
		
		string auxOpcao;
		string auxTemperatura;
		
		ClassConversor cnv = new ClassConversor(); // Criar classe
		
		while (opcao != 3)
		{
		    Console.Clear();
			// Menu
			Console.Write("\n 1. Converter de Celsius para Fahrenheit\n 2. Converter de Fahrenheit para Celsius\n 3. Sair do programa\n Digite sua opção: ");
			auxOpcao = Console.ReadLine();
			
			bool teste = int.TryParse(auxOpcao, out opcao); // Teste de erro
			
			if (teste == true && (opcao == 1 || opcao == 2)) // Verificação
            {
			    Console.Write("\n Digite a temperatura à converter: "); // Pedir a temperatura
			    auxTemperatura = Console.ReadLine();
			
			    bool teste2 = double.TryParse(auxTemperatura, out temperatura); // Teste de erro
			    
			    Console.Clear();
			    
			    if (teste == true && teste2 == true)
			    {
			        switch(opcao)
			        {
			        	case 1:
			    		
			    		cnv.conversor(temperatura,'c'); // Chama a classe
			    		
			    		break;
			    		
			    		case 2:
			    		
			    		cnv.conversor(temperatura,'f'); // Chama a classe
			    		
			    		break;
			    		
			    		case 3:
			    		break;
			    		
			    		default:
			    		
			    		Console.Write("\n OPÇÃO INVÁLIDA!"); // Informa erro
			    	    Console.ReadKey();
			    	    Console.Clear();
			    		
			    		break;
			        }
                }
			}
            else if (opcao != 3)
			{
				Console.Write("\n OPÇÃO INVÁLIDA!"); // Informa erro
				Console.ReadKey();
				Console.Clear();
		    }
			
			Console.Clear();
	    }
	}
  }
}