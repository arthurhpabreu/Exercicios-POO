// Nome do programa: Ex3.4_Votacao.cs
// Programador(es): João Gontijo
// Data: 18/08/2017
// Entrada(s): Um número inteiro através da linha de comando
// Saida(s): Imprime o número de votos e a porcentagem.
// Para executar digite: csc.bat Ex3.4_Votacao.cs
// Para testar digite: Ex3.4_Votacao.exe 6
// Descricao: Recebe o número de eleitores e contabiliza os votos.

using System;
using System.Text;

namespace Ex3_4_Votacao
{
  class Program
  {
    static void Main(string[] args)
	{
		if (args.Length != 1)
		{
			Console.Write("\n ERRO DE PARÂMETRO\n"); // Verificação de erro
			Console.ReadKey();
		}
		else
		{
		    // Variaveis
			string teste2;
		    int numEleitores;
		    int voto = 0;
		    int machado = 0, guimaraes = 0, cecilia = 0;
		    int i = 0;
			
			bool teste = int.TryParse(args[0], out numEleitores); // Primeiro teste de erro
			
			if (teste == true)
			{
				numEleitores = int.Parse(args[0]); // Teste de erro
			}
			else
			{
				numEleitores = 0; // Teste de erro
			}
		    
			if (numEleitores > 0)
			{
		        while (i < numEleitores)
		        {
		        	Console.Write("\n Digite o voto do {0}º eleitor (19,21,33): ", i + 1); // Solicita os votos
		        	teste2 = Console.ReadLine();
			    	
			    	bool teste3 = int.TryParse(teste2, out voto); // Segundo teste de erro
			    	
			    	
			    	if (teste3 == true)
			    	{
			    		voto = int.Parse(teste2); // Segundo teste de erro
			    	}
			    	else
			    	{
			    		voto = 0;
			    	}
			    	
					// Registro de votos
		        	if (voto == 19)
		        	{
		        		machado++;
		        		i++;
		        	}
		        	else if (voto == 21)
		        	{
		        		guimaraes++;
		        		i++;
		        	}
		        	else if (voto == 33)
		        	{
		        		cecilia++;
		        		i++;
		        	}
		        	else
		        	{
		        		Console.Write("\n Voto inválido\n"); // Verificação de erro
		        	}
		        }
		        // Imprime os resultados
		        Console.Write("\n O número de votos para o Machado de Assis é de {0} voto(s) - {1}%", machado, (machado * 100) / numEleitores);
		        Console.Write("\n O número de votos para o Guimarães Rosa é de {0} voto(s) - {1}%", guimaraes, (guimaraes * 100) / numEleitores);
		        Console.Write("\n O número de votos para o Cecília Meireles é de {0} voto(s) - {1}%", cecilia, (cecilia * 100) / numEleitores);
		        
		        Console.ReadKey();
			}
			else
			{
				Console.Write("\n ERRO DE PARÂMETRO\n"); // Verificação de erro
			    Console.ReadKey();
			}
		}
	}
  }
}