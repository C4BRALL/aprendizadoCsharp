using System;

namespace variaveis_numericas_alura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("criando variaveis");

            int idade;
            idade = 32;

            Console.WriteLine($"idade: {idade}");

            idade = idade + 5;

            Console.WriteLine($"idade mais + 5 = {idade}");

            Console.WriteLine("Execusão finalizada");
            Console.ReadLine();
        }
    }
}
