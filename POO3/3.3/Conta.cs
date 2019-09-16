using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    abstract class Conta : IConta
    {
        protected string nome;
        protected int agencia, conta, tipoConta;
        protected double saldo = 0;
        public static string path = @"Contas\";

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public int NumConta
        {
            get
            {
                return conta;
            }
            set
            {
                conta = value;
            }
        }

        public int Agencia
        {
            get
            {
                return agencia;
            }
            set
            {
                agencia = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        public int TipoConta
        {
            get
            {
                return tipoConta;
            }
            set
            {
                tipoConta = value;
            }
        }
        public void CriaArquivo()
        {
            if (!Directory.Exists(@"Contas"))
            {
                Directory.CreateDirectory(@"Contas");
            }
            string path = @"Contas\agencia" + agencia + ".txt";
            string content = nome + ";" + agencia + ";" + conta + ";" + tipoConta + ";" + saldo;
            StreamWriter escreve = new StreamWriter(path, true);
            if (!File.Exists(path))
            {
                File.Create(path);
                escreve.WriteLine(content);
            }
            else
            {
                escreve.WriteLine(content);
            }
            escreve.Close();
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
            alteraDadosArquivo();
        }

        public void Saca(double valor)
        {
            saldo -= valor;
            alteraDadosArquivo();
        }
        public static bool verificaExistenciaConta(Conta[] vetConta, int conta)
        {
            if (vetConta[conta - 1] != null)
            {
                return true;
            }
            return false;
        }

        public void taxaPorOperacao(double valor)
        {
            saldo -= valor;
            alteraDadosArquivo();
        }

        private void alteraDadosArquivo()
        {
            string dadosLinha = "";
            string[] arrayDados = new string[5];
            if (Directory.Exists(Conta.path))
            {
                string[] arquivos = Directory.GetFiles(Conta.path);
                string line = "";
                if (arquivos.Length != 0)
                {
                    foreach (var arq in arquivos)
                    {
                        StreamReader leArq = new StreamReader(arq);
                        string[] novoArq = new string[File.ReadAllLines(arq).Length];
                        int count = 0;

                        while ((line = leArq.ReadLine()) != null)
                        {
                            dadosLinha = line;
                            arrayDados = dadosLinha.Split(';');
                            if (arrayDados[2] != Convert.ToString(conta))
                            {
                                novoArq[count] = dadosLinha;
                            }
                            else
                            {
                                novoArq[count] = arrayDados[0] + ";" + arrayDados[1] + ";" + arrayDados[2] + ";" + arrayDados[3] + ";" + saldo;
                            }
                            count++;
                        }
                        leArq.Close();
                        StreamWriter grava = new StreamWriter(arq);
                        for (int i = 0; i < novoArq.Length; i++)
                        {
                            if (novoArq[i] != null)
                            {
                                grava.WriteLine(novoArq[i]);
                            }
                        }
                        grava.Close();
                    }
                }
            }
        }
    }
    
}
