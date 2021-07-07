using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Numeros1
    {

        static void Main()
        {

            float num1, num2;
            StringBuilder saida = new StringBuilder(100);

            Console.WriteLine("Digite 2 numeros: ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());

            saida.Append("Soma: " + (num1 + num2) + "\n");
            saida.Append("Subtração: " + (num1 - num2) + "\n");
            saida.Append("Multiplicação: " + (num1 * num2) + "\n");
            saida.Append("Divisão: " + (num1 / num2) + "\n"); 
            saida.Append("Divisão Inteira: " + (int)(num1 / num2) + "\n");
            saida.Append("Resto: " + (num1 % num2) + "\n");
            saida.Append("Potencia: " + (Math.Pow(num1, num2)) + "\n");

            Console.WriteLine(saida);

            Console.ReadLine();

        }

    }
}
