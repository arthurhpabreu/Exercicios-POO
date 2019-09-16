using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    class PFisica : Contribuinte
    {
        private string cpf;
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }
        private double salario;
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }
        public PFisica()
        {
            Nome = string.Empty;
            Enderco = string.Empty;
            cpf = string.Empty;
            salario = 0;
        }
        public PFisica(string nome, string endereço, string cps, double salario)
        {
            Nome = nome;
            Enderco = endereço;
            this.cpf = cps;
            this.salario = salario;
        }
        public override double CalcImposto()
        {
            if (salario >= 0 && salario <= 1400)
            {
                return 0;
            }
            else if (salario > 1400 && salario <= 2100)
            {
                return ((salario * 0.1) - 100);
            }
            else if (salario > 2100 && salario <= 2800)
            {
                return ((salario * 0.15) - 100);
            }
            else if (salario > 2800 && salario <= 3600)
            {
                return ((salario * 0.25) - 100);
            }
            else 
            {
                return ((salario * 0.30) - 100);
            }
        }
        public override void Excluir()
        {
            Nome = null;
            Enderco = null;
            cpf = null;
            salario = 0;
        }
        public override string Imprimir()
        {
            string dados = "Nome:" + Nome + "\nEndereço:" + Enderco + "\nCNPJ:" + cpf + "\nFaturamento:" + salario + "\n";
            return dados;
        }
        public override int Comprarar(string registro)
        {
            if (registro == cpf)
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
