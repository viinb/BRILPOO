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
    public partial class w_ListaUsuarios: Form
    {
        List<Usuario> Lista;

        public w_ListaUsuarios()
        {
            InitializeComponent();
        }

        public w_ListaUsuarios(List<Usuario> lista_us)
        {
            InitializeComponent();
            Lista = lista_us;
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (tb_NomeUsuario.Text != "")
            {
                Usuario usuario = new Usuario(tb_NomeUsuario.Text);
                Lista.Add(usuario);
            }

            this.Atualiza();
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (lbx_Usuarios.SelectedIndex >= 0)
            {
                Lista.RemoveAt(lbx_Usuarios.SelectedIndex);
            }

            this.Atualiza();
        }

        private void w_ListaUsuarios_Load(object sender, EventArgs e)
        {
            this.Atualiza();
        }

        public void Atualiza()
        {
            lbx_Usuarios.Items.Clear();

            foreach (Usuario usuario in Lista)
            {
                lbx_Usuarios.Items.Add(usuario.Nome);
            }
        }
    }
}
