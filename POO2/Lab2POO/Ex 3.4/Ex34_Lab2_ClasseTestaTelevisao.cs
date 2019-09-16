// programa: Televisao
// programadores: Daniel Jorge, Robert Victor, 
// data: 24/09/2017 
// descricao: exemplo de programa utilizando classes, para simular uma televisão e suas funções.
// entrada(s): digitar de 1 a 4 para selecionar opção do menu
// saida(s): informação ou ação solicitada pelo menu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisao
{
    class TestaTelevisao
    {
        static int verificarStatus()
        {
            if(vetTv.status == "Ligada")
            {
                return 1;
            }
            else
            {
                Console.Write("Opção invalida, sua televisão está desligada.\n");
                return 0;
            }
        }      
        static Televisao vetTv;
        static void Main(string[] args)
        {
            int repetidor = 1, opcao;
            vetTv = new Televisao();
            while (repetidor != 0)
            {
                Console.Write("Status:{0}\nVolume:{1}\nCanal :{2}\nOpções do programa.\n1.Ligar ou desligar a televisão.\n2.Aumentar ou abaixar o volume.\n3.Subir ou abaixar o canal.\n4.Fechar.\nQual a opção desejada:", vetTv.status,vetTv.Volume,vetTv.Canal);
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        vetTv.StatusTV();                   
                        Console.Clear();
                        break;
                    case 2:
                        if (verificarStatus() == 1)
                        {
                            vetTv.VolumeTv();
                        }
                        else
                        {
                            Console.Write("Digite alguma tecla para continuar.\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        if (verificarStatus() == 1)
                        {
                            vetTv.CanalTv();
                        }
                        else
                        {
                            Console.Write("Digite alguma tecla para continuar.\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        repetidor = 0;
                        break;
                    default:
                        Console.Write("Erro, opção invalida.\nDigite alguma tecla para continuar.\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }                    
            }
        }
    }
}
