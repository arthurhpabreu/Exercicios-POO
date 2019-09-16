using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Vendedores: Funcionarios
    {
        double totalVendas, comissao;
        public static int contador=1;

        public Vendedores(string nome, string rg, double salfixo)
        {
            this.nome = nome;
            this.rg = rg;
            this.salfixo = salfixo;
        }

        public void Acumula(double n)
        {
            TotalVendas += n;
        }

        public double ExtraSS()
        {
            comissao = totalVendas * 5 / 100;
            return comissao;
        }

        public void ExibeSal()
        {
            Console.WriteLine("Salário a receber: {0}", SalFixo + ExtraSS());
            totalVendas = 0;
            comissao = 0;
        }

        public double TotalVendas
        {
            get
            {
                return totalVendas;
            }

            set
            {
                totalVendas = value;
            }
        }
    }
}
