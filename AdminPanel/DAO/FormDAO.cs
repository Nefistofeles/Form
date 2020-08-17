using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.DAO
{
    public class FormDAO
    {
        public void Insert(MySqlConnection connection, Form form)
        {
            string query = "insert into form(id, name, tag, information, isActive) values(DEFAULT" + ",'" + form.Name + "','" + form.Tag + "','" + form.Information + "'," + form.IsActive + ");";

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
        public void Update(MySqlConnection connection, Form form)
        {
            string query = "Update form set name = '" + form.Name + "'," + "tag = '" + form.Tag + "'," + "information = '" + form.Information + "'," + "isActive = " + form.IsActive + " where id = " + form.Id ;

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
        public void Delete(MySqlConnection connection, Form form)
        {
            string query = "delete from form where id = " + form.Id;

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
        
        public List<Form> GetList(MySqlConnection connection)
        {
            List<Form> formList = new List<Form>();
            string query = "Select * from form";
            MySqlCommand command = new MySqlCommand(query, connection);
                
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        formList.Add(new Form(reader.GetInt16("id"), reader.GetString("tag"), reader.GetString("name"), reader.GetString("information"), reader.GetBoolean("isActive")));
                        
                    }
                }

                command.Dispose();
                reader.Dispose();
               
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return formList;
        }
        public Form GetForm(MySqlConnection connection, int id)
        {
            Form form = null ;
            string query = "select * from form where id = " + id;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        form = new Form(reader.GetInt16("id"), reader.GetString("tag"), reader.GetString("name"), reader.GetString("information"), reader.GetBoolean("isActive"));
                    }
                }
                command.Dispose();
                reader.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return form;
        }
    }
}
