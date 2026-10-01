using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Polimorfismo
{
    public class ListaFuncionarios
    {
        // Listas com os objetos derivados de funcionário: Gerente, Telefonista e Secretaria
        Funcionario[] ListaTodosFuncionarios = new Funcionario[15];

        // Variável de controle para o cadastro de funcionários
        // Essa variável possuem apenas o método privado get, pois não queremos que sejam atualizadas
        // Froa da classe.
        private int NumTodosFuncionarios = 0;

        public int TodosFuncionariosCadastrados
        {
            get
            {
                return NumTodosFuncionarios;
            }
        }

        // Inicializa objetos dos vetores de funcionários: Gerente, Telefonista e Secretária
        public ListaFuncionarios()
        {

        }

        // Método para inserir um funcionário
        // Comoa a classe Funcionário é pai das classes, Greente, Telefonista e Secretários, o método aceita como parâmetros esses três tipos
        public void InserirFuncionario(Funcionario objFuncionario)
        {
            if (this.NumTodosFuncionarios < 15)
            {
                this.ListaTodosFuncionarios[NumTodosFuncionarios] = objFuncionario;
                // Atualiza Variável de controle
                NumTodosFuncionarios++;
            }
            else
            {
                MessageBox.Show("Número máximo de Funcionários alcançado!!");
            }
        }

        // Retonra um objeto do tipo Funcionário e seus filhos.        
        public Funcionario RecuperaFuncionario(int Posicao)
        {
            return (ListaTodosFuncionarios[Posicao] as Funcionario);
        }


        // Por enqaunto não estamos removendo os objetos do vetosr estamos apenas mudando a variável de 
        // controle, pois a remoção está sendo sempre do último elemento
        // Assim, com a subtração da variável de controle, deixamos de consider o item "removido"
        public void RemoverFuncionario(int Posicao)
        {
            int Cont;

            if (this.NumTodosFuncionarios > 0)
            {
                //Desloca posições do vetor para remoção
                for (Cont = Posicao; Cont < this.NumTodosFuncionarios - 1; Cont++)
                {
                    this.ListaTodosFuncionarios[Cont] = this.ListaTodosFuncionarios[Cont + 1];
                }

                this.NumTodosFuncionarios--;
            }
        }
    }
}
