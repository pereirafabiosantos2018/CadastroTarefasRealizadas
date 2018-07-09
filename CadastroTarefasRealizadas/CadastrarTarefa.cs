using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace CadastroTarefasRealizadas
{
    public partial class CadastrarTarefa : Form
    {
        string arquivoFoto = string.Empty;
        byte[] vetorImagem;

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
            lerCategoriaCommand.CommandType = CommandType.StoredProcedure;

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
            //converter a foto em byte[] antes de gravar
            FileInfo arquivoImagem = new FileInfo(pictureFoto.ImageLocation);
            long tamanhoimagem = arquivoImagem.Length;
            FileStream fluxo = new FileStream(pictureFoto.ImageLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
            vetorImagem = new byte[Convert.ToInt32(tamanhoimagem)];
            int iBytesLidos = fluxo.Read(vetorImagem, 0, Convert.ToInt32(tamanhoimagem));
            fluxo.Close();

            SqlCommand GravarTarefaRealizadaCommand = new SqlCommand("GravarTarefaRealizada", BancoDeDados.AbrirConexaoBanco());
            GravarTarefaRealizadaCommand.CommandType = CommandType.StoredProcedure;

            GravarTarefaRealizadaCommand.Parameters.Add("@categoria", SqlDbType.VarChar, 100);
            GravarTarefaRealizadaCommand.Parameters[0].Value = comboCategoria.Text;

            GravarTarefaRealizadaCommand.Parameters.Add("@descricao", SqlDbType.VarChar, 500);
            GravarTarefaRealizadaCommand.Parameters[1].Value = textDescricao.Text;

            GravarTarefaRealizadaCommand.Parameters.Add("@foto", SqlDbType.Image);
            GravarTarefaRealizadaCommand.Parameters[2].Value = vetorImagem;

            GravarTarefaRealizadaCommand.Parameters.Add("@data_cadastro", SqlDbType.DateTime);
            GravarTarefaRealizadaCommand.Parameters[3].Value = DateTime.Now;

            try
            {
                GravarTarefaRealizadaCommand.ExecuteNonQuery();
                MessageBox.Show("A tarefa realizada foi cadastrada corretamente.", "Tarefa realizada");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Erro");
            }
        }

        /// <summary>
        /// Escolhe a foto a ser exibida no controle de foto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureFoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog escolherFoto = new OpenFileDialog();

            if (escolherFoto.ShowDialog() == DialogResult.OK)
            {
                arquivoFoto = escolherFoto.FileName;
                pictureFoto.ImageLocation = arquivoFoto;
            }
        }
    }
}
