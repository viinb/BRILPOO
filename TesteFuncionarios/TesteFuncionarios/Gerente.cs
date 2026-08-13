using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFuncionarios
{
    public class Gerente : Funcionario
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public override double CalculaBonificacao()
        {
            return this.Salario * 0.6 + 100;
        }
    }
}
