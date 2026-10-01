using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao10092026
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsuarioIFSP usuarioIFSP1 = new UsuarioIFSP();
            //UsuarioIFSP usuarioIFSP2 = new UsuarioIFSP("Sílvio Serrano", 16);

            // Console.WriteLine(UsuarioIFSP.ID);
            //Console.WriteLine(usuarioIFSP1.Prontuario);

            // Console.WriteLine(UsuarioIFSP.ID);
            //Console.WriteLine($"{usuarioIFSP2.Prontuario} - {usuarioIFSP2.Nome}");

            //usuarioIFSP2.Imprimir();

            AlunoIFSP alunoIFSP = new AlunoIFSP("Transfusão de Sangue da Silva", 16);
            alunoIFSP.Imprimir();
            Console.WriteLine(alunoIFSP.RecuperaDados());

            ProfessorIFSP professorIFSP = new ProfessorIFSP("História da Silva", 200000000);
            professorIFSP.Imprimir();
            Console.WriteLine(professorIFSP.RecuperaDados());

        }
    }
}
