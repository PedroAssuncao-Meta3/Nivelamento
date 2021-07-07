using System;

namespace Exercicio2_Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            int X, Y;

            do {

                entrada = Console.ReadLine().Split(' ');
                X = int.Parse(entrada[0]);
                Y = int.Parse(entrada[1]);

                if (X > 0 && Y > 0) Console.WriteLine("Q1");
                else if (X < 0 && Y > 0) Console.WriteLine("Q2");
                else if (X < 0 && Y < 0) Console.WriteLine("Q3");
                else if (X > 0 && Y < 0) Console.WriteLine("Q4");

            } while (X != 0 && Y != 0);
        }
    }
}
