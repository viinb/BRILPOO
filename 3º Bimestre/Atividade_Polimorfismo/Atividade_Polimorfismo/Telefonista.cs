using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    public class Telefonista : Funcionario
    {
        // Adiciona o campo EstacaoDeTrabalo aos já herdados do funcionário
        public int EstacaoDeTrabalho { get; set; }

        public Telefonista() : base("Telefonista")
        {

        }

        // Atualiza o objeto com nome, salário e EstacaoDeTrabalho
        public virtual void InsereDados(string Nome, double Salario, int EstacaoDeTrabalho)
        {
            // Nome e Salario estão implementados na classe pai
            base.InsereDados(Nome, Salario);
            this.EstacaoDeTrabalho = EstacaoDeTrabalho;
        }

        public override string RecuperaDados()
        {
            // Chama o método da classe pai que retorna um string com nome salário 
            // e completa com os da classe filha
            // ??? Questão: Implemente o retorno da função de modo a preencher o listbox
            // similar ao da classe Gerente
            return base.RecuperaDados()
                   + " EstaçãoDeTrabalho: " + Convert.ToString(this.EstacaoDeTrabalho) + RecuperaBonificacao();
        }



    }
}
