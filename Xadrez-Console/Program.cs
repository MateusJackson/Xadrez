using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using Xadrez_Console.Tabuleiro;
using Xadrez.Jogo;
namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}


