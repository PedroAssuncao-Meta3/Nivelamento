using System;

namespace Exercicio5_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("+-----------------------------------+\n");
            Console.Write("| Codigo   Especificação     Preço  |\n");
            Console.Write("|   1      Cachorro quente   R$4,00 |\n");
            Console.Write("|   2      X - Salada        R$4,50 |\n");
            Console.Write("|   3      X - Bacon         R$5,00 |\n");
            Console.Write("|   4      Torrada Simples   R$2,00 |\n");
            Console.Write("|   5      Refrigerante      R$1,50 |\n");
            Console.Write("+-----------------------------------+\n");

            string[] entrada = Console.ReadLine().Split(' ');
            int codigo = int.Parse(entrada[0]);
            int quantidade = int.Parse(entrada[1]);
            float pagar = 0;

            switch (codigo)
            {
                case 1:

                    pagar = 4.0f * quantidade;
                    break;
                case 2:

                    pagar = 4.5f * quantidade;
                    break;
                case 3:

                    pagar = 5.0f * quantidade;
                    break;
                case 4:

                    pagar = 2.0f * quantidade;
                    break;
                case 5:

                    pagar = 1.5f * quantidade;
                    break;
                default:

                    Console.WriteLine("Codigo inválido!");
                    break;
            }

            Console.WriteLine($"Total: R${pagar:F2}");
        }
    }
}
