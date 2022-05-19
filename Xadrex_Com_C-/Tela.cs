using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tabuleiro;

namespace Xadrex_Com_C_ {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            int linha = 8;
            char coluna = 'a';
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write($"{linha} ");
                linha--;
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("- ");
                    } else {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("  ");
            for (int j = 0; j < tab.colunas; j++) {
                Console.Write($"{coluna} ");
                coluna++;
            }

        }
        public static void imprimirPeca(Peca peca) {
            if (peca.cor == Cor.Branca) {
                Console.Write(peca);
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
