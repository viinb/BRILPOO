using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public class Usuario
    {
        public string Nome { get; set; }

        public Usuario(string nome)
        {
            this.Nome = nome;
        }

        public Usuario() : this("")
        {
        }
    }
}
