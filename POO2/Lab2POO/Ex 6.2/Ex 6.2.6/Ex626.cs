//
// nome do programa: Ex626
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Caminho do diretorio a ser copiado, caminho para onde vai copiar o diretorio
// saida(s): Imprime se o diretorio foi copiado, ou se ja é existente
// para executar  e testar digite: 
// Ex626.exe Diretorio01 DiretorioCopiado
// descricao:Copia um diretorio existente para um caminho especificado
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_626
{
    class Ex626
    {
        static void Main(string[] args)
        {
            string pathAntigo = args[0];
            string pathNovo = args[1];
            if (Directory.Exists(pathAntigo))
            {
                copiaDiretorio(pathAntigo,pathNovo);
				Console.WriteLine("Diretorio copiado");
            }

            else
            {
                Console.WriteLine("Diretório inexistente!");
            }
                Console.ReadKey();
        }
        public static void copiaDiretorio(string input, string output)
        {
            if (!Directory.Exists(output))
            {
                Directory.CreateDirectory(output);
            }

            if (!string.IsNullOrEmpty(input))
            {
                string[] arquivos = Directory.GetFiles(input);
                foreach (string arquivo in arquivos)
                {
                    File.Copy(input + @"\" + Path.GetFileName(arquivo), output + @"\" + Path.GetFileName(arquivo), true);
                }
                string[] diretorios = Directory.GetDirectories(input);
                foreach (string diretorio in diretorios)
                {
                    copiaDiretorio(diretorio, output + @"\" + diretorio.Split(Convert.ToChar(@"\"))[diretorio.Split(Convert.ToChar(@"\")).Length - 1]);
                }
            }

        }

    }
}
