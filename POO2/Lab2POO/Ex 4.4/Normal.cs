using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing
{
    class Normal : Ingresso
    {
        public string impremeIngressoNormal()
        {
            return "Ingresso Normal";
        }

        public Normal(double valor)
        {
            Valor = valor;
        }
    }
}
