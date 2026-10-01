using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public class Livro
    {
        string titulo = "";

        public Livro()
        {

        }

        public string Titulo { 
            get 
            {
                return this.titulo;
            }
            set {
                if (value != "")
                {
                    this.titulo = value;
                }
                else
                {
                    MessageBox.Show("Título está vazio", "Aviso!");
                }
            }
        }
    }
}
