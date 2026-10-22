using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class Professor : IFSP
    {
        private string area;
        public string Area
        {
            get
            {
                return area;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    ArgumentException E = new ArgumentException("Área não pode ser vazio!");
                    throw E;
                }
                else
                {
                    this.area = value;
                }
            }
        }

        public Professor(string Nome, string Area) : base(1)
        {
            this.Nome = Nome;
            this.Area = Area;
        }
    }
}
