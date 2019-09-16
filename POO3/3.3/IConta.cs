using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    interface IConta
    {
        void Deposita(double valor);
        void Saca(double valor);
        double Saldo { get; set; }
        void CriaArquivo();
    }
}
