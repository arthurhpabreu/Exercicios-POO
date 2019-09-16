using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing
{
    class CamaroteInferior : Vip
    {
        string localizacao = "Camarote Inferior";

        public CamaroteInferior(double valor)
        {
            Valor = valor;
            adicionaValorAdicional();
            alteraValor();
        }
        public string impreLocalizacao()
        {
            return localizacao;
        }
    }
}
