using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando");

        int idade = 13;
        int quantidadeDePessoas = 1;

        if (idade >= 18 && quantidadeDePessoas > 1)
        {
            Console.WriteLine("tem a idade maior ou igual a 18 anos");
        }
        else
        {
            if (quantidadeDePessoas < 2)
            {
                Console.WriteLine("não está acompanhado");
            }
            Console.WriteLine("é menor de idade");
        }

        Console.WriteLine("fim da execução...");
        Console.ReadLine();
    }
}