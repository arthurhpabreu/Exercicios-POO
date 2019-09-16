using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing
{
    class CamaroteSuperior : Vip
    {
        string localizacao = "Camarote Superior";
        double valorAdicionalCamaroteSup;

        public CamaroteSuperior(double valor)
        {
            Valor = valor;
            adicionaValorAdicional();
            alteraValor();
            adicionaValorAdicionalCamaroteSup();
            alteraValorCamroteSup();
        }

        public string impreLocalizacao()
        {
            return localizacao;
        }

        public void adicionaValorAdicionalCamaroteSup()
        {
            valorAdicionalCamaroteSup = 0.1 * Valor;
        }
        public void alteraValorCamroteSup()
        {
            Valor = Valor + valorAdicionalCamaroteSup;
        }
    }
}
