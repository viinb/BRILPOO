using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public double SaldoCashBack { get; set; }

        public Conta(string nome, double saldo, double limite)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Limite = limite;
            this.SaldoCashBack = 0;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
            SaldoCashBack += (valor / 100) * 5;
        }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;
            SaldoCashBack++;
        }

        public double Consultar()
        {
            return this.Saldo;
        }
    }
}
