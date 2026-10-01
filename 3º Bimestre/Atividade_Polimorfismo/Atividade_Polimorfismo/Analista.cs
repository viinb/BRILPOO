using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    public class Analista : Funcionario
    {
        // Adiciona o campo Ramal aos já herdados do funcionário
        public string Nivel { get; set; }

        public Analista() : base("Analista")
        {

        }

        // Bonificação do analista é 30% do salário mais 100
        public override double Bonificacao
        {
            get
            {
                return this.Salario * 0.3 + 100;
            }
        }

        // Atualiza o objeto com nome, salário e Ramal
        public virtual void InsereDados(String Nome, double Salario, string Nivel)
        {
            // Nome e Salario estão implementados na classe pai
            base.InsereDados(Nome, Salario);
            this.Nivel = Nivel;
        }

        public override string RecuperaDados()
        {
            // Chama o método da classe pai que retorna um string com nome salário 
            // e completa com os da classe filha
            // ??? Questão: Implemente o retorno da função de modo a preencher o listbox
            // similar ao da classe Gerente
            return base.RecuperaDados()
                   + " Nivel: " + Convert.ToString(this.Nivel) + RecuperaBonificacao();
        }
    }
}
