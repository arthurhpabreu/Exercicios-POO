using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31
{
    class ControleDePonto
    {
        public void Entrada (Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = agora.ToString();
            Console.WriteLine("ENTRADA: {0}", f.Nome);
            Console.WriteLine("DATA: {0}", horario);
            f.Trabalhando = true;
            f.historicoE.Add(horario);
        }

        public void Saida (Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = agora.ToString();
            Console.WriteLine("SAÍDA: {0}", f.Nome);
            Console.WriteLine("DATA: {0}", horario);
            f.Trabalhando = false;
            f.historicoS.Add(horario);
        }
    }
}
