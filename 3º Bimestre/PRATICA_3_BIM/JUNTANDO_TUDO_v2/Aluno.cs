using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class Aluno : Usuario
    {
        public string Curso { get; set; }
        private double media = 0;
        public double Media {
            get
            {
                return this.media;
            }
            set
            {
                if (value >= 0)
                {
                    this.media = value;
                }
                else
                {
                    MessageBox.Show("Erro", "Média negativa!!");
                }
            }
        }

        public Aluno(string Codigo, string Nome, string Curso, double Media) : base(Codigo, Nome, "Aluno")
        {
            this.Curso = Curso;
            this.Media = Media;
        }

        public override string MostraDetalhe()
        {
            return $"Curso: {this.Curso}, Média: {this.Media}";
        }
    }
}
