using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_IFSP
{
    internal class Sistema_IFSP
    {
        static void Registrar_Catraca(Usuario_IFSP U)
        {
            Console.WriteLine("Registro - Prontuário: " + U.Prontuario);
            Console.WriteLine("Registro - Tipo: " + U.Tipo);
            Console.WriteLine("---- DETALHES----");
            switch (U.Tipo)
            {
                case "Professor":
                    Console.WriteLine("Registro - Tipo: " + (U as Professor).Area);
                    break;
                case "TAE":
                    Console.WriteLine("Registro - Tipo: " + ((TAE) U).Formacao);
                    break;
                case "Aluno":
                    if (U is Aluno)
                    {
                        Aluno A;
                        A = (Aluno) U;
                        Console.WriteLine("Registro - Tipo: " + A.IRA);
                    }
                    
                    break;
                default:
                    Console.WriteLine("Erro: Tipo indeterminado!!!");
                    break;
            }
            


        }

        static void Main(string[] args)
        {
            /*Professor P1 = new Professor("Informática");
            Aluno A1 = new Aluno();
            TAE T1 = new TAE("Psicologia");

            Usuario_IFSP U;

            //Testando o atributo e método de classe
            Console.WriteLine("P1 - Prontuário: " + P1.Prontuario);
            Console.WriteLine("P1 - Área:  " + P1.Area);
            Console.WriteLine("A1 - Prontuário: " + A1.Prontuario);
            Console.WriteLine("A1 - IRA:  " + A1.IRA);

            U = P1;
            Console.WriteLine("U - Prontuário: " + U.Prontuario);
            U = A1;
            Console.WriteLine("U - Prontuário: " + U.Prontuario);

            Registrar_Catraca(P1);
            Registrar_Catraca(A1);
            Registrar_Catraca(T1);
            */

            Aluno A1 = new Aluno();
            Aluno_ETEC A2 = new Aluno_ETEC("230941");

            Console.WriteLine(A1.Tipo + " - " + A1.Prontuario + ": " + A1.RealizarInscricao());
            Console.WriteLine(A2.Tipo + " - " + A2.RM + ": " + A2.RealizarInscricao());

        }

    }
}
