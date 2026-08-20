using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    // Clase base para os funcionários
    // Implementas os atributos e métodos para Salário e Nome
    public class Funcionario
    {
        private double salario;
        private string nome;
        public string Classe {  get; }

        public Funcionario()
        {

        }

        public Funcionario(string Classe)
        {
            this.Classe = Classe;
        }

        public double Salario
        {
            get
            {
                return this.salario;
            }
            set
            {
                this.salario = value;
            }
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        // Cálculo de bonificação = 10% do salário.
        // Esse cáculo pode variar de acordo com o cargo do funcionário.
        public virtual double Bonificacao{
            get
            {
                return this.Salario * 0.1;
            }
        }
        
        // Recupera o valor de bonificação no formato de string para ser colocado em um Listbox
        public virtual string RecuperaBonificacao()
        {
            return " Bonificação: " + Convert.ToString(Bonificacao);
        }

        // Atualiza os atributos de nome e salário
        public virtual void InsereDados(string Nome, double Salario)
        {
            this.Nome = Nome;
            this.Salario = Salario;
        }

        // Retorna um string com o Nome e salário do usuário para
        // posso ser inserido no listbox
        public virtual string RecuperaDados()
        {
            return ("Nome: " + Convert.ToString(this.Nome)
                             + " Salario: " + Convert.ToString(this.Salario));
        }
    }
}
