using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP.Usuarios.Servidores
{
    public class TAE : Servidor
    {
        public string Formacao { get; }

        public TAE() : base("TAE")
        {

        }

        public TAE(string formacao) : this()
        {
            this.Formacao = formacao;
        }
    }
}
