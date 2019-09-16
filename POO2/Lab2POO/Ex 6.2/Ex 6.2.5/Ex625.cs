//
// nome do programa: Ex625
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Caminho do diretorio, novo nome do diretorio
// saida(s): Imprime se o diretorio teve o nome alterado, ou se é inexistente
// para executar  e testar digite: 
// Ex625.exe Diretorio01 DiretorioNovo
// descricao: Renomeia um diretorio
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_625
{
    class Ex625
    {
        static void Main(string[] args)
        {
            string pathAntigo = args[0];
            string pathNovo = args[1];
			string pathRaiz = "";
			pathRaiz = Directory.GetCurrentDirectory()+"\\";
            if (Directory.Exists(pathAntigo))
            {
				if (Path.GetDirectoryName(pathAntigo) != "")
				{
					pathRaiz = Path.GetDirectoryName(pathAntigo)+"\\";
				}
				Directory.Move(pathAntigo, pathRaiz+pathNovo);
                Console.WriteLine("Nome alterado");
            }
			else
			{
				Console.WriteLine("Diretório inexistente!");	
			}
            Console.ReadKey();
        }
    }
}
