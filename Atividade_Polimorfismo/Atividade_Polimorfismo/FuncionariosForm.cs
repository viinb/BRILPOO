using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Atividade_Polimorfismo
{
    public partial class FuncionariosForm : Form
    {
        // Lista com todos os funcionários
        List<Funcionario> ListaFuncionarios = new List<Funcionario>();

        public FuncionariosForm()
        {
            InitializeComponent();
        }


        // Além de inicializar todos os compontente, guarda a referência da lista de funcionários        
        public FuncionariosForm(List<Funcionario> Lista) : this()
        {
            this.ListaFuncionarios = Lista;
        }

        public void Mostrar_Detalhes(string Op)
        {
            Funcionario objFuncionario;
            w_Det Detalhe;

            if (Op == "I") //Inserir
            {
                if (rb_Gerente.Checked) //Gerente
                {
                    objFuncionario = new Gerente();


                    Detalhe = new w_Det_Ger(this, objFuncionario, Op);
                    Detalhe.ShowDialog();
                    if (!string.Equals(objFuncionario.Nome, ""))
                    {
                        this.ListaFuncionarios.Add(objFuncionario);
                    }
                }
                else
                {
                    if (rb_Telefonista.Checked) //Telefonista
                    {
                        objFuncionario = new Telefonista();
                        //IMPLEMENTAR

                        Detalhe = new w_Det_Tel(this, objFuncionario, Op);
                        Detalhe.ShowDialog();

                        if (!string.Equals(objFuncionario.Nome, ""))
                        {
                            this.ListaFuncionarios.Add(objFuncionario);
                        }
                    }
                    else
                    {
                        if (rb_Secretario.Checked) //Secretaria
                        {
                            objFuncionario = new Secretaria();
                            //IMPLEMENTAR

                            Detalhe = new w_Det_Sec(this, objFuncionario, Op);
                            Detalhe.ShowDialog();

                            if (!string.Equals(objFuncionario.Nome, ""))
                            {
                                this.ListaFuncionarios.Add(objFuncionario);
                            }
                        }
                        else {
                            if (rb_Analista.Checked) //Analista
                            {
                                objFuncionario = new Analista();
                                //IMPLEMENTAR

                                Detalhe = new w_Det_Ana(this, objFuncionario, Op);
                                Detalhe.ShowDialog();

                                if (!string.Equals(objFuncionario.Nome, ""))
                                {
                                    this.ListaFuncionarios.Add(objFuncionario);
                                }
                            }
                        }
                    }
                }
            }
            else //Inserir
            {
                if (lbx_Funcionarios.SelectedIndex >= 0)
                {
                    objFuncionario = this.ListaFuncionarios[lbx_Funcionarios.SelectedIndex];

                    if (objFuncionario.Classe == "Gerente")
                    {
                        Detalhe = new w_Det_Ger(this, (objFuncionario as Gerente), Op);
                        Detalhe.ShowDialog();
                    }
                    else
                    {
                        if (objFuncionario.Classe == "Telefonista")
                        {
                            Detalhe = new w_Det_Tel(this, (objFuncionario as Telefonista), Op);
                            Detalhe.ShowDialog();
                        }
                        else
                        {
                            if (objFuncionario.Classe == "Secretária")
                            {
                                Detalhe = new w_Det_Tel(this, (objFuncionario as Telefonista), Op);
                                Detalhe.ShowDialog();
                            }
                            else
                            {
                                if (objFuncionario.Classe == "Analista")
                                {
                                    Detalhe = new w_Det_Ana(this, (objFuncionario as Analista), Op);
                                    Detalhe.ShowDialog();
                                }
                            }
                        }
                    }
                }
            }

            this.MostrarFuncionarios();
        }

        // Adiciona funcionário de acordo com check marcado (Gerente, Telefonista ou secretários)
        private void bt_Adicionar_Click(object sender, EventArgs e)
        {

            this.Mostrar_Detalhes("I");
        }

        // Atualiza o listBox dos funcionários com todos os funcionários
        private void MostrarFuncionarios()
        {
            // Limpa o listbox para começar a inserir desde o início
            lbx_Funcionarios.Items.Clear();

            // Insere todos os funcionários no ListBox
            foreach (Funcionario objFuncionario in ListaFuncionarios)
            {
                // preenche o ListBox
                if (objFuncionario.Classe == "Gerente")
                {
                    lbx_Funcionarios.Items.Add((objFuncionario as Gerente).RecuperaDados());
                }
                else
                {
                    if (objFuncionario.Classe == "Telefonista")
                    {
                        //IMPLEMENTAR
                        lbx_Funcionarios.Items.Add((objFuncionario as Telefonista).RecuperaDados());
                    }
                    else //Secretária
                    {
                        //IMPLEMENTAR
                        if (objFuncionario.Classe == "Secretária")
                        {
                            lbx_Funcionarios.Items.Add((objFuncionario as Secretaria).RecuperaDados());
                        }
                        else
                        {
                            if (objFuncionario.Classe == "Analista")
                            {
                                lbx_Funcionarios.Items.Add((objFuncionario as Analista).RecuperaDados());
                            }
                        }
                    }
                }
            }
        }

        // Inicialização do formulário de funcionários com todos os funcionários cadastrados
        private void FuncionariosForm_Load(object sender, EventArgs e)
        {

        }

        // Remove o funcionário de acordo com o check marcado (gerente, secretário ou Telefonista)
        private void bt_Remover_Click(object sender, EventArgs e)
        {
            if (lbx_Funcionarios.SelectedIndex >= 0)
            {
                ListaFuncionarios.RemoveAt(lbx_Funcionarios.SelectedIndex);
                MostrarFuncionarios();
            }

        }

        private void lbx_Funcionarios_DoubleClick(object sender, EventArgs e)
        {

            this.Mostrar_Detalhes("E");

        }

        private void lbx_Funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
