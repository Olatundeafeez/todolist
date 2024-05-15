using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolistarray
{
    public class Todolist
    {

        int taskNumber = 0;
        Task task = null;



        //properties
        public int TaskNumber { get; set; }
        public Task Task { get; set; }
        public bool Completed { get; private set; }

        //constructor
        public Todolist()
        {
            taskNumber = TaskNumber;
            task = Task;
        }

        //method
        public void AddTask()
        {

            Console.WriteLine("please enter  a task name : ");
            var taskName = Console.ReadLine();
            Console.WriteLine("please enter  a description : ");
            var taskDescription = Console.ReadLine();
            Console.WriteLine("please enter  a due date : ");
            var TaskDueDate = DateTime.Parse(Console.ReadLine());

            var newtask = new Task(taskName, taskDescription, TaskDueDate);
            task = newtask;
            TaskNumber++;
        }


        public void RemoveTask()
        {
            Console.WriteLine("enter the task number to be removed");
            int RemovedtaskNumber = int.Parse(Console.ReadLine());

            if (RemovedtaskNumber == TaskNumber)
            {
                task = null;
            }
            else
            {
                Console.WriteLine("the task number does not exist");
            }

        }
        public void MarkTaskAsCompleted()
        {
            Console.WriteLine("enter task number to be marked as completed ");
            int TobeCompletedTaskNumber = int.Parse(Console.ReadLine());

            if (TobeCompletedTaskNumber == TaskNumber && task != null)
            {
                Completed = true;

            }
            else
            {
                Console.WriteLine("the task number you entered does not exist");
            }

        }
        public void DisplayTasks()
        {
            if (task != null)
            {
                string displayName = task.Name;
                string displayDescription = task.Description;
                DateTime displayDueDate = task.DueDate;
                bool displayCompleted = task.Completed;
                Console.WriteLine($" Name :{task.Name} /n Description : {task.Description} /n dueDate : {task.DueDate} /n completion : {task.Completed}");

            }
            else
            {
                Console.WriteLine("there are no task");
            }
        }
}
