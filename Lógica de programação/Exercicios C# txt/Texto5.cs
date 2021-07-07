using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Quarta_quinta
{
    class Texto5
    {

        static void Main()
        {

            Console.WriteLine("Digite uma string: ");
            string textoEntrada = Console.ReadLine();
            int i = 0, InicioNovaString = 0, FimNovaString = 0;
            DateTime data = DateTime.Now;
            string novaString;
            StringBuilder saida = new StringBuilder(50);
        

            Boolean possuiHifen = false;

            for (i = 0; i < textoEntrada.Length; i++)
            {

                if (textoEntrada[i] == '-')
                {
                    possuiHifen = true;
                    break;
                }
                
            }

            if(possuiHifen == true)
            {

                for (InicioNovaString = i + 1; InicioNovaString < textoEntrada.Length; InicioNovaString++) {

                    if (textoEntrada[InicioNovaString] != ' ') break;
                }

                for (FimNovaString = (textoEntrada.Length - 1); FimNovaString > 0; FimNovaString--)
                {
                    if (textoEntrada[FimNovaString] != ' ') break;
                }

                novaString = textoEntrada.Substring(InicioNovaString, (FimNovaString-InicioNovaString)+1);

                Console.WriteLine(novaString);
            }

            else
            {
                saida.Append(data.ToString() + " - ");
                saida.Append(textoEntrada);

                Console.WriteLine(saida);
            }

            Console.ReadLine();
        }
    }
}
