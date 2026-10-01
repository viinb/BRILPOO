using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao10092026
{
    public abstract class UsuarioIFSP
    {
        public static int ID = 0;

        public string Prontuario { get; } = "BI";
        public string Nome = "";
        public int Idade = 0;

        public UsuarioIFSP()
        {
            UsuarioIFSP.ID++;
            this.Prontuario += ID.ToString("D7");
        }

        public UsuarioIFSP(string nome, int idade) : this()
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void Imprimir(bool total)
        {
            Console.Write($"Prontuário: {this.Prontuario} - ");
            Console.Write($"Nome: {this.Nome}; ");

            if (total)
            {
                Console.Write($"Idade: {this.Idade} ");
            }

            Console.WriteLine();
        }

        public void Imprimir()
        {
            this.Imprimir(true);
        }

        public void Imprimir(int idade)
        {
            if (this.Idade > idade)
            {
                this.Imprimir(true);
            }
        }

        public virtual string RecuperaDados()
        {
            return $"Nome: {this.Nome} Idade: {this.Idade}";
        }
    }
}
