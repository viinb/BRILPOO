using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP.Usuarios.Servidores
{
    public class Servidor : Usuario
    {
        public double Salario { get; set; } = 0;

        public Servidor() : this("Servidor")
        {

        }

        public Servidor(string tipo) : base(tipo)
        {

        }
    }
}
