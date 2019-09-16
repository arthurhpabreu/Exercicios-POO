// Nome do programa: Ex3.3_Data.cs
// Programador(es): João Gontijo
// Data: 18/08/2017
// Entrada(s): Uma data na linha de comando dd/mm/aaaa
// Saida(s): Imprime o número de dias decorridos no ano.
// Para executar digite: csc.bat Ex3.3_Data.cs
// Para testar digite: Ex3.3_Data.exe 15/01/2010
// Descricao: Recebe uma data e verifica quantos dias do ano já se passaram.

using System;
using System.Text;

namespace Ex3_3_Data
{
  class Program
  {
	static void quantosDias (int dia, int mes, int ano) // Método para calcular a quantidade de dias
	{
		DateTime data = new DateTime(ano, mes, dia); // Registra a data digitada pelo usuario
		DateTime primeiroDia = new DateTime(ano, 1, 1); // Registra o primeiro dia do ano
		TimeSpan diferença = data - primeiroDia; // Cálcula a quantidade de dias/datas/ano de um ano pelo outro
		
		int resultado = diferença.Days; // Transforma a conta para dias

		Console.Write("\n Se passaram {0} dias do ano.", resultado); // Imprime na tela o resultado
	}
    static void Main(string[] args)
	{
		if (args.Length != 1)
		{
			Console.Write("\n ERRO DE PARÂMETRO\n"); // Verificação de erro
			Console.ReadKey();
		}
		else
		{
		    char delimitador = '/';
		    
		    string[] data = args[0].Split(delimitador); // Divide a data
		    
		    int dia = int.Parse(data[0]); // Variáveis
		    int mes = int.Parse(data[1]);
		    int ano = int.Parse(data[2]);
		    
		    if ((ano % 4 == 0) && (dia > 0 && dia <= 31) && (mes > 0 && mes <= 12) && ano > 0) // Condições / Validações
		    {
		    	quantosDias(dia, mes, ano);
		    }
		    else
		    {
		    	Console.Write("\n Data inválida"); // Mensagem de erro
		    }
		    
		    Console.ReadKey();
		}
	}
  }
}
		