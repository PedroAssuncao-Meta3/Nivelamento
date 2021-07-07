using System;

namespace Exercicio3_Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            int gasolina = 0, alcool = 0, diesel = 0;
            bool fechar = false;

            while(fechar != true)
            {

                opt = int.Parse(Console.ReadLine());

                if (opt == 1) alcool++;

                else if (opt == 2) gasolina++;

                else if (opt == 3) diesel++;

                else if (opt == 4) fechar = true;
            }

            Console.WriteLine($"Muito Obrigado!\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}
