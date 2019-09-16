//
// nome do programa: Ex33
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Tipo de acao a ser realizada, escolhida pelo menu
// saida(s): Devolver a opção desejada, realizando a ação
// descricao: Executa varias funcoes relacionada a pessoa, como UMC, salvar dados, calcular idade e entre outras
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex33
    {
        const int MAXPESSOAS = 100;
        static Pessoa [] vetPessoas = new Pessoa [MAXPESSOAS];
        static void Main(string[] args)
        {
            int op = 0;
            int d, m, a, x;
            double pe, al, idade, imc;
            string data;
            string[] datas;
            do
            {
                Console.Clear();
                Menu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Incluir nova pessoa");
                        Console.WriteLine("---------------------------------");
						if (Pessoa.contador <= MAXPESSOAS)
						{
                        Console.Write("\nDigite a data de nascimento no seguinte formato: dia/mes/ano: ");
                        data = Convert.ToString(Console.ReadLine());
                        if (Verifica(data, out datas))
                        {
                            d = Convert.ToInt32(datas[0]);
                            m = Convert.ToInt32(datas[1]);
                            a = Convert.ToInt32(datas[2]);
                            if (Pessoa.contador <= MAXPESSOAS)
                            {
                                if (Verifica(d, m, a))
                                {
                                    DateTime Data = new DateTime(a, m, d);
                                    Console.Write("\nDigite a altura em cm: ");
                                    al = double.Parse(Console.ReadLine());
                                    Console.Write("\nDigite o peso em kg: ");
                                    pe = double.Parse(Console.ReadLine());
                                    if (Verifica(al, pe))
                                    {
                                        vetPessoas[Pessoa.contador - 1] = new Pessoa(Data, al, pe);
                                        Console.WriteLine("\nPessoa cadastrada, número de registro: {0} - Pressione qualquer tecla para sair", Pessoa.contador);
                                        Pessoa.contador++;
                                    }

                                    else
                                    {
                                        Console.WriteLine("\nAltura ou peso informado inválidos - Pressione qualquer tecla para sair");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("\nData em formato correto, porém inválida - Pressione qualquer tecla para sair");
                                }
                            }

                            else
                            {
                                Console.WriteLine("\nLimite máximo de pessoas já foi atingido - Pressione qualquer tecla para sair");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nData em formato inválido - Pressione qualquer tecla para sair");
                        }
						}
						else
						{
							Console.WriteLine("Limite de pessoas já foi atingido - Pressione qualquer tecla para sair");
						}
                        Console.ReadKey();
                        break;

                    default:
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Alterar data de nascimento");
                        Console.WriteLine("---------------------------------");
                        Console.Write("\nDigite o número da pessoa: ");
                        x = int.Parse(Console.ReadLine());
                        if (Verifica(x))
                        {
                            Console.Write("\nDigite a data de nascimento no seguinte formato: dia/mes/ano: ");
                            data = Convert.ToString(Console.ReadLine());
                            if (Verifica(data, out datas))
                            {
                                d = Convert.ToInt32(datas[0]);
                                m = Convert.ToInt32(datas[1]);
                                a = Convert.ToInt32(datas[2]);
                                DateTime Data = new DateTime(a, m, d);
                                vetPessoas[x - 1].Nasc = Data;
                                Console.WriteLine("\nData de nascimento alterada - Pressione qualquer tecla para sair");
                            }

                            else
                            {
                                Console.WriteLine("\nData em formato inválido - Pressione qualquer tecla para sair");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNúmero de pessoa inválido - Pressione qualquer tecla para sair");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("3. Alterar o peso");
                        Console.WriteLine("---------------------------------");
                        Console.Write("\nDigite o número da pessoa: ");
                        x = int.Parse(Console.ReadLine());
                        if (Verifica(x))
                        {
                            Console.Write("\nDigite o novo peso: ");
                            pe = double.Parse(Console.ReadLine());
                            al = vetPessoas[x - 1].Altura;
                            if (Verifica(al, pe))
                            {
                                vetPessoas[x - 1].Peso = pe;
                                Console.WriteLine("\nPeso alterado - Pressione qualquer tecla para sair");
                            }

                            else
                            {
                                Console.WriteLine("\nPeso informado inválido - Pressione qualquer tecla para sair");
                            }
                        }

                        else
                        {
                            Console.WriteLine("\nNúmero de pessoa inválido - Pressione qualquer tecla para sair");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("4. Alterar a altura");
                        Console.WriteLine("---------------------------------");
                        Console.Write("\nDigite o número da pessoa: ");
                        x = int.Parse(Console.ReadLine());
                        if (Verifica(x))
                        {
                            Console.Write("\nDigite a nova altura: ");
                            pe = vetPessoas[x - 1].Peso;
                            al = double.Parse(Console.ReadLine());
                            if (Verifica(al, pe))
                            {
                                vetPessoas[x - 1].Altura = al;
                                Console.WriteLine("\nAltura alterada - Pressione qualquer tecla para sair");
                            }

                            else
                            {
                                Console.WriteLine("\nAltura informada inválida - Pressione qualquer tecla para sair");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNúmero de pessoa inválido - Pressione qualquer tecla para sair");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("5. Informar idade atual");
                        Console.WriteLine("---------------------------------");
                        Console.Write("\nDigite o número da pessoa: ");
                        x = int.Parse(Console.ReadLine());
                        if (Verifica(x))
                        {
                            idade = DateTime.Now.Subtract(vetPessoas[x - 1].Nasc).TotalDays;
                            idade /= 365;
                            idade = Convert.ToInt64(idade);
                            Console.WriteLine("\nNúmero da pessoa: {0}\nIdade: {1}\nPressione qualquer tecla para sair", x, idade);
                        }
                        else
                        {
                            Console.WriteLine("\nNúmero de pessoa inválido - Pressione qualquer tecla para sair");
                        }
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("6. Informar IMC");
                        Console.WriteLine("---------------------------------");
                        Console.Write("\nDigite o número da pessoa: ");
                        x = int.Parse(Console.ReadLine());
                        if (Verifica(x))
                        {
                            imc = vetPessoas[x - 1].Peso / (Math.Pow(vetPessoas[x - 1].Altura / 100, 2));
                            Console.WriteLine("\nIMC: {0}", imc);
                        }

                        else
                        {
                            Console.WriteLine("\nNúmero de pessoa inválido - Pressione qualquer tecla para sair");
                        }
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("7. Sair do programa");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("\nAperte qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                }


            } while (op != 7);
        }

            static void Menu()
        {
            Console.WriteLine("Menu de opções\n");
            Console.WriteLine("1. Incluir nova pessoa");
            Console.WriteLine("2. Alterar a data de nascimento de uma pessoa cadastrada");
            Console.WriteLine("3. Alterar o peso de uma pessoa cadastrada");
            Console.WriteLine("4. Alterar a altura de uma pessoa cadastrada");
            Console.WriteLine("5. Informar a idade atual de uma pessoa cadastrada");
            Console.WriteLine("6. Informar IMC de uma pessoa cadastrada");
            Console.WriteLine("7. Sair do programa");
        }

        static bool Verifica(int dia, int mes,int ano)
        {
            

            if ((dia <= 0) || (dia > 31) || (mes % 2 == 0 && dia > 30 && mes < 8) || (mes == 2 && dia > 29) || (mes == 2 && dia > 28 && ano % 4 != 0) || (mes <= 0) || (mes > 12) || (ano < 0))
            {
                return false;
            }

            return true;
        }

        static bool Verifica (double altura, double peso)
        {
            if (peso < 0 || altura < 0 || peso > 180 || altura > 250)
            {
                return false;
            }

            return true;
        }

        static bool Verifica(int x)
        {
            if (!(x > Pessoa.contador || x < 1 || x > 100))
            {
                return true;
            }

            return false;
        }

        static bool Verifica(string data, out string [] datas)
        {
            int[] c = new int[3];
         datas = data.Split('/');
           for (int i = 0; i < datas.Length; i++)
            {
               bool testa = Int32.TryParse(datas[0], out c[0]);
                if (!testa)
                {
                    return false;
                }
            }

            return true;    
        }
    }
}
