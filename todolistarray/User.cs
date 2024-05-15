using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Todolist
{
    public class User
    {
        int id;
        string name;

        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
        {
            id = Id;
            name = Name;
        }
    }

}