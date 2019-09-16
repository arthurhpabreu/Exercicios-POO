// programa: Exer4.3
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 24/09/2017
// Descrição: programa principal que utiliza as classes imovel ,novo e velho
// Entrada(s):Digitar 1 para imovel novo e 2 para imovel velho , e depois entre com o preço
// Saida:retorna preço final
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha se seu imovel é: \n 1- Novo  \n 2- Velho");

            int imovel = int.Parse(Console.ReadLine());

            if (imovel == 1)
            {
                Novo im1 = new Novo();
                Console.WriteLine("Escreva o Preço inicial do imovel:");
                im1.Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Preço Final:" + im1.PrecoFinal());
                Console.ReadKey();
            }
            if (imovel == 2)
            {
                Velho im2 = new Velho();
                Console.WriteLine("Escreva o Preço inicial do imovel:");
                im2.Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Preço Final:" + im2.PrecoFinal());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opçao Invalida!");
                Console.ReadKey();
            }
        }
    }
}