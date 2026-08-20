using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividade_Polimorfismo
{
    public partial class w_Det_Ana : Atividade_Polimorfismo.w_Det
    {
        public w_Det_Ana()
        {
            InitializeComponent();
        }

        public w_Det_Ana(FuncionariosForm P, Funcionario F, string Tipo) : base(P, F, Tipo)
        {
            InitializeComponent();

            cb_Nivel.Items.Add("Junior");
            cb_Nivel.Items.Add("Senior");
            cb_Nivel.Items.Add("Pleno");
        }

        public override bool ValidaCamposFuncionario()
        {
            return (base.ValidaCamposFuncionario() && (cb_Nivel.Text != ""));
        }

        public override void Mostra_Funcionario()
        {
            base.Mostra_Funcionario();
            cb_Nivel.Text = (F as Analista).Nivel;
        }

        public override int Grava_Funcionario()
        {
            int Ret = 0;

            if (ValidaCamposFuncionario())
            {

                (F as Analista).InsereDados(base.txb_Nome.Text, float.Parse(base.txb_Salario.Text), cb_Nivel.Text);
                Ret = 1;

            }
            else
            {
                MessageBox.Show("Há dados do analista a preencher!!!");
            }

            return Ret;
        }
    }
}
