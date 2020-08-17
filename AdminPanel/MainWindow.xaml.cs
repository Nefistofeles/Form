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
            ClearAll();
            Form form = FormInformation.SelectedItem as Form;
            if(form != null)
            {
                FormNameBox.Text = form.Name;
                FormTagBox.Text = form.Tag;
                FormInformationBox.Text = form.Information;
                FormIsActive.IsChecked = form.IsActive;

                MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
                connection.Open();
                List<Question> questionList = questiondata.GetListForForm(connection, form);
                connection.Close();
                QuestionList.ItemsSource = questionList;
            }
            
        }
        private void SelectedQuestionItem(object sender, EventArgs e)
        {
            Question question = QuestionList.SelectedItem as Question;
            if (question != null)
            {
                QuestionStringBox.Text = question.Question_string;

                MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
                connection.Open();
                List<QuestionOption> questionOptionList = questionOptiondata.GetListForQuestion(connection, question);
                connection.Close();
                QuestionOptionList.ItemsSource = questionOptionList;
            }
        }
        private void SelectedQuestionOptionItem(object sender, EventArgs e)
        {
            QuestionOption questionOption = QuestionOptionList.SelectedItem as QuestionOption;
            if (questionOption != null)
            {
                OptionBox.Text = questionOption.Option_string;
                PointBox.Text = questionOption.Point.ToString();

            }
        }
        private void Update(object sender, EventArgs e)
        {
            Form form = FormInformation.SelectedItem as Form;
            Question question = QuestionList.SelectedItem as Question;
            QuestionOption questionOption = QuestionOptionList.SelectedItem as QuestionOption;
            
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
           
            if(form != null)
            {
                form.Name = FormNameBox.Text;
                form.Tag = FormTagBox.Text;
                form.Information = FormInformationBox.Text;
                form.IsActive = Boolean.Parse("" + FormIsActive.IsChecked);
                formdata.Update(connection, form);
            }
            if(question != null)
            {
                question.Question_string = QuestionStringBox.Text; 
                questiondata.Update(connection, question);
            }
            if(questionOption != null)
            {
                questionOption.Option_string = OptionBox.Text;
                questionOption.Point = Int16.Parse(PointBox.Text);

                questionOptiondata.Update(connection, questionOption);
            }
            connection.Close();
            
            ClearAll();
            FormInformation.ItemsSource = new List<Form>();
            //string query = "update form inner join question on form.id = question.form_id inner join question_option on question.id = question_option.question_id set question.question_string = " + a + ", question_option.option_string = " + b + " where form.id = 1 and question.id = 1 and question_option.id = 1; ";
        }
        private void ClearAll()
        {
            FormNameBox.Text = "";
            FormTagBox.Text = "";
            FormInformationBox.Text = "";
            FormIsActive.IsChecked = false;

            QuestionStringBox.Text = "";

            OptionBox.Text = "";
            PointBox.Text = "";

            
            QuestionList.ItemsSource = new List<Question>();
            QuestionOptionList.ItemsSource = new List<QuestionOption>();
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
