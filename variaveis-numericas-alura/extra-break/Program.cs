using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando");

        //*
        //**
        //***
        //****
        //*****

        for (int linhas = 0; linhas < 5; linhas++)
        {
            for(int colunas = 0; colunas < 5; colunas++)
            {
                Console.Write("*");
                if (colunas >= linhas)
                break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("fim da execução...");
        Console.ReadLine();
    }
}