using System;

namespace Exercicio1_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            uint saida;

            if (uint.TryParse(entrada,out saida))
            {
                Console.WriteLine("Não negativo!");
            }
            else
            {
                Console.WriteLine("Negativo!");
            }
        }
    }
}
