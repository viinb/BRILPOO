using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JUNTANDO_TUDO_v2
{
    public partial class frm_ListaPessoas : Form
    {
        List<Usuario> ListaUsuario = new List<Usuario>();
        List<Parceiro> ListaParceiro = new List<Parceiro>();
        int coluna_atual;

        public frm_ListaPessoas()
        {
            InitializeComponent();
        }

        private void IniciaListas()
        {
            ListaUsuario.Add(new TAE("bi001", "Anderson Lahr", "Pedagógico", 1, "Teste 1"));
            ListaUsuario.Add(new TAE("bi002", "Daniel Carlos", "Gestão", 2, "Teste 2"));
            ListaUsuario.Add(new Aluno("bi003", "Marcos Wilson", "TSI", 7));
            ListaUsuario.Add(new Aluno("bi004", "Emanuel Pontes", "Engenharia", 5));
            ListaUsuario.Add(new Professor("bi005", "Marcos Bica", "Indústria"));
            ListaUsuario.Add(new Professor("bi006", "Valtemir de Alencar", "Informática"));
            ListaParceiro.Add(new Parceiro("bi007", "Carlos - Libras", "111.111.111-11", 3, "Teste 3"));
            ListaParceiro.Add(new Parceiro("bi008", "Prefeitura de Birigui", "46.151.718/0001-80", 4, "Teste 4"));
        }

        private void AddUsuarioGrid(Usuario U, ref int Cont)
        {
            string[] Linha = new string[4];

            switch (U.Classe)
            {
                case "TAE":
                    Linha[0] = (U as TAE).Codigo;
                    Linha[1] = (U as TAE).Nome;
                    Linha[2] = (U as TAE).Classe;
                    break;
                case "Aluno":
                    Linha[0] = (U as Aluno).Codigo;
                    Linha[1] = (U as Aluno).Nome;
                    Linha[2] = (U as Aluno).Classe;
                    break;
                case "Professor":
                    Linha[0] = (U as Professor).Codigo;
                    Linha[1] = (U as Professor).Nome;
                    Linha[2] = (U as Professor).Classe;
                    break;
            }
            Linha[3] = Cont.ToString();
            Cont++;
            dg_Lista.Rows.Add(Linha);
        }

        private void AddParceiroGrid(Parceiro P, ref int Cont)
        {
            string[] Linha = new string[4];
            Linha[0] = P.Codigo;
            Linha[1] = P.Nome;
            Linha[2] = "Parceiro";
            Linha[3] = Cont.ToString();
            Cont++;
            dg_Lista.Rows.Add(Linha);
        }

        private void CarregaGrid()
        {
            int Cont = 0;
            string[] Linha = new string[4];

            foreach (Usuario usuario in ListaUsuario)
            {
                AddUsuarioGrid(usuario, ref Cont);
            }

            foreach (Parceiro parceiro in ListaParceiro)
            {
                AddParceiroGrid(parceiro, ref Cont);
            }

            //Ordena pela primeira coluna
            dg_Lista.Sort(dg_Lista.Columns[0], ListSortDirection.Ascending);
        }

        private void frm_ListaPessoas_Load(object sender, EventArgs e)
        {
            this.IniciaListas();
            this.CarregaGrid();
        }        

        private void MostraDetalhes(string Tipo, int PosVetor)
        {
            Parceiro P;
            Usuario U;

            gb_Inst.Visible = false;
            gb_Parceiro.Visible = false;

            if (Tipo == "Parceiro")
            {
                P = ListaParceiro[PosVetor % ListaParceiro.Count];
                tb_CPF.Text = P.CPF_CNPJ;
                gb_Parceiro.Visible = true;
                btn_ImprimirContrato.Visible = true;
            }
            else
            {
                U = ListaUsuario[PosVetor];
                switch (U.Classe)
                {
                    case "TAE":
                        label1.Text = "Tipo:";
                        tb_1.Text = (U as TAE).Tipo;
                        label2.Visible = false;
                        tb_2.Visible = false;
                        gb_Inst.Visible = true;
                        btn_ImprimirContrato.Visible = true;
                        break;
                    case "Aluno":
                        label1.Text = "Curso:";
                        tb_1.Text = (U as Aluno).Curso;
                        label2.Text = "Média:";
                        tb_2.Text = (U as Aluno).Media.ToString();
                        label2.Visible = true;
                        tb_2.Visible = true;
                        gb_Inst.Visible = true;
                        btn_ImprimirContrato.Visible = false;
                        break;
                    case "Professor":
                        label1.Text = "Área:";
                        tb_1.Text = (U as Professor).Area;
                        label2.Visible = false;
                        tb_2.Visible = false;
                        gb_Inst.Visible = true;
                        btn_ImprimirContrato.Visible = false;
                        break;
                }
            }
        }

        private void dg_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                coluna_atual = e.RowIndex;
                DataGridViewRow row = dg_Lista.Rows[coluna_atual];
                this.MostraDetalhes(row.Cells[2].Value.ToString(), Int32.Parse(row.Cells[3].Value.ToString()));
            }
        }

        private void dg_Lista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dg_Lista_CellClick(sender, e);
        }

        private void dg_Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_ImprimirContrato_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg_Lista.Rows[coluna_atual];
            IContrato C;

            switch (row.Cells[2].Value.ToString())
            {
                case "Parceiro":
                    C = (ListaParceiro[Int32.Parse(row.Cells[3].Value.ToString()) % ListaParceiro.Count] as Parceiro);
                    MessageBox.Show(C.ImprimeContrato());
                    break;
                case "TAE":
                    C = (ListaUsuario[Int32.Parse(row.Cells[3].Value.ToString())] as TAE);
                    MessageBox.Show(C.ImprimeContrato());
                    break;
                default:
                    MessageBox.Show("Inválido!");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg_Lista.Rows[coluna_atual];
            Parceiro P;
            Usuario U;

            switch (row.Cells[2].Value.ToString())
            {
                case "Parceiro":
                    P = (ListaParceiro[Int32.Parse(row.Cells[3].Value.ToString()) % ListaParceiro.Count]);
                    MessageBox.Show(P.MostraDetalhe());
                    break;
                default:
                    U = (ListaUsuario[Int32.Parse(row.Cells[3].Value.ToString())]);
                    MessageBox.Show(U.MostraDetalhe());
                    break;
            }
        }
    }
}
