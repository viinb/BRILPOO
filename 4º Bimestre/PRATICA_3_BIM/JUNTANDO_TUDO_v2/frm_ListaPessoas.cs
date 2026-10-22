using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace JUNTANDO_TUDO_v2
{
    public partial class frm_ListaPessoas : Form
    {
        List<I_IFSP> listaIfsp = new List<I_IFSP>();

        public frm_ListaPessoas()
        {
            InitializeComponent();
        }

        private void AdicionaIFSP(Func<I_IFSP> criarUsuario, List<I_IFSP> lista)
        {
            try
            {
                lista.Add(criarUsuario());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Erro ao cadastrar:\n{ex.Message}");
            }
        }

        private void IniciaListas()
        {
            AdicionaIFSP(() => new TAE("Anderson Lahr", "Pedagógico"), listaIfsp);
            AdicionaIFSP(() => new TAE("Daniel Carlos", "Gestão"), listaIfsp);
            AdicionaIFSP(() => new Aluno("Marcos Wilson", "TSI", 7), listaIfsp);
            AdicionaIFSP(() => new Aluno("Emanuel Pontes", "Engenharia", 5), listaIfsp);
            AdicionaIFSP(() => new Professor("Marcos Bica", "Indústria"), listaIfsp);
            AdicionaIFSP(() => new Professor("Valtemir de Alencar", "Informática"), listaIfsp);
            AdicionaIFSP(
                () => new Parceiro("pa007", "Carlos - Libras", "111.111.111-11"),
                listaIfsp);
            AdicionaIFSP(
                () => new Parceiro("pa008", "Prefeitura de Birigui", "46.151.718/0001-80"),
                listaIfsp);
        }

        private void GridAddListaIFSP(List<I_IFSP> lista, ref int cont)
        {
            string[] linha = new string[4];

            foreach (I_IFSP usuarioIfsp in lista)
            {
                linha[0] = usuarioIfsp.Codigo;
                linha[1] = usuarioIfsp.Nome;
                if (usuarioIfsp is IFSP)
                {
                    switch ((usuarioIfsp as IFSP).Classe)
                    {
                        case 1:
                            linha[2] = "Professor";
                            break;
                        case 2:
                            linha[2] = "Aluno";
                            break;
                        case 3:
                            linha[2] = "TAE";
                            break;
                        default:
                            linha[2] = "Outro";
                            break;
                    }
                } 
                else
                {
                    if (usuarioIfsp is Parceiro)
                    {
                        linha[2] = "Parceiro";
                    }
                }

                linha[3] = cont.ToString();
                dg_Lista.Rows.Add(linha);
                ++cont;
            }
        }

        private void CarregaGrid()
        {
            int cont = 0;
            GridAddListaIFSP(listaIfsp, ref cont);

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
            gb_Inst.Visible = false;
            gb_Parceiro.Visible = false;
            int posVetorSeguro = PosVetor % listaIfsp.Count;

            switch (Tipo)
            {
                case "TAE":
                    TAE ifspTae = (listaIfsp[posVetorSeguro] as TAE);
                    MudarDetalhe(Tipo, "Tipo:", "", ifspTae.Tipo, "");
                    break;
                case "Aluno":
                    Aluno ifspAluno = (listaIfsp[posVetorSeguro] as Aluno);
                    MudarDetalhe(Tipo, "Curso:", "Média:", ifspAluno.Curso, ifspAluno.MediaGeral.ToString());
                    break;
                case "Professor":
                    Professor ifspProfessor = (listaIfsp[posVetorSeguro] as Professor);
                    MudarDetalhe(Tipo, "Área:", "", ifspProfessor.Area, "");
                    break;
                case "Parceiro":
                    Parceiro ifspParceiro = (listaIfsp[posVetorSeguro] as Parceiro);
                    MudarDetalhe(Tipo, "", "", "", "");
                    tb_CPF.Text = ifspParceiro.CpfCnpj;
                    break;
            }
        }

        private void MudarDetalhe(string tipo, string l1, string l2, string tb1, string tb2)
        {
            gb_Inst.Visible = false;
            gb_Parceiro.Visible = false;

            switch (tipo)
            {
                case "Parceiro":
                    gb_Parceiro.Visible = true;
                    break;
                default:
                    gb_Inst.Visible = true;
                    break;
            }

            label1.Text = l1;
            label1.Visible = !string.IsNullOrWhiteSpace(l1);

            label2.Text = l2;
            label2.Visible = !string.IsNullOrWhiteSpace(l2);

            tb_1.Text = tb1;
            tb_1.Visible = !string.IsNullOrWhiteSpace(tb1);

            tb_2.Text = tb2;
            tb_2.Visible = !string.IsNullOrWhiteSpace(tb2);
        }

        private void dg_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow row = dg_Lista.Rows[e.RowIndex];
                this.MostraDetalhes(row.Cells[2].Value.ToString(), Int32.Parse(row.Cells[3].Value.ToString()));
            }
            
        }

        private void dg_Lista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dg_Lista_CellClick(sender, e);
        }
    }
}
