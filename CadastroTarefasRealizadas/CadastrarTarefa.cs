﻿using System;
using System.Windows.Forms;

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
