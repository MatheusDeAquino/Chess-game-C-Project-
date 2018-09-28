using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Projeto {
    class Program {
        static void Main(string[] args) {

          /*     PosicaoXadrez pos = new PosicaoXadrez('c', 7);
               Console.WriteLine(pos);
               Console.WriteLine(pos.toPosicao());             */ //testes sobre posição do xadrez real vs posição na matriz do codigo 

            try {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem:");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }                                                               

            Console.ReadLine();
        }
    }
}
