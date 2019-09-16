//
// nome do programa: Ex31
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 24/09/2017
// entrada(s): Tipo de acao a ser realizada, e datas
// saida(s): imprime diferenca de datas, proximo dia de uma data, data por extenso, quantidade de dias tem um mes,
// resultado se o ano é bissexto, resultado se a data é valida, dia da data naquele ano.
// para testar digite:
// Ex31.exe
// descricao: Executa varias funcoes com data, como dar a diferenca entre duas datas, verificar se um ano é bissexto
// dentre outras.
//
using System;
using System.Threading;
using System.Text;
using Date_5;

namespace Ex_31_LAB2
{
  class Program
  {
    static void Main(string[] args)
    {
		menu();
    }
	public static void menu()
	{
		int ano = 0,mes = 0,dia = 0;
		int op = 0;
		bool dataValida = true;
		string data  = " ";
		Date5 data1 = new Date5();
		Date5 data2 = new Date5();
		Console.Clear();
		Console.WriteLine("*********************** Testes Classe Date5 ***********************");
		Console.WriteLine("***********************         Menu        ***********************");
		Console.WriteLine("1 - Diferença de datas");
		Console.WriteLine("2 - Próximo dia de uma data");
		Console.WriteLine("3 - Data por extenso");
		Console.WriteLine("4 - Quantidade de dias tem o mes");
		Console.WriteLine("5 - Verificar se o ano é bissexto");
		Console.WriteLine("6 - Verificar se uma data é válida");
		Console.WriteLine("7 - Dia da data");
		Console.WriteLine("0 - Sair");		op = int.Parse(Console.ReadLine());
		
		switch(op)
		{
			case 1:
				Console.Clear();
				Console.WriteLine("Digite a primeira data, com dia,mes e ano respectivamente separados por '/'");
				data = Console.ReadLine();
				if (quebraData(ref ano, ref mes, ref dia, data))
				{
					data1 = new Date5(ano, mes, dia);
				}
				else
				{
					menu();
					break;
				}
				if (data1.dataValida())
				{
					Console.WriteLine("\nDigite a segunda data, com dia,mes e ano respectivamente separados por '/'");
					data = Console.ReadLine();
					if (quebraData(ref ano, ref mes, ref dia, data))
					{
						data2 = new Date5(ano, mes, dia);
					}
					else
					{
						menu();
						break;
					}
					if (!data2.dataValida())
					{
						dataValida =  false;
					}
				}
				else
				{
					dataValida = false;
				}
				if (dataValida)
				{
					Console.WriteLine("\n"+diferencaDias(data1, data2));
					voltarMenu();
				}
				else
				{
					Console.WriteLine("Data inválida");
				}
				break;
			case 2:
				Console.Clear();
				Console.WriteLine("Digite uma data, com dia,mes e ano respectivamente separados por '/'");
				data = Console.ReadLine();
				if (quebraData(ref ano, ref mes, ref dia, data))
				{
					data1 = new Date5(ano, mes, dia);
				}
				else
				{
					menu();
					break;
				}
				if (data1.dataValida())
				{
					data1.proximoDia();
					Console.WriteLine("O próximo dia da data é o dia "+data1.getDia());
					voltarMenu();
				}
				else
				{
					Console.WriteLine("Data inválida");
				}
				break;
			case 3:
				Console.Clear();
				Console.WriteLine("Digite uma data, com dia,mes e ano respectivamente separados por '/'");
				data = Console.ReadLine();
				if (quebraData(ref ano, ref mes, ref dia, data))
				{
					data1 = new Date5(ano, mes, dia);
				}
				else
				{
					menu();
					break;
				}
				if (data1.dataValida())
				{
					Console.WriteLine(data1.extenso());
					voltarMenu();
				}
				else
				{
					Console.WriteLine("Data inválida");
				}
				break;
			case 4:
				Console.Clear();
				Console.WriteLine("Digite uma data, com dia,mes e ano respectivamente separados por '/'");
				data = Console.ReadLine();
				if (quebraData(ref ano, ref mes, ref dia, data))
				{
					data1 = new Date5(ano, mes, dia);
				}
				else
				{
					menu();
					break;
				}
				if (data1.dataValida())
				{
					string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToLower();
					Console.WriteLine(mesExtenso+" de "+ano+" tem "+data1.diasMes()+" dias");
					voltarMenu();
				}
				else
				{
					Console.WriteLine("Data inválida");
				}
				break;
			case 5:
				Console.Clear();
				Console.WriteLine("Digite um ano");
				ano = int.Parse(Console.ReadLine());
				if (ano > 0)
				{
					if (data1.bissexto(ano))
					{
						Console.WriteLine(ano+" é bissexto!");
						voltarMenu();
					}
					else
					{
						Console.WriteLine(ano+" não é bissexto!");
						voltarMenu();
					}
				}
				else
				{
					Console.WriteLine("Ano inválido");
				}
				break;
			case 6:
				Console.Clear();
				Console.WriteLine("Digite uma data, com dia,mes e ano respectivamente separados por '/'");
				data = Console.ReadLine();
				if (quebraData(ref ano, ref mes, ref dia, data))
				{
					data1 = new Date5(ano, mes, dia);
				}
				else
				{
					menu();
					break;
				}
				if (data1.dataValida())
				{
					Console.WriteLine("A data é válida !");
					voltarMenu();
				}
				else
				{
					Console.WriteLine("Data inválida");
					voltarMenu();
				}
				break;
			case 7:
				Console.Clear();
				Console.WriteLine("Digite uma data, com dia,mes e ano respectivamente separados por '/'");
				data = Console.ReadLine();
				if (quebraData(ref ano, ref mes, ref dia, data))
				{
					data1 = new Date5(ano, mes, dia);
				}
				else
				{
					menu();
					break;
				}
				if (data1.dataValida())
				{
					Console.WriteLine(data1.extenso()+" é o dia "+data1.diaData()+" do ano");
					voltarMenu();
				}
				else
				{
					Console.WriteLine("Data inválida");
				}
				break;
			case 0:
				sair();
				break;
			default:
				Console.WriteLine("Digite uma opção válida, aperte qualquer tecla para voltar ao menu");
				Console.ReadKey();
				menu();
				break;
		}
	}
	
	public static void sair()
	{
		Console.Write("Saindo em ");
		for (int i  = 3; i >= 1; i--)
		{
			Console.Write(i+" ");
			Thread.Sleep(500);
		}
		Console.Clear();
		Environment.Exit(0);
	}
	
	public static void voltarMenu()
	{
		char resposta = ' ';
		Console.WriteLine("Deseja voltar ao menu inicial ? s/n");
		resposta = char.Parse(Console.ReadLine());
		if (resposta == 's' || resposta == 'S')
		{
			menu();
		}
		else
		{
			sair();
		}
	}
	
	public static bool quebraData(ref int ano, ref int mes, ref int dia, string data)
	{
		string[] arrayData = data.Split('/');
		if (arrayData.Length != 3)
		{
			Console.WriteLine("Data com argumentos inválidos !, aperte qualquer tecla para voltar ao menu");
			Console.ReadKey();
			return false;
		}
		for (int i = 0; i < arrayData.Length; i++)
		{
			if (!validaInt(arrayData[i]))
			{
				Console.WriteLine("Data com argumentos inválidos !, aperte qualquer tecla para voltar ao menu");
				Console.ReadKey();
				return false;
			}
		}
		ano = int.Parse(arrayData[2]);
		mes = int.Parse(arrayData[1]);
		dia = int.Parse(arrayData[0]);	
		return true;
	}
	
	public static bool validaInt(string numero)
	{
		uint verificaConversao = 0;
		if (uint.TryParse(numero, out verificaConversao ))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public static string diferencaDias(Date5 data1, Date5 data2)
	{
		string dataInicial 		= data1.extenso();
		string dataFinal 		= data2.extenso();
		string retorno 			= "";
		string day 				= "dias";
		int quantDias 			= 0;
		Date5 aux = new Date5();
		
		DateTime dt1 = new DateTime(data1.getAno(), data1.getMes(),data1.getDia());
		DateTime dt2 = new DateTime(data2.getAno(), data2.getMes(),data2.getDia());
		if (dt1 > dt2)
		{
			dataFinal = data1.extenso();
			dataInicial = data2.extenso();
			aux = data2;
			data2 = data1;
			data1 = aux;
		}
		quantDias = data1.diffDias(data2,data1);
		if (quantDias == 1)
		{
			day = "dia";
		}

		retorno = "O numero de dias entre "+dataInicial+" até "+dataFinal+" é de "+quantDias+" "+day;
		return retorno;
	}
  }
}
