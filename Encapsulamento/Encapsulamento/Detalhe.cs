using System;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class w_Detalhe : Form
    {
        Livro livro;

        public w_Detalhe()
        {
            InitializeComponent();
        }

        public w_Detalhe(Livro livro) : this()
        {
            this.livro = livro;
        }

        private void w_Detalhe_Load(object sender, EventArgs e)
        {
            this.tb_Titulo.Text = this.livro.Titulo;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.livro.Titulo = tb_Titulo.Text;
            this.Close();
        }
    }
}
