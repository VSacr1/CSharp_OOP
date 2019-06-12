using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    abstract class Employee
    {
        //3 private member variables: employeeName, employeeBaseSalary and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        //Create integer variable called "employeeCount and assign value to 1
        private static int employeeCount = 1; 

        //Constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++; 
        }

        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value; 
            }
        }

        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }

        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value; 
            }
        }


        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public String getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID; 
        }
        public String toString()
        {
            return this.ID + " " + this.Name; 
        }

        public abstract String employeeStatus();

    }
}
