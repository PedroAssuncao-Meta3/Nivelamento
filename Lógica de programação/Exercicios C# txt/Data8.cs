using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Data8
    {

        static void Main()
        {

            Console.WriteLine("Escreva a data 1: ");
            string data1 = Console.ReadLine();
            Console.WriteLine("Escreva a data 2: ");
            string data2 = Console.ReadLine();
            DateTime dataMenor, dataMaior;
            System.TimeSpan diferenca;

            if (!(DateTime.TryParse(data1, out dataMenor)) || !(DateTime.TryParse(data2, out dataMaior)))
            {
                Console.WriteLine("Formato inválido!");
            }

            else
            {
                diferenca = dataMaior.Subtract(dataMenor);
                Console.WriteLine(diferenca);
                
                if (diferenca.TotalDays > 365)
                {
                    Console.WriteLine("Diferença em anos: {0}", (int)diferenca.TotalDays / 365);
                }
                else if (diferenca.TotalDays <= 365 && diferenca.TotalDays > 30) {

                    Console.WriteLine("Diferença em meses: {0}", (int)diferenca.TotalDays / 30);
                }
                else if (diferenca.TotalDays <= 30 && diferenca.TotalDays >= 1) {

                    Console.WriteLine("Diferença em dias: {0}", (int)diferenca.TotalDays);
                }
                else if (diferenca.TotalDays < 1 && diferenca.TotalHours >= 0 && diferenca.TotalMinutes >= 0 && diferenca.TotalSeconds >= 0) {

                    Console.WriteLine("Diferença em horas: {0}\nDiferença em minutos: {1}\nDiferença em segundos: {2}", (int)diferenca.TotalHours, diferenca.TotalMinutes, diferenca.TotalSeconds);
                }
                else
                {
                    throw new Exception("A diferença entre as datas é negativa");
                }
            }

            Console.ReadLine();
        }
    }
}
