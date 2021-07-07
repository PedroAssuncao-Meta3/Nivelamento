using System;

namespace Exercicio2_Estrutura_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0, fora = 0, limite, numeros;

            limite = int.Parse(Console.ReadLine());

            for (int i = 0; i < limite; i++)
            {
                numeros = int.Parse(Console.ReadLine());

                if (numeros >= 10 && numeros <= 20) dentro++;
                else fora++;
            }

            Console.WriteLine($"in: {dentro}\nout: {fora}");
        }
    }
}
