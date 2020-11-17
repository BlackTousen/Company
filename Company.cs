using System;
using System.Collections.Generic;


namespace classes
{
    public class Company
    {
        private string _name { get; set; }
        private DateTime _founded { get; set; }
        public List<Employee> employees = new List<Employee>();
        public Company(string name, DateTime date)
        {
            _name = name;
            _founded = date;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public DateTime Established
        {
            get
            {
                return _founded;
            }
        }
        public void AddEmployee(Employee person)
        {
            employees.Add(person);
        }

    }
}
