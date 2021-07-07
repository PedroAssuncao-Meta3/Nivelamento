using System;

namespace Exercicio1_Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {
            const string senha = "2002";

            string entrada;
            bool SenhaCorreta = false;

            do {
                entrada = Console.ReadLine();

                if (entrada.Equals(senha))
                {
                    SenhaCorreta = !SenhaCorreta;
                    Console.WriteLine("Acesso concedido");
                }
                else Console.WriteLine("Senha inválida!");
            } while (SenhaCorreta != true);
        }
    }
}
