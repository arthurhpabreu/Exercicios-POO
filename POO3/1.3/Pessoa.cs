using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Pessoa
    {
        protected string nome;
        protected string endereco;
        protected string nascimento;

        public string InformaNome()
        {
            return nome;
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }
        public string Nascimento
        {
            get
            {
                return nascimento;
            }
            set
            {
                nascimento = value;
            }
        }

    }
}
