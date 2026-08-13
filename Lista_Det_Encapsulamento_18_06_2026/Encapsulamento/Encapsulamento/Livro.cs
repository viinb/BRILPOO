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
        static int id=0; //atributo da classe

        static int GeraId()
        {
            Livro.id++;

            return Livro.id;
        }

        int id_Livro;
        public string Codigo { get; }
        
        string titulo="";        
        public string Titulo
        {
            get
            {                
                return this.titulo;
            }

            set
            {
                if (value != "")
                {
                    this.titulo = value;
                }
                else
                {
                    MessageBox.Show("Título não preenchido!!", "AVISO!!!");
                }

            }
        }

        public string Autor { get; set; }

        public Livro()
        {
            this.id_Livro = Livro.GeraId();
            this.Codigo = "L_" + this.id_Livro.ToString();

        }

        
    }
}
