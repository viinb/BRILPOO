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
    public partial class w_AddGerente : Form
    {
        Gerente gerente;
        public w_AddGerente()
        {
            InitializeComponent();
        }

        public w_AddGerente(Gerente gerente) : this()
        {
            this.gerente = gerente;
        }

        private void btn_AddGerente_Click(object sender, EventArgs e)
        {
            this.gerente.Nome = this.tb_Nome.Text;
            this.gerente.Salario = double.Parse(this.tb_Salario.Text);
            this.gerente.Usuario = this.tb_Usuario.Text;
            this.gerente.Senha = this.tb_Senha.Text;
            this.Close();
        }

        private void w_AddGerente_Load(object sender, EventArgs e)
        {

        }
    }
}
