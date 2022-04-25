using System;

class Program
{
    static void Main(string[] args)
    {
        double investimento = 1000;
        int mes = 1;

        // rendimento de 0.5% ao mês

        // mês 1
        //investimento = investimento + investimento * 0.005;
        // mês 2
        //investimento = investimento + investimento * 0.005;
        // mês 3
        //investimento = investimento + investimento * 0.005;
        // mês 4
        //investimento = investimento + investimento * 0.005;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;

            Console.WriteLine($"investimento no mês {mes}: {investimento}");
            
            mes ++;
        }


        Console.WriteLine("fim da execução....");
        Console.ReadLine();
    }
}