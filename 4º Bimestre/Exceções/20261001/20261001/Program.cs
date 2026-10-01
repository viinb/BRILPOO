using System;

namespace Aula_20261001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            string CampoTela;
            bool Valido = false;

            do
            {
                Console.Clear();
                Console.Write("Digite um número: ");
                CampoTela = Console.ReadLine();

                try
                {
                    A = Int32.Parse(CampoTela);
                    Valido = true;
                }
                catch (Exception E)
                {
                    Console.WriteLine("Erro: " + E.Message);
                    Console.ReadKey(true);
                    Valido = false;
                }
                finally
                {
                    if (Valido == true)
                    {
                        Console.WriteLine(A);
                        Console.ReadKey(true);
                    }
                }
            } while (Valido == false);
        }
    }
}
