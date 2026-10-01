using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao10092026
{
    public class AlunoIFSP : UsuarioIFSP
    {
        public double IRA { get; set; } = 0;

        public AlunoIFSP(string nome, int idade) : base(nome, idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string RecuperaDados()
        {
            return base.RecuperaDados() + $" IRA: {this.IRA}";
        }
    }
}
