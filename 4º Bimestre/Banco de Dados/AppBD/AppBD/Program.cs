using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace AppBD
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connStr = "User Id=BRILPOO;Password=BRILPOO;Data Source=10.102.50.43:1521 / XE;";

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Conectou!");
                    Application.Run(new w_Contato(conn));
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }
    }
}
