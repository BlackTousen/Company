using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }
        public Employee(string fname, string lname)
        {
            _firstName = fname;
            _lastName = lname;
        }
        public string title { get; set; }

        public DateTime startDate { get; set; }


    }
}
