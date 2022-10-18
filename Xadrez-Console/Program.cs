using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using Xadrez_Console.Tabuleiro;
namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(3, 4);
            Console.WriteLine("Posicao: " + p);
        }
    }
}


