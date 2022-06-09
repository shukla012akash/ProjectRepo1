using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FoodCourtManagementSystem;

namespace FoodCourtManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("---------------Welcome To The Food Court Management System-----------------");
            Console.WriteLine("Please log in into an one of following account");
            Console.WriteLine("Press 1 for ManageFoodItems.ManageFoodItem");
            Console.WriteLine("Press 2 for ManageFoodCategory.ManageFoodCategory");
            Console.WriteLine("Press 3 for ManageSales.ManageSales");
            Console.WriteLine("Press 4 for ReportsOfProjectFood.ReportsOfProjectFood");
            Console.WriteLine(" ");

            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("--------WELCOME TO THE MANAGE FOOD ITEMS---------");
                    Console.WriteLine();
                    Console.WriteLine("Please choose one of the following action:");
                    Console.WriteLine("a.Add a item in the Manage Food Item.");
                    Console.WriteLine("b.Update a item in the Manage Food Item.");
                    Console.WriteLine("c.Available a item in the Manage Food Item.");
                    int choice1 = Convert.ToChar(Console.ReadLine());
                    switch (choice1)
                    {
                        case 'a':
                            Console.WriteLine("");
                            Item.Additemtothemanagefooditem();

                            break;
                        case 'b':
                            Console.WriteLine("");
                            Item.ShowAvailableItem();

                            break;
                    }
                    break;
                case 2:
                            Console.WriteLine("--------WELCOME TO THE MANAGE FOOD CATEGORY---------");
                            Console.WriteLine();
                            Console.WriteLine("Please choose one of the following action:");
                            Console.WriteLine("a.Add a item in the Manage Food Category.");
                            Console.WriteLine("b.Update a item in the Manage Food Category.");
                            Console.WriteLine("c.Available a item in the Manage Food Category.");
                            int choice2 = Convert.ToChar(Console.ReadLine());
                    switch (choice2)
                    {
                        case 'a':
                            Console.WriteLine("");
                            Item.Additemtothemanagefooditem();

                            break;
                        case 'b':
                            Console.WriteLine("");
                            Item.ShowAvailableItem();

                            break;
                    }
                    break;
                case 3:

                                    Console.WriteLine("--------WELCOME TO THE MANAGE SALES ITEMS---------");
                                    Console.WriteLine();
                                    Console.WriteLine("Please choose one of the following action:");
                                    Console.WriteLine("a.Add a item in the Manage Sales Item.");
                                    Console.WriteLine("b.Update a item in the Manage Sales Item.");
                                    Console.WriteLine("c.Available a item in the Manage Sales Item.");
                                    int choice3 = Convert.ToChar(Console.ReadLine());
                    switch (choice3)
                    {
                        case 'a':
                            Console.WriteLine("");
                            Item.Additemtothemanagefooditem();

                            break;
                        case 'b':
                            Console.WriteLine("");
                            Item.ShowAvailableItem();

                            break;
                    }
                    break;
                        case 4:

                                            Console.WriteLine("--------WELCOME TO THE REPORTS OF PROJECT FOOD ITEMS---------");
                                            Console.WriteLine();
                                            Console.WriteLine("Please choose one of the following action:");
                                            Console.WriteLine("a.Report of all food Item.");
                                            Console.WriteLine("b.Report of all food category  Item.");
                                            Console.WriteLine("c.Report of all Sales Item.");
                                            int choice4 = Convert.ToChar(Console.ReadLine());
                                            switch (choice4)
                                            {
                                                case 'a':
                                                    Console.WriteLine("");
                                                    Item.Additemtothemanagefooditem();

                                                    break;
                                                case 'b':
                                                    Console.WriteLine("");
                                                    Item.ShowAvailableItem();

                                                    break;
                                            }
                    break;
                                            
                                    }
                                    
                            }
                            
                    }

            }
        
        
    

    internal class Item
    {
        internal static void Additemtothemanagefooditem()
        {
            throw new NotImplementedException();
        }

        internal static void ShowAvailableItem()
        {
            throw new NotImplementedException();
        }
    }

    

