using System;

namespace Exercicio3_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int num1 = int.Parse(entrada[0]);
            int num2 = int.Parse(entrada[1]);

            if (num2 % num1 == 0 || num1 % num2 == 0) Console.WriteLine("São multiplos!");
            else Console.WriteLine("Não são multiplos!");
        }
    }
}
