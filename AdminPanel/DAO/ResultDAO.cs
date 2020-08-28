using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAO
{
    public class ResultDAO
    {
        public ResultDAO()
        {

        }
        public List<Result> GetList(MySqlConnection connection)
        {
            List<Result> resultList = new List<Result>();
            string query = "Select * from result";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string email = "";
                        if(reader.GetString("e_mail") == null)
                        {
                            email = "";
                        }
                        else
                        {
                            email = reader.GetString("e_mail");
                        }
                        resultList.Add(new Result(reader.GetInt16("id"),reader.GetInt16("point"), email, reader.GetInt16("form_id")));

                    }
                }

                command.Dispose();
                reader.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return resultList;
        }
        public List<Result> GetListForSearch(MySqlConnection connection, string columnName, string searchText)
        {
            List<Result> resultList = new List<Result>();
            string query = "Select * from result where " + columnName + " LIKE '" + searchText + "' ;";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        resultList.Add(new Result(reader.GetInt16("id"), reader.GetInt16("point"), reader.GetString("email"), reader.GetInt16("form_id")));

                    }
                }

                command.Dispose();
                reader.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return resultList;
        }
        public List<Result> GetListForForm(MySqlConnection connection, Form form)
        {
            List<Result> resultList = new List<Result>();
            string query = "Select * from result where form_id = " + form.Id;
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        resultList.Add(new Result(reader.GetInt16("id"), reader.GetInt16("point"), reader.GetString("email"), reader.GetInt16("form_id")));

                    }
                }

                command.Dispose();
                reader.Dispose();
                reader.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

            return resultList;
        }
        public Result GetResult(MySqlConnection connection, int id)
        {
            Result result = null;
            string query = "select * from result where id = " + id;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        result = new Result(reader.GetInt16("id"), reader.GetInt16("point"), reader.GetString("email"), reader.GetInt16("form_id"));
                    }
                }
                command.Dispose();
                reader.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return result;
        }
        public List<string> FindColumnNamesOnlyString(MySqlConnection connection)
        {
            List<string> columnNames = new List<string>();
            string query = "show columns from result";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString("Type").Contains("varchar") || reader.GetString("Type").Contains("text"))
                            columnNames.Add(reader.GetString("Field"));

                    }
                }

                command.Dispose();
                reader.Dispose();

            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return columnNames;
        }
        public List<string> FindColumnNamesAndInformation(MySqlConnection connection, out List<string> informationType)
        {
            List<string> columnNames = new List<string>();
            informationType = new List<string>();
            string query = "show columns from result";
            MySqlCommand command = new MySqlCommand(query, connection);


            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        columnNames.Add(reader.GetString("Field"));
                        informationType.Add(reader.GetString("Type"));
                    }
                }

                command.Dispose();
                reader.Dispose();

            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return columnNames;
        }


    }
}
