// programa: Imovel
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 24/09/2017
// Descrição: classe pai das classes velho e novo , com a funçao de salvar o preco do imovel.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4._3
{
    class Imovel
    {
        private double preco;// definiçao de atributo
        public double Preco// get e set para conseguir alterar o preço depois
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
            }
        }

        public virtual double PrecoFinal()// funçao virtual para ser sobrescrita nas classes filhas
        {
            return 0;
        }

        protected int RandomNumber(int min, int max)// funçao que gera numeros aleatorios
        {
            Random random = new Random();
            int resultado = random.Next(min, max);
            return resultado;
        }
    }
}