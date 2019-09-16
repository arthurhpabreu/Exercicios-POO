
using System;
using System.Threading;
using System.Globalization;

namespace Date_5 {
	class Date5 
	{
		public int dia;
		public int mes;
		public int ano;
		
		public Date5()
		{
			this.dia = 1;
			this.mes = 1;
			this.ano = 2000;
		}
		public Date5 (int ano, int mes, int dia)
		{
			this.dia = dia;
			this.mes = mes;
			this.ano = ano;
		}
		
		public void proximoDia()
		{
			if (this.dia >= diasMes())
			{
				this.dia = 1;
				if (this.mes >= 12)
				{
					this.mes = 1;
					this.ano++;
				}
				else
				{
					this.mes++;
				}
			}
			else
			{
				this.dia++;
			}
		}	
		
		public int proximoDia(int ano, int mes, int dia)
		{
			if (dia >= diasMes(ano, mes))
			{
				dia = 1;
			}
			else
			{
				dia++;
			}
			return dia;
		}
		public string extenso()
		{
			CultureInfo culture = new CultureInfo("pt-BR");
			DateTime myDateTime = new System.DateTime(this.ano, this.mes, this.dia);
			return myDateTime.ToLongDateString();
		}
		
		public string extenso(int ano, int mes, int dia)
		{
			CultureInfo culture = new CultureInfo("pt-BR");
			DateTime myDateTime = new System.DateTime(ano, mes, dia);
			return myDateTime.ToLongDateString();
		}
		public int diasMes()
		{
			int[] diasMes = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (this.mes == 2 && bissexto())
			{
				diasMes[1] = 29;
			}
			
			return diasMes[this.mes - 1];
		}
		
		public int diasMes(int ano, int mes)
		{
			int[] diasMes = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (mes == 2 && bissexto(ano))
			{
				diasMes[1] = 29;
			}
			
			return diasMes[mes - 1];
		}
		
		public bool bissexto()
		{
			if(((this.ano % 400 == 0) || (this.ano % 4 == 0)) && (this.ano % 100 != 0))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public bool bissexto(int ano)
		{
			if(((ano % 400 == 0) || (ano % 4 == 0)) && (ano % 100 != 0))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public int diffDias(Date5 objetoDataFinal, Date5 objetoDataInicial)
		{
			int quantidadeDias = 0;
			DateTime dataFinal = new DateTime(objetoDataFinal.getAno(), objetoDataFinal.getMes(), objetoDataFinal.getDia());
			DateTime dataInicial = new DateTime(objetoDataInicial.getAno(), objetoDataInicial.getMes(), objetoDataInicial.getDia());
			TimeSpan quantidadeDiasTs = dataFinal - dataInicial;
			return quantidadeDias = quantidadeDiasTs.Days;
		}
		
		public bool dataValida()
		{
			if (this.ano < 1)
			{
				return false;
			}
			else if (this.mes > 12 || this.mes < 1)
			{
				return false;
			}
			else if (this.dia > diasMes(this.ano, this.mes) || dia < 1)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		
		public bool dataValida(int ano, int mes, int dia)
		{
			if (dia > diasMes(ano,mes) || dia < 1)
			{
				return false;
			}
			else if (mes > 12 || mes < 1)
			{
				return false;
			}
			else if (ano < 1)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		
		public int diaData()
		{
			int quantidadeDias = 0;
			for (int i = 1; i <= this.mes; i++)
			{
				if (i == this.mes)
				{
					quantidadeDias += this.dia;
				}
				else
				{
					quantidadeDias += diasMes(this.ano, i);
				}
			}
			return quantidadeDias;
		}
		
		public int diaData(int ano, int mes, int dia)
		{
			int quantidadeDias = 0;
			for (int i = 1; i <= mes; i++)
			{
				if (i == mes)
				{
					quantidadeDias += dia;
				}
				else
				{
					quantidadeDias += diasMes(ano, i);
				}
			}
			return quantidadeDias;
		}
		
		public int getDia()
		{ 
			return dia;
		}
		public int setDia(int dia)
		{ 
			return this.dia = dia;
		}
		public int getMes()
		{ 
			return mes;
		}
		public int setMes(int mes)
		{
			return this.mes = mes;
		}
		public int getAno()
		{
			return ano;
		}
	}		
}
