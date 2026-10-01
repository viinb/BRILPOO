using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class Professor : Usuario
    {
        public string Area { get; set; } //Informática/Indústria/Gestão

        public Professor(string Codigo, string Nome, string Area) : base(Codigo, Nome, "Professor")
        {
            this.Area = Area;
        }

        public override string MostraDetalhe()
        {
            return $"Área: {this.Area}";
        }
    }
}
