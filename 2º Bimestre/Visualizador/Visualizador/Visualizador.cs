namespace Visualizador
{
    public partial class w_Visualizador : Form
    {
        public w_Visualizador()
        {
            InitializeComponent();
        }

        private void w_Visualizador_Load(object sender, EventArgs e)
        {

        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.op_SelFigura.ShowDialog() == DialogResult.OK)
            {
                this.pb_Figura.Image = Image.FromFile(this.op_SelFigura.FileName);
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void op_SelFigura_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
