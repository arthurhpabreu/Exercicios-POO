using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class ContaPoupanca : Conta, IConta
    {
        public ContaPoupanca(string nome, int agencia, int conta, int tipoConta, bool novaConta)
        {
            this.nome = nome;
            this.agencia = agencia;
            this.conta = conta;
            this.tipoConta = tipoConta;
            CriaArquivo();
        }
        public ContaPoupanca(string nome, int agencia, int conta, int tipoConta, double saldo)
        {
            this.nome = nome;
            this.agencia = agencia;
            this.conta = conta;
            this.tipoConta = tipoConta;
            this.saldo = saldo;
        }
    }
}
