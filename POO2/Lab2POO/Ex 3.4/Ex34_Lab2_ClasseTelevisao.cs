using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisao
{
    class Televisao
    {
        //Atributos e Gets/Sets        
        private int canal;
        public int Canal
        {
            get
            {
                return canal;
            }
            set
            {
                canal = value;
            }
        }
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
        public string status;        
        //Metodos
        public Televisao()
        {
            status = "Desligado";
            canal = 1;
            volume = 0;
        }
        public Televisao(string status,int canal, int volume)
        {
            this.status = status;
            this.canal = canal;
            this.volume = volume;
        }
        public void StatusTV()
        {
            if (status == "Ligada")
            {
                status = "Desligada";
            }
            else
            {
                status = "Ligada";
            }
        }
        public void VolumeTv()
        {
            char opcaoVolume;
            int repetidor = 1;
            while (repetidor != 0)
            {
                Console.Write("Volume atual:{0}\nDigite (M) para voltar ao menu,(U) para aumentar e (D) para abaixar o volume:", volume);
                opcaoVolume = char.Parse(Console.ReadLine());
                if (opcaoVolume == 'd')
                {
                    if (volume == 0)
                    {
                        Console.Write("Volume minimo atingido.");
                        Console.ReadKey();
                    }
                    else
                    {
                       volume--;
                    }
                }
                if (opcaoVolume == 'u')
                {
                    if (volume == 100)
                    {
                        Console.Write("Volume maximo atingido.");
                        Console.ReadKey();
                    }
                    else
                    {
                        volume++;
                    }
                }
                if (opcaoVolume == 'm')
                {
                    repetidor = 0;
                }                
                Console.Clear();
            }
        }
        public void CanalTv()
        {
            char opcaoCanal;
            int repetidor = 1;
            while (repetidor != 0)
            {
                Console.Write("Canal atual:{0}\nDigite (M) para voltar ao menu,(U) para aumentar e (D) para abaixar o volume:", canal);
                opcaoCanal = char.Parse(Console.ReadLine());
                if (opcaoCanal == 'd')
                {
                    if(canal == 1)
                    {
                        canal = 83;
                    }
                    else
                    {
                        canal--;
                    }
                }
                if (opcaoCanal == 'u')
                {
                    if(canal == 83)
                    {
                        canal = 1;
                    }
                    else
                    {
                        canal++;
                    }
                }
                if (opcaoCanal == 'm')
                {
                    repetidor = 0;
                }
                Console.Clear();
            }
        }
    }
}