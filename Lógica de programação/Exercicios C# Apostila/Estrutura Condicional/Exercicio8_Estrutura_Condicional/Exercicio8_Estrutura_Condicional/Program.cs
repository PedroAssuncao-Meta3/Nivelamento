using System;

namespace Exercicio8_Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = float.Parse(Console.ReadLine());

            if (salario >= 0 && salario <= 2000.00f) Console.WriteLine("Isento");
            else if (salario > 2000.00f && salario <= 3000.00f) Console.WriteLine($"R${salario * 0.08f:F2}");
            else if (salario > 3000.00f && salario <= 4500.00f) Console.WriteLine($"R${(salario - 3000.00f) * 0.18f + 1000.00f * 0.08:F2}");
            else Console.WriteLine($"R${(salario - 4500.00f) * 0.28f + 1944.40 * 0.18f:F2}");
        }
    }
}
