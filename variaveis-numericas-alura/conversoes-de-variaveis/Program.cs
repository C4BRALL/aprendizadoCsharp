using System;

namespace conversoes_de_variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            valor = 1400.31;

            Console.WriteLine($"valor em Double: {valor}");
            
            // int é um tipo de variavel de 32bits
            int salarioEmInteiro = (int)valor;

            Console.WriteLine($"valor em Int: {salarioEmInteiro}");

            long idadeDoUniverso;
            idadeDoUniverso = 13000000000000;

            Console.WriteLine($"idade dio universo ocupa 64bits na variavel long: {idadeDoUniverso}");

            Console.WriteLine("short é uma variavel que ocupa 16bits na memoria, admite até 16000");

            //float não é tão preciso qaunto double
            float altura;
            altura = 1.72f;

            Console.WriteLine($"altura em float: {altura}");

            Console.WriteLine("_________________________________");

            double salario = 1270.50;
            int salarioInt = (int)salario;
            Console.WriteLine($"salario em int: {salarioInt}");

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine($"total: {total}");

            Console.WriteLine("fim da execusão");
            Console.ReadLine();
        }
    }
}
