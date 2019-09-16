//
// nome do programa: Ex624
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Caminho do diretorio
// saida(s): Imprime se o diretorio foi deletado ou se é inexistente
// para executar  e testar digite: 
// Ex624.exe Diretorio01
// descricao: Recebe o caminho de um diretorio pela lc, se ele existir, ele é deletado
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_624
{
    class Ex624
    {
        static void Main(string[] args)
        {
            string path = args[0];

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
				Console.WriteLine("Diretorio deletado!");
            }
            else
            {
                Console.WriteLine("Diretório inexistente!");
            }
        }
    }
}
