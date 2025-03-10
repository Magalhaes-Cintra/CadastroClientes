﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captaçãocliente
{
    public partial class Busca : Form
    {
        Cl cont = new Cl();
        Controlecl controle = new Controlecl();

        public Busca()
        {
            InitializeComponent();
        }


        private void buscar_Click(object sender, EventArgs e)
        {
            if (cbOpcao.SelectedIndex == 0)
            {
                try
                {
                    string cpf = txtBusca.Text;
                    dataGridView1.DataSource = controle.pesquisaCpf(cpf);
                }

                catch

                {
                    MessageBox.Show("Digite um cpf com todos os caracteres");
                    txtBusca.Clear();
                    txtBusca.Focus();
                }

            }
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcao.SelectedIndex < 0)
            {
                txtBusca.Enabled = false;
                btnBuscar.Enabled = false;
                lblOpcao.Text = "";
            }

            else

            {
                txtBusca.Enabled = true;
                lblOpcao.Text = "Digite o " + cbOpcao.Text;
                txtBusca.Clear();
                txtBusca.Focus();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                btnBuscar.Enabled = true;
            }

            else
            {
                btnBuscar.Enabled = false;
            }
            if (cbOpcao.SelectedIndex == 1)
            {
                string nome = (txtBusca.Text);
                dataGridView1.DataSource = controle.pesquisanome(nome);
            }
        }
    }
}
