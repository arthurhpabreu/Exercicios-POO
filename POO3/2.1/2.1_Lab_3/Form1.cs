// Programa: Exercício 2.1 do LAB 3
// Programadores: João Gontijo, Daniel Jorge, Arthur Henrique, Robert Victor, Breno Vieira.
// Data: 19/10/2017
// Descrição: Programa que simula um controle de TV e DVD. Com funções de ligar, desligar, Volume, Aumentar e Diminuir o Canal,
// Inserir o Disco, Play, Pause, Stop.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_Lab_3
{
    public partial class Form1 : Form
    {
        cTelevisor televisor = new cTelevisor(); // Objetos
        cDVD dvd = new cDVD();

        int seg = 0, min = 0, hr = 0; // Variaveis

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void powerTV_Click(object sender, EventArgs e)
        {
            televisor.Power(); // Método de Ligar a TV

            if (televisor.statusPower) // Mudar label e enables
            {
                statusTV.Text = "On";
                volumeTV.Enabled = true;
                aumentarCanal.Enabled = true;
                diminuirCanal.Enabled = true;
            }
            else 
            {
                statusTV.Text = "Off";
                volumeTV.Enabled = false;
                aumentarCanal.Enabled = false;
                diminuirCanal.Enabled = false;
            }
        }

        private void PowerDVD_Click(object sender, EventArgs e)
        {
            dvd.Power(); // Método de ligar o DVD

            if (dvd.statusPower)
            {
                statusDVD.Text = "On";
                volumeDVD.Enabled = true;
                inserirButton.Enabled = true;
                if (dvd.statusCD == true)
                {
                    playButton.Enabled = true;
                    stopButton.Enabled = true;
                }
            }
            else
            {
                statusDVD.Text = "Off";
                volumeDVD.Enabled = false;
                inserirButton.Enabled = false;
                playButton.Enabled = false;
                stopButton.Enabled = false;
                timer1.Enabled = false;
                statusFilme.Text = "00:00:00";
                dvd.Filme();
                playButton.Text = "PLAY";
            }
        }

        private void volumeTV_Scroll(object sender, EventArgs e)
        {
            televisor.Volume(volumeTV.Value);
            statusVolumeTV.Text = Convert.ToString(televisor.volume);
        }

        private void canalTV_Click(object sender, EventArgs e)
        {

        }

        private void VolumeDVD_Scroll(object sender, EventArgs e)
        {
            dvd.Volume(volumeDVD.Value);
            statusVolumeDVD.Text = Convert.ToString(dvd.volume);
        }

        private void aumentarCanal_Click(object sender, EventArgs e)
        {
            televisor.aumentarCanal();
            statusCanal.Text = Convert.ToString(televisor.canal);
        }

        private void diminuirCanal_Click(object sender, EventArgs e)
        {
            televisor.diminuirCanal();
            statusCanal.Text = Convert.ToString(televisor.canal);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            dvd.Filme();

            if (dvd.statusFilme)
            {
                playButton.Text = "PAUSE";
                inserirButton.Enabled = false;
                timer1.Enabled = true;
            }
            else
            {
                playButton.Text = "PLAY";
                inserirButton.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // Cronometro usado no filme
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            if (min == 60)
            {
                hr++;
                min = 0;
            }
            statusFilme.Text = hr.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');
        }

        private void inserirButton_Click(object sender, EventArgs e) // Metodo usado para verificar a existencia de disco
        {
            dvd.CD();

            if (dvd.statusCD)
            {
                statusCD.Text = "DISCO INSERIDO";
                inserirButton.Text = "Ejetar";
                statusFilme.Text = "00:00:00";
                playButton.Enabled = true;
                stopButton.Enabled = true;
            }
            else
            {
                statusCD.Text = "INSIRA O DISCO";
                inserirButton.Text = "Inserir";
                statusFilme.Text = "00:00:00";
                playButton.Enabled = false;
                stopButton.Enabled = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e) // botão de parada
        {
            statusFilme.Text = "00:00:00";
            dvd.Filme();
            playButton.Text = "PLAY";
            inserirButton.Enabled = true;
            timer1.Enabled = false;
            seg = 0;
            min = 0;
            hr = 0;
        }
    }
}
