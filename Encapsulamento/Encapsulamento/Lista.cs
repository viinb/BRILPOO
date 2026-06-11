using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class w_Lista : Form
    {
        List<Livro> livros = new List<Livro>();

        public w_Lista()
        {
            InitializeComponent();
        }

        public void AtualizarListBox()
        {
            lb_Lista.Items.Clear();
            foreach (Livro livro in livros)
            {
                this.lb_Lista.Items.Add(livro.GetTitulo());
            }
        }

        public void EditarLivro(Livro livro, char tipo)
        {
            w_Detalhe detalhe = new w_Detalhe(livro);
            detalhe.ShowDialog();

            if (tipo == 'A')
            {
                this.livros.Add(livro);
            }

            this.AtualizarListBox();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            this.EditarLivro(livro, 'A');
        }

        private void lb_Lista_DoubleClick(object sender, EventArgs e)
        {
            if (lb_Lista.SelectedIndex >= 0)
            {
                this.EditarLivro(this.livros[lb_Lista.SelectedIndex], 'E');
            } 
        }
    }
}
