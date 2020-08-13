using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    public class Question
    {
        private int id;
        private string question_string;
        private Form form;

        public Question(int id, string question_string, Form form)
        {
            this.Id = id;
            this.question_string = question_string;
            this.Form = form;
        }

        public int Id { get => id; set => id = value; }
        public string Question_string { get => question_string; set => question_string = value; }
        public Form Form { get => form; set => form = value; }
    }
}
