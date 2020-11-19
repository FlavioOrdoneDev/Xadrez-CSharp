using _1_Apresentacao;
using _3_Dominio;
using System;

namespace Xadrez_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadKey();
        }
    }
}
