// programa: Soma.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Classe com a funçao de somar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._5
{
    class Soma : IOperacaoMatematica
    {
        public Soma()
        {

        }
        public int Calcula(int a, int b)
        {
            return  (a + b);
        }
    }
}
