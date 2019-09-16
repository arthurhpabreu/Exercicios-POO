// Nome do programa: Ex3.2_Valores.cs
// Programador(es): João Gontijo
// Data: 17/08/2017
// Entrada(s): N numeros inteiros através da linha de comando
// Saida(s): Imprime o vetor de números ordenado, o menor, o maior e a média dos valores.
// Para executar digite: csc.bat Ex3.2_Valores.cs 
// Para testar digite: Ex3.2_Valores.exe 9 3 8 5
// Descricao: Recebe n numeros inteiros através da linha de comando,
// armazena em um vetor e chama um método estático que receba estes
// números inteiros (armazenados no vetor),  e retorna   o maior
// deles e a média de seus valores.
// Faltava: Ordenar o vetor na ordem crescente de valores, obter o menor valor.

using System;
using System.Text;

namespace Ex3_2_Valores
{
  class Program
  {
    static void Main(string[] args)
	{	 
	int contador = 0;
	
	bool teste = true;
	int[] teste2 = new int[args.Length];
		
	for (int i = 0; i < args.Length; i++) // Repetição
	{
		teste = int.TryParse(args[i], out teste2[i]); // Teste de erro
		
		if (teste == true)
		{
			contador++;
		}
	}
	
	if ((contador == args.Length) && args.Length > 0)
	{	
        int maior = 0, media = 0, menor = 0, aux = 0; // Inicializacao de variaveis para calculo 
	    
	    int j = args.Length; // Inicializacao de variaveis contadoras
	    
	    int [] vetor = new int[j]; // Alocacao de vetor para receber numeros inteiros
	    
	    Console.WriteLine("\nPrograma Ex3.2.exe com " + j + " parametros : ");
	    
	    for (int i = 0; i < j ; i++) // Mostra e converte parametros recebidos na LC
	    { 
	      Console.Write(" args[" + i + "] = "  + args[i]);
	      Console.Write(" args[{0}] = {1}", i, args[i]);
	      vetor[i] = int.Parse(args[i]); // Converte parametro recebidos na LC de string para inteiro e armazena no vetor
	      Console.WriteLine(" vetor[{0}] = {1}", i, vetor[i]); // Mostra vetor
        }
	    
	    Operar_valores(vetor, ref maior, ref media, ref menor, ref aux); // Chama metodo para fazer as operacoes solicitadas
	    
	    	Console.WriteLine("Maior : " + maior);   // Mostra maior valor
	    	Console.WriteLine("Media : " + media); // Mostra media dos valores
	    	Console.WriteLine("Menor : " + menor); // Mostra menor valor
	    	Console.Write("Vetor : ");
        
        for (int i = 0; i < vetor.Length; i++) // Mostrar valores ordenados
	    {
	    	 Console.Write(vetor[i] + " ");
        }		
    }
	else 
	{
		Console.Write("\n ERRO DE PARÂMETRO\n");
		Console.ReadKey();
	}
	}
    static void Operar_valores(int[] vetor, ref int maior, ref int media, ref int menor, ref int aux) // Método de operação
    {
		
     int soma = 0;
	 
	 media = 0;
	 maior = vetor[0];
	 menor = vetor[0];
	 
     for (int i = 0; i < vetor.Length; i++) 
	 {
        soma += vetor[i]; // Acumular valores
		
        if (vetor[i] > maior) // atualizar maior valor
        {
            maior = vetor[i];
        }
		if (vetor[i] < menor) // Atualizar menor Valor
		{
			menor = vetor[i];
		}
     }
	 
     media = soma / vetor.Length; // Calcular media dos valores
	 
	 for (int i = 0; i < vetor.Length; i++) // Ordenar o Vetor
     {
         for (int j = 0; j < vetor.Length; j++)
         {
             if (vetor[i] < vetor[j])
             {
                 aux = vetor[i];
                 vetor[i] = vetor[j];
                 vetor[j] = aux;
             }
         }
     }	 
    } 
 }  
}
