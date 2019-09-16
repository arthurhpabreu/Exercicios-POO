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
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Programadores: João Gontijo, Daniel Jorge, Arthur Henrique, Robert Victor, Breno Vieira.\n\n");

            cTelefoneEletronico TelefoneEletronico = new cTelefoneEletronico(); // Objetos
            cTelefone Telefone = new cTelefone();

            Telefone.Ring(); // Chamar métodos
            TelefoneEletronico.Ring();

            Console.ReadKey();
        }
    }
}
