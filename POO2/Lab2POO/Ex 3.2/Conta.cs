using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3._2
{
    class Conta
    {
        // Atributos
        private string titular;
        public string Titular
        {
            get
            {
                return titular;
            }
        }

        private int agencia;
        public int Agencia 
        {
            get
            {
                return agencia;
            }
        }

        private int numConta;
        public int NumConta
        {
            get
            {
                return numConta;
            }
        }

        private double saldo = 0;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value > 0.0)
                {
                    saldo = value;
                }
                else
                {
                    saldo = 0.0;
                }
            }
        }

        public Conta(int agencia, int numConta, string titular) // Construtor
        {
            this.agencia = agencia;
            this.numConta = numConta;
            this.titular = titular;
        }

        public void excluirConta() // Excluir conta
        {
            agencia = 0;
            numConta = 0;
            titular = null;
            saldo = 0;
        }

        public void depositar(double valor) // Depositar
        {
            saldo = valor;
        }

        public void sacar(double valor) // sacar
        {
            saldo -= valor;
        }

        public static int contador = 0; // Contador
    }
}