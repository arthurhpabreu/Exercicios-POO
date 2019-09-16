// programa: Retangulo.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Classe para definir as caracteristicas de um retangulo e suas funçoes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2._2
{
    class Retangulo:IForma
    {
        private double lado1,lado2;

        public Retangulo(double lado1 , double lado2)
        {
            lado1 = this.lado1;
            lado2 = this.lado2;
        }
        public Retangulo ()
        {
            lado1 = 0;
            lado2 = 0;
        }
        public double Lado1
        {
            get
            {
                return lado1;
            }
            set
            {
                lado1 = value;
            }
        }
        public double Lado2
        {
            get
            {
                return lado2;
            }
            set
            {
                lado2 = value;
            }
        }
        public double Area()
        {
            return (lado1*lado2);
        }

        public double Perimetro()
        {
            return ((lado1*2)+(lado2*2));
        }
    }
}
