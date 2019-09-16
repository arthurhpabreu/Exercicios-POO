// programa: Ex3.5.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Programa principal para executar as operaçoes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.");
            int num1, num2;
            int opcao = -1;
            
            while(opcao != 0)
            {
                Console.WriteLine("\t CALCULO \n 1 - SOMA \n 2 - SUBTRAÇAO \n 3 - MULTIPLICAÇÃO \n 4 - DIVISÃO \n OPÇAO:");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    Console.WriteLine("Entre com o primeiro numero:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o segundo numero:");
                    num2 = int.Parse(Console.ReadLine());

                    Soma soma = new Soma();

                    Console.WriteLine("Resultado:" + soma.Calcula(num1, num2));

                    Console.ReadKey();
                    Console.Clear();
                }
                else if(opcao == 2)
                {
                    Console.WriteLine("Entre com o primeiro numero:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o segundo numero:");
                    num2 = int.Parse(Console.ReadLine());

                    Subtraçao subtraçao = new Subtraçao();

                    Console.WriteLine("Resultado:" + subtraçao.Calcula(num1, num2));

                    Console.ReadKey();
                    Console.Clear();
                }
                else if(opcao == 3)
                {
                    Console.WriteLine("Entre com o primeiro numero:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o segundo numero:");
                    num2 = int.Parse(Console.ReadLine());

                    Multiplicacao multiplicaçao = new Multiplicacao();

                    Console.WriteLine("Resultado:" + multiplicaçao.Calcula(num1, num2));

                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Entre com o primeiro numero:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o segundo numero:");
                    num2 = int.Parse(Console.ReadLine());
                    if ((num1 / num2 == 0) && (num1 != 0 && num2 != 0))
                    {
                        Console.WriteLine("ERRO DIVISAO INVALIDA");
                    }
                    else
                    {
                        Divisao divisao = new Divisao();

                        Console.WriteLine("Resultado:" + divisao.Calcula(num1, num2));

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
