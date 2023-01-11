using System;
using ClassLibrary;
namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            department.AddEmployee(new Employee() { Name = "Abbas", Surname = "Abbasov", Salary = 250 });
            department.AddEmployee(new Employee() { Name = "Hikmet", Surname = "Abbasov", Salary = 500 });
            department.AddEmployee(new Employee() { Name = "Abbas", Surname = "Abbasov", Salary = 120 });

        }
    }
}
