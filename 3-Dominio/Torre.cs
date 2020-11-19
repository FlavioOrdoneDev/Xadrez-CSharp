using _1_Apresentacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Dominio
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor)
            : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
