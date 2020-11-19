using _1_Apresentacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Dominio
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor)
            : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
