using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Texto4
    {
        static void Main()
        {

            Console.WriteLine("Digite respectivamente uma frase e um caracter: ");
            string frase = Console.ReadLine();
            string Aprocurar = Console.ReadLine();
            int ocorrencias = 0;
            

            frase = frase.ToLower();
            Aprocurar = Aprocurar.ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                if (Aprocurar[0] == frase[i]) {
                    ocorrencias++;
                }
            }

            Console.WriteLine("O número de ocorrências de {0} é: {1}",Aprocurar,ocorrencias);

            Console.ReadLine();
        }
    }
}
