using System;
using AulaPOO_PolimorfismoSobreposicao.classes;

namespace AulaPOO_PolimorfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman jogador = new Megaman();

            Zero jogador2 = new Zero();

            Console.WriteLine($"MEGAMAN - {jogador.Correr()}");
            Console.WriteLine($"ZERO - {jogador2.Correr()}");
            Console.WriteLine($"MEGAMAN - {jogador.Pular()}");
            Console.WriteLine($"ZERO - {jogador2.Pular()}");
        }
    }
}
