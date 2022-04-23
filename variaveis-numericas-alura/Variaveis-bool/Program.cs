using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando");

        int idade = 13;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("pode entrar");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("fim da execução...");
        Console.ReadLine();
    }
}