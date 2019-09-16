// programa: Copiar binário
// programadores: Daniel Jorge, Robert Victor, João Gontijo, Arthur Henrique, Breno Vieira
// data: 24/09/2017 
// descricao: Programa que faz a copia de um texto qualquer.
// entrada(s): linha de comando ambos arquivos, para copiar
// saida(s): arquivo copiado

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace copia_bin_cada_byte_sga_s116 {
		
  class copia_bin_cada_byte {
                
	static void Main(string[] args){	
		int i,b;
		// args[0]: nome do arquivo de origem (ja existente)
		// args[1]: nome do arquivo de destino(a ser criado)
		FileInfo fi = new FileInfo(args[0]); // cria objeto Fileinfo para obter atributos do arquivo 
		Console.WriteLine("Arquivo de origem: " + fi.Name); // exibe alguns atributos do arquivo
		Console.WriteLine("Diretorio: " +  fi.Directory);
		Console.WriteLine("Tamanho do arquivo: " + fi.Length);
		Console.WriteLine("Arquivo de destino: " + args[1]);
		Stream entrada  = File.Open(args[0], FileMode.Open); // abre arquivo de origem ja existente
		Stream saida = File.Open(args[1], FileMode.Create); // criar arquivo de destino
		for (i = 0; i < fi.Length ; i++) {        
			b = entrada.ReadByte();
			saida.WriteByte( (byte)b);
		}
		Console.WriteLine("Bytes copiados: " + i ); 
        entrada.Close();
		saida.Close();    		
	}
		
   }
}
