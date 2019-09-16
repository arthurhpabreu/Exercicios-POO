// programa: subtraçao.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Classe com a funçao de subtrair
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._5
{
    class Subtraçao:IOperacaoMatematica
    {
        public Subtraçao()
        {

        }

        public int Calcula(int a, int b)
        {
            return (a - b);
        }
    }
}
