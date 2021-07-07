using System;

namespace Exercicio4_Estrutura_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int denominador, numerador;
            int limite = int.Parse(Console.ReadLine());
            string[] pares;

            for(int i = 0; i < limite; i++) {

                pares = Console.ReadLine().Split(' ');
                numerador = int.Parse(pares[0]);
                denominador = int.Parse(pares[1]);

                if (denominador == 0) Console.WriteLine("Divisão impossivel!");
                else Console.WriteLine("{0}", numerador / denominador);
            }
        }
    }
}
