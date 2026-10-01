using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP
{
    public class Aluno_ETEC : Usuario_ETEC, IProvaoPaulista
    {
        public string RM { get; set; }
        public string Tipo { get; }

        public Aluno_ETEC(string RM)
        {
            this.RM = RM;
            this.Tipo = "Aluno ETEC";
        }

        public string RealizarInscricao()
        {
            return "Inscrição do Aluno da ETEC Concluida";
        }
    }
}
