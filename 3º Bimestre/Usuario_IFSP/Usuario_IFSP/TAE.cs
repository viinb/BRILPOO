using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP
{
    public class TAE:Servidor
    {
        public string Formacao { get; }

        public TAE():base("TAE")
        {
            //Console.WriteLine("Construtor TAE");
        }

        public TAE(string Form_Atuacao):this()
        {
            this.Formacao = Form_Atuacao;
        }
    }
}
