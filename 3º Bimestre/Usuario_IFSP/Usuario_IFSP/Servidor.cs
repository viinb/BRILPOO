using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP
{
    public class Servidor:Usuario_IFSP
    {
        public double Salario { get; set; } = 0;

        //public Servidor()
        //{
            //Console.WriteLine("Construtor Servidor");
       //}

        public Servidor(string Tipo):base(Tipo)
        {
            
        }
    }
}
