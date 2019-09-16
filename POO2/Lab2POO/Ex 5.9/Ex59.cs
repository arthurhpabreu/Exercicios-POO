using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            string caracteres, aux;
            FileInfo informacoes = new FileInfo(args[0]);
            Console.Write("Arquivo de entrada:{0}\nArquivo de saida{1}\n", args[0], args[1]);
            Console.Write("Digite uma sequencia de caractereres, depois digite * no ultimo caracter:");
            caracteres = Console.ReadLine();
            string[] separa = caracteres.Split('*');
            aux = separa[0];
            Console.Write("Caracter digitados:{0}\n",aux);
            char[] caracSeparado = new char[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                caracSeparado[i] = aux[i];
            }
            File.Create(args[0]);
            StreamWriter arqEntrada = new StreamWriter(args[0]);
            for (int i = 0; i < aux.Length; i++)
            {
                arqEntrada.WriteLine(caracSeparado[i]);
            }
            arqEntrada.Close();        
            Console.ReadKey();  
            
            if (File.Exists(args[0]))
            {
                int contLinhas = 0;
                StreamReader arqLeitura = new StreamReader(args[0]);
                string linha;
                linha = arqLeitura.ReadLine();
                string dados = "";
                while(linha != null)
                {
                    dados = linha + ',';
                    contLinhas++;
                    linha = arqLeitura.ReadLine();
                }
                string[] dadosColetados = dados.Split(',');
                File.Create(args[1]);
                StreamWriter arqEscrita = new StreamWriter(args[1]);
                for (int i = 0; i < contLinhas; i++)
                {
                    Console.Write(dadosColetados[i].ToUpper());
                    arqEscrita.WriteLine(dadosColetados[i].ToUpper());
                }
                arqEscrita.Close();
            }
            else
            {
                Console.Write("Erro, arquivo não existe.");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
