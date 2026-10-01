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
    public partial class w_AddSecretaria : Form
    {
        Secretaria secretaria;

        public w_AddSecretaria()
        {
            InitializeComponent();
        }

        public w_AddSecretaria(Secretaria secretaria) : this()
        {
            this.secretaria = secretaria;
        }

        private void w_AddSecretaria_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddGerente_Click(object sender, EventArgs e)
        {
            this.secretaria.Nome = this.tb_Nome.Text;
            this.secretaria.Salario = double.Parse(this.tb_Salario.Text);
            this.secretaria.Ramal = int.Parse(this.tb_Ramal.Text);
            this.Close();
        }
    }
}
