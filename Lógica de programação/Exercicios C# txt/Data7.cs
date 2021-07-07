using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Data7
    {
        static void Main()
        {
            Console.WriteLine("Digite uma data e hora (dd/MM/AA)(hh:mm:ss):");
            string DataEntrada = Console.ReadLine();
            int dia, mes, ano, hora, minuto, segundo;
            DateTime date;

            if (DateTime.TryParse(DataEntrada, out date))
            {

                dia = date.Day;
                mes = date.Month;
                ano = date.Year;
                hora = date.Hour;
                minuto = date.Minute;
                segundo = date.Second;

                Console.WriteLine("Dia {0} do mês {1} do ano {2}, as {3} horas, {4} minutos e {5} segundos", dia, mes, ano, hora, minuto, segundo);
            }

            else Console.WriteLine("Data/Hora inválida");

            Console.ReadLine();
        }
    }
}
