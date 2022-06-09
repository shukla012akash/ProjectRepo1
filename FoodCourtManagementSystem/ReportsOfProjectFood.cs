using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagementSystem
{
    internal class ReportsOfProjectFood
    {
        public void performAction()
        {
        upper:
            menu();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Item(@"C:\Users\Boss\Desktop\New folder\fooditem.txt");
                    goto upper;
                case 2:
                    Item(@"C:\Users\Boss\Desktop\New folder\category.txt");
                    goto upper;
                case 3:
                    Item(@"C: \Users\Boss\Desktop\New folder\sales.txt");
                    goto upper;
                case 4:
                    break;
                default:
                    Console.WriteLine("Wrong Choice ");
                    goto upper;

            }


        }

        private void Item(string v)
        {
            throw new NotImplementedException();
        }

      
        private void menu()
        {
            Console.WriteLine("Press 1 for: The Show Reports Of FoodItems ");
            Console.WriteLine("Press 2 for:  The Show Reports of food category ");
            Console.WriteLine("Press 3 for:  The Show Reports of sales");

            Console.WriteLine("Press 4 : Goto OutSide");
            Console.Write("                             ");
        }
    }
}
