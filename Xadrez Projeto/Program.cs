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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }                                                               

            Console.ReadLine();
        }
    }
}
