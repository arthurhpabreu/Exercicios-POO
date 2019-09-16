// programa: Testar Arquivos
// programadores: Daniel Jorge, Robert Victor, João Gontijo, Breno Vieira, Arthur Henrique
// data: 24/09/2017 
// descricao: exemplo de programa para manipular arquivo
// entrada(s): digitar para selecionar opção do menu
// saida(s): informação ou ação solicitada pelo menu
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicios
{
    class Ex56
    {
        static void Main(string[] args)
        {
            List<string> c = new List<string>();
            ConsoleKeyInfo receptor = new ConsoleKeyInfo();
            StreamWriter entradaE = new StreamWriter(args[0]);
            StreamWriter saidaE = new StreamWriter(args[1]);
            StreamReader entradaL;
            StreamReader saidaL;
            int i = 0;
            string x = "0";

            Console.WriteLine("Programa de teste do sistema de arquivos \nAlunos Robert, Daniel, Breno \nArquivo texto de entrada: entrada.txt \nArquivo texto de saída: saida.txt \nEntre com os caracteres: a x r s q w z *");

            while (!(string.Equals(x, "*")))
            {
                Console.Write("Informe o caracter: ");
                receptor = Console.ReadKey();
                c.Add(Convert.ToString(receptor.KeyChar));
                Console.WriteLine("\nCaracter adicionada\n");
                x = Convert.ToString(c[i]);
                i++;
            }

            i = 0;

            for (i = 0; i < c.Count - 1; i++)
            {
                entradaE.WriteLine(c[i]);
            }

            entradaE.Close();

            string[] chars = new string[c.Count];
            string[] charsM = new string[c.Count];

            entradaL = new StreamReader(args[0]);

            Console.Write("\nCaracteres digitados: ");
            for (i = 0; i < chars.Length - 1; i++)
            {
                chars[i] = entradaL.ReadLine();
                Console.Write(chars[i] + " ");
                saidaE.WriteLine(chars[i].ToUpper());
            }
            saidaE.Close();
            entradaL.Close();

            saidaL = new StreamReader(args[1]);

            Console.Write("\nCaracteres convertidos: ");
            for (i = 0; i < charsM.Length - 1; i++)
            {
                charsM[i] = saidaL.ReadLine();
                Console.Write(charsM[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
