using System;

class Program
{
    static void Main(string[] args)
    {
        double investimento = 0;
        double fatorRendimento = 1.015;

        // rendimento de 0.15% ao mês

        for (int anos = 0; anos <= 10; anos++)
        {
            for(int mes = 0; mes <= 12; mes++)
            {
                //Console.WriteLine($"valor do investimento por mês = {investimento}");
                investimento = (investimento + 1000) * 1.015;
            }

            fatorRendimento += 0.001;

            Console.WriteLine($"investimento no ano {anos} com o fator de rendimento = {fatorRendimento}: {investimento}");
        }

        Console.WriteLine($"valor total = {investimento}");

        Console.WriteLine("fim da execução....");
        Console.ReadLine();
    }
}