using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing
{
    class Vip : Ingresso
    {
        double valorAdicional;

        public double impremeValorComAdicional()
        {
            return Valor + valorAdicional;
        }
        public void adicionaValorAdicional()
        {
            valorAdicional = 0.2 * Valor;
        }
        public void alteraValor()
        {
            Valor = Valor + valorAdicional;
        }
    }
}
