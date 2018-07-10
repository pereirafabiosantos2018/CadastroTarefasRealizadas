using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CadastroTarefasRealizadas
{
    public partial class VisualizarTarefasRealizadas : Form
    {
        byte[] vetorImagem;
        
        public VisualizarTarefasRealizadas()
        {
            InitializeComponent();
            LerTarefasRealizadas();
        }

        /// <summary>
        /// Lê as tarefas realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LerTarefasRealizadas();
        }

        /// <summary>
        /// Lê as tarefas realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LerTarefasRealizadas()
        {
            gridTarefasRealizadas.Rows.Clear();
            pictureFoto.Image = null;
            labelDescricao.Text = "Selecione um item na lista";

            SqlCommand lerTarefasrealizadasCommand = new SqlCommand("LerTarefasRealizadas", BancoDeDados.AbrirConexaoBanco());
            lerTarefasrealizadasCommand.CommandType = CommandType.StoredProcedure;

            SqlDataReader tarefasRealizadas = lerTarefasrealizadasCommand.ExecuteReader();

            while (tarefasRealizadas.Read())
            {
                gridTarefasRealizadas.Rows.Add(tarefasRealizadas[0], tarefasRealizadas[1], tarefasRealizadas[2], tarefasRealizadas[3]);
            }
        }
        
        /// <summary>
        /// Exibe os dados completos da tarefa selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridTarefasRealizadas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand lerFotoCommand = new SqlCommand("LerFoto", BancoDeDados.AbrirConexaoBanco());
            lerFotoCommand.Parameters.Add("@id", SqlDbType.Int, 4);
            lerFotoCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                if (gridTarefasRealizadas.SelectedRows.Count > 1)
                {
                    labelDescricao.Text = "Foi selecionada mais de uma célula";
                    pictureFoto.Image = null;
                }
                else
                {
                    labelDescricao.Text = gridTarefasRealizadas.SelectedCells[2].Value.ToString();

                    lerFotoCommand.Parameters[0].Value = int.Parse(gridTarefasRealizadas.SelectedCells[0].Value.ToString());
                    byte[] vetorImagem = (byte[])lerFotoCommand.ExecuteScalar();
                    string nomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());

                    FileStream fileStream = new FileStream(nomeArquivo, FileMode.CreateNew, FileAccess.Write);
                    fileStream.Write(vetorImagem, 0, vetorImagem.Length);
                    fileStream.Flush();
                    fileStream.Close();

                    pictureFoto.Image = Image.FromFile(nomeArquivo);
                }
            }
            catch
            {
                pictureFoto.Image = null;
                return;
            }
        }

        /// <summary>
        /// Apaga a tarefa selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (gridTarefasRealizadas.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas 1 linha.", "Erro");
                return;
            }

            try
            {
                SqlCommand apagarRegistroCommand = new SqlCommand("ApagarRegistro", BancoDeDados.AbrirConexaoBanco());
                apagarRegistroCommand.CommandType = CommandType.StoredProcedure;

                apagarRegistroCommand.Parameters.Add("@id", SqlDbType.Int, 4);
                apagarRegistroCommand.Parameters[0].Value = int.Parse(gridTarefasRealizadas.SelectedCells[0].Value.ToString());

                apagarRegistroCommand.ExecuteNonQuery();
                MessageBox.Show("O item selecionado foi apagado.", "Tarefas realizadas");

                LerTarefasRealizadas();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Erro");
            }

        }
    }
}
