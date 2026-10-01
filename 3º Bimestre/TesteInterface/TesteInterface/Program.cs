using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TesteInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op = 0;
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Saldo = 1000;
            contaCorrente.Tarifa = 1.5;

            do
            {
                Console.Write("Opções:\n[1] Depositar\n[2] Sacar\n[3] Mostrar Saldo\n[0] Sair\nOpção: ");
                Op = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (Op)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Valor do Deposito: ");
                        contaCorrente.Depositar(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Valor do Saque: ");
                        contaCorrente.Sacar(double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Saldo: {0:C2}", contaCorrente.GetSaldo());
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        return;
                }

                Console.Clear();
            } while (Op != 0);
        }
    }
}
