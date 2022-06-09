using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[10];
            for(int i = 0; i< Array1.Length; i++)
            {
                Array1[i] = i;
            }
            Console.WriteLine("Array1 contain value are.");
            for(int i = 0; i<Array1.Length; i++)
            {
                Console.WriteLine(Array1[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine();

            string[] Namearray = { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine("value of NameArray are.");
            for (int i = 0; i<Namearray.Length; i++)
            {
                Console.Write(Namearray[i]+"  ");

            }
            Console.WriteLine();
            Console.WriteLine();

            string[] TrueandFalseArray = new string[10];
            for(int i = 0; i<TrueandFalseArray.Length; i++)
            {
                Console.WriteLine(TrueandFalseArray[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine();

            List<string> list = new List<string>();

            Console.WriteLine("Enter no of items you want to store");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the flavor name.");
                list.Add(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Size of the flavor list are:" + list.Count);

            //Removing item at index 2(3rd item in the list)
            list.RemoveAt(2);

            Console.WriteLine("List of Flavors are:");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Size of the flavor list after removing a item is:" + list.Count);

        }
    }
}

     
    

