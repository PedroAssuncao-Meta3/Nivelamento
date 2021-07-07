using System;

namespace Exercicio2_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            const int teste = 2;
            string entrada = Console.ReadLine();
            int numero = int.Parse(entrada);

            if (numero % teste == 0) Console.WriteLine("Par!");
            else Console.WriteLine("Impar!");
        }
    }
}
