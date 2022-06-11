using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflectionhandson
{
    internal class Student
    {
       public int RollNo
        {
            get; set;
        }
        public string Name
        { get; set; }

        // no argument
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        // parameter constructor
        public Student(int rno, string n)
        {
            RollNo = rno;
            Name = n;

        }
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}",RollNo);
            Console.WriteLine("Name : {0}",Name);
        }
    }
}

