using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EncapsulamentoExercicios
{
    public partial class ContasUsuarios : Form
    {
        public List<Conta> ListaContas = new List<Conta>();

        public ContasUsuarios()
        {
            InitializeComponent();
        }

        public void ApagaContas(List<Conta> Lista)
        {
            Lista.Clear();
            this.MostraContas(Lista);
        }

        public void MostraContas(List<Conta> Lista)
        {
            lbxContas.Items.Clear();

            foreach (Conta conta in Lista)
            {
                lbxContas.Items.Add(conta.DadosConta());
                lbxContas.Items.Add("Saldo Disp: " + conta.SaldoDisp() + "\t Limite: " + Conta.Limite);
                lbxContas.Items.Add("--------------------------------------");
            }
        }

        public void AddConta(List<Conta> Lista, int Numero, double Saldo)
        {
            Conta C = new Conta(Numero, Saldo);
            Lista.Add(C);
            this.MostraContas(Lista);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AddConta(this.ListaContas, 1234, 1000);
            this.AddConta(this.ListaContas, 5678, 2000);
        }

        private void btn_Contas_Click(object sender, EventArgs e)
        {
            this.MostraContas(this.ListaContas);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            lbxContas.Items.Clear();
        }

        private void lbxContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            this.ApagaContas(this.ListaContas);
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            this.AddConta(this.ListaContas, Convert.ToInt32(tb_Conta.Text), Convert.ToDouble(tb_Saldo.Text));
        }

        private void btn_Limite_Click(object sender, EventArgs e)
        {
            Conta.Limite = Convert.ToDouble(tb_Limite.Text);
            this.MostraContas(ListaContas);
        }
    }
}
