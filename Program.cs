using _1_Apresentacao;
using System;

namespace Xadrez_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);

            Console.ReadKey();
        }
    }
}
