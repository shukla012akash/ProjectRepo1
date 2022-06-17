using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EventManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            Console.WriteLine("---------------WELCOME TO EVENT MANAGEMENT SYSTEM---------------");
            Console.WriteLine("Please log in into any of the following account:");
            Console.WriteLine("Press 1 for. Event");
            Console.WriteLine("Press 2 for. Admin");
            Console.WriteLine("Press 3 for. SuperAdmin");
            Console.WriteLine("Press 4 for. Customer");
            Console.WriteLine("");
            Console.ReadLine();



            //SuperAdmin superAdmin = new SuperAdmin();
            //string a = superAdmin.InsertSuperAdmin();
            //Console.WriteLine(a);
            //Console.ReadLine();
            //string b = superAdmin.UpdateSuperAdmin();
            //Console.WriteLine(b);
            //Console.ReadLine();

            //Admin admin = new Admin();
            //string b = admin.InsertAdmin();
            //Console.WriteLine(b);
            //Console.ReadLine();
            //admin.DisplayAllBookings();
            //admin.InsertFoodItems();
            //Console.ReadLine();


            //Event obj = new Event();
            //string c = obj.InsertEvent();
            //Console.WriteLine(c);
            //Console.ReadLine();
            //string b = obj.UpdateEvent();
            //Console.WriteLine(b);
            //Console.ReadLine();


            //CustomerDetail obj1 = new CustomerDetail();
            //string d = obj1.CustomerDetails();
            //Console.WriteLine(d);
            //Console.ReadLine();
            //string e = obj1.UpdateCustomerDetail();
            //Console.WriteLine(e);
            //Console.ReadLine();



        }
    }
}      

