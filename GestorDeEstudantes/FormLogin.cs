﻿using MySql.Data.MySqlClient;
using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
                
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            // Cria um objeto da classe "MeuBancoDeDados"
            MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable tabelaDeDados = new DataTable();  
            MySqlCommand comandoSql= new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario`= @usuario AND `senha`= @senha", meuBancoDeDados.getConexao);

            comandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textBoxName.Text;
            comandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxSenha.Text;

            meuAdaptadorSql.SelectCommand = comandoSql;

            meuAdaptadorSql.Fill(tabelaDeDados);

            if(tabelaDeDados.Rows.Count > 0)
            {
                this.DialogResult= DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
