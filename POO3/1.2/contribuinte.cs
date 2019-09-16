using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    public abstract class Contribuinte
    {
        static private int cont = -1;
        static public int Cont
        {
            get
            {
                return cont;
            }
            set
            {
                cont = value;
            }
        }
        //Atributos
        protected string nome;
        public string Nome
        {
            get
            {
                return nome;
            }            
        }
        protected string endereco;
        public string Endereco
        {
            get
            {
                return endereco;
            }
        }
        //Metodos
        abstract public double CalcImposto(double salario);
        abstract public void Excluir();
    }
}
