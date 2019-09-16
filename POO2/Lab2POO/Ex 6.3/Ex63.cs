//
// nome do programa: Ex63
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Nao tem
// saida(s): Imprime dados dos sistemas de arquivos
// para executar  e testar digite: 
// Ex63.exe
// descricao: Pega os sistemas de arquivos da máquina e retorna as informacoes
//


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Ex_623
{
    class Ex63
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (var d in allDrives)
            {
                Console.WriteLine("\nNome do drive: {0}",d.Name);
                if (d.IsReady ==  true)
                {
                    Console.WriteLine("\tSistema de Arquivo: {0}", d.DriveFormat);
                    Console.WriteLine("\tTipo de drive: {0}", d.DriveType);
                    Console.WriteLine("\tDiretorio: {0}",d.RootDirectory);
                    Console.WriteLine("\tCapacidade total: {0} bytes", d.TotalSize);
                    Console.WriteLine("\tEspaço livre: {0} bytes",d.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("\tDrive nao está em funcionamento no momento");
                }

            }
            Console.ReadKey();
        }
    }
}
