using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    public class Form
    {
        private int id;
        private string tag;
        private string name;
        private string information;
        private bool isActive;
        
        public Form(int id, string tag, string name, string information, bool isActive)
        {
            this.id = id;
            this.tag = tag;
            this.name = name;
            this.information = information;
            this.isActive = isActive;
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Tag { get { return this.tag; } set { this.tag = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Information { get { return this.information; } set { this.information = value; } }
        public bool IsActive { get { return this.isActive; } set { this.isActive = value; } }

    }
}
