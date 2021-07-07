using System;

namespace Exercicio5_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');
            int num1 = int.Parse(peca1[0]);
            int quantidade1 = int.Parse(peca1[1]);
            float preco1 = float.Parse(peca1[2]);
            int num2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            float preco2 = float.Parse(peca2[2]);

            Console.WriteLine($"Preco a pagar = {(quantidade1*preco1)+(quantidade2*preco2):F2}");
        }
    }
}
