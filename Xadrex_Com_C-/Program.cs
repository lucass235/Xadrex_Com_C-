using tabuleiro;
using Xadrex_Com_C_;
using xadrez;

namespace Xadrex_Com_C {
    class Program {
        static void Main(string[] args) {
            try {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));



            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

            }
            catch (TabuleiroException e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
