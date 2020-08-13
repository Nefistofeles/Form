using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdminPanel
{
    public class MyMySQLConnection
    {
        public MySqlConnection ConnectMySQL()
        {
            string mysqlConn = "Server = localhost; Database = formstatistics; Uid = root; Pwd = ''; ";
            MySqlConnection connection = new MySqlConnection(mysqlConn);
            return connection;
        }
    }
}
