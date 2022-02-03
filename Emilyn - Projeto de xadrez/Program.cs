using System;
using tabuleiro;

namespace Emilyn___Projeto_de_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição "+ P);

            Console.ReadLine();
        }
    }
}
