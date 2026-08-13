using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa (string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public Pessoa()
        {

        }

        public void MostrarCampos()
        {
            Console.WriteLine($"Nome: {this.Nome} Idade: {this.Idade}");
        }
    }
}
