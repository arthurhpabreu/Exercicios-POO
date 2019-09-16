using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    class ContaPoupança: Conta
    {
        int diaAniv;

        public int DiaAniv
        {
            get
            {
                return diaAniv;
            }

            set
            {
                diaAniv = value;
            }
        }

        public ContaPoupança(int diaAniv)
        {
            saldo = 0;
            this.diaAniv = diaAniv;
        }

        public override void ExibeExtrato()
        {
            Console.WriteLine("EXTRATO DETALHADO DE CONTA POUPANÇA");
            DateTime now = DateTime.Now;
            Console.WriteLine("\nDATA: {0}", now);
            Console.WriteLine("\nSALDO: {0}", Saldo);
            Console.WriteLine("\nANIVERSÁRIO: {0}", diaAniv);
        }

        public override void Saque(ref double valor)
        {
            if (saldo - valor >= 0 && valor > 0)
            {
                saldo -= valor;
            }

            else
            {
                valor = -1;
            }
        }

        public override void Deposito(ref double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }

            else
            {
                valor = -1;
            }
        }
    }
}
