using System;

namespace Exercicio6_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14159;
            string[] entrada = Console.ReadLine().Split(' ');
            double A = double.Parse(entrada[0]);
            double B = double.Parse(entrada[1]);
            double C = double.Parse(entrada[2]);

            Console.WriteLine($"Triangulo = {A*C/2:F2}\nCirculo = {Pi*Math.Pow(C,2):F2}" +
                              $"\nTrapezio = {(A+B)*C/2:F2}\nQuadrado = {Math.Pow(B,2):F2}" +
                              $"\nRetangulo = {A*B:F2}");
        }
    }
}
