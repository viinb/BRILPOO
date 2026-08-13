using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Aluno : Pessoa
    {
        public double IRA { get; set; }

        public Aluno() 
        {

        }

        public Aluno(string Nome, int Idade) : base(Nome, Idade)
        {

        }
    }
}
