using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    class Juridica : Contribuinte
    {
        //Atributos
        protected string cnpj;
        public string Cnpj
        {
            get
            {
                return cnpj;
            }
        }
        protected double faturamento;
        public double Faturamento
        {
            get
            {
                return faturamento;
            }
        }
        //Metodos
        public Juridica(string nome, string endereco, string cnpj, double faturamento)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cnpj = cnpj;
            this.faturamento = faturamento;
        }
        public override double CalcImposto(double faturamento)
        {
            return (0.1 * faturamento);
        }
        public override void Excluir()
        {
            nome = null;
            endereco = null;
            cnpj = null;
            faturamento = 0;
        }
    }
}
