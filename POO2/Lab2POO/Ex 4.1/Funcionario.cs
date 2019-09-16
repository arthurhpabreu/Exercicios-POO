using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Funcionarios
    {
       protected string nome, rg;
       protected double salfixo;

        public string Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Rg
        {
            get
            {
                return this.rg;
            }

            set
            {
                this.rg = value;
            }
        }

        public double SalFixo
        {
            get
            {
                return this.salfixo;
            }

            set
            {
                this.salfixo = value;
            }
        }

    }
}
