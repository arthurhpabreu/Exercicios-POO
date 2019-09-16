// programa: Quadrado.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Classe para definir as caracteristicas de um quadrado e suas funçoes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2._2
{
    class Quadrado : IForma
    {
        private double lado;
        public Quadrado(double lado)
        {
            lado = this.lado;
        }

        public Quadrado()
        {
            lado = 0;
        }

        public double Lado
        {
            get
            {
                return lado;
            }
            set
            {
                lado = value;
            }
        }

        public double Area()
        {
            return (lado * lado);
        }

        public double Perimetro()
        {
            return (lado * 4);
        }
    }
}
