using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask
{
    internal class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
        public string Email { get; set; }
        public List<Task> Tasks { get; set; }
        public User(string Name, string Sname, string Email)
        {
            this.Name = Name;
            this.SName = Sname;
            this.Email = Email;
            ID=new Random().Next();
            Tasks=new List<Task>();
        }

    }
}
