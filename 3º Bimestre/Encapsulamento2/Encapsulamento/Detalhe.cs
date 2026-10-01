using System;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class w_Detalhe : Form
    {
        Livro L;
        public w_Detalhe()
        {
            InitializeComponent();
        }

        public w_Detalhe(Livro Liv) : this()
        {
            this.L = Liv;
        }

        private void w_Detalhe_Load(object sender, EventArgs e)
        {
            tb_Titulo.Text = L.Titulo;
            tb_Autor.Text = L.Autor;
            tb_Codigo.Text = L.Codigo;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            L.Titulo = tb_Titulo.Text;
            L.Autor = tb_Autor.Text;
            this.Close();
        }
    }
}
