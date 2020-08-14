using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAO
{
    public class FindThemAll
    {
        
        public void FindThemAllInformation()
        {
            string query = "select * from question_option inner join question on question.id = question_option.question_id inner join form on question.form_id = form.id order by form.id";
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        
                    }
                }

                command.Dispose();
                reader.Dispose();
                connection.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }
    }
}
