using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Linqhandson
{
    public class Class1
    {
        public void Data()
        {
            int[] n1 =
        {
                1,3,-2,-4,-7,-3,-8,12,19,6,9,10,14
            };
            Console.WriteLine("Find the positive number:");
            var nQuery =
                from VrNum in n1
                where VrNum > 0
                where VrNum < 14
                select VrNum;
            Console.WriteLine("The numbers within the range of 1 to 14 are:");
            foreach (var VrNum in nQuery)
            {
                Console.WriteLine("{0} ", VrNum);
            }
        }
    }
    class Linq2
    {
        public void Datas()

        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
            Console.Write("---------------------------------------------------------------------\n");
            Console.Write("The numbers in the array  are : \n");
            Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

            var n = from x in arr1
                    group x by x into y
                    select y;
            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
            Console.WriteLine("\n");
        }
    }
    // STARTS AND END WITH SPECIFIC CHARACTER   
    class Linq3
    {
        public void Datas1()
        {
            string chst, chen;
            char ch;
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };
            Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            Console.Write("\n-----------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");
            Console.Write("\nInput starting character for the string : ");
            ch = (char)Console.Read();
            chst = ch.ToString();
            Console.Write("\nInput ending character for the string : ");
            ch = (char)Console.Read();
            chen = ch.ToString();
            var _result = from x in cities
                          where x.StartsWith(chst)
                          where x.EndsWith(chen)
                          select x;
            Console.Write("\n\n");
            foreach (var city in _result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
            }
            Console.ReadLine();
        }
    }
    //PRINT TOP NTH RECORDS
    class Linq4
    {


        public void Datas2()
        {
            int[] number = new int[] { 5, 7, 13, 24, 6, 9, 8, 7 };
            var topNth = number.OrderByDescending(n => n);
            Console.WriteLine(" top "  + "  number are ...");
            foreach (var num in topNth)
            {
                Console.WriteLine(num);
            }

        }

    }

    // MAXIMUM GRADE POINT

    class Linq5
    {
        public static void Datas3()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            //Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : 3 
            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  :");
            int nthGrPoints = Convert.ToInt32(Console.ReadLine());

            var res = (from stulistitems in stulist
                       orderby stulistitems.GrPoint descending
                       group stulistitems.GrPoint by stulistitems.GrPoint
                       ).ToList();


            var list = res[nthGrPoints - 1];

            List<Students> result = new List<Students>();

            foreach (var item in list)
            {
                result = (from stulistitems in stulist
                          where stulistitems.GrPoint == item
                          select stulistitems).ToList();
            }
            foreach (var resultitem in result)
            {
                Console.WriteLine($"id: {resultitem.StuId} name: {resultitem.StuName} Achived grade points: {resultitem.GrPoint}");
            }


            Console.WriteLine();

        }
    }

    internal class Students
    {
        public int StuId { get; internal set; }
        public string StuName { get; internal set; }
        public int GrPoint { get; internal set; }
    }

    // LASTNAME STARTS WITH D

    class Linq6
    {
        public static void Datas4()
        {
            var people = new List<Person>()
        {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","DeLauter", 84 ),
            new Person("Gail","Dawson", 19 ),

        };
            Console.Write("Enter a character to fine all lastname which start from that character: ");
            String s = Console.ReadLine();
            var res = (from peopleItem in people
                    
                       select peopleItem.Lname).ToList();
            foreach (var resultitem in res)
            {
                Console.WriteLine(resultitem);
            }

            //8.	Number of people whose last name starts with the letter D
            Console.WriteLine($"Number of people whose name startswith {s} are: {res.Count()}");

            //query
            //9.	Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name
            var resdescName = (from peopleItem in people
                               where peopleItem.Age > 40
                               orderby peopleItem.Lname descending
                               select peopleItem.Fname).ToList();


            foreach (var resultitem in resdescName)
            {
                Console.Write($"{resultitem}, ");
            }

        }

    }

    internal class Person
    {
        public Person(string v1, string v2, int v3)
        {
        }

        public object Lname { get; internal set; }
        public int Age { get; internal set; }
        public object Fname { get; internal set; }
    }

    // STARTS WITH LETTER L

    class Linq7
    {
        public static void Datas5()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var outputList = (from froutList in fruits
                              where froutList.StartsWith("L")
                              select froutList).ToList();
            Console.WriteLine("words in the collection that start with the letter 'L'");
            foreach (var resultitem in outputList)
            {
                Console.Write($"{resultitem}, ");
            }
            Console.WriteLine("");

        }
    }

    //print MULTIPLE OF 4 & 6

    class Linq8
    {
        public static void Datas6()
        {
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var res = (from item in mixedNumbers
                       where item % 4 == 0 && item % 6 == 0
                       select item).ToList();

            Console.WriteLine("The following numbers are multiples of 4 or 6:");
            foreach (var resultitem in res)
            {
                Console.Write($"{resultitem}, ");
            }
            Console.WriteLine();

        }

    }

    
}



