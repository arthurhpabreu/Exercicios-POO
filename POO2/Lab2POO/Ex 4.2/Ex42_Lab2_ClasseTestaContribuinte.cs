// programa: Imposto
// programadores: Daniel Jorge, Robert Victor, João Gontijo, Breno Vieira, Arthur Henrique
// data: 24/09/2017 
// descricao: exemplo de programa utilizando classes, para calcular imposto de pessoa fisica e juridica
// entrada(s): digitar para selecionar opção do menu
// saida(s): informação ou ação solicitada pelo menu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    class TestarContribuinte
    {
        static int verificarCadastro(string registro)
        {
            for (int i = 0; i < cont; i++)
            {
                if (vetContribuinte[i].Comprarar(registro) == 1)
                {
                    return 1;
                }
            }
            return 0;
        }
        static void cadastrar()
        {
            double dinheiro;
            string nome, endereço, registro;
            int tipo;
            Console.Write("O contribuinte é:\n1 - Pessoa Juridica:\n2 - Pessoa Fisica\nQual a opção:");
            tipo = int.Parse(Console.ReadLine());
            Console.Write("Informe o CNPJ ou CPF do contribuinte:");
            registro = Console.ReadLine();            
            if (verificarCadastro(registro) == 0)
            {
                if (tipo == 1)
                {
                    Console.Write("Qual o nome do constribuinte:");
                    nome = Console.ReadLine();
                    Console.Write("Qual o endereço:");
                    endereço = Console.ReadLine();                    
                    Console.Write("Qual o faturamento:");
                    dinheiro = double.Parse(Console.ReadLine());
                    PJuridica aux = new PJuridica(nome, endereço, registro, dinheiro);
                    vetContribuinte[cont] = aux;
                    dadosJuridica = dadosJuridica + vetContribuinte[cont].Imprimir();
                    cont++;                    
                }
                else if (tipo == 2)
                {
                    Console.Write("Qual o nome do constribuinte:");
                    nome = Console.ReadLine();
                    Console.Write("Qual o endereço:");
                    endereço = Console.ReadLine();                    
                    Console.Write("Qual o salario:");
                    dinheiro = double.Parse(Console.ReadLine());
                    PFisica aux = new PFisica(nome, endereço, registro, dinheiro);
                    vetContribuinte[cont] = aux;
                    dadosFisica = dadosFisica +  vetContribuinte[cont].Imprimir();
                    cont++;
                }
            }
            else if(verificarCadastro(registro) == 1)
            {
                Console.Write("Erro, contribuinte já cadastrado.\n");
            }
        }
        static void excluirContribuinte()
        {
            string registro;
            int tipo;
            Console.Write("O contribuinte é:\n1 - Pessoa Juridica:\n2 - Pessoa Fisica\nQual a opção:");
            tipo = int.Parse(Console.ReadLine());
            Console.Write("Informe o CNPJ ou CPF do contribuinte que deseja escluir:");
            registro = Console.ReadLine();
            if (verificarCadastro(registro) == 1)
            {                
                for (int i = 0; i < cont; i++)
                {
                    if (vetContribuinte[i].Comprarar(registro) == 1)
                    {
                        vetContribuinte[i].Excluir();
                    }
                }
            }
            else if (verificarCadastro(registro) == 0)
            {
                Console.Write("Erro, contribuinte não cadastrado.\n");
            }
        }
        static void imprimirContribuinte()
        {
            string registro;
            int tipo;
            Console.Write("O contribuinte é:\n1 - Pessoa Juridica:\n2 - Pessoa Fisica\nQual a opção:");
            tipo = int.Parse(Console.ReadLine());
            Console.Write("Informe o CNPJ ou CPF do contribuinte que deseja escluir:");
            registro = Console.ReadLine();
            if (verificarCadastro(registro) == 1)
            {
                for (int i = 0; i < cont; i++)
                {
                    if (vetContribuinte[i].Comprarar(registro) == 1)
                    {
                        Console.Write(vetContribuinte[i].Imprimir());
                    }
                }
            }
            else if (verificarCadastro(registro) == 0)
            {
                Console.Write("Erro, contribuinte não cadastrado.\n");
            }
        }
        static void imposto()
        {
            string registro;
            int tipo;
            Console.Write("O contribuinte é:\n1 - Pessoa Juridica:\n2 - Pessoa Fisica\nQual a opção:");
            tipo = int.Parse(Console.ReadLine());
            Console.Write("Informe o CNPJ ou CPF do contribuinte que deseja escluir:");
            registro = Console.ReadLine();
            if (verificarCadastro(registro) == 1)
            {
                if (tipo == 1)
                {
                    for (int i = 0; i < cont; i++)
                    {
                        if (vetContribuinte[i].Comprarar(registro) == 1)
                        {
                            Console.Write("Imposto a ser pago é de:R$ {0}",vetContribuinte[i].CalcImposto());
                            i = cont;
                        }
                    }
                } 
            }
        }
        static void imprimirFisicos()
        {
            Console.Write(dadosFisica);            
        }
        static void imprimirJuridica()
        {            
            Console.Write(dadosJuridica);
        }
        static string dadosFisica ="";
        static string dadosJuridica = "";
        static int cont = 0;
        static Contribuinte[] vetContribuinte;
        static void Main(string[] args)
        {
            int maxContribuintes = 100;
            vetContribuinte = new Contribuinte[maxContribuintes];                  
            int repetidor = 1, opcao;
            while (repetidor != 0)
            {
                Console.Write("Menu:\n1.Incluir um contribuinte.\n2.Excluir um contribunte.\n3.Exibir os dados de um contribuinte:CPF/CNPJ, nome, endereço e salario/faturamenteo.\n4.Calcular e exibir o imposto a ser pago por um contribinte.\n5.Imprimir uma realção dos contribuintes Pessoa Fisica cadastrados, mostrando os dados:CPF, nome e endereço.\n6Imprimir uma realção dos contribuintes Pessoa Juridica cadastrados, mostrando os dados:CNPJ, nome e endereço.\n7.Sair do programa.\nQual a opção desejada:");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        cadastrar();
                        Console.Write("Digite alguma tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        excluirContribuinte();
                        Console.Write("\nDigite alguma tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        imprimirContribuinte();
                        Console.Write("\nDigite alguma tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        imposto();
                        Console.Write("\nDigite alguma tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        imprimirFisicos();
                        Console.Write("\nDigite alguma tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        imprimirJuridica();
                        Console.Write("\nDigite alguma tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        repetidor = 0;
                        break;
                    default:
                        Console.Write("Erro, opção invalida.\nDigite alguma tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
