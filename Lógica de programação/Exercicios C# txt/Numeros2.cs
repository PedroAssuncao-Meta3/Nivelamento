using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Numeros2
    {

        static void Main()
        {
            Console.WriteLine("Digite um numero: ");
            int IntConvertido = 0;
            float floatConvertido = 0;
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out IntConvertido))
            {
                Console.WriteLine("Inteiro");
            }
            else if(float.TryParse(entrada, out floatConvertido))
            {
                Console.WriteLine("Flutuante");
            }
            else
            {
                Console.WriteLine("Não é um número válido");
            }

            Console.ReadLine();
        }
    }
}
