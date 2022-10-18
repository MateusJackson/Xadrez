using Xadrez_Console.Tabuleiro;
namespace Xadrez.Jogo
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
