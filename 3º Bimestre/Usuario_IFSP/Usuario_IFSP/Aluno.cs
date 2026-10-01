using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP
{
    public class Aluno:Usuario_IFSP
    {
        public double IRA { get; set; } = 0;

        public Aluno():base("Aluno")
        {
            //Console.WriteLine("Construtor Aluno");
        }
    }
}
