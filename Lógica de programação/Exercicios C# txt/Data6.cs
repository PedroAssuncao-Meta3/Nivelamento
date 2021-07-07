using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Data6
    {
        static void Main()
        {
            Console.Write("Digite uma data: ");
            string EntradaData = Console.ReadLine();
            DateTime data;

            if (DateTime.TryParse(EntradaData, out data)) Console.WriteLine("Data Válida");

            else Console.WriteLine("Data inválida");

            Console.ReadLine();
        }
    }
}
