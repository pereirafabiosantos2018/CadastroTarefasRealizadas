using System;
using System.Windows.Forms;

namespace CadastroTarefasRealizadas
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exibe a janela para cadastrar tarefa realizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tarefaRealizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarTarefa cadastrarTarefa = new CadastrarTarefa();
            cadastrarTarefa.ShowDialog();
        }

        /// <summary>
        /// Exibe a janela com as tarefas realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tarefaRealizadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizarTarefasRealizadas visualizarTarefasRealizadas = new VisualizarTarefasRealizadas();
            visualizarTarefasRealizadas.ShowDialog();
        }

        /// <summary>
        /// Sobre o aplicativo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Sistema feito para cadastrar tarefas realizadas.", "Sobre");
        }
    }
}
