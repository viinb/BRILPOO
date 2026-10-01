using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeAcompanhamento_10092026
{
    class Conta
    {
        public double Saldo { get; set; }
        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }

    interface ITributavel
    {
        double CalculaTributo();
        double CalculaImposto();
    }

    class ContaPoupanca : Conta, ITributavel
    {
        // resto da classe aqui

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

        public double CalculaImposto()
        {
            return 0;
        }
    }

    class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }

        public double CalculaImposto()
        {
            return 0;
        }
    }

    class SeguroDeVida : ITributavel
    {
        public double CalculaTributo()
        {
            return 42;
        }

        public double CalculaImposto()
        {
            return 0;
        }
    }

    class TotalizadorDeTributos
    {
        public double Total { get; private set; } = 0;

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        }
    }

    class GerenciadorDeImposto
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel tributavel)
        {
            this.Total += tributavel.CalculaTributo();
        }
    }

    // 8.

    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public void ReajustarPreco(float percentual)
        {
            Preco -= Preco * percentual;
        }
    }

    class ProdutoPerecivel : Produto
    {
        public string PrazoDeValidade { get; set; }
    }

    class ProdutoEletronico : Produto, ITributavel 
    {
        public string Marca { get; set; } 
        public int Voltagem { get; set; }
        public double CalculaImposto()
        {
            return Preco * 0.2;
        }

        public double CalculaTributo()
        {
            return 0;
        }
    }

    class ProdutoImportado : Produto, ITributavel
    {
        public string Pais { get; private set;  } 
        public int AnoFabricacao { get; private set; }

        public double CalculaImposto()
        {
            return Preco * 0.5;
        }

        public double CalculaTributo()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. (a)

            // 2. O programa faz polimorfismo com o objeto da classe que implementa a interface ITributavel e imprime o retorno da implementação do método CalculaTributo da classe. Para consertar tive que adicionar a classe Conta e trocar o "MessageBox.Show" por "Console.WriteLine".

            /* 3. 
                interface ITributavel
                {
                    double CalculaTributo();
                }

                class MalEducada : ITributavel
                {
                    // não implementa o método aqui
                }
             *
             * Da erro porque uma classe que "contrata" uma interface é obrigada a implementar todos os métodos dela. 
             */

            // 4. O programa faz polimorfismo com os dois objetos das classes que implementam a interface ITributavel e imprime o total acumulado de tributo pelos dois.

            TotalizadorDeTributos t = new TotalizadorDeTributos();
            ContaInvestimento ci = new ContaInvestimento();
            ContaPoupanca cp = new ContaPoupanca();
            SeguroDeVida sv = new SeguroDeVida();

            ci.Deposita(100.0);
            cp.Deposita(100.0);

            t.Acumula(ci);
            t.Acumula(cp);
            t.Acumula(sv);

            Console.WriteLine("O total de tributos é: " + t.Total);

            /* 7.
             * 
                GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
                ContaCorrente c = new ContaPoupanca();
                gerenciador.Adiciona(c);
             *
             *  Não. O programa só roda após corrigir o tipo da c para o tipo correto, já que a variavel é do tipo da classe ContaCorrente que não existe, e também ela chama o construtor da classe ContaPoupanca.
             */
            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
            ContaPoupanca c = new ContaPoupanca(); // <<
            gerenciador.Adiciona(c);

            Console.WriteLine("O total do gerenciador de imposto é: " + gerenciador.Total); // 6.
        }
    }
}
