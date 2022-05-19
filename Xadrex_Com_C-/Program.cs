using tabuleiro;
using Xadrex_Com_C_;

namespace Xadrex_Com_C {
    class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
