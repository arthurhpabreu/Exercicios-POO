//
// nome do programa: Ex1.3
//
// programador(es): Breno Vieira, Daniel Jorge, Robert Victor, Arthur Henrique e João Gontijo
// data: 12/10/2017
// entrada(s): Nao tem
// saida(s): Imprime os dados do cliente e do funcionario criado
// para testar digite:
// Ex13.cs
// descricao: Cria um cliente e um funcionario e busca seus respectivos dados.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando funcionario
            Funcionario f =  new Funcionario("Breno","Teste","05/03/1999",2000);

            // Criando cliente
            Cliente c = new Cliente("Joao", "Rua teste 01", "01/01/2000", 0524, 200);

            Console.WriteLine("Dados do funcionario:");
            Console.WriteLine("Nome: {0}\nEndereco: {1}\nData Nascimento: {2}\nSalario: {3}",f.InformaNome(),f.Endereco,f.Nascimento,f.InformarSalario());
            Console.WriteLine();
            Console.WriteLine("Dados do Cliente:");
            Console.WriteLine("Nome: {0}\nEndereco: {1}\nData Nascimento: {2}\nCartao: {3}\nDebito: {4}", c.InformaNome(), c.Endereco, c.Nascimento, c.InformarCartao(), c.InformarDebito());
            Console.ReadKey();
        }
    }
}
