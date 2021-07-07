using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Data9
    {
        static void Main()
        {
            Console.WriteLine("Digite uma data no formato DD/MM/AAAA HH:MI:SS: ");
            string DataDigitada = Console.ReadLine();
            int dia,mes,ano,hora,minuto,segundo;
            int i, j;
            DateTime date;

            DataDigitada = DataDigitada.Replace(',', '/').Replace(' ','/');

            for (i = 0; i < DataDigitada.Length; i++) {
                if (DataDigitada[i] != '/') break;
            }

            for (j = i; j < DataDigitada.Length; j++){

                if (DataDigitada[j] == '/') break;
            }

            dia = int.Parse(DataDigitada.Substring(i, j - i));

            for (i = j; i < DataDigitada.Length; i++)
            {
                if (DataDigitada[i] != '/') break;
            }

            for (j = i; j < DataDigitada.Length; j++)
            {

                if (DataDigitada[j] == '/') break;
            }

            mes = int.Parse(DataDigitada.Substring(i, j - i));

            for (i = j; i < DataDigitada.Length; i++)
            {
                if (DataDigitada[i] != '/') break;
            }

            for (j = i; j < DataDigitada.Length; j++)
            {

                if (DataDigitada[j] == '/') break;
            }

            ano = int.Parse(DataDigitada.Substring(i, j - i));

            for (i = j; i < DataDigitada.Length; i++)
            {
                if (DataDigitada[i] != '/') break;
            }

            for (j = i; j < DataDigitada.Length; j++)
            {

                if (DataDigitada[j] == '/') break;
            }

            hora = int.Parse(DataDigitada.Substring(i, j - i));

            for (i = j; i < DataDigitada.Length; i++)
            {
                if (DataDigitada[i] != '/') break;
            }

            for (j = i; j < DataDigitada.Length; j++)
            {

                if (DataDigitada[j] == '/') break;
            }

            minuto = int.Parse(DataDigitada.Substring(i, j - i));

            for (i = j; i < DataDigitada.Length; i++)
            {
                if (DataDigitada[i] != '/') break;
            }

            for (j = i; j < DataDigitada.Length; j++)
            {

                if (DataDigitada[j] == '/') break;
            }

            segundo = int.Parse(DataDigitada.Substring(i, j - i));

            switch (mes)
            {
                case 1:
                    if (dia > 31) Console.WriteLine("O mes só tem 31 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 2:
                    if ((ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0) && dia > 29) Console.WriteLine("O mes só tem 29 dias!");
                    else if (dia > 28) Console.WriteLine("O ano não é bissexto logo o mes só tem 28 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 3:
                    if (dia > 31) Console.WriteLine("O mes só tem 31 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 4:
                    if (dia > 30) Console.WriteLine("O mes só tem 30 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 5:
                    if(dia > 31) Console.WriteLine("O mes só tem 31 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 6:
                    if (dia > 30) Console.WriteLine("O mes só tem 30 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 7:
                    if(dia > 31) Console.WriteLine("O mes só tem 31 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 8:
                    if(dia > 31) Console.WriteLine("O mes só tem 31 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 9:
                    if (dia > 30) Console.WriteLine("O mes só tem 30 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 10:
                    if (dia > 31) Console.WriteLine("O mes só tem 31 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 11:
                    if(dia > 30) Console.WriteLine("O mes só tem 30 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                case 12:
                    if(dia > 31) Console.WriteLine("O mes só tem 31 dias!");
                    else
                    {
                        if (ano >= 0 && ano <= 9999)
                        {
                            if (hora >= 0 && hora <= 23)
                            {
                                if (minuto >= 0 && minuto <= 59)
                                {
                                    if (segundo >= 0 && segundo <= 59)
                                    {
                                        date = new DateTime(ano, mes, dia, hora, minuto, segundo);
                                        Console.WriteLine(date);
                                    }
                                    else Console.WriteLine("Segundo inválido!");
                                }
                                else Console.WriteLine("Minuto inválido");
                            }
                            else Console.WriteLine("Hora inválida!");

                        }
                        else Console.WriteLine("Ano inválido!");
                    }
                    break;
                default:
                    Console.WriteLine("O ano tem 12 meses!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
