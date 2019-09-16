using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    abstract class Conta
    {
        protected double saldo;

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value > 0)
                {
                    saldo = value;
                }
            }
        }

        public abstract void ExibeExtrato();
        public abstract void Saque(ref double valor);
        public abstract void Deposito(ref double valor);
    }
}
