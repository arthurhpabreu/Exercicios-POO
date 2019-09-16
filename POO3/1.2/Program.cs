// programa: Program.cs
// programadores: Daniel Jorge,Robert Victor,Breno Vieira,Arthur Henrique,João Gontijo.
// data: 19/10/2017
// Descrição: Programa principal para executar cadastros e calculos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Imposto
{
    class Program
    {
        const int maxContribuintes = 100;
        static Contribuinte[] lst = new Contribuinte[maxContribuintes];
        //Verifacor de CPF/CNPJ
        static bool Verificador(string registro)
        {
            bool verificador = false;
            StreamReader arqContriLeitura = new StreamReader("cadastros.txt");
            string linha;
            linha = arqContriLeitura.ReadLine();
            while (linha != null)
            {
                if(linha == "")
                {
                    linha = arqContriLeitura.ReadLine();
                }
                else
                {
                    string[] separado = linha.Split(',');
                    if (separado[1] == registro)
                    {
                        verificador = true;
                    }
                    linha = arqContriLeitura.ReadLine();
                }                
            }
            arqContriLeitura.Close();
            if (verificador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
        //Cadastro de Contribuinte
        static void CadContribuinte()
        {
            char tipo;
            string registro, nome, endereco;
            double valor;
            if(!File.Exists("cadastros.txt"))
            {
                StreamWriter arqCadastros = new StreamWriter("cadastros.txt");
                arqCadastros.Close();
            }
            Console.Write("Informe abaixo os dados do contribuinte.\nO contribuinte é Pessoa Fisica ou Juridica (Digite F ou J):");
            tipo = char.Parse(Console.ReadLine());
            if(tipo == 'f' || tipo == 'F')
            {
                Console.Write("Digite o CPF do contribuinte:");
                registro = Console.ReadLine();
                if (Verificador(registro) == true)
                {
                    Console.Write("Erro, contribuinte já registrado.\n");
                }
                else
                {
                    Console.Write("Qual o nome do Contribuinte:");
                    nome = Console.ReadLine();
                    Console.Write("Qual o enderço do Contribuinte(Digite o Rua , numero)):");
                    endereco = Console.ReadLine();
                    Console.Write("Qual salario do Contribuinte:");
                    valor = double.Parse(Console.ReadLine());
                    Fisica PFisica = new Fisica(nome, endereco, registro, valor);
                    StreamReader arq = new StreamReader("cadastros.txt");
                    string dados = arq.ReadToEnd();
                    arq.Close();
                    StreamWriter arqEscrever = new StreamWriter("cadastros.txt");
                    string linha = dados + "PF" + "," + PFisica.Cpf + "," + PFisica.Nome + "," + PFisica.Endereco + "," + PFisica.Salario;
                    arqEscrever.WriteLine(linha);
                    arqEscrever.Close();
                    Contribuinte.Cont++;
                    lst[Contribuinte.Cont] = PFisica;
                }
            }
            else if (tipo == 'J' || tipo == 'j')
            {
                Console.Write("Digite o CNPJ do contribuinte:");
                registro = Console.ReadLine();
                if (Verificador(registro))
                {
                    Console.Write("Erro, contribuinte já registrado.\n");
                }
                else
                {
                    Console.Write("Qual o nome do Contribuinte:");
                    nome = Console.ReadLine();
                    Console.Write("Qual o enderço do Contribuinte(Digite o Rua , numero)):");
                    endereco = Console.ReadLine();
                    Console.Write("Qual faturamento do Contribuinte:");
                    valor = double.Parse(Console.ReadLine());
                    Juridica PJuridica = new Juridica(nome, endereco, registro, valor);
                    StreamReader arq = new StreamReader("cadastros.txt");
                    string dados = arq.ReadToEnd();
                    arq.Close();
                    StreamWriter arqEscrever = new StreamWriter("cadastros.txt");
                    string linha = dados + "PJ" + "," + PJuridica.Cnpj + "," + PJuridica.Nome + "," + PJuridica.Endereco + "," + PJuridica.Faturamento;
                    arqEscrever.WriteLine(linha);
                    arqEscrever.Close();
                    Contribuinte.Cont++;
                    lst[Contribuinte.Cont] = PJuridica;
                }
            }
            else
            {
                Console.Write("Erro, opção invalida.\nDigite alguma tecla para continuar.\n");
                Console.ReadKey();
                Console.Clear();
            }            
        }
        static void ExcluirContribuinte()
        {
            string registro, linhas = "", todosDados;
            char tipo;
            Console.Write("O contribuinte que deseja excluir é Pessoa Fisica ou Juridica (Digite F ou J):");
            tipo = char.Parse(Console.ReadLine());
            if (tipo == 'f' || tipo == 'F')
            {
                Console.Write("Digite o CPF do contribuinte:");
                registro = Console.ReadLine();
                if (Verificador(registro) == false)
                {
                    Console.Write("Erro, contribuinte não registrado.\n");
                }
                else
                {
                    StreamReader arqExcluir = new StreamReader("cadastros.txt");    
                    todosDados = arqExcluir.ReadToEnd();
                    string[] separa = todosDados.Split('\n');
                    for (int i = 0; i < separa.Length - 1; i++)
                    {
                        string[] excluir = separa[i].Split(',');
                        if (!(excluir[1] == registro))
                        {
                            if(separa[i] != "")
                            {
                                linhas = linhas + separa[i];
                                if (i < (separa.Length -2))
                                {
                                    linhas = linhas + "\n";
                                }
                            }     
                        }                      
                    }
                    arqExcluir.Close();
                    StreamWriter arqNovo = new StreamWriter("cadastros.txt");
                    arqNovo.WriteLine(linhas);
                    arqNovo.Close();          
                }
            }
            else if (tipo == 'j' || tipo == 'J')
            {
                Console.Write("Digite o CNPJ do contribuinte:");
                registro = Console.ReadLine();
                if (Verificador(registro) == false)
                {
                    Console.Write("Erro, contribuinte não registrado.\n");
                }
                else
                {
                    StreamReader arqExcluir = new StreamReader("cadastros.txt");    
                    todosDados = arqExcluir.ReadToEnd();
                    string[] separa = todosDados.Split('\n');
                    for (int i = 0; i < separa.Length - 1; i++)
                    {
                        string[] excluir = separa[i].Split(',');
                        if (!(excluir[1] == registro))
                        {
                            if(separa[i] != "")
                            {
                                linhas = linhas + separa[i];
                                if (i < (separa.Length -2))
                                {
                                    linhas = linhas + "\n";
                                }
                            }     
                        }                      
                    }
                    arqExcluir.Close();
                    StreamWriter arqNovo = new StreamWriter("cadastros.txt");
                    arqNovo.WriteLine(linhas);
                    arqNovo.Close(); 
                }
            }
            else
            {
                Console.Write("Erro, opção invalida.\nDigite alguma tecla para continuar.\n");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Imprimir Contribuinte
        static void ImprimirContri()
        {
            string registro, dados;
            Console.Write("Digite o CPF ou CNPJ do contribuinte:");
            registro = Console.ReadLine();
            if (Verificador(registro) == false)
            {
                Console.Write("Erro, contribuinte não registrado.\n");
            }
            else
            {
                StreamReader arqImprimi = new StreamReader("cadastros.txt");
                dados = arqImprimi.ReadToEnd();
                string[] separaLinha = dados.Split('\n');
                for (int i = 0; i < separaLinha.Length - 1; i++)
                {
                    string[] dadosContri = separaLinha[i].Split(',');
                    if (dadosContri[1] == registro)
                    {
                        if (dadosContri[0]== "PF")
                        {
                            Console.Write("Tipo: Pessoa Fisicia\nCPF:{0}\nNome:{1}\nEndereço:{2},{3}\nSalario:{4}\n",dadosContri[1], dadosContri[2], dadosContri[3], dadosContri[4], dadosContri[5]);
                        }
                        else
                        {
                            Console.Write("Tipo: Pessoa Juridica\nCNPJ:{0}\nNome:{1}\nEndereço:{2},{3}\nFaturamento:{4}\n", dadosContri[1], dadosContri[2], dadosContri[3], dadosContri[4], dadosContri[5]);
                        }
                    }
                }
                arqImprimi.Close();
            }            
        }
        static void ImprimirFisico()
        {
            string dadosFisico;
            StreamReader arqImprimiFisico = new StreamReader("cadastros.txt");
            dadosFisico = arqImprimiFisico.ReadToEnd();
            string[] separaLinha = dadosFisico.Split('\n');
            for (int i = 0; i < separaLinha.Length - 1; i++)
            {
                string[] dadosContri = separaLinha[i].Split(',');
                if (dadosContri[0] == "PF")
                {
                    Console.Write("Tipo: Pessoa Fisicia\nCPF:{0}\nNome:{1}\nEndereço:{2},{3}\nSalario:{4}\n", dadosContri[1], dadosContri[2], dadosContri[3], dadosContri[4], dadosContri[5]);
                }   
            }
            arqImprimiFisico.Close();
        }
        static void ImprimirJuridico()
        {
            string dadosJuridico;
            StreamReader arqImprimiJuridi = new StreamReader("cadastros.txt");
            dadosJuridico = arqImprimiJuridi.ReadToEnd();
            string[] separaLinha = dadosJuridico.Split('\n');
            for (int i = 0; i < separaLinha.Length - 1; i++)
            {
                string[] dadosContri = separaLinha[i].Split(',');
                if (dadosContri[0] == "PJ")
                {
                     Console.Write("Tipo: Pessoa Juridica\nCNPJ:{0}\nNome:{1}\nEndereço:{2},{3}\nFaturamento:{4}\n", dadosContri[1], dadosContri[2], dadosContri[3], dadosContri[4], dadosContri[5]);
                }
            }
            arqImprimiJuridi.Close();
        }
        static void CalcImposto()
        {
            double valor;
            string registro, dados;
            Console.Write("Digite o CPF ou CNPJ do contribuinte:");
            registro = Console.ReadLine();
            if (Verificador(registro) == false)
            {
                Console.Write("Erro, contribuinte não registrado.\n");
            }
            else
            {
                StreamReader arqImposto = new StreamReader("cadastros.txt");
                dados = arqImposto.ReadToEnd();
                string[] separaLinha = dados.Split('\n');
                for (int i = 0; i < separaLinha.Length - 1; i++)
                {
                    string[] dadosContri = separaLinha[i].Split(',');
                    if (dadosContri[1] == registro)
                    {
                        if(dadosContri[0] == "PF")
                        {
                            valor = double.Parse(dadosContri[5]);
                            if (valor > 1400 && valor <= 2100)
                            {
                                Console.Write("Imposto a ser pago é:{0}\n", (valor * 0.1));
                            }
                            else if (valor > 2100 && valor <= 2800)
                            {
                                Console.Write("Imposto a ser pago é:{0}\n", (valor * 0.15));
                            }
                            else if (valor > 2800 && valor <= 3600)
                            {
                                Console.Write("Imposto a ser pago é:{0}\n", (0.25 * valor));
                            }
                            else if (valor > 3600)
                            {
                                Console.Write("Imposto a ser pago é:{0}\n", (0.30 * valor));
                            }
                            else
                            {
                                Console.Write("Imposto a ser pago é:{0}\n", 0);
                            }
                            
                        }
                        else
                        {
                            valor = double.Parse(dadosContri[5]);
                            Console.Write("Imposto a ser pago é:{0}\n", (valor * 0.1));
                        }
                    }
                }
                arqImposto.Close();
            }
        }
        static void Main(string[] args)
        {
            int repetidor = 1, opcao;
            while (repetidor != 0)
            {
                Console.Write("Menu de opções abaixo:\n1.Incluir um contribuinte.\n2.Excluir um contribuinte.\n3.Exibir os dados de um contribuinte: CPF/CNPJ, nome, endereço e salario/faturamento.\n4.Calcular e exibir o imposto a ser pago por um contribuinte.\n5.Imprimir uma relação dos contribuintes Pessoa Física cadastrados, mostrando os dados:CPF, nome e endereço.\n6.Imprimir uma relação dos contribuintes Pessoa Jurídica cadastrados, mostrando os dados: CNPJ, nome e endereço.\n7.Sair do programa.\nQual opção desejada:");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadContribuinte();
                        Console.Write("Digite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        ExcluirContribuinte();
                        Console.Write("Digite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        ImprimirContri();
                        Console.Write("Digite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        CalcImposto();
                        Console.Write("Digite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        ImprimirFisico();
                        Console.Write("Digite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        ImprimirJuridico();
                        Console.Write("Digite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        repetidor = 0;
                        break;
                    default:
                        Console.Write("Erro, opção invalida.\nDigite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
