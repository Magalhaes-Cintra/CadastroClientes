using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace captaçãocliente
{
    public partial class cadcliente : Form
    {
        Cl cont = new Cl();
        Controlecl controle = new Controlecl();

        private void limpar()
        {
            rg.Clear();
            nome.Clear();
            telefone.Clear();
            cpf.Clear();
            email.Clear();
            cidade.Clear();
            uf.Clear();
            cep.Clear();
            endereco.Clear();
        }

        public cadcliente()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (nome.Text == "")
            {
                MessageBox.Show("Não é permitido cadastro sem um nome");
            }
            else
            {
                cont.Nome = nome.Text;
                cont.Telefone = telefone.Text;
                cont.Rg = rg.Text;
                cont.Email = email.Text;
                cont.Cpf = cpf.Text;
                cont.Cep = cep.Text;
                cont.Endereco = endereco.Text;
                cont.Cidade = cidade.Text;
                cont.Uf = uf.Text;
                cont.Numero = numero.Text;

                MessageBox.Show(controle.cadastrar(cont));
                limpar();
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            cont.Nome = nome.Text;
            cont.Telefone = telefone.Text;
            cont.Rg = rg.Text;
            cont.Email = email.Text;
            cont.Cpf = cpf.Text;
            cont.Cep = cep.Text;
            cont.Endereco = endereco.Text;
            cont.Cidade = cidade.Text;
            cont.Uf = uf.Text;
            cont.Numero = numero.Text;

            MessageBox.Show(controle.atualizar(cont));
            limpar();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            cont.Nome = nome.Text;
            cont.Telefone = telefone.Text;
            cont.Rg = rg.Text;
            cont.Email = email.Text;
            cont.Cpf = cpf.Text;
            cont.Cep = cep.Text;
            cont.Endereco = endereco.Text;
            cont.Cidade = cidade.Text;
            cont.Uf = uf.Text;
            cont.Numero = numero.Text;

            MessageBox.Show(controle.excluir(cont));
            limpar();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Busca buscar = new Busca();
            buscar.Show();

        }
    }
}

