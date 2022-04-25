using System;

class Program
{
    static void Main(string[] args)
    {
        double investimento = 1000;

        // rendimento de 0.15% ao mês

        for(int mes = 0; mes <= 12; mes++)
        {
            investimento *= 1.015;

            Console.WriteLine($"investimento no mês {mes}: {investimento}");
        }


        Console.WriteLine("fim da execução....");
        Console.ReadLine();
    }
}