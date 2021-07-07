using System;

namespace Exercicio1_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int num1 = int.Parse(entrada[0]);
            int num2 = int.Parse(entrada[1]);

            Console.WriteLine($"A soma = {num1+num2}");
        }
    }
}
