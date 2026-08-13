using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP.Usuarios
{
    public class Aluno : Usuario
    {
        public double IRA { get; set; }

        public Aluno() : base("Aluno")
        {

        }
    }
}
