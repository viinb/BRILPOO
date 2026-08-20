using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividade_Polimorfismo
{
    public partial class w_Det_Ger : Atividade_Polimorfismo.w_Det
    {
        public w_Det_Ger()
        {
            InitializeComponent();
        }

        public  w_Det_Ger(FuncionariosForm P, Funcionario F, string Tipo) : base(P, F, Tipo)
        {
            InitializeComponent();
        }

        public override bool ValidaCamposFuncionario()
        {
            return (base.ValidaCamposFuncionario() && (txb_Usuario.Text != "") && (txb_Senha.Text != ""));
        }

        public override void Mostra_Funcionario()
        {
            base.Mostra_Funcionario();
            txb_Usuario.Text = (F as Gerente).Usuario;
            txb_Senha.Text = (F as Gerente).Senha;
        }

        public override int Grava_Funcionario()
        {
            int Ret = 0;

            if (ValidaCamposFuncionario())
            {
                
                (F as Gerente).InsereDados(base.txb_Nome.Text, float.Parse(base.txb_Salario.Text), txb_Usuario.Text, txb_Senha.Text);
                Ret = 1;
                
            }
            else
            {
                MessageBox.Show("Há dados do gerente a preencher!!!");
            }

                return Ret;
        }

        private void w_Det_Ger_Load(object sender, EventArgs e)
        {

        }

        private void ListaFunc_Load(object sender, EventArgs e)
        {

        }

        private void ListaFunc_Load_1(object sender, EventArgs e)
        {

        }
    }

}
