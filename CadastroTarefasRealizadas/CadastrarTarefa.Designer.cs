﻿namespace CadastroTarefasRealizadas
{
    partial class CadastrarTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.textDescricao = new System.Windows.Forms.RichTextBox();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Foto";
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(95, 23);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(285, 21);
            this.comboCategoria.TabIndex = 3;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(95, 81);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(670, 128);
            this.textDescricao.TabIndex = 4;
            this.textDescricao.Text = "";
            // 
            // pictureFoto
            // 
            this.pictureFoto.Location = new System.Drawing.Point(95, 242);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(670, 429);
            this.pictureFoto.TabIndex = 5;
            this.pictureFoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tirar foto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 699);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Gravar tarefa realizada";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CadastrarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarTarefa";
            this.Text = "Cadastrar tarefa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.RichTextBox textDescricao;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}