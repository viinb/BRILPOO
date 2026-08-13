using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFuncionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalculaBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
