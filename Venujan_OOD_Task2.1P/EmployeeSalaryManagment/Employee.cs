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
        private double tax = 0;
        private double bal = 0;

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

        public void deductTax()
        {
            this.salary -= tax ;
        }

        public double employeeTax()
        {

            if ((this.salary >= 0) && (this.salary <= 18200))
            {
                this.tax = 0;
            }
            else if((this.salary >= 18201) && (this.salary <= 37000))
            {
                this.bal = (this.salary - 18200);
                this.tax = (this.bal * 0.19);

            }
            else if ((this.salary >= 37001) && (this.salary <= 90000))
            {
                this.bal = (this.salary - 37000);
                this.tax = (this.bal * 0.325) + 3572;
            }
            else if((this.salary >= 90001) && (this.salary <= 180000))
            {
                this.bal = (this.salary - 90000);
                this.tax = (this.bal * 0.37) + 20797; 
            }
            else 
            {
                this.bal = (this.salary - 180000);
                this.tax = (this.bal * 0.45) +54096;
            }
            return tax;
        }

    }
}
