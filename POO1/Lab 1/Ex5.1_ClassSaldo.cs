using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_1_Saldo
{
    class ClassSaldo
    {
        public double depositar (double saldo) // Classe de deposito
        {
        	string auxTeste; // Variáveis
        	double auxDeposito;
        	
        	Console.Write("\n Digite o valor à depositar: "); // Valor à depositar
        	auxTeste = Console.ReadLine();
        	
        	bool teste = double.TryParse(auxTeste, out auxDeposito); // Teste de erro
        	
        	
        	
        	if (teste == true && auxDeposito > 0)
        	{ 
        		saldo += auxDeposito; // Alterar o saldo
				return saldo; // Retorna novo saldo
        	}
        	else
        	{
        		Console.Write("\n VALOR INVÁLIDO!\n"); // Imformar erro
        		Console.ReadKey();
        		
				return saldo; // Retorna saldo sem alteração
        	}
        }
        public double sacar (double saldo) // Classe de saque
        {
        	string auxTeste; // Variáveis
        	double auxSaque;
        	
        	Console.Write("\n Digite o valor à sacar: "); // Solicitar valor
        	auxTeste = Console.ReadLine();
        	
        	bool teste = double.TryParse(auxTeste, out auxSaque); // Teste de erro
        	
        	
        	
        	if (teste == true && auxSaque < saldo)		
        	{ 
        		saldo -= auxSaque; // Alterar saldo
				return saldo; // Retorna novo saldo
        	}
        	else
        	{
        		Console.Write("\n VALOR INVÁLIDO!\n"); // Informar erro
        		Console.ReadKey();
        		
				return saldo; // Retorna saldo sem alteração
        	}
        }
        public void imprimirSaldo (double saldo) // Classe para informar saldo
        {
        	Console.Write("\n Seu saldo é de {0} reais\n", saldo); // Informar saldo
        	Console.ReadKey();
        	
        }
    }
}