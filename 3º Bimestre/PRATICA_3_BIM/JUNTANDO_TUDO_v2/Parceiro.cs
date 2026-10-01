using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JUNTANDO_TUDO_v2
{
    class Parceiro : IContrato
    {
        private string codigo = "";
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                if (value != "")
                {
                    this.codigo = value;
                }
                else
                {
                    MessageBox.Show("Erro", "Código inválido!!");
                }
            }
        }
        public string Nome { get; set; }
        public int NumContrato { get; set; }
        public int DescContrato { get; set; }
        public string CPF_CNPJ { get; set; }

        public Parceiro(string Codigo, string Nome, string CPF_CNPJ, int NumContrato, string DescContrato)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.CPF_CNPJ = CPF_CNPJ;
        }

        public string MostraDetalhe()
        {
            return $"CPF/CNPJ: {CPF_CNPJ}";
        }

        public string ImprimeContrato()
        {
            return $"Número: {this.NumContrato}\nDesc: {this.DescContrato}";
        }
    }
}
