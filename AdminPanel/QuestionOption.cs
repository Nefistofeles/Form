using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    public class QuestionOption
    {
        private int id;
        private string option_string;
        private int point;
        private Question question;

        public QuestionOption(int id, string option_string, int point, Question question)
        {
            this.Id = id;
            this.Option_string = option_string;
            this.Point = point;
            this.Question = question;
        }

        public int Id { get => id; set => id = value; }
        public string Option_string { get => option_string; set => option_string = value; }
        public int Point { get => point; set => point = value; }
        public Question Question { get => question; set => question = value; }
    }
}
