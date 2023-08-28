using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryManagment
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


    }
}
