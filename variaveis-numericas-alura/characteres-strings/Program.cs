using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando");

        //ASCII valor decimal de 'A' é 65
        char letra = (char)65;

        Console.WriteLine($"valor da variavel char: {letra}");

        letra = (char)(65 + 1);

        Console.WriteLine($"valor de 65 + 1 em char: {letra}");

        string primeiraFrase = "Alura - curso de tecnologia em C#";
        Console.WriteLine($"{primeiraFrase} 2022");
        Console.WriteLine(primeiraFrase[2]);

        for(int i = 0; i < primeiraFrase.Length; i++)
        {
            Console.WriteLine($"indice do array da frase: {primeiraFrase[i]}");
        }

        Console.WriteLine("fim da execução...");
        Console.ReadLine();
    }
}
