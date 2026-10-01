using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_FOOD
{
    public partial class w_Imp_Lista : Form
    {
        List<string> Lista { get; set; }

        public w_Imp_Lista(List<string> lista) : this()
        {
            this.Lista = lista;
        }

        public w_Imp_Lista()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imp_Lista_Load(object sender, EventArgs e)
        {
            foreach (string linhaTexto in this.Lista)
            {
                lb_Lista.Items.Add(linhaTexto);
            }
        }
    }
}
