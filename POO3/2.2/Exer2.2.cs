// programa: Exer2.2.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Programa principal para armazenar os diferentes objetos em arraylist e depois printar.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Exer2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas Formas deseja criar?(quadrado,retangulo ou circulo:");

           ArrayList ListaFormas = new ArrayList();

            int quantidade = int.Parse(Console.ReadLine());

            for (int x = 0; x < quantidade; x++) // criar arraylist de objetos 
            {
                Console.WriteLine("Qual forma deseja criar?:");

                string nome = Console.ReadLine();

                if(nome == "quadrado" || nome == "Quadrado")
                {
                   Console.WriteLine("Entre com o Lado do quadrado:");

                   double lado = double.Parse(Console.ReadLine());
                   var quadrado = new Quadrado();

                   quadrado.Lado = lado;

                   ListaFormas.Add(quadrado);

                }
                else if(nome =="retangulo" || nome == "Retangulo")
                {

                    Console.WriteLine("Entre com o primeiro lado:");
                    double lado1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Entre com o segundo lado:");
                    double lado2 = double.Parse(Console.ReadLine());

                    var retangulo = new Retangulo();

                    retangulo.Lado1 = lado1;
                    retangulo.Lado2 = lado2;

                    ListaFormas.Add(retangulo);
                }
                else if(nome == "circulo" || nome == "Circulo")
                {
                    Console.WriteLine("Entre com o raio do circulo:");
                    double raio = double.Parse(Console.ReadLine());

                    var circulo = new Circulo();
                    circulo.Raio = raio;

                    ListaFormas.Add(circulo);
                }
                else
                {
                    Console.WriteLine("Erro opcao invalida");
                }

                
            }
            for (int x = 0; x < quantidade; x++) // testar e printar os objetos
            {
                var forma = ListaFormas[x];
                Console.Write($"Forma[{x}] => {forma.GetType()}");

                if (forma is Circulo)
                {
                    Console.Write($" com Raio : {(forma as Circulo).Raio}");
                    Console.WriteLine(" e perimetro :" + (forma as Circulo).Perimetro() + " e Area :" + (forma as Circulo).Area());
                }

                else if (forma is Quadrado)
                {
                    Console.Write($" com Lado : {(forma as Quadrado).Lado}");
                    Console.WriteLine(" com area de :" + (forma as Quadrado).Area() + " e perimetro de : " + (forma as Quadrado).Perimetro());
                }
                else if (forma is Retangulo)
                {
                    Console.Write($" com Lado 1 : {(forma as Retangulo).Lado1} e Lado 2 : {(forma as Retangulo).Lado2}");
                    Console.WriteLine(" com area de :" + (forma as Retangulo).Area() + " e perimetro de : " + (forma as Retangulo).Perimetro());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
           
            }
            }

        }
    


