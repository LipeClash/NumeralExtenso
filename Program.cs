using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Vamos exibir um numero inteiro por extenso ---\n");

            int numero = 8744365;
            string numeroPorExtenso = numero.ToWords();
            Console.WriteLine($"{numeroPorExtenso}");
        }
    }
}
