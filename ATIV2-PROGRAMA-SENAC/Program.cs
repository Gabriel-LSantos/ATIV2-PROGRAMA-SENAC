using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um número inteiro:");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("Este número é positivo.");
        }
        else
        {
            Console.WriteLine("Este número não é positivo.");
        }
    }
}
