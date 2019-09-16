using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ex_31
{
    abstract class Funcionario
    {
        public static int contador = 1;
       protected string nome;
        public List<string> historicoE = new List<string>();
        public List<string> historicoS = new List<string>();
        protected bool trabalhando = false;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public bool Trabalhando
        {
            get
            {
                return trabalhando;
            }

            set
            {
                trabalhando = value;
            }
        }

        public override string ToString()
        {
            string[] vetString;
            string x = base.ToString();

            vetString = x.Split('.');
            return vetString[1];
        }

    }
    }
