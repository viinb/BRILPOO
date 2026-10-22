using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    abstract public class IFSP : I_IFSP
    {
        static int id = 0;
        public string Codigo { get; } = "bi";

        string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    ArgumentException E = new ArgumentException("Nome não pode ser vazio!");
                    throw E;
                } else
                {
                    this.nome = value;
                }
            }
        }

        public int Classe { get; }

        public IFSP(int Classe)
        {
            ++IFSP.id;
            this.Codigo += id.ToString("D7");
            this.Classe = Classe;
        }
    }
}
