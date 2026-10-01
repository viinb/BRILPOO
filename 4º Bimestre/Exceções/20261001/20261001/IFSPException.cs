using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20261001
{
    class IFSPException : Exception
    {
        public string Titulo { get; }

        public IFSPException(string Titulo, string Mensagem) : base (Mensagem)
        {
            this.Titulo = Titulo;
        }
    }
}
