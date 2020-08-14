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
        private int form_id;

        public Result(int id, int point, string e_mail, int form_id)
        {
            this.Id = id;
            this.Point = point;
            this.E_mail = e_mail;
            this.Form_id = form_id;
        }
        public override string ToString()
        {
            return "id " + id + " point " + point + " e_mail " + e_mail + " form_id " + Form_id;
        }
        public int Id { get => id; set => id = value; }
        public int Point { get => point; set => point = value; }
        public string E_mail { get => e_mail; set => e_mail = value; }
        public int Form_id { get => form_id; set => form_id = value; }
    }
}
