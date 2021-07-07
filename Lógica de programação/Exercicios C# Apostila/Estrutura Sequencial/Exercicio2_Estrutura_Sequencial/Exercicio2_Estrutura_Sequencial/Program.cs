using System;

namespace Exercicio2_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14159f;
            float raio = float.Parse(Console.ReadLine());

            Console.WriteLine($"A= {Pi*Math.Pow(raio,2):F4}");
        }
    }
}
