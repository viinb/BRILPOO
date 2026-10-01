using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP
{
    public class Usuario_IFSP
    {
        static int Id=0;
        public string Prontuario { get; } = "BI";
        public string Tipo { get; }

        static int GeraId()
        {
            return ++Id;
        }

        public Usuario_IFSP()
        {
            this.Prontuario += GeraId().ToString("D7");
            //Console.WriteLine("Construtor Usuário IFSP");
        }

        public Usuario_IFSP(string Tipo_Usuario):this()
        {
            this.Tipo = Tipo_Usuario;
            
        }
    }
}
