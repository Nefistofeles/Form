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
        private MyMySQLConnection databaseConnection; 
        public MainWindow()
        {
            InitializeComponent();
            databaseConnection = new MyMySQLConnection();
            

        }
        private void SelectedItem(object sender, EventArgs e)
        {
            Form form = FormInformation.SelectedItem as Form;
            NameBox.Text = form.Name;
            TagBox.Text = form.Tag;
            InformationBox.Text = form.Information;
            IsActive.IsChecked = form.IsActive;
        }
        private void Button_Find(object sender, EventArgs e)
        {
            MySqlConnection connection = databaseConnection.ConnectMySQL();
            string query = "select * from form";
            MySqlCommand command = new MySqlCommand(query, connection);
            List<Form> formList = new List<Form>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        formList.Add(new Form(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4)));
                    }
                    
                }
                FormInformation.ItemsSource = formList;
                connection.Close();
            }catch(Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }
        
    }
}
