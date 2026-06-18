using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class w_Lista : Form
    {
        List<Livro> Lista = new List<Livro>();
        public w_Lista()
        {
            InitializeComponent();
        }

        //Atualiza a listbox a partir do vetor Lista
        public void Atualiza()
        {
            lb_Lista.Items.Clear();
            foreach (Livro L in Lista)
            {
                lb_Lista.Items.Add($"[{L.Codigo}] {L.Autor} - {L.Titulo}");
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Livro L = new Livro();

            this.GravaDetalhes(L, "A");
        }

        public void GravaDetalhes(Livro L, string Tipo)
        {
            //Tipo: "A" - Add, "E" - Edit
            w_Detalhe w_Det = new w_Detalhe(L);
            w_Det.ShowDialog();

            if (Tipo == "A")
            {
                Lista.Add(L);
            }

            this.Atualiza();
        }

        private void lb_Lista_DoubleClick(object sender, EventArgs e)
        {
            if (lb_Lista.SelectedIndex >= 0)
            {
                this.GravaDetalhes(Lista[lb_Lista.SelectedIndex], "E");
            }
        }
    }
}
