﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAO
{
    public class QuestionOptionDAO
    {
        private QuestionDAO questiondata;
        public QuestionOptionDAO(QuestionDAO questiondata)
        {
            this.questiondata = questiondata;
        }
        public void Insert(MySqlConnection connection, QuestionOption questionOption)
        {
            string query = "insert into question_option(id, option_string, point, question_id) values(DEFAULT" + "," + questionOption.Option_string + "," + questionOption.Point + ", " + questionOption.Question_id + ");";

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
            string query = "Update question_option set question_option.option_string = " + questionOption.Option_string + "," + "question.point = " + questionOption.Point + "," + "question_option.question_id = " + questionOption.Question_id + " where id = " + questionOption.Id;

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
    }
}
