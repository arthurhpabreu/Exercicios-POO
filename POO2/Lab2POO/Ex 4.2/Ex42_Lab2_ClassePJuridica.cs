using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    class PJuridica : Contribuinte
    {
        private string cnpj;
        public string Cnpj
        {
            get
            {
                return cnpj;
            }
            set
            {
                cnpj = value;
            }
        }
        private double faturamento;
        public double Faturamento
        {
            get
            {
                return faturamento;
            }
            set
            {
                faturamento = value;
            }
        }
        public PJuridica()
        {
            Nome = string.Empty;
            Enderco = string.Empty;
            cnpj = string.Empty;
            faturamento = 0;
        }
        public PJuridica(string nome, string endereço, string cnpj, double faturamento)
        {
            Nome = nome;
            Enderco = endereço;
            this.cnpj = cnpj;
            this.faturamento = faturamento;
        }
        public override double CalcImposto()
        {
            return (faturamento * 0.1);
        }
        public override void Excluir()
        {
            Nome = null;
            Enderco = null;
            cnpj = null;
            faturamento = 0;
        }
        public override string Imprimir()
        {
            string dados = "Nome:" + Nome + "\nEndereço:" + Enderco + "\nCNPJ:" + cnpj + "\nFaturamento:" + faturamento + "\n";
            return dados;
        }
        public override int Comprarar(string registro)
        {
            if(registro == cnpj)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
