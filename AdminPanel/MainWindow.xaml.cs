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
using AdminPanel.DAO;
using MySql.Data.MySqlClient;

namespace AdminPanel
{
    public partial class MainWindow : Window
    {
        private FormDAO formdata;
        private QuestionDAO questiondata;
        private QuestionOptionDAO questionOptiondata;

        public MainWindow()
        {
            InitializeComponent();
            formdata = new FormDAO();
            questiondata = new QuestionDAO(formdata);
            questionOptiondata = new QuestionOptionDAO(questiondata);

        }
        private void SelectedItem(object sender, EventArgs e)
        {
            Form form = FormInformation.SelectedItem as Form;
            if(form != null)
            {
                NameBox.Text = form.Name;
                TagBox.Text = form.Tag;
                InformationBox.Text = form.Information;
                IsActive.IsChecked = form.IsActive;

                MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
                connection.Open();
                List<Question> questionList = questiondata.GetListForForm(connection, form);
                connection.Close();
                QuestionList.ItemsSource = questionList;
            }
            else
            {
                NameBox.Text = "";
                TagBox.Text = "";
                InformationBox.Text ="";
                IsActive.IsChecked = false;
            }
            
        }
        private void Button_Find(object sender, EventArgs e)
        {
            FormInformation.UnselectAll();
            QuestionList.UnselectAll();
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<Form> formList = formdata.GetList(connection);
            connection.Close();
            FormInformation.ItemsSource = formList;
            
        }
        
    }
}
