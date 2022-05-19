using tabuleiro;
using Xadrex_Com_C_;
using xadrez;

namespace Xadrex_Com_C {
    class Program {
        static void Main(string[] args) {
            try {
                
                PartidaDeXadrex partida = new PartidaDeXadrex();
                while (!partida.terminada) {
                    Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
