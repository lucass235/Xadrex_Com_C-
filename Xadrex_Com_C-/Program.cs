using tabuleiro;
using Xadrex_Com_C_;
using xadrez;

namespace Xadrex_Com_C {
    class Program {
        static void Main(string[] args) {
            try {
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());

            }
            catch (TabuleiroException e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
