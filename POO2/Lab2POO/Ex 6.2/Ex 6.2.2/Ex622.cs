//
// nome do programa: Ex622
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Nao tem
// saida(s): Imprime o diretorio absoluto onde o programa esta sendo executado
// para executar  e testar digite: 
// Ex622.exe
// descricao: Mostra o nome do diretorio onde o programa foi executado
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_622
{
    class Ex622
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diretorio absoluto: {0}",Directory.GetCurrentDirectory());
        }
    }
}
