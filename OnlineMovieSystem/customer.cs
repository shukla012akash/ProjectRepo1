using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnlineMovieSystem
{
    internal class customer
    {
        public string userName, bookName;
        public int userId;
        // DateTime issueDate;

      
        public void BorrowBook()
        {
            Console.WriteLine("Enter Your name");
            userName = Console.ReadLine();

            Console.WriteLine("Enter Your borrower Id");
            userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the book name you want to borrow.");
            bookName = Console.ReadLine();

            
        }

        public void StoreInventoryDetails( int userId)
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Open, FileAccess.Read);
            FileStream fileStreamWObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Append, FileAccess.Write);

            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamWObj);

           
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] borrowerArr = line.Split(',');
                DateTime dt2 = Convert.ToDateTime(borrowerArr[3]);


                if (borrowerArr[1] == Convert.ToString(userId))
                {
                   
                    

                    streamWriterObj.Write(borrowerArr[1] + ",");
                    streamWriterObj.Write(borrowerArr[0] + ",");
                   
                    //Console.WriteLine(borrowerArr[1] + "\t" + borrowerArr[0] + "\t" + rentPeriod * 15);
                }


            }
            streamWriterObj.Close();
            streamReaderObj.Close();
            fileStreamObj.Close();
        }
        public void ShowInventoryDetails()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("UserId\tuserName\tAmount");

            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] dataArr = line.Split(',');
                for (int i = 0; i < dataArr.Length; i++)
                {
                    Console.Write(dataArr[i] + "\t");
                    if (i == 1)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            streamReaderObj.Close();
            fileStreamObj.Close();

        }
    }
}

