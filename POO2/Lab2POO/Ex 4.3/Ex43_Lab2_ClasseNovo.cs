// programa: Novo
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 24/09/2017
// Descrição: classe filha que pega o valor do preço e adiciona um numero aleatorio a ele.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4._3
{
    class Novo : Imovel
    {
        public Novo()// construtor padrao
        {
            Preco = 0;
        }

        public override double PrecoFinal()// funçao que retorna o preço do imovel novo
        {
            double resultado = Preco + RandomNumber(50000, 400000);// adiciona numero aleatorio de 50000 a 400000
            return resultado;
        }
    }
}