/*
 * Created by Venujan Malaiyandi (a.k.a) Bello
 * BSCP | CS | 61| 101
 * For Task 4.2C
 * SIT 282 OOB
 */

using System;

namespace RevisedTaskManager
{

    // To contain an array of strings to store tasks
    class TaskMembers
    {
        // Declare string array
        private string[] tasks = new string[0];


        // Private Add tasks to the task array
        private string[] AddTaskToArray(string[] tasks, string task)
        {
            string[] newTasks = new string[tasks.Length + 1];
            for (int j = 0; j < tasks.Length; j++)
            {
                newTasks[j] = tasks[j];
            }
            newTasks[newTasks.Length - 1] = task;
            return newTasks;
        }

        // Public method
        public void AddTask(string task)
        {
            tasks = AddTaskToArray(tasks, task);
        }

        public string[] GetTasks()
        {
            return tasks;
        }

        
    }

    // To manage different categories of tasks
    class TaskCollection
    {
        private TaskMembers tasksIndividual = new TaskMembers();
        private TaskMembers tasksWork = new TaskMembers();
        private TaskMembers tasksFamily = new TaskMembers();

        // Display the task members
        public void UpdateTasks()
        {
            Console.Clear();
            int max = Math.Max(Math.Max(tasksIndividual.GetTasks().Length, tasksWork.GetTasks().Length), tasksFamily.GetTasks().Length);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 12) + "CATEGORIES");
            Console.WriteLine(new string(' ', 10) + new string('-', 94));
            Console.WriteLine("{0,10}|{1,30}|{2,30}|{3,30}|", "item #", "Personal", "Work", "Family");
            Console.WriteLine(new string(' ', 10) + new string('-', 94));

            for (int i = 0; i < max; i++)
            {
                Console.Write("{0,10}|", i);

                if (tasksIndividual.GetTasks().Length > i)
                {
                    Console.Write("{0,30}|", tasksIndividual.GetTasks()[i]);
                }
                else
                {
                    Console.Write("{0,30}|", "N/A");
                }

                if (tasksWork.GetTasks().Length > i)
                {
                    Console.Write("{0,30}|", tasksWork.GetTasks()[i]);
                }
                else
                {
                    Console.Write("{0,30}|", "N/A");
                }

                if (tasksFamily.GetTasks().Length > i)
                {
                    Console.Write("{0,30}|", tasksFamily.GetTasks()[i]);
                }
                else
                {
                    Console.Write("{0,30}|", "N/A");
                }

                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine("\nWhich category do you want to place a new task? Type 'Personal', 'Work', or 'Family'");
            Console.Write(">> ");
            string listName = Console.ReadLine().ToLower();

            Console.WriteLine("Describe your task below (max. 30 symbols).");
            Console.Write(">> ");
            string task = Console.ReadLine();

            if (task.Length > 30) task = task.Substring(0, 30);

            AddTask(listName, task);
        }

        // Add a task to the specified category
        private void AddTask(string listName, string task)
        {
            switch (listName)
            {
                case "personal":
                    tasksIndividual.AddTask(task);
                    break;
                case "work":
                    tasksWork.AddTask(task);
                    break;
                case "family":
                    tasksFamily.AddTask(task);
                    break;
                default:
                    Console.WriteLine("Invalid category. Please try again.");
                    break;
            }
        }
    }

    // Main class
    class Revised
    {
        static void Main(string[] args)
        {
            TaskCollection taskManager = new TaskCollection();

            while (true)
            {
                taskManager.UpdateTasks();
            }
        }
    }
}
