using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP
{
    public class Professor:Servidor
    {
        public string Area { get;  }

        public Professor():base("Professor")
        {
            //Console.WriteLine("Construtor Professor");
        }

        public Professor(string Area_Atuacao):this()
        {
            this.Area = Area_Atuacao;
        }

    }
}
