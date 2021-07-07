using System;

namespace Exercicio1_Estrutura_For
{
    class Program
    {
        static void Main(string[] args)
        {
            const int teste = 2;
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++) if (i % 2 != 0) Console.WriteLine(i);
        }
    }
}
