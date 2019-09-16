//
// nome do programa: Ex623
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Caminho do diretorio
// saida(s): Imprime as pastas e arquivos do diretorio
// para executar  e testar digite: 
// Ex623.exe Diretorio01
// descricao: O programa recebe um caminho pela lc e imprime as pastas e arquivos que estao dentro dele
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_623
{
    class Ex623
    {
        static void Main(string[] args)
        {
            string path = args[0];

            if (Directory.Exists(path))
            {
                string[] diretorios = Directory.GetDirectories(path);
                string[] arquivos = Directory.GetFiles(path);
                if (diretorios.Length != 0)
                {
                    Console.WriteLine("**********Diretórios**********\n");
                    foreach (var dir in diretorios)
                    {
                        Console.WriteLine(dir);
                    }
                }

                if (arquivos.Length != 0)
                {
                    Console.WriteLine("\n**********Arquivos**********\n");

                    foreach (var arq in arquivos)
                    {
                        Console.WriteLine(arq);
                    }
                }
                
				if (arquivos.Length == 0 && diretorios.Length == 0)
				{
					Console.WriteLine("Diretorio vazio!");
				}
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Diretório inexistente!");
            }
        }
    }
}
