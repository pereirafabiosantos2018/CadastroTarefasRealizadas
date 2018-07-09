using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
