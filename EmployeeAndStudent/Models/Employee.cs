using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee:Person
    {
        public Employee(string name, string surname, byte age, double salaryPerHour, int workingHour):base(name, surname, age)
        {
            this.SalaryPerHour = salaryPerHour;
            this.WorkingHour = workingHour;
        }

        public double SalaryPerHour { get; set; }
        public int WorkingHour { get; set; }
        public double CalculateSalary()
        {
            return 30 * WorkingHour * SalaryPerHour;
        }
    }
}
