using System;

namespace Exercicio7_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            float x = float.Parse(entrada[0]);
            float y = float.Parse(entrada[1]);

            if (x > 0 && y > 0) Console.WriteLine("Q1");
            else if (x < 0 && y > 0) Console.WriteLine("Q2");
            else if (x < 0 && y < 0) Console.WriteLine("Q3");
            else if (x > 0 && y < 0) Console.WriteLine("Q4");
            else if (x == 0 && y != 0) Console.WriteLine("Eixo y");
            else if (x != 0 && y == 0) Console.WriteLine("Eixo x");
            else Console.WriteLine("Origem");
        }
    }
}
