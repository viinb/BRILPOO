using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP.Usuarios.Servidores
{
    public class Professor : Servidor
    {
        public string Area { get; }

        public Professor() : base("Professor")
        {

        }

        public Professor(string area) : this()
        {
            this.Area = area;
        }
    }
}
