//
// arquivo prova1_s217.cs
//
//
// programa prova1_s217.cs
// programadores: nome dos alunos (fulano, sicrano e beltrano)
// data: 10/08/2017 
// descricao: exemplo de passagem de parametros na linha de comando (lc)
// entrada(s) : parametros na linha de comandos (lc), sendo: 
// o numero de matricula (6 dígitos)e o nome completo do aluno 
// saida(s): exibe na tela os parametros na linha de comandom (lc)
// para executar  e testar digite: 
// prova1_s217.exe 231650 JOAO MANUEL FRAGOSOa 
// descricao de parametros opcionais na lc (variaveis pre-definidas do command prompt ou shell)
// args[0]:  primeiro parametro posicional na lc
// args[1] e args[8] segundo e nono parametros posicionais na lc
//
using System;
using System.Text;

namespace Prova1 {
   class Prova1 { 
	static void Main(string[] args) {
	 	int i,j, x, A=0, B=0, C=0, NMAT;
	  	int[ ] vetor = new int[10];
	  	string NOME1, NOME2;
      	  	double r = 0;
	  	j = args.Length;
	  	NMAT = int.Parse(args[0]);
	  	x = NMAT;
	  	NOME1 = args[1];  NOME2 = args[2];
	  	for (i = 0; x > 0; i++)  {
          	  		vetor[i] = x % 10 + j;
          	 		x = x / 10;
      	  	}
	  	A = vetor[1]; B = vetor[2]; C = vetor[3];
	  	Console.WriteLine("NOME1 = " + NOME1 + " NOME2 = " +  NOME2); 
	  	Console.WriteLine("A = " + A + " B = " + B + " C = " + C ); 
	  	Faz1(A, B, C); // primeira chamada
	  	Console.Write("A = " + A + " B = " + B + " C = " + C ); 
	  	Console.WriteLine(" r = " + r);
	  	r = Faz2(ref A, ref B, ref C); //segunda chamada
	  	Console.Write("A = " + A + " B = " + B + " C = " + C ); 
	  	Console.WriteLine(" r = " + r);	          
  	}
		
	public static void Faz1(int x, int y,  int z) {
      		Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
	  	x = x + 10; y = y + 20; z = z + 30;
      		z = x + y + z;
      		Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
    	}

	public static  double Faz2(ref int x, ref int y, ref int z){
		double w = 0;
	  	Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
	  	x = x + 10; y = y + 20; z = z + 30;
      		z = x + y + z;
      		Console.WriteLine("x = " + x + " y = " + y + " z = " + z);
      		w = x + y + z;
      		Console.Write("x = " + x + " y = " + y + " z = " + z);
     		 Console.WriteLine(" w = " + w);
      		return (w);
    	}
   }
}


