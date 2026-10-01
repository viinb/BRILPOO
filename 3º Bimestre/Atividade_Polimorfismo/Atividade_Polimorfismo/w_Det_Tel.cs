using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividade_Polimorfismo
{
    public partial class w_Det_Tel : Atividade_Polimorfismo.w_Det
    {
        public w_Det_Tel()
        {
            InitializeComponent();
        }

        public w_Det_Tel(FuncionariosForm P, Funcionario F, string Tipo) : base(P, F, Tipo)
        {
            InitializeComponent();
        }

        public override bool ValidaCamposFuncionario()
        {
            return (base.ValidaCamposFuncionario() && (txb_EstTrab.Text != ""));
        }

        public override void Mostra_Funcionario()
        {
            base.Mostra_Funcionario();
            txb_EstTrab.Text = (F as Telefonista).EstacaoDeTrabalho.ToString();            
        }

        public override int Grava_Funcionario()
        {
            int Ret = 0;

            if (ValidaCamposFuncionario())
            {

                (F as Telefonista).InsereDados(base.txb_Nome.Text, float.Parse(base.txb_Salario.Text), int.Parse(txb_EstTrab.Text));
                Ret = 1;

            }
            else
            {
                MessageBox.Show("Há dados da telefonista a preencher!!!");
            }

            return Ret;
        }

        private void w_Det_Tel_Load(object sender, EventArgs e)
        {

        }
    }
}
