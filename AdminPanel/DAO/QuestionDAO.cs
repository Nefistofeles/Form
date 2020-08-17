using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAO
{
    public class QuestionDAO
    {
        private FormDAO formdata;
        public QuestionDAO(FormDAO formdata)
        {
            this.formdata = formdata;
        }
        public void Insert(MySqlConnection connection, Question question)
        {
            string query = "insert into question(id, question_string, form_id) values(DEFAULT" + ",'" + question.Question_string + "'," + question.Form_id+ ");";

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
        public void Update(MySqlConnection connection, Question question)
        {
            string query = "Update question set question_string = '" + question.Question_string + "'," + "form_id = " + question.Form_id + " where id = " + question.Id + " where id = " + question.Id;

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
        public void Delete(MySqlConnection connection, Question question)
        {
            string query = "delete from question where id = " + question.Id;

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

        public List<Question> GetList(MySqlConnection connection)
        { 
            List<Question> questionList = new List<Question>();
            string query = "Select * from question";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        questionList.Add(new Question(reader.GetInt16("id"), reader.GetString("question_string"), reader.GetInt16("form_id")));

                    }
                }

                command.Dispose();
                reader.Dispose();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return questionList;
        }
        public List<Question> GetListForForm(MySqlConnection connection, Form form)
        {
            List<Question> questionList = new List<Question>();
            string query = "Select * from question where form_id = " + form.Id;
            MySqlCommand command = new MySqlCommand(query, connection);
                
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         
                        questionList.Add(new Question(reader.GetInt16("id"), reader.GetString("question_string"), reader.GetInt16("form_id")));
                        
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
            
            return questionList;
        }
        public Question GetQuestion(MySqlConnection connection, int id)
        {
            Question question = null;
            string query = "select * from question where id = " + id;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        question = new Question(reader.GetInt16("id"), reader.GetString("question_string"), reader.GetInt16("question.form_id"));
                    }
                }
                command.Dispose();
                reader.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return question;
        }
    }
}
