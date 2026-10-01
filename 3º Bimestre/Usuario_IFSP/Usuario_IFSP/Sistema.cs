using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuario_IFSP.Usuarios;
using Usuario_IFSP.Usuarios.Servidores;

namespace Usuario_IFSP
{
    public class Sistema
    {
        static void RegistrarCatraca(Usuario usuario)
        {
            Console.WriteLine($"===== REGISTRO =====\nRegistro - Prontuário: {usuario.Prontuario}\n" +
                $"Registro - Tipo: {usuario.Tipo}\n" +
                $"===== DETALHE =====");

            switch(usuario.Tipo)
            {
                case "Professor":
                    Console.WriteLine($"Registro - Tipo: {(usuario as Professor).Area}");
                    break;
                case "TAE":
                    Console.WriteLine($"Registro - Tipo: {(usuario as TAE).Formacao}");
                    break;
                case "Aluno": 
                    Console.WriteLine($"Registro - Tipo: {(usuario as Aluno).IRA}");
                    break;
                default:
                    Console.WriteLine("Erro: Tipo indeterminado");
                    break;
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Professor professor1 = new Professor("Informática");
            Aluno aluno1 = new Aluno();
            TAE tae1 = new TAE("Psicologia");

            RegistrarCatraca(professor1);
            RegistrarCatraca(aluno1);
            RegistrarCatraca(tae1);
        }
    }
}
