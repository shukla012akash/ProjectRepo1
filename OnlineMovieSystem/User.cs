using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnlineMovieSystem
{
    internal class User
    {

        string bookName;
        int bookId;
        string issueDate;
        public void AddMovieToTheBooking()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swObj = new StreamWriter(fileStreamObj);

            int counter = 1, totalMovie;
            Console.WriteLine("Enter total number Of movie you want to book in the booking system");
            totalMovie = Convert.ToInt32(Console.ReadLine());
            //streamWriterObj.WriteLine("BookId\tBookName\");

            while (counter <= totalMovie)
            {

                Console.WriteLine("Enter Book Id.");
                bookId = Convert.ToInt32(Console.ReadLine());
                swObj.Write(bookId + ",");

                Console.WriteLine("Enter book name.");
                bookName = Console.ReadLine();
                swObj.Write(bookName + ",");


                counter++;
            }
            swObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");

        }

        public void CustomerDetails(String customerName, int customerId, string bookingName)
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            streamWriterObj.Write(customerName + ",");

            streamWriterObj.Write(customerId + ",");

            streamWriterObj.Write(bookingName);

            issueDate = DateTime.Now.ToShortDateString();
            streamWriterObj.WriteLine(issueDate);

            streamWriterObj.Close();
            fileStreamObj.Close();

            Console.WriteLine("File write operation completed");
            //Here time to update the libraryin bookDetails.txt(Remaining books in library after giving to a user)
            UpdateBookingDetailFile(bookingName);


        }

        public void UpdateBookingDetailFile(string bookName)
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            FileStream fileStreamWObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamWObj);

            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] bookDataArr = line.Split(',');
                if (line.Contains(bookName))
                {
                    continue;

                }
                else
                {
                    for (int i = 0; i < bookDataArr.Length; i++)
                        streamWriterObj.Write(bookDataArr[i] + ", ");
                }
                streamWriterObj.Write("\n");
            }
            streamWriterObj.Close();
            streamReaderObj.Close();
            fileStreamWObj.Close();

            File.Delete(@"C: \Users\Boss\Desktop\New folder\file2.txt");
            File.Move(@"C:\Users\Boss\Desktop\console\ConsoleApp\LibraryManagment\LibraryManagment", @"C:\Users\Boss\Desktop\New folder\file2.txt");

        }

        public void ShowAvailableMovieInBooking()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\file2.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("BookingId\tBookingName\tBookingOwner");
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] bookDataArr = line.Split(',');

                for (int i = 0; i < bookDataArr.Length; i++)
                {
                    Console.Write(bookDataArr[i] + "\t");
                    if (i == 1)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("");
            }
            streamReaderObj.Close();
            fileStreamObj.Close();
        }




    }
}

