using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class TAE : Usuario, IContrato
    {
        public int NumContrato { get; set; }
        public int DescContrato { get; set; }
        public string Tipo { get; set; } //Pedagógico/Gestão

        public TAE(string Codigo, string Nome, string Tipo, int NumContrato, string DescContrato) : base(Codigo, Nome, "TAE")
        {
            this.Tipo = Tipo;
        }

        public string ImprimeContrato()
        {
            return $"Número: {this.NumContrato}\nDesc: {this.DescContrato}";
        }

        public override string MostraDetalhe()
        {
            return $"Tipo: {this.Tipo}";
        }
    }
}
