using System;

namespace Exercicio3_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int A = int.Parse(entrada[0]);
            int B = int.Parse(entrada[1]);
            int C = int.Parse(entrada[2]);
            int D = int.Parse(entrada[3]);

            Console.WriteLine($"Diferença = {A * B - C * D}");
        }
    }
}
