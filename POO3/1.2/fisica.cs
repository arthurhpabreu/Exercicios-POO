using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    class Fisica : Contribuinte
    {
        //Atributos
        protected string cpf;
        public string Cpf
        {
            get
            {
                return cpf;
            }
        }
        protected double salario;
        public double Salario
        {
            get
            {
                return salario;
            }
        }
        //Metodos
        public Fisica(string nome, string endereco, string cpf, double salario)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
            this.salario = salario;
        }
        public override double CalcImposto(double salario)
        {
            if (salario > 1400 && salario <= 2100 )
            {
                return (0.1 * salario);
            }
            else if (salario > 2100 && salario <= 2800)
            {
                return (0.15 * salario);
            }
            else if (salario > 2800 && salario <= 3600)
            {
                return (0.25 * salario);
            }
            else if (salario > 3600)
            {
                return (0.30 * salario);
            }
            else 
            {
                return 0;
            }            
        }
        public override void Excluir()
        {
            nome = null;
            endereco = null;
            cpf = null;
            salario = 0;
        }
    }
}
