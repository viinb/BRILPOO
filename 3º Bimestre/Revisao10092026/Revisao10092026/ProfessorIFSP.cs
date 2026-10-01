using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao10092026
{
    public class ProfessorIFSP : UsuarioIFSP
    {
        public double Salario { get; set; } = 0;

        public ProfessorIFSP(string nome, int idade) : base(nome, idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string RecuperaDados()
        {
            return base.RecuperaDados() + $" Salário: {this.Salario}";
        }
    }
}
