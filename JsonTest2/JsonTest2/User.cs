using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest2
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User()
        {
            
        }
        public User(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
