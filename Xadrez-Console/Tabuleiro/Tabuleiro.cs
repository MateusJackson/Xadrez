namespace Xadrez_Console.Tabuleiro
{
    internal class Tabuleiro
    {
        private Peca[,] Pecas;
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Tabuleiro(int linha, int colunas)        {
            Linhas = linha;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

    }
}
