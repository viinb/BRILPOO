using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class w_Lista: Form
    {
        List<Livro> Lista = new List<Livro>();
        List<Usuario> Lista_Us = new List<Usuario>();
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
                lb_Lista.Items.Add("["+ L.Codigo +"] "+L.Titulo + " - " +L.Autor);
            }

            /*
            int Cont;
            for (Cont = 0; Cont < Lista.Count; Cont++)
            {
                lb_Lista.Items.Add(Lista[Cont].Titulo);
            }*/
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
            
            if (Tipo == "A"){
                Lista.Add(L);
            }
            
            this.Atualiza();
        }

        private void lb_Lista_DoubleClick(object sender, EventArgs e)
        {
            if(lb_Lista.SelectedIndex >= 0)
            {
                this.GravaDetalhes(Lista[lb_Lista.SelectedIndex], "E");
            }
        }

        private void w_Lista_Load(object sender, EventArgs e)
        {

        }

        private void lb_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            w_ListaUsuarios L = new w_ListaUsuarios(this.Lista_Us);
            L.ShowDialog();
        }
    }
}
