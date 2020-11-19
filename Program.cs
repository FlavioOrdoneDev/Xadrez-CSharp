using _1_Apresentacao;
using _3_Dominio;
using System;

namespace Xadrez_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 7));

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 6));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 7));

                Tela.ImprimirTabuleiro(tab);

                //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                //Console.WriteLine(pos);

                //Console.WriteLine(pos.ToPosicao());


            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();


        }
    }
}
