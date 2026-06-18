using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoExercicios
{
    public class Conta
    {
        int numero;
        double saldo;

        public int Numero { 
            get 
            { 
                return this.numero; 
            } 
            set 
            { 
                this.numero = value; 
            } 
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Conta com saldo negativo!", "Erro!");
                } else
                {
                    this.saldo = value;
                }
            }
        }

        public static double Limite { get; set; }

        public Conta(int Numero, double Saldo)
        {
            this.GravaConta(Numero, Saldo);
        }

        public void GravaConta(int Numero, double Saldo)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
        }

        public string DadosConta()
        {
            return "Conta: " + this.Numero + "\t Saldo: " + this.Saldo;
        }

        public double SaldoDisp()
        {
            return (this.Saldo + Conta.Limite);
        }
    }
}
