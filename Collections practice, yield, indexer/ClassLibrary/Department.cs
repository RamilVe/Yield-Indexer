using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {
        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;

        List<Employee> _employees = new List<Employee>();

        public List<string> ExamSubjects
        {
            get
            {
                List<string> list = new List<string>();
                foreach (Employee item in _employees)
                    list.AddRange(list);

                return list;
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (!_employees.Contains(employee))
                _employees.Add(employee);
        }
    }
}
