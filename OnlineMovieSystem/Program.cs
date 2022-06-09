using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------WELCOME TO Online Movie Booking SYSTEM---------------");
            Console.WriteLine("Please log in into any of the following account:");
            Console.WriteLine("Press 1 for Customer. Customer");
            Console.WriteLine("Press 2 for Administrator. Administrator");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());
            User movie = new User();
          

            switch (choice)
            {
                case 1:
                    Console.WriteLine("---------------WELCOME TO CUSTOMER PORTAL---------------");
                    Console.WriteLine("");
                    Console.WriteLine("Please choose one of the following action:");
                    Console.WriteLine("a. Add a Movie in the Booking System.");
                    Console.WriteLine("b. Show the current available Movie in the Booking System.");
                    Console.WriteLine("c. Show current inventory details.");
                    char choice1 = Convert.ToChar(Console.ReadLine());
                    switch (choice1)
                    {
                        case 'a':
                            Console.WriteLine("");
                            movie.AddMovieToTheBooking();

                            break;
                        case 'b':
                            Console.WriteLine("");
                            movie.ShowAvailableMovieInBooking();

                            break;
                       
                    }
                    break;
                case 2:
                    Console.WriteLine("\t\t---------------WELCOME TO ADMINISTRATOR PORTAL---------------\t\t");
                    Console.WriteLine("");
                    Console.WriteLine("Please choose one of the following action:");
                    Console.WriteLine("a. Borrow a movie ticket from the bookinglist.");
                    Console.WriteLine("b. See currently available movie ");
                    char choice2 = Convert.ToChar(Console.ReadLine());
                    switch (choice2)
                    {
                        case 'a':
                            Console.WriteLine("");
                              movie.AddMovieToTheBooking();

                            break;
                        case 'b':
                            movie.ShowAvailableMovieInBooking();
                            break;
                    }
                    break;
            }
        }
    }

        }
    

