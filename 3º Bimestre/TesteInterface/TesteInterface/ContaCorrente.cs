using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInterface
{
    class ContaCorrente : IConta
    {
        public double Saldo { get; set; }
        public double Tarifa { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            double valorTarifado = valor + Tarifa;
            if (Saldo >= valorTarifado)
            {
                Saldo -= valorTarifado;
            }
        }

        public double GetSaldo()
        {
            return Saldo;
        }
    }
}
