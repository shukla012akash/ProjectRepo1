using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibraryAuthor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book();
            //string a = book.InsertBook();
           
            //Console.WriteLine(a);
            //Console.ReadLine();

            Author author = new Author();
            string b = author.InsertAuthor();
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
