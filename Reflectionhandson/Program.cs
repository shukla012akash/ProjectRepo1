using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflectionhandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            Type type = typeof(Student);
            var member = type.GetMembers();
            Console.WriteLine($"Following {member.Count()} members are available for Student :");
            foreach (var member2 in member)
            {
                Console.WriteLine($"(member");
            }
            Console.WriteLine();
            var prop = type.GetProperties();
            Console.WriteLine($"Following {prop.Count()} properties are available for Student :");
            foreach (var prop2 in prop)
            {
                Console.WriteLine(prop);
            }
            Console.WriteLine();
            var method = type.GetMethods();
            Console.WriteLine($"Following {method.Count()} method are available for Student :");
            foreach (var method2 in method)
            {
                Console.WriteLine(method);
            }
            Console.WriteLine();
        }
    }
}
            
          
