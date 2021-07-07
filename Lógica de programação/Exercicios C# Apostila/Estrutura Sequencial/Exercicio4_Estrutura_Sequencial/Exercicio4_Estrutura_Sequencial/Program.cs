using System;

namespace Exercicio4_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int numero = int.Parse(entrada[0]);
            int horas = int.Parse(entrada[1]);
            float valorHora = float.Parse(entrada[2]);


            Console.WriteLine($"Numero = {numero}\nSalário = {valorHora*horas:F2}");
        }
    }
}
