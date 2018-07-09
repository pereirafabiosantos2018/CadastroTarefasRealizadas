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
                MessageBox.Show("Conexão", "A conexão com o banco de dados foi realizada corretamente.");
                return sqlConnection;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Erro", e1.Message);
                return null;
            }
        }
    }
}
