using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine($"idadeAna: {idadeAna}");

        idade = 25;

        // executado por linhas por isso não altera o valor
        Console.WriteLine($"idadeAna após a mudança: {idadeAna}");

        Console.WriteLine("fim da execução...");
        Console.ReadLine();
    }
}