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
    class cDVD : IControleRemoto
    {
        public bool statusPower = false; // Atributos
        public int volume = 0;
        public bool statusFilme = false;
        public bool statusCD = false;

        public void Volume(int vol)
        {
            volume = vol; // Volume DVD
        }

        public void Power() // Status Power (on/off)
        {
            if (!statusPower)
            {
                statusPower = true;
            }
            else
            {
                statusPower = false;
            }
        }

        public void Filme() // Status do filme, se ele está rodando ou não
        {
            if (!statusFilme)
            {
                statusFilme = true;
            }
            else
            {
                statusFilme = false;
            }
        }

        public void CD() // Status do CD, se ele está inserido ou não
        {
            if (!statusCD)
            {
                statusCD = true;
            }
            else
            {
                statusCD = false;
            }
        }
    }
}
