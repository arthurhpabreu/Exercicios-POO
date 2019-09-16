using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Pessoa
    {
        private DateTime nasc = new DateTime(01/01/2017);
        private double peso, altura;
        public static int contador=1;

        public Pessoa (DateTime nasc, double altura, double peso)
        {
            if (!(nasc > DateTime.Now))
            {
                this.nasc = nasc;
            }
            this.peso = peso;
            this.altura = altura;
        }

       public DateTime Nasc
        {
            get
            {
                return this.nasc;
            }

            set
            {
                this.nasc = value;
            }
        }

        public double Peso
        {
            get
            {
                return this.peso;
            }

            set
            {
                this.peso = value;
            }
        }

        public double Altura
        {
            get
            {
                return this.altura;
            }

            set
            {
                this.altura = value;
            }
        }
    }
}
