﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes
{
    public partial class formPrincpal : Form
    {
        public formPrincpal()
        {
            InitializeComponent();
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirAluno formInserirAluno = new FormInserirAluno();
            formInserirAluno.Show(this);
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarEstudantes formListarEstudantes = new FormListarEstudantes();
            formListarEstudantes.Show(this);
        }

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
