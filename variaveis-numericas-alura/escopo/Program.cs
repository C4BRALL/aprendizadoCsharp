using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("executando");

        int idade = 13;
        int quantidadeDePessoas = 1;

        bool acompanhado = quantidadeDePessoas > 1;

        string textoAddForaDoScopo;

        if(acompanhado == true)
        {
            string textoAdd = "está acompanhando";
            textoAddForaDoScopo = textoAdd;
        }
        else
        {
            string textoAdd = "não está acompanhado";
            textoAddForaDoScopo = textoAdd;
        }

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine(textoAddForaDoScopo);
            Console.WriteLine("pode entrar");
        }

          Console.WriteLine(textoAddForaDoScopo);
          Console.WriteLine("Não pode entrar");


        Console.WriteLine("fim da execução...");
        Console.ReadLine();
    }
}