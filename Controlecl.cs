using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;

namespace captaçãocliente
{
    public class Controlecl
    {
        banco b = new banco();

        public string cadastrar(Cl cont) 
        {
            try
            {
                string sql = $"INSERT INTO CadCliente (nome, telefone, email, cpf, rg, cep, endereco, numero, cidade, estado )" +
                    $"VALUES ( ' { cont.Nome }', " +
                    $"' {cont.Telefone }', " +
                    $"'{ cont.Email }', " +
                    $"'{ cont.Cpf }', " +
                    $"'{ cont.Rg }', " +
                    $"'{ cont.Cep }', " +
                    $"'{ cont.Endereco }', " +
                    $"'{ cont.Numero }', " +
                    $"'{ cont.Cidade }', " +
                    $"'{ cont.Uf}')";
                MySqlCommand cmd = new MySqlCommand(sql, b.con);
                b.Conectar();
                cmd.ExecuteNonQuery();
                b.desconectar();
                return ("Cadastro realizado com sucesso.");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string atualizar(Cl cont)
        {
            try
            {
                string sql = "UPDATE CadCliente set nome = '" + cont.Nome + "', '" + cont.Telefone + "', '" + cont.Email + "', '" + cont.Rg + "', '" + cont.Cpf + "', '" + cont.Cep + "', '" + cont.Endereco + "', '" + cont.Cidade + "', '" + cont.Uf + "', '" + cont.Numero + "' WHERE cpf = '" + cont.Cpf + "'";
                MySqlCommand cmd = new MySqlCommand(sql, b.con);
                b.Conectar();
                cmd.ExecuteNonQuery();
                b.desconectar();
                return ("Cadastro alterado com sucesso.");
            }
            catch (MySqlException e) 
            {
                return (e.ToString());
            }
        }

        public string excluir( Cl cont)
        {
            try 
            {
                string sql = "DELETE from CadCliente WHERE nome = '" + cont.Nome + "', '" + cont.Telefone + "', '" + cont.Email + "', '" + cont.Rg + "', '" + cont.Cpf + "', '" + cont.Cep + "', '" + cont.Endereco + "', '" + cont.Cidade + "', '" + cont.Uf + "', '" + cont.Numero + "' )";
                MySqlCommand cmd = new MySqlCommand(sql, b.con);
                b.Conectar();
                cmd.ExecuteNonQuery();
                b.desconectar();
                return ("Cadastro deletado com sucesso.");
            }
            catch (MySqlException e)
            {
                    return (e.ToString());
            }
        }
        public Cl buscar(string cpf)
        {
            Cl cont = new Cl();

            try
            {
                string sql = "select * from CadCliente where cpf= @cpf";
                MySqlCommand cmd = new MySqlCommand(sql, b.con);
                b.Conectar();
                MySqlDataReader objDados = cmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    return null;
                }

                else
                {
                    objDados.Read();
                    cont.Nome = objDados["nome"].ToString();
                    cont.Telefone = objDados["telefone"].ToString();
                    cont.Email = objDados["email"].ToString();
                    cont.Rg = objDados["rg"].ToString();
                    cont.Cpf = objDados["cpf"].ToString();
                    cont.Cep = objDados["cep"].ToString();
                    cont.Endereco = objDados["endereco"].ToString();
                    cont.Numero = objDados["numero"].ToString();
                    cont.Cidade = objDados["cidade"].ToString();
                    cont.Uf = objDados["estado"].ToString();
                    objDados.Close();
                    return cont;
                }
            }
            catch { return null; }
        }

        public DataTable PreencherTodos()
        {
            string sql = "SELECT nome AS 'Nome', cpf AS 'CPF', rg AS 'RG', telefone AS 'Telefone', " +
                 "email AS 'Email', cep AS 'CEP', endereco AS 'Endereço', numero AS 'Número', " +
                 "cidade AS 'Cidade', estado AS 'Estado' FROM CadCliente;";
            MySqlCommand cmd = new MySqlCommand(sql, b.con);
            b.Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            b.desconectar();
            return contato;
        }

        public DataTable pesquisaCpf(string Cpf)
        {
            string sql = "SELECT nome AS 'Nome', cpf AS 'CPF', rg AS 'RG', telefone AS 'Telefone', " +
                 "email AS 'Email', cep AS 'CEP', endereco AS 'Endereço', numero AS 'Número', " +
                 "cidade AS 'Cidade', estado AS 'Estado' FROM CadCliente WHERE cpf = @cpf;";
            MySqlCommand cmd = new MySqlCommand(sql, b.con);
            b.Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            b.desconectar();
            return contato;
        }

        public DataTable pesquisanome(string nome)
        {
            string sql = "SELECT nome AS 'Nome', cpf AS 'CPF', rg AS 'RG', telefone AS 'Telefone', " +
                 "email AS 'Email', cep AS 'CEP', endereco AS 'Endereço', numero AS 'Número', " +
                 "cidade AS 'Cidade', estado AS 'Estado' FROM CadCliente WHERE nome LIKE @nome;";

            MySqlCommand cmd = new MySqlCommand(sql, b.con);
            b.Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            b.desconectar();
            return contato;
        }

    }
}