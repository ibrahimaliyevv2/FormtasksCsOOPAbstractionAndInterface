using System;
using Models;

namespace EmployeeAndStudent
{
    class Program
    { 
        static void Main(string[] args)
        {
            Employee employee = new Employee("Qezenfer", "Abbdullayev", 12, 17, 150);
            employee.CalculateSalary();
            Student student = new Student("Fazil", "Israfilov", 10, 100, 155);
            student.ExamResult();
        }
    }
}
