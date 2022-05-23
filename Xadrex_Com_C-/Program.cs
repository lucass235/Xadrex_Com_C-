using tabuleiro;
using Xadrex_Com_C_;
using xadrez;

namespace Xadrex_Com_C {
    class Program {
        static void Main(string[] args) {

            PartidaDeXadrex partida = new PartidaDeXadrex();
            while (!partida.terminada) {
                
                try {
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.WriteLine("Turno: " + partida.turno);
                    Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDeOrigiem(origem);

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentoPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDeDestino(origem, destino);
                    partida.realizaJogada(origem, destino);



                }
                catch (TabuleiroException e) {
                    Console.WriteLine("Erro: " + e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
