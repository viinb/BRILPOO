using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    public class Secretaria : Funcionario
    {
        // Adiciona o campo Ramal aos já herdados do funcionário
        public int Ramal { get; set; }

        public Secretaria() : base("Secretária")
        {

        }

        // Atualiza o objeto com nome, salário e Ramal
        public virtual void InsereDados(String Nome, double Salario, int Ramal)
        {
            // Nome e Salario estão implementados na classe pai
            base.InsereDados(Nome, Salario);
            this.Ramal= Ramal;
        }

        public override string RecuperaDados()
        {
            // Chama o método da classe pai que retorna um string com nome salário 
            // e completa com os da classe filha
            // ??? Questão: Implemente o retorno da função de modo a preencher o listbox
            // similar ao da classe Gerente
            return base.RecuperaDados()
                   + " Ramal: " + Convert.ToString(this.Ramal) + RecuperaBonificacao();
        }
    }
}
