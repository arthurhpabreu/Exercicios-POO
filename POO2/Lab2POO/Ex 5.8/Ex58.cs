using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
// copia_texto_linha_sga_s217 
// copia_binario_cada_byte_sga_s217.exe arq_origem arq_destino
namespace copia_texto_linha_s217 {
		
  class copia_texto_linha_s217 {
                
	static void Main(string[] args){	
		int i=0;
		String linha;  //para ler ou escrever linhas do ou para o arquivo
		// args[0]: nome do arquivo de origem (ja existente): arq_origem
		// args[1]: nome do arquivo de destino(a ser criado): arq_destino
		FileInfo fi = new FileInfo(args[0]); // cria objeto Fileinfo para obter atributos do arquivo
		Console.WriteLine("Arquivo de origem: " + fi.Name); // exibe alguns atributos do arquivo
		Console.WriteLine("Diretorio: " +  fi.Directory);
		Console.WriteLine("Tamanho do arquivo: " + fi.Length);
		Console.WriteLine("Arquivo de destino: " + args[1]);
		
		if (File.Exists(args[0]))  //se existe o arquivo...
        {// Aqui se tem certeza que o arquivo existe

			StreamReader entrada = new StreamReader(args[0]); //abrir o arquivo origem
			StreamWriter saida   = new StreamWriter(args[1]); //abre arquivo de destino
			linha = entrada.ReadLine();     //ler 1a linha
            while (linha != null)           //enquanto houver dados...
            {
                saida.WriteLine(linha);      //escreve no arquivo
				linha = entrada.ReadLine(); //ler proxima linha
				i++;
            }
            entrada.Close();       //fecha arquivo de leitura
			saida.Close();  //fecha o arquivo de escrita
        }
		Console.WriteLine("Bytes copiados: " + i ); 
            		
	}
		
   }
}
