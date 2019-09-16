// Programa: Exercício 2.1 do LAB 3
// Programadores: João Gontijo, Daniel Jorge, Arthur Henrique, Robert Victor, Breno Vieira.
// Data: 19/10/2017
// Descrição: Programa que simula um controle de TV e DVD. Com funções de ligar, desligar, Volume, Aumentar e Diminuir o Canal,
// Inserir o Disco, Play, Pause, Stop.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Lab_3
{
    interface IControleRemoto // Interface do controle
    {
        void Power();

        void Volume(int volume);
    }
}
