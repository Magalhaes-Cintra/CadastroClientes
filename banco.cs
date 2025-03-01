using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace captaçãocliente
{
    public class banco
    {
        public MySqlConnection con = new MySqlConnection (@"Server=localhost; database=clientes; Uid=root; pwd=root");

        public string Conectar()
        {
            try
            {
                con.Open();
                return ("Conexão realizada com sucesso");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string desconectar()
        {
            try
            {
                con.Close();
                return ("Conexão encerrada!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
