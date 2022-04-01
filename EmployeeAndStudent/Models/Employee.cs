using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee:Person
    {
        public Employee(string name, string surname, byte age, int workingHour, int salaryOfHour) : base(name, surname, age)
        {
            this.WorkingHour = workingHour;
            this.SalaryOfHour = salaryOfHour;
        }
        private int _salaryOfHour;
        private int _workingHour;
        public int SalaryOfHour
        {
            get { return _salaryOfHour; }
            set
            {
                if (Age >= 18)
                {
                    if (WorkingHour * value * 30 > 250)
                    {
                        _salaryOfHour = value;
                    }
                }
            }
        }

        public int WorkingHour
        {
            get { return _workingHour; }
            set
            {
                if(Age>=18){
                    if (value <= 8)
                    {
                        _workingHour = value;
                    }
                }
            }
        }
        public void CalculateSalary()
        {
            if (Age >= 18)
            {
                Console.WriteLine($"Salary: {SalaryOfHour * WorkingHour * 30}");
            }
            else
            {
                Console.WriteLine("People Little than age 18 can't work!");
            }
        }
    }
}
