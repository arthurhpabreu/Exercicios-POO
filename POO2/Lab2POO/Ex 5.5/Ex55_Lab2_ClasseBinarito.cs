// programa: Copiar binário
// programadores: Daniel Jorge, Robert Victor, João Gontijo, Arthur Henrique, Breno Vieira
// data: 24/09/2017 
// descricao: Programa que faz a copia de um arquivo qualquer (texto ou binário).
// entrada(s): linha de comando ambos arquivos, para copiar
// saida(s): arquivo copiado

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace copia_bin_cada_byte
{
    class copia_bin_cada_byte
    {
        static void Main(string[] args)
        {
            // args[0]: nome do arquivo de origem (ja existente): arq_origem
            // args[1]: nome do arquivo de destino(a ser criado): arq_destino
            FileInfo fi = new FileInfo(args[0]); // cria objeto Fileinfo para obter atributos do arquivo
            Console.WriteLine("Arquivo de origem: " + fi.Name); // exibe alguns atributos do arquivo
            Console.WriteLine("Diretorio: " + fi.Directory);
            Console.WriteLine("Tamanho do arquivo: " + fi.Length);
            Console.WriteLine("Arquivo de destino: " + args[1]);
            Stream entrada = File.Open(args[0], FileMode.Open); // abrir arquivo
			Stream saida = File.Open(args[1], FileMode.Create); // criar arquivo
			BinaryReader f1 = new BinaryReader(entrada);
			BinaryWriter f2 = new BinaryWriter(saida);
			byte[ ] buf = new byte[1]; // buffer para armazenar byte(s) lido(s)
			int lidos; // byte(s) lido(s) ou escritos em cada etapa
			while (true)
			{
				lidos = f1.Read(buf, 0, 1); // ler um byte de cada vez
				if (lidos < 0) break; // erro no arquivo
				if (lidos == 0) break; // fim de arquivo
				f2.Write(buf, 0, lidos); // escrever byte(s) lido(s)
			}
			f1.Close(); // fechar arquivo de leitura
			f2.Close(); // fechar arquivo de escrita
        }
    }
}