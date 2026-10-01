using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno("Homem Gravido da Silva", 16);
            Aluno B = new Aluno("Six Sevenaldo da Silva", 6);
            Aluno C = new Aluno("Africa do Sul da Silva", 13);

            A.MostrarCampos();
            B.MostrarCampos();
            C.MostrarCampos();

            Pessoa P;

            P = A;

            P.MostrarCampos();
        }
    }
}
