using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Administrativos: Funcionarios
    {
        double hExtra, comissao;
        public static int contador = 1;

        public double Comissao
        {
            get
            {
                return comissao;
            }
            
            set
            {
                comissao = value;
            }
        }

        public double Hxtra
        {
            get
            {
                return hExtra;
            }

            set
            {
                hExtra = value;
            }
        }

        public Administrativos(string nome, string rg, double salfixo)
        {
            this.nome = nome;
            this.rg = rg;
            this.salfixo = salfixo;
        }

        public void Acumula(double n)
        {
            Comissao += n;
        }

        public double ExtraSS()
        {
            comissao = salfixo / 100 * hExtra;
            return comissao;
        }

        public void ExibeSal()
        {
            Console.WriteLine("Salário a receber: {0}", SalFixo + ExtraSS());
            hExtra = 0;
            comissao = 0;
        }
    }
}
