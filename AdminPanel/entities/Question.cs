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
        private int form_id;

        public Question()
        {

        }
        public Question(int id, string question_string, int form_id)
        {
            this.Id = id;
            this.question_string = question_string;
            this.Form_id = form_id;
        }
        public override string ToString()
        {
            return "id " + id + " question_string " + question_string + " form_id " + Form_id;
        }
        public int Id { get => id; set => id = value; }
        public string Question_string { get => question_string; set => question_string = value; }
        public int Form_id { get => form_id; set => form_id = value; }
    }
}
