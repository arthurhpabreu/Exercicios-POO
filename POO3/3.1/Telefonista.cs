using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31
{
    class Telefonista: Funcionario
    {
        int ramal;

        public int Ramal
        {
            get
            {
                return ramal;
            }

            set
            {
                if (value > 0)
                ramal = value;
            }
        }
    }
}
