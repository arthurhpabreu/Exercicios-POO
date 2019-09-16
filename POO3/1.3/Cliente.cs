using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Cliente : Pessoa
    {
        private int cartao;
        private double debito;

        public Cliente(string nome, string endereco, string nascimento, int cartao, double debito)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.nascimento = nascimento;
            this.cartao = cartao;
            this.debito = debito;
        }
        public int InformarCartao()
        {
            return cartao;
        }
        public double InformarDebito()
        {
            return debito;
        }
    }
}
