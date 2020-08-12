using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace AdminPanel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = ConnectMySQL();
            string query = "select * from form where id = 1";
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1));
                    }
                    
                }
                
                connection.Close();
            }catch(Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }
        
        private MySqlConnection ConnectMySQL()
        {
            string mysqlConn = "Server = localhost; Database = formstatistics; Uid = root; Pwd = ''; ";
            MySqlConnection connection = new MySqlConnection(mysqlConn);
            return connection;
        }
    }
}
