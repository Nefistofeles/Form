using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.entities
{
    public class Users
    {
        private int id;
        private string nickname;
        private string password;
        private string name_surname;

        public Users()
        {

        }
        public Users(int id, string nickname, string password, string name_surname)
        {
            this.id = id;
            this.nickname = nickname;
            this.password = password;
            this.name_surname = name_surname;
        }

        public string Nickname { get => nickname; set => nickname = value; }
        public string Password { get => password; set => password = value; }
        public string Name_surname { get => name_surname; set => name_surname = value; }
        public int Id { get => id; set => id = value; }
    }
}
