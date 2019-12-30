using System;
using System.Collections.Generic;
using Features.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            { 
                new Employee() { Id = 1, Name = "Outmane" }, 
                new Employee() { Id = 2, Name = "Hamza" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee() { Id = 3, Name = "Mehdi"}
            };

            Console.WriteLine(developers.Count());

            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }
        }
    }
}
