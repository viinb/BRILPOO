using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDoIMC
{
    public partial class w_IMC: Form
    {
        public w_IMC()
        {
            InitializeComponent();
        }

        private void w_IMC_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblAnalise.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float peso, altura, imc;

            if (txtAltura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Insira a altura e o peso!");
            }
            else
            {
                // Calcular IMC
                peso = float.Parse(txtPeso.Text);
                altura = float.Parse(txtAltura.Text);
                imc = peso / (altura * altura);

                // Mostrar resultado
                lblResultado.Text = $"IMC = {imc:0.00}";

                // Mostrar análise
                if (imc < 18.5) lblAnalise.Text = "Abaixo do Peso";
                else if(imc < 25) lblAnalise.Text = "Peso Saúdavel";
                else if(imc < 30) lblAnalise.Text = "Sobrepeso";
                else if(imc < 35) lblAnalise.Text = "Obesidade Grau I";
                else if(imc < 40) lblAnalise.Text = "Obesidade Grau II";
                else lblAnalise.Text = "Obesidade Mórbida";
            }
        }
    }
}
