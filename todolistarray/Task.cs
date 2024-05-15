using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolistarray
{
    public class Task
    {
        //field
        string name;
        string description;
        DateTime dueDate;
        bool completed = false;

        //private string taskName;
        //private string taskdescription;
        //private int taskduedate;

        //properties
        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public DateTime DueDate { get { return dueDate; } }
        public bool Completed { get { return completed; } }

        //constructed
        public Task(string myTaskName, string myTaskDescription, DateTime myTaskDueDate)
        {
            name = myTaskName;
            description = myTaskDescription;
            dueDate = myTaskDueDate;
        }
        // completed = Completed;

        //public Task(string taskName, string taskdescriptione, int taskduedate)
        //{
        //    this.taskName = taskName;
        //    this.taskdescription = taskdescription;
        //    this.taskduedate = taskduedate;
        //}
    }
}
