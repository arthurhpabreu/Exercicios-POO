using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class GeradorDeExtrato
    {
        public void GeraExtrato(IConta c)
        {
            System.Console.WriteLine(" EXTRATO ");
            System.Console.WriteLine(" SALDO : " + c.Saldo);
        }
    }
}
