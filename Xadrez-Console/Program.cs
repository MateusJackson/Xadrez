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
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 7));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine (e.Message);
            }
        }
    }
}


