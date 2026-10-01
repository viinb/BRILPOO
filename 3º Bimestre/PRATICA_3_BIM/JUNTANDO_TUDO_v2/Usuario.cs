using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    abstract class Usuario
    {
        private string codigo = "";
        public string Codigo { 
            get
            {
                return this.codigo;
            }
            set
            {
                if (value != "")
                {
                    this.codigo = value;
                }
                else
                {
                    MessageBox.Show("Erro", "Código inválido!!");
                }
            } 
        }
        public string Nome { get; set; }
        public string Classe { get; private set; }

        public Usuario(string Codigo, string Nome, string Classe) 
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Classe = Classe;
        }

        public abstract string MostraDetalhe();
    }
}
