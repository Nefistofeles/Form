using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    public class Result
    {
        private int id;
        private int point;
        private string e_mail;
        private Form form;

        public Result(int id, int point, string e_mail, Form form)
        {
            this.Id = id;
            this.Point = point;
            this.E_mail = e_mail;
            this.Form = form;
        }

        public int Id { get => id; set => id = value; }
        public int Point { get => point; set => point = value; }
        public string E_mail { get => e_mail; set => e_mail = value; }
        public Form Form { get => form; set => form = value; }
    }
}
