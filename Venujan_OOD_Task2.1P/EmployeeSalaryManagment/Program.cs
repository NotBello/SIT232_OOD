using System;

namespace EmployeeSalaryManagement
{
    class EmployeeProgram
    {
        static void Main(string[] args)
        {
            Employee bello = new Employee("bello", 60000);
            Console.WriteLine("Employee name:   " + bello.getName());
            Console.WriteLine("Employee salary: " + bello.getSalary());
            Console.WriteLine("Raising " + bello.getName() + "'s salary...");
            bello.raiseSalary();

            Console.WriteLine();
            Console.WriteLine("Employee name:   " + bello.getName());
            Console.WriteLine("Employee salary: " + bello.getSalary());

        }
    }
}