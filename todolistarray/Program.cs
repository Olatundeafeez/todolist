using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using todolistarray;

namespace project_Todolist
{
    public class Program
    {
        static void Main(string[] args)
        {
            var todoList = new Todolist();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Display Tasks");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        todoList.AddTask();
                        break;
                    case 2:
                        todoList.RemoveTask();
                        break;
                    case 3:
                        todoList.MarkTaskAsCompleted();
                        break;
                    case 4:
                        todoList.DisplayTasks();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }


            }
        }
    }
}
