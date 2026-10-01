using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteFuncionarios
{
    public partial class w_TesteFuncionarios : Form
    {
        List<Gerente> listaGerente = new List<Gerente>();
        List<Telefonista> listaTelefonista = new List<Telefonista>();
        List<Secretaria> listaSecretaria = new List<Secretaria>();
        public w_TesteFuncionarios()
        {
            InitializeComponent();
        }

        private void w_TesteFuncionarios_Load(object sender, EventArgs e)
        {
        }

        private void btn_AddGerente_Click(object sender, EventArgs e)
        {
            Gerente gerente = new Gerente();
            w_AddGerente addGerente = new w_AddGerente(gerente);
            addGerente.ShowDialog();
            
            if (gerente.Nome != "")
            {
                this.listaGerente.Add(gerente);
                this.AtualizarListbox();
            }
        }

        private void btn_AddTelefonista_Click(object sender, EventArgs e)
        {
            Telefonista telefonista = new Telefonista();
            w_AddTelefonista addTelefonista = new w_AddTelefonista(telefonista);
            addTelefonista.ShowDialog();

            if (telefonista.Nome != "")
            {
                this.listaTelefonista.Add(telefonista);
                this.AtualizarListbox();
            }
        }

        private void btn_AddSecretaria_Click(object sender, EventArgs e)
        {
            Secretaria secretaria = new Secretaria();
            w_AddSecretaria addSecretaria = new w_AddSecretaria(secretaria);
            addSecretaria.ShowDialog();

            if (secretaria.Nome != "")
            {
                this.listaSecretaria.Add(secretaria);
                this.AtualizarListbox();
            }
        }

        void AtualizarListbox()
        {
            lb_ListaFuncionarios.Items.Clear();

            lb_ListaFuncionarios.Items.Add("GERENTES");
            foreach (Gerente gerente in listaGerente)
            {
                lb_ListaFuncionarios.Items.Add($" - Nome: {gerente.Nome} Salário: {String.Format("{0:C2}", gerente.Salario)} Usuário: {gerente.Usuario} Senha: {gerente.Senha} Bonificação: {String.Format("{0:C2}", gerente.CalculaBonificacao())}");
            }

            lb_ListaFuncionarios.Items.Add("");
            lb_ListaFuncionarios.Items.Add("TELEFONISTAS");
            foreach (Telefonista telefonista in listaTelefonista)
            {
                lb_ListaFuncionarios.Items.Add($" - Nome: {telefonista.Nome} Salário: {String.Format("{0:C2}", telefonista.Salario)} Estação de Trabalho: {telefonista.EstacaoDeTrabalho} Bonificação: {String.Format("{0:C2}", telefonista.CalculaBonificacao())}");
            }

            lb_ListaFuncionarios.Items.Add("");
            lb_ListaFuncionarios.Items.Add("SECRETARIAS");
            foreach (Secretaria secretaria in listaSecretaria)
            {
                lb_ListaFuncionarios.Items.Add($" - Nome: {secretaria.Nome} Salário: {String.Format("{0:C2}", secretaria.Salario)} Ramal: {secretaria.Ramal} Bonificação: {String.Format("{0:C2}", secretaria.CalculaBonificacao())}");
            }
        }
    }
}
