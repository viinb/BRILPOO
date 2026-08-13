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
    public partial class w_AddTelefonista : Form
    {
        Telefonista telefonista;

        public w_AddTelefonista()
        {
            InitializeComponent();
        }

        public w_AddTelefonista(Telefonista telefonista) : this()
        {
            this.telefonista = telefonista;
        }

        private void w_AddTelefonista_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddGerente_Click(object sender, EventArgs e)
        {
            this.telefonista.Nome = this.tb_Nome.Text;
            this.telefonista.Salario = double.Parse(this.tb_Salario.Text);
            this.telefonista.EstacaoDeTrabalho = int.Parse(this.tb_Est.Text);
            this.Close();
        }
    }
}
