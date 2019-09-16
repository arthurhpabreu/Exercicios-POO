using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    class ContaCorrente : Conta, IConta
    {
        public ContaCorrente(string nome, int agencia, int conta, int tipoConta, bool novaConta)
        {
            this.nome = nome;
            this.agencia = agencia;
            this.conta = conta;
            this.tipoConta = tipoConta;
            CriaArquivo();
        }
        public ContaCorrente(string nome, int agencia, int conta, int tipoConta, double saldo)
        {
            this.nome = nome;
            this.agencia = agencia;
            this.conta = conta;
            this.tipoConta = tipoConta;
            this.saldo = saldo;
        }
    }
}
