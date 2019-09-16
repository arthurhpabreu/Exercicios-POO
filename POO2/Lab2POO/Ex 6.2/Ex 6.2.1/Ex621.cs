//
// nome do programa: Ex621
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Caminho do diretorio a ser criado com o nome do diretorio
// saida(s): Imprime se o diretorio foi criado, ou se ja é existente
// para executar  e testar digite: 
// Ex621.exe Diretorio01
// descricao: Cria um diretório no caminho especificado, se conter somente o nome
// cria o diretorio onde está o arquivo exe do programa
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_621
{
    class Ex621
    {
        static void Main(string[] args)
        {
            string nomeDir = args[0];
            if (!Directory.Exists(nomeDir))
            {
                Directory.CreateDirectory(nomeDir);
				Console.WriteLine("Diretorio criado");
            }
			else
			{
				Console.WriteLine("Diretório já existente !");
			}
        }
    }
}
