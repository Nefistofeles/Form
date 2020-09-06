using AdminPanel.entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAO
{
    public class UsersDAO
    {
        public bool ControlUser(MySqlConnection connection, Users users)
        {
            string query = "select * from users where nickname = '" + users.Nickname + "' and password = '" + users.Password + "'";
            bool exist = false;
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        users = new Users(reader.GetInt16("id"), reader.GetString("nickname"), reader.GetString("password"),reader.GetString("name_surname"));
                        exist = true;
                    }
                }
                command.Dispose();
                reader.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            return exist;
        }
    }
}
