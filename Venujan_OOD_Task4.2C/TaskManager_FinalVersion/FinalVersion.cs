/*
 * Created by Venujan Malaiyandi 
 * BSCP | CS | 61 | 101
 * For task 4.2C question 3
 * SIT 232 OOB
 */

using System;
using System.Collections.Generic;

namespace FinalTaskManager
{
    // Represents a single task with properties like name, due date, priority, and importance
    class Task
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public bool IsImportant { get; set; }

        // Constructor to initialize task properties
        public Task(string name, DateTime dueDate, int priority, bool isImportant)
        {
            Name = name;
            DueDate = dueDate;
            Priority = priority;
            IsImportant = isImportant;
        }

        // Overrides the default ToString method to provide a custom string representation of the task
        public override string ToString()
        {
            string importantIndicator = IsImportant ? "[IMPORTANT] " : "";
            return $"{importantIndicator}{Name} (Due: {DueDate.ToShortDateString()}, Priority: {Priority})";
        }
    }

    // Represents a category containing a list of tasks
    class Category
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }

        // Moves the priority of tasks within the category
        public void MoveTaskPriority(int oldPriority, int newPriority)
        {
            foreach (var task in tasks)
            {
                if (task.Priority == oldPriority)
                {
                    task.Priority = newPriority;
                }
            }
        }

        public void HighlightImportantTasks()
        {
            foreach (var task in tasks)
            {
                if (task.IsImportant)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(task);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(task);
                }
            }
        }
    }

    // Represents the collection of categories and manages user interaction

    class TaskCollection
    {
        private Dictionary<string, Category> categories = new Dictionary<string, Category>();

        public TaskCollection()
        {
            categories.Add("Personal", new Category());
            categories.Add("Work", new Category());
            categories.Add("Family", new Category());
        }

        // Displays and manages the tasks for various categories
        public void UpdateTasks()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 12) + "CATEGORIES");
            Console.WriteLine(new string(' ', 10) + new string('-', 94));

            // Display category names dynamically
            foreach (var categoryName in categories.Keys)
            {
                Console.Write("{0,30}|", categoryName);
            }

            Console.WriteLine();
            Console.WriteLine(new string(' ', 10) + new string('-', 94));

            int max = categories.Values.Max(category => category.GetTasks().Count);

            for (int i = 0; i < max; i++)
            {
                Console.Write("{0,10}|", i);

                foreach (var category in categories.Values)
                {
                    List<Task> tasks = category.GetTasks();

                    if (tasks.Count > i)
                    {
                        Console.Write("{0,30}|", tasks[i]);
                    }
                    else
                    {
                        Console.Write("{0,30}|", "N/A");
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Delete Task");
            Console.WriteLine("3. Move Task Priority");
            Console.WriteLine("4. Move Task to Another Category");
            Console.WriteLine("5. Highlight Important Tasks");
            Console.WriteLine("6. Add Category");
            Console.WriteLine("7. Delete Category");
            Console.WriteLine("8. Quit");
            Console.Write("Enter your choice (1-8): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    DeleteTask();
                    break;
                case "3":
                    MoveTaskPriority();
                    break;
                case "4":
                    MoveTaskToAnotherCategory();
                    break;
                case "5":
                    HighlightImportantTasks();
                    break;
                case "6":
                    AddCategory();
                    break;
                case "7":
                    DeleteCategory();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        private void AddTask()
        {
            Console.WriteLine("Which category do you want to add a task to? (Personal, Work, Family)");
            string categoryName = Console.ReadLine();

            if (categories.ContainsKey(categoryName))
            {
                Console.WriteLine("Describe your task below (max. 30 symbols).");
                Console.Write(">> ");
                string taskName = Console.ReadLine();

                Console.WriteLine("Enter due date (yyyy-mm-dd): ");
                Console.Write(">> ");
                DateTime dueDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter priority (1 for highest, 3 for lowest): ");
                Console.Write(">> ");
                int priority = int.Parse(Console.ReadLine());

                Console.WriteLine("Is this task important? (y/n): ");
                Console.Write(">> ");
                bool isImportant = Console.ReadLine().ToLower() == "y";

                Task task = new Task(taskName, dueDate, priority, isImportant);
                categories[categoryName].AddTask(task);
            }
            else
            {
                Console.WriteLine("Invalid category. Please try again.");
            }
        }

        private void DeleteTask()
        {
            Console.WriteLine("Which category do you want to delete a task from? (Personal, Work, Family)");
            string categoryName = Console.ReadLine();

            if (categories.ContainsKey(categoryName))
            {
                Console.WriteLine("Enter the index of the task you want to delete: ");
                int taskIndex = int.Parse(Console.ReadLine());

                List<Task> tasks = categories[categoryName].GetTasks();

                if (taskIndex >= 0 && taskIndex < tasks.Count)
                {
                    Task task = tasks[taskIndex];
                    categories[categoryName].RemoveTask(task);
                }
                else
                {
                    Console.WriteLine("Invalid task index. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid category. Please try again.");
            }
        }

        private void MoveTaskPriority()
        {
            Console.WriteLine("Which category do you want to move a task within? (Personal, Work, Family)");
            string categoryName = Console.ReadLine();

            if (categories.ContainsKey(categoryName))
            {
                Console.WriteLine("Enter the index of the task you want to move: ");
                int taskIndex = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the new priority for the task: ");
                int newPriority = int.Parse(Console.ReadLine());

                Category category = categories[categoryName];
                List<Task> tasks = category.GetTasks();

                if (taskIndex >= 0 && taskIndex < tasks.Count)
                {
                    Task task = tasks[taskIndex];
                    task.Priority = newPriority;
                }
                else
                {
                    Console.WriteLine("Invalid task index. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid category. Please try again.");
            }
        }

        private void MoveTaskToAnotherCategory()
        {
            Console.WriteLine("Enter the source category of the task you want to move: ");
            string sourceCategory = Console.ReadLine();

            if (categories.ContainsKey(sourceCategory))
            {
                Console.WriteLine("Enter the index of the task you want to move: ");
                int taskIndex = int.Parse(Console.ReadLine());

                List<Task> sourceTasks = categories[sourceCategory].GetTasks();

                if (taskIndex >= 0 && taskIndex < sourceTasks.Count)
                {
                    Task task = sourceTasks[taskIndex];

                    Console.WriteLine("Enter the destination category (Personal, Work, Family): ");
                    string destinationCategory = Console.ReadLine();

                    if (categories.ContainsKey(destinationCategory))
                    {
                        categories[sourceCategory].RemoveTask(task);
                        categories[destinationCategory].AddTask(task);
                    }
                    else
                    {
                        Console.WriteLine("Invalid destination category. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid task index. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid source category. Please try again.");
            }
        }

        private void HighlightImportantTasks()
        {
            Console.WriteLine("Which category do you want to highlight important tasks? (Personal, Work, Family)");
            string categoryName = Console.ReadLine();

            if (categories.ContainsKey(categoryName))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(new string(' ', 12) + "IMPORTANT TASKS");
                Console.WriteLine(new string(' ', 10) + new string('-', 94));

                categories[categoryName].HighlightImportantTasks();
            }
            else
            {
                Console.WriteLine("Invalid category. Please try again.");
            }
        }

        private void AddCategory()
        {
            Console.WriteLine("Enter the name of the new category: ");
            string categoryName = Console.ReadLine();

            if (!categories.ContainsKey(categoryName))
            {
                categories.Add(categoryName, new Category());
                Console.WriteLine($"{categoryName} category added.");
            }
            else
            {
                Console.WriteLine("Category with the same name already exists. Please choose a different name.");
            }
        }

        private void DeleteCategory()
        {
            Console.WriteLine("Enter the name of the category you want to delete: ");
            string categoryName = Console.ReadLine();

            if (categories.ContainsKey(categoryName))
            {
                categories.Remove(categoryName);
                Console.WriteLine($"{categoryName} category deleted.");
            }
            else
            {
                Console.WriteLine("Invalid category name. Please try again.");
            }
        }
    }

    // Main class 
    class FinalVersion
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
