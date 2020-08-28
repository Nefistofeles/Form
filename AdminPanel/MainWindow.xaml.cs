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
        private ResultDAO resultdata;

        private List<string> tableDatas;

        private List<string> formColumnNames;
        private List<string> questionColumnNames;
        private List<string> questionOptionColumnNames;
        private List<string> resultColumnNames;


        public MainWindow()
        {
            InitializeComponent();

            tableDatas = new List<string>();
            tableDatas.Add("form");
            tableDatas.Add("question");
            tableDatas.Add("question_option");
            UpdateTableData.ItemsSource = tableDatas;
            DeleteTableData.ItemsSource = tableDatas;

            formdata = new FormDAO();
            questiondata = new QuestionDAO();
            questionOptiondata = new QuestionOptionDAO();
            resultdata = new ResultDAO();

            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            formColumnNames = formdata.FindColumnNamesOnlyString(connection);
            questionColumnNames = questiondata.FindColumnNamesOnlyString(connection);
            questionOptionColumnNames = questionOptiondata.FindColumnNamesOnlyString(connection);
            resultColumnNames = resultdata.FindColumnNamesOnlyString(connection);
            connection.Close();

        }

        /**Update Form, Question, Question_Option*/
        private void SelectedItem(object sender, EventArgs e)
        {
            ClearAll();
            Form form = FormListUpdate.SelectedItem as Form;
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
                QuestionListUpdate.ItemsSource = questionList;
            }
            
        }
        private void SelectedQuestionItem(object sender, EventArgs e)
        {
            Question question = QuestionListUpdate.SelectedItem as Question;
            if (question != null)
            {
                QuestionStringBox.Text = question.Question_string;

                MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
                connection.Open();
                List<QuestionOption> questionOptionList = questionOptiondata.GetListForQuestion(connection, question);
                connection.Close();
                QuestionOptionListUpdate.ItemsSource = questionOptionList;
            }
        }
        private void SelectedQuestionOptionItem(object sender, EventArgs e)
        {
            QuestionOption questionOption = QuestionOptionListUpdate.SelectedItem as QuestionOption;
            if (questionOption != null)
            {
                OptionBox.Text = questionOption.Option_string;
                PointBox.Text = questionOption.Point.ToString();

            }
        }
        private void Update(object sender, EventArgs e)
        {
            Form form = FormListUpdate.SelectedItem as Form;
            Question question = QuestionListUpdate.SelectedItem as Question;
            QuestionOption questionOption = QuestionOptionListUpdate.SelectedItem as QuestionOption;
            
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
            FormListUpdate.ItemsSource = new List<Form>();
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


            QuestionListUpdate.ItemsSource = new List<Question>();
            QuestionOptionListUpdate.ItemsSource = new List<QuestionOption>();
        }

        private void Button_Find(object sender, EventArgs e)
        {
            FormListUpdate.UnselectAll();
            QuestionListUpdate.UnselectAll();
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<Form> formList = formdata.GetList(connection);
            connection.Close();
            FormListUpdate.ItemsSource = formList;
            
        }
        /*Create Form, Question, Question_Option*/

        private void CreateForm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FormNameBoxCreate.Text) || string.IsNullOrEmpty(FormTagBoxCreate.Text) || string.IsNullOrEmpty(FormInformationBoxCreate.Text))
            {
                ErrorBoxCreate.Text = "Please fill all Form area";
            }
            else
            {
                MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
                connection.Open();
                Form form = new Form();
                form.Name = FormNameBoxCreate.Text;
                form.Tag = FormTagBoxCreate.Text;
                form.Information = FormInformationBoxCreate.Text;
                form.IsActive = FormIsActiveCreate.IsEnabled;

                Console.WriteLine(form.ToString());

                formdata.Insert(connection, form);

                connection.Close();
                ErrorBoxCreate.Text = "";
            }

        }
        private void CreateQuestion(object sender, EventArgs e)
        {
            Form form = FormListCreate.SelectedItem as Form;

            if (string.IsNullOrEmpty(QuestionStringBoxCreate.Text) || form == null)
            {
                ErrorBoxCreate.Text = "Please fill all Question area or select form list from form ";
            }
            else
            {
                MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
                connection.Open();
                Question question = new Question();
                question.Question_string = QuestionStringBoxCreate.Text;
                question.Form_id = form.Id;

                Console.WriteLine(question.ToString());
                questiondata.Insert(connection, question);

                connection.Close();
                ErrorBoxCreate.Text = "";
            }

        }
        private void CreateQuestionOption(object sender, EventArgs e)
        {
            Question question = QuestionListCreate.SelectedItem as Question;
            int point;
            if (string.IsNullOrEmpty(OptionBoxCreate.Text) || question == null || !int.TryParse(PointBoxCreate.Text, out point))
            {
                ErrorBoxCreate.Text = "Please fill all Question Option area or select question list from question or Point value must be number...";
            }
            else
            {
                MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
                connection.Open();
                QuestionOption option = new QuestionOption();
                option.Option_string = OptionBoxCreate.Text;
                option.Point = point;
                option.Question_id = question.Id;
                Console.WriteLine(option.ToString() + " " + point);
                questionOptiondata.Insert(connection, option);
                connection.Close();
                ErrorBoxCreate.Text = "";
            }

        }
        private void FindFormListForCreate(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<Form> formList = formdata.GetList(connection);
            FormListCreate.ItemsSource = formList;
            connection.Close();
        }
        private void FindQuestionListForCreate(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<Question> questionList = questiondata.GetList(connection);
            QuestionListCreate.ItemsSource = questionList;
            connection.Close();

        }

        //delete
        private void FindForm(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<Form> formList = formdata.GetList(connection);
            FormListDelete.ItemsSource = formList;
            connection.Close();
        }
        private void FindQuestion(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<Question> questionList = questiondata.GetList(connection);
            QuestionListDelete.ItemsSource = questionList;
            connection.Close();
        }
        private void FindQuestionOption(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<QuestionOption> optionList = questionOptiondata.GetList(connection);
            QuestionOptionListDelete.ItemsSource = optionList;
            connection.Close();
        }
        
        private void AreYouSure(object sender, EventArgs e)
        {
            ControlBorder.Visibility = Visibility.Visible;
        }
        private void YesButtonFunc(object sender, EventArgs e)
        {

            ControlBorder.Visibility = Visibility.Hidden;
            Delete();
        }
        private void NoButtonFunc(object sender, EventArgs e)
        {
            ControlBorder.Visibility = Visibility.Hidden;
        }

        private void Delete()
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            Form form = FormListDelete.SelectedItem as Form;
            Question question = QuestionListDelete.SelectedItem as Question;
            QuestionOption option = QuestionOptionListDelete.SelectedItem as QuestionOption;
            if(form != null)
            {
                formdata.Delete(connection, form);
            }
            if(question != null)
            {
                questiondata.Delete(connection, question);
            }
            if(option != null)
            {
                questionOptiondata.Delete(connection, option);
            }
            connection.Close();
        }

        private void SearchUpdate(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            string searchString = UpdateSearchBox.Text;
            string selectedColumnName = UpdateComboColumnBox.SelectedItem as string;
            string selectedTableData = UpdateTableData.SelectedItem as string;

            if (selectedColumnName == null || selectedTableData == null || string.IsNullOrEmpty(searchString))
            {
                UpdateErrorSearchText.Text = "Please select column or form ";
            }
            else
            {
                if (selectedTableData.Contains("form"))
                {
                    FormListUpdate.ItemsSource = formdata.GetListForSearch(connection, selectedColumnName, searchString);
                }
                else if (selectedTableData.Contains("option"))
                {
                    QuestionOptionListUpdate.ItemsSource = questionOptiondata.GetListForSearch(connection, selectedColumnName, searchString);
                }
                else if (selectedTableData.Contains("question"))
                {
                    QuestionListUpdate.ItemsSource = questiondata.GetListForSearch(connection, selectedColumnName, searchString);
                }
                UpdateErrorSearchText.Text = "";

            }
            connection.Close();
        }
        private void SearchDelete(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            string searchString = DeleteSearchBox.Text;
            string selectedColumnName = DeleteComboColumnBox.SelectedItem as string;
            string selectedTableData = DeleteTableData.SelectedItem as string;
            
            if (selectedColumnName == null || selectedTableData == null || string.IsNullOrEmpty(searchString))
            {
                DeleteErrorSearchText.Text = "Please select column or form ";
            }
            else
            {
                if (selectedTableData.Contains("form"))
                {
                    FormListDelete.ItemsSource = formdata.GetListForSearch(connection, selectedColumnName, searchString);
                }
                else if (selectedTableData.Contains("option"))
                {
                    QuestionOptionListDelete.ItemsSource = questionOptiondata.GetListForSearch(connection, selectedColumnName, searchString);
                }
                else if (selectedTableData.Contains("question"))
                {
                    QuestionListDelete.ItemsSource =  questiondata.GetListForSearch(connection, selectedColumnName, searchString);
                }
                DeleteErrorSearchText.Text = "";

            }
            connection.Close();
        }

        private void OnTimedUpdate(object sender, EventArgs e)
        {
            string selected = UpdateTableData.SelectedItem as string;
            Console.WriteLine("updated " + selected);

            if(selected != null){
                if (selected.Contains("form"))
                {
                    UpdateComboColumnBox.ItemsSource = formColumnNames;
                }
                else if (selected.Contains("option"))
                {
                    UpdateComboColumnBox.ItemsSource = questionOptionColumnNames;
                }
                else if (selected.Contains("question"))
                {
                    UpdateComboColumnBox.ItemsSource = questionColumnNames;
                }
               
            }

        }
        private void OnTimedDelete(object sender, EventArgs e)
        {
            string selected = DeleteTableData.SelectedItem as string;

            if (selected != null)
            {
                if (selected.Contains("form"))
                {
                    DeleteComboColumnBox.ItemsSource = formColumnNames;
                }
                else if (selected.Contains("option"))
                {
                    DeleteComboColumnBox.ItemsSource = questionOptionColumnNames;
                }
                else if (selected.Contains("question"))
                {
                    DeleteComboColumnBox.ItemsSource = questionColumnNames;
                }
               
            }

        }
        private void SearchResult(object sender, EventArgs e)
        {
            MySqlConnection connection = MyMySQLConnection.ConnectionSingleton();
            connection.Open();
            List<Result> resultList = resultdata.GetList(connection);
            ResultList.ItemsSource = resultList;

            connection.Close();
        }
        
    }
}
