using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class TAE : IFSP
    {
        public string Tipo { get; set; } //Pedagógico/Gestão

        public TAE(string Nome, string Tipo) : base(3)
        {
            this.Nome = Nome;
            this.Tipo = Tipo;
        }
    }
}
