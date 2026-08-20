using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Polimorfismo
{
    public partial class w_Det : Form
    {
        public FuncionariosForm ListaFunc = new FuncionariosForm();
        public Funcionario F = new Funcionario();
        public string Tipo = "";

        public w_Det()
        {
            InitializeComponent();
        }

        public w_Det(FuncionariosForm Parent, Funcionario F, string Tipo) : this()
        {
            this.ListaFunc = Parent;
            this.F = F;
            this.Tipo = Tipo; //Tipo: "I" = Inserir e "E" = Editar
        }

        public virtual bool ValidaCamposFuncionario()
        {
            return ((txb_Nome.Text != "") && (txb_Salario.Text != ""));
        }

        public virtual void Mostra_Funcionario()
        {
            txb_Nome.Text = F.Nome;
            txb_Salario.Text = F.Salario.ToString();
            txb_Bonificacao.Text = F.Bonificacao.ToString();
        }

        public virtual int Grava_Funcionario()
        {
            int Ret = 0;

            if (ValidaCamposFuncionario())                
            {
                this.F.InsereDados(txb_Nome.Text, float.Parse(txb_Salario.Text));
                Ret = 1;
            }

            return Ret;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void w_Det_Load(object sender, EventArgs e)
        {
           if (this.F != null && this.F.Classe != "")
           {
               this.Text = "Detalhe [" + this.F.Classe + " - " + this.F.Nome + "]";
           }

           if (this.Tipo == "E")
           {
               //Carrega os atributos na tela
               this.Mostra_Funcionario();
           }
          
        }

        public virtual void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (this.Grava_Funcionario() == 1)
            {
                this.Mostra_Funcionario();
            }            
        }
    }
}
