using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    class Contribuinte
    {
        private string nome;
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
        private string enderco;
        public string Enderco
        {
            get
            {
                return enderco;
            }
            set
            {
                enderco = value;
            }
        }
        
        public virtual double CalcImposto()
        {
            return 0;
        }
        public virtual void Excluir()
        {

        }
        public virtual string Imprimir()
        {
            string dados = "";
            return dados;
        }     
        public virtual int Comprarar(string registro)
        {
            return 0;
        }
    }
}
