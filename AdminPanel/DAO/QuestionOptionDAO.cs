using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAO
{
    public class QuestionOptionDAO
    {
        public QuestionOptionDAO()
        {
        }
        public void Insert(MySqlConnection connection, QuestionOption questionOption)
        {
            string query = "insert into question_option(id, option_string, point, question_id) values(DEFAULT" + ",'" + questionOption.Option_string + "'," + questionOption.Point + ", " + questionOption.Question_id + ");";

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Update(MySqlConnection connection, QuestionOption questionOption)
        {
            string query = "Update question_option set option_string = '" + questionOption.Option_string + "'," + "point = " + questionOption.Point + "," + "question_id = " + questionOption.Question_id + " where id = " + questionOption.Id;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public void Delete(MySqlConnection connection, QuestionOption questionOption)
        {
            string query = "delete from question_option where id = " + questionOption.Id;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public List<QuestionOption> GetList(MySqlConnection connection)
        { 
            List<QuestionOption> questionOptionList = new List<QuestionOption>();
            string query = "Select * from question_option";
            MySqlCommand command = new MySqlCommand(query, connection);
               
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        questionOptionList.Add(new QuestionOption(reader.GetInt16("id"), reader.GetString("option_string"), reader.GetInt16("point"), reader.GetInt16("question_id")));

                    }
                }

                command.Dispose();
                reader.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return questionOptionList;
        }
        public List<QuestionOption> GetListForSearch(MySqlConnection connection, string columnName, string searchText)
        {
            List<QuestionOption> questionOptionList = new List<QuestionOption>();
            string query = "Select * from question_option where " + columnName + " LIKE '%" + searchText + "%';";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        questionOptionList.Add(new QuestionOption(reader.GetInt16("id"), reader.GetString("option_string"), reader.GetInt16("point"), reader.GetInt16("question_id")));

                    }
                }

                command.Dispose();
                reader.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return questionOptionList;
        }
        public List<QuestionOption> GetListForQuestion(MySqlConnection connection, Question question)
        {
            List<QuestionOption> questionOptionList = new List<QuestionOption>();
            string query = "Select * from question_option where question_id = " + question.Id;
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        questionOptionList.Add(new QuestionOption(reader.GetInt16("id"), reader.GetString("option_string"), reader.GetInt16("point"), reader.GetInt16("question_id")));

                    }
                }

                command.Dispose();
                reader.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return questionOptionList;
        }
        public QuestionOption GetQuestionOption(MySqlConnection connection, int id)
        {
            QuestionOption questionOption = null;
            string query = "select * from question_option where id = " + id;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        questionOption = new QuestionOption(reader.GetInt16("id"), reader.GetString("question_string"), reader.GetInt16("point"), reader.GetInt16("question_id"));
                    }
                }
                command.Dispose();
                reader.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return questionOption;
        }
        public List<string> FindColumnNamesOnlyString(MySqlConnection connection)
        {
            List<string> columnNames = new List<string>();
            string query = "show columns from question_option";
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
        public List<string> FindColumnNamesAndInformation(MySqlConnection connection, out List<string> typeInformation)
        {
            List<string> columnNames = new List<string>();
            typeInformation = new List<string>();
            string query = "show columns from question_option";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        columnNames.Add(reader.GetString("Field"));
                        typeInformation.Add(reader.GetString("Type"));

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
