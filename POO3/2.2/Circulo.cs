// programa: Circulo.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Classe para definir as caracteristicas de um circulo e suas funçoes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2._2
{
    class Circulo:IForma
    {
        private double raio;

        public Circulo(double raio)
        {
            raio = this.raio;
        }
        public Circulo()
        {

        }
        public double Raio
        {
            get
            {
                return raio;
            }
            set
            {
                raio = value;
            }
        }

        public double Area()
        {
            return (3.14*(raio*raio));// pi*raio^2
        }

        public double Perimetro()
        {
            return ((2*3.14)*raio);// 2*pi*raio
        }
    }
}
