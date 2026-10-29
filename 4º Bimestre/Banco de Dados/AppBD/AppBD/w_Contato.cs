using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBD
{
    public partial class w_Contato : Form
    {
        public OracleConnection Connection { get; set; }

        public w_Contato()
        {
            InitializeComponent();
        }

        public w_Contato(OracleConnection connection):this()
        {
            this.Connection = connection;
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO BRILPOO.CONTATO(NOME, EMAIL, TELEFONE) VALUES('{txt_Nome.Text}', '{txt_Email.Text}', '{txt_Telefone.Text}')";

            object result = new object();
            bool erro = false;

            using (OracleCommand command = new OracleCommand(sql, this.Connection))
            {
                try
                {
                    result = command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                    erro = true;
                }
                finally
                {
                    if (!erro)
                    {
                        MessageBox.Show("Dados gravados com sucesso!");
                    }
                }
            }
        }
    }
}
