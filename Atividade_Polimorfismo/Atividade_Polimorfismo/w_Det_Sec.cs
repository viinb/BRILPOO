using System.Windows.Forms;

namespace Atividade_Polimorfismo
{
    public partial class w_Det_Sec : Atividade_Polimorfismo.w_Det
    {
        public w_Det_Sec()
        {
            InitializeComponent();
        }

        public w_Det_Sec(FuncionariosForm P, Funcionario F, string Tipo) : base(P, F, Tipo)
        {
            InitializeComponent();
        }

        public override bool ValidaCamposFuncionario()
        {
            return (base.ValidaCamposFuncionario() && (txb_Ramal.Text != ""));
        }

        public override void Mostra_Funcionario()
        {
            base.Mostra_Funcionario();
            txb_Ramal.Text = (F as Secretaria).Ramal.ToString();
        }

        public override int Grava_Funcionario()
        {
            int Ret = 0;

            if (ValidaCamposFuncionario())
            {

                (F as Secretaria).InsereDados(base.txb_Nome.Text, float.Parse(base.txb_Salario.Text), int.Parse(txb_Ramal.Text));
                Ret = 1;

            }
            else
            {
                MessageBox.Show("Há dados da secretária a preencher!!!");
            }

            return Ret;
        }
    }
}
