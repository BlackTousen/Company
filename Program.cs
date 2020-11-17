using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee jerry = new Employee("Jerry", "Robertson");
            jerry.title = "Manager";
            jerry.startDate = new DateTime(2017, 11, 22);
            Employee matt = new Employee("Matthew", "Goodman");
            matt.title = "Assistant Manager";
            matt.startDate = new DateTime(2017, 11, 22);
            Employee jas = new Employee("Jasmine", "Morello");
            jas.title = "Human Resources Manager";
            jas.startDate = new DateTime(2017, 11, 22);
            Company Goodwill = new Company("Goodwill", new DateTime(2017, 11, 22));
            Goodwill.AddEmployee(jerry);
            Goodwill.AddEmployee(matt);
            Goodwill.AddEmployee(jas);

            foreach (var person in Goodwill.employees)
            {
                Console.Write($@"
{person.FullName} works for {Goodwill.Name} as a {person.title} since {person.startDate.ToShortDateString()}.            
                ");
            }

        }
    }
}
