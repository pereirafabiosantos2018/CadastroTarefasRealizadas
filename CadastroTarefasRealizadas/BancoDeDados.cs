using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroTarefasRealizadas
{
    public static class BancoDeDados
    {
        public static SqlConnection AbrirConexaoBanco()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=COMPUTADOR\\SQLEXPRESS;Integrated Security=True;");
            
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Erro");
                return null;
            }
        }
    }
}
