using System;

namespace tipo_double_pontos_flutuantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 5;
            double freq = 33.45;

            Console.WriteLine($"variavel ponto flutuante {freq}");

            double calculo = freq * x + y;

            Console.WriteLine($"freq * x + y = {calculo}");

            Console.WriteLine("fim da execução do programa...");
            Console.ReadLine();
        }
    }
}
