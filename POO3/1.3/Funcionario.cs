using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Funcionario: Pessoa
    {
        private double salario;

        public Funcionario(string nome, string endereco, string nascimento, double salario)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.nascimento = nascimento;
            this.salario = salario;
        }

        public double InformarSalario()
        {
            return salario;
        }
        public int CalcularIdade()
        {
            DateTime DataNascimento = DateTime.Parse(nascimento);
            int anos = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))

                anos--;

            return anos;
        }
    }
}
