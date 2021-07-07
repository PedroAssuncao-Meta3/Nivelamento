using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Texto3
    {

        static void Main()
        {

            Console.WriteLine("Digite uma frase:");
            string entrada = Console.ReadLine();

            StringBuilder saida = new StringBuilder(100);

            saida.Append(entrada.Length);
            saida.Append(" - " + entrada.ToUpper());
            saida.Append(" - " + entrada.ToLower());

            Console.WriteLine(saida);

            Console.ReadLine();
        }
    }
}
