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
    class cTelevisor : IControleRemoto
    {
        public bool statusPower = false; // Atributos
        public int volume = 0;
        public int canal = 1;

        public void Volume(int vol)
        {
            volume = vol; // Volume Televisor
        }

        public void Power() //  Status da televisão (on/off)
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

        public void aumentarCanal() // Aumentar canal
        {
            if (canal >= 1 && canal <= 82)
            {
                canal++;
            }
            else
            {
                canal = 1;
            }
        }
        public void diminuirCanal() // Diminuir canal
        {
            if (canal >= 2 && canal <= 83)
            {
                canal--;
            }
            else
            {
                canal = 83;
            }
        }
    }
}