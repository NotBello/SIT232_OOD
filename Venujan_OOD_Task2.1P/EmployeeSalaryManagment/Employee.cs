using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryManagement
{
    class Employee
    {
        //Instance Variables
        private string name;
        private double salary;

        //Constructor
        public Employee(string employeeName, double currentSalary)
        {
            this.name = employeeName;
            this.salary = currentSalary;
        }

        //Accessor methods
        public string getName()
        {
            return name;
        }

        public string getSalary()
        {
            return salary.ToString("C");
        }

        //Methods
        public void raiseSalary()
        {
            double raise = this.salary * 0.03;
            this.salary += raise ; 
        }


    }
}
