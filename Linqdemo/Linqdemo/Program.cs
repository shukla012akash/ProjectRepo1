using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empList = new List<Employee>(
                new Employee[]
                {
                    new Employee {Id = 1,Name = "Akash", Age = 30},
                    new Employee {Id = 2,Name = "Anush", Age = 26},
                    new Employee {Id = 3,Name = "Mohit", Age = 34},
                    new Employee {Id = 4,Name = "Vikas", Age = 22},
                });
            var lst = from e in empList
                      where e.Age > 27
                      select new { e.Name };
            foreach (var emp in lst)
                Console.WriteLine(emp.Name);
            Console.ReadLine();
        }
    }
}
