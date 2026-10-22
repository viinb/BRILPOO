using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class Aluno : IFSP
    {
        private string curso;
        public string Curso
        {
            get
            {
                return curso;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    ArgumentException E = new ArgumentException("Nome não pode ser vazio!");
                    throw E;
                }
                else
                {
                    this.curso = value;
                }
            }
        }
        private double media;
        public double MediaGeral
        {
            get
            {
                return media;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    ArgumentException E = new ArgumentException("Média não pode ser negativa ou maior que 10!");
                    throw E;
                }
                else
                {
                    this.media = value;
                }

            }
        }

        public Aluno(string Nome, string Curso, double Media) : base(2)
        {
            this.Nome = Nome;
            this.Curso = Curso;
            this.MediaGeral = Media;
        }
    }
}
