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
        private int question_id;

        public QuestionOption()
        {

        }
        public QuestionOption(int id, string option_string, int point, int question_id)
        {
            this.Id = id;
            this.Option_string = option_string;
            this.Point = point;
            this.Question_id = question_id;
        }
        public override string ToString()
        {
            return "id " + id + " option_string " + option_string + " point " + point + " question_id " + Question_id;
        }
        public int Id { get => id; set => id = value; }
        public string Option_string { get => option_string; set => option_string = value; }
        public int Point { get => point; set => point = value; }
        public int Question_id { get => question_id; set => question_id = value; }
    }
}
