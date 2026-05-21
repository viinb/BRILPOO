using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class w_ContaCorrente: Form
    {
        List<Conta> contas = new List<Conta>();
        Conta conta;

        public w_ContaCorrente()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSaldoAtual.Text == "" || txtLimite.Text == "")
            {
                MessageBox.Show("Informe valores de nome, saldo e limite da conta!");
            }
            else
            {
                conta = new Conta(txtNome.Text, double.Parse(txtSaldoAtual.Text), double.Parse(txtLimite.Text));
                contas.Add(conta);

                //txtNome.ReadOnly = true;
                //txtSaldoAtual.ReadOnly = true;
                //txtLimite.ReadOnly = true;

                MessageBox.Show("Conta criada com sucesso!");

                lbContas.Items.Add(contas.Count);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (txtValorOperacao.Text == "")
            {
                MessageBox.Show("Informe o valor da operação!");
            } else
            {
                conta.Sacar(double.Parse(txtValorOperacao.Text));
                txtValorOperacao.Text = "";
                txtSaldoAtual.Text = conta.Consultar().ToString();
                txtCashback.Text = "Cashback: " + conta.SaldoCashBack.ToString();
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtValorOperacao.Text == "")
            {
                MessageBox.Show("Informe o valor da operação!");
            }
            else
            {
                conta.Depositar(double.Parse(txtValorOperacao.Text));
                txtValorOperacao.Text = "";
                txtSaldoAtual.Text = conta.Consultar().ToString();
                txtCashback.Text = "Cashback: " + conta.SaldoCashBack.ToString();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Saldo atual: {conta.Consultar()}");
        }

        private void w_ContaCorrente_Load(object sender, EventArgs e)
        {
            txtCashback.Text = "";
        }

        private void lbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            conta = contas[lbContas.SelectedIndex];
            TrocarConta();
        }

        private void TrocarConta()
        {
            txtNome.Text = conta.Nome;
            txtSaldoAtual.Text = conta.Saldo.ToString();
            txtLimite.Text = conta.Limite.ToString();

            if (conta.SaldoCashBack == 0)
            {
                txtCashback.Text = "";
            }
            else
            {
                txtCashback.Text = "Cashback: " + conta.SaldoCashBack.ToString();
            }
        }
    }
}
