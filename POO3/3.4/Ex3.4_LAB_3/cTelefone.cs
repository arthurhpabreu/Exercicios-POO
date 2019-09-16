// Programa: Exercício 3.4 do LAB 3
// Programadores: João Gontijo, Daniel Jorge, Arthur Henrique, Robert Victor, Breno Vieira.
// Data: 19/10/2017
// Descrição: Programa que Simula dois tipo de toque, analógico e digital. Usando Override, Polimorfismo e Herança
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._4_LAB_3
{
    class cTelefone
    {
        protected string tipoDoTelefone = "Analógico"; // Atributo

        public virtual void Ring()
        {
            Console.Write(" Tocando o {0}\n", tipoDoTelefone); // Método principal
        }
    }
}
