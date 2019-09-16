// programa: Velho
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 24/09/2017
// Descrição: classe filha que pega o valor do preço e subtrai um numero aleatorio a ele
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4._3
{
    class Velho : Imovel
    {
        public Velho()// contrutor padrao
        {
            Preco = 0;
        }

        public override double PrecoFinal()//funçao que retorna o preço do imovel velho
        {
            double resultado = Preco - RandomNumber(50000, 400000);// numero entre 50000 e 400000

            if (Preco >= 0)
            {
                return resultado;
            }
            else
            {
                return 0;
            }
        }
    }
}