//
// nome do programa: Ex44
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Tipo do ingresso, localizacao do camarote
// saida(s): Imprime o tipo do ingresso, ou a localizacao do camarote do tipo VIP e o preço do ingresso
// para executar  e testar digite: 
// Ex44.exe
// descricao: Pergunta ao usuario se ele quer comprar um ingresso do tipo Normal ou VIP,
// caso escolha normal, imprimo o tipo do ingresso e o valor.
// caso escolha Vip, o valor recebe um acrécimo de 20% do valor, é solicitado qual camarote o cliente quer, superior ou inferior,
// se o cliente quiser o superior tem mais um preco adicional no ingresso, que é de 10%
// se o cliente escolher o inferior, o acrécimo é somente o default do VIP.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double valorIngresso = 50;
            Console.WriteLine("****Menu de Ingresso******");
            Console.WriteLine("1 - Ingresso Normal");
            Console.WriteLine("2 - Ingresso Vip");
            Console.WriteLine("Digite o ingresso desejado:");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Normal ingresso = new Normal(valorIngresso);
                    Console.WriteLine("Tipo de ingresso: {0}", ingresso.impremeIngressoNormal());
                    Console.WriteLine("Valor do ingresso: R${0}", ingresso.Valor);
                    Console.ReadKey();
                    break;
                case 2:
                    menuVip();
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            CamaroteInferior camInf = new CamaroteInferior(valorIngresso);
                            Console.WriteLine("Localizacao: {0}", camInf.impreLocalizacao());
                            Console.WriteLine("Valor do ingresso: R${0}", camInf.Valor);
                            Console.ReadKey();
                            break;
                        case 2:
                            CamaroteSuperior camSup = new CamaroteSuperior(valorIngresso);
                            Console.WriteLine("Localizacao: {0}", camSup.impreLocalizacao());
                            Console.WriteLine("Valor do ingresso: R${0}", camSup.Valor);
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opcao Inválida");
                            Console.ReadKey();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Opcao Inválida");
                    Console.ReadKey();
                    break;
            }
        }
        public static void menuVip()
        {
            Console.WriteLine("*****Menu Ingresso VIP*****");
            Console.WriteLine("1 - Camarote Inferior");
            Console.WriteLine("1 - Camarote Superior");
            Console.WriteLine("Digite o camarote desejado:");
        }
    }
}
