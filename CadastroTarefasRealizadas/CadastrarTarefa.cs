using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroTarefasRealizadas
{
    public partial class CadastrarTarefa : Form
    {
        public CadastrarTarefa()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exibe as categorias cadastradas
        /// </summary>
        private void CadastrarTarefa_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }

        /// <summary>
        /// Exibe as categorias cadastradas
        /// </summary>
        private void ListarCategorias()
        {
            SqlCommand lerCategoriaCommand = new SqlCommand("LerCategorias", BancoDeDados.AbrirConexaoBanco());

            try
            {
                SqlDataReader categorias = lerCategoriaCommand.ExecuteReader();

                while (categorias.Read())
                {
                    comboCategoria.Items.Add(categorias[0]);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Erro");
            }
        }

        /// <summary>
        /// Grava a tarefa realizada no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
