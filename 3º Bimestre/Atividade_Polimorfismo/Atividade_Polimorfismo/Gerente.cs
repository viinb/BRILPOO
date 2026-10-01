using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Polimorfismo
{
    
    public class Gerente : Funcionario
    {
        // Adiciona os campos Usuário e Senha aos já herdados do funcionário
        public string Usuario {get; set;}
        public string Senha {get; set;}

        public Gerente() : base("Gerente")
        {

        }

        // Bonificação do gerente é 60% do salário mais 100
        public override double Bonificacao
        {
            get
            {
                return this.Salario * 0.6 + 100;
            }
        }

        // Atualiza o objeto com nome, salário, usuário e senha.
        public virtual void InsereDados(String Nome, double Salario, String Usuario, String Senha)
        {
            // Nome e Salario estão implementados na classe pai
            base.InsereDados(Nome, Salario);
            this.Usuario = Usuario;
            this.Senha = Senha;
        }

        // Retorna um string com os dados do gerente para ser inserida num listbox 
        // do formulário de funcionários
        public override string RecuperaDados()
        {
            // Chama o método da classe pai que retorna um string com nome salário 
            // e completa com os da classe filha
            return base.RecuperaDados() 
                   + " Usuário: " + this.Usuario + RecuperaBonificacao();
        }
    }
}
