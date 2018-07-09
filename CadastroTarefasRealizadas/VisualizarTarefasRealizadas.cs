using System;
using System.Windows.Forms;

namespace CadastroTarefasRealizadas
{
    public partial class VisualizarTarefasRealizadas : Form
    {
        public VisualizarTarefasRealizadas()
        {
            InitializeComponent();
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
            
        }

        /// <summary>
        /// Exibe os dados completos da tarefa selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridTarefasRealizadas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Apaga a tarefa selecionada quando a tecla Del for pressionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridTarefasRealizadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Delete)
            {
                MessageBox.Show("A tecla Del foi pressionada", "Tarefas realizadas");
            }
        }
    }
}
