using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaGames
{
    class conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=dbgames;user=root;pwd=12345678");

        public static string msg;

        public MySqlConnection ConnectarBD()
        {
            try
            {
                con.Open();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

        public MySqlConnection DesConnectarBD()
        {
            try
            {
                con.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }
    }
}
