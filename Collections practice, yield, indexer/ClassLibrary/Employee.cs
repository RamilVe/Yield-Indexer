using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;
        
        public double Salary
        {
            get => _salary;
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (StartWithUpper(value) && HasLetter(value))
                    _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (StartWithUpper(value) && HasLetter(value))
                    _surname = value;
            }
        }

        public bool StartWithUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[0]))
                    return true;
            }
            return false;
        }

        public bool HasLetter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }
    }
}
