using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class Parceiro : I_IFSP
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }

        public Parceiro(string Codigo, string Nome, string CpfCnpj)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.CpfCnpj = CpfCnpj;
        }
    }
}
