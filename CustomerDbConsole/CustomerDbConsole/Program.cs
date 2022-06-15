using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDbConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerData customerData = new CustomerData();
            //string a = customerData.InsertCustomer();
            //string b = customerData.UpdateCustomer();
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            Console.ReadLine();
            Console.ReadLine();

            //select query
            //DataTable dt = customerData.SelectCustomers();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Rows[i].Rows.Count; j++)
            //    {
            //        Console.Write(dt.Rows[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.ReadLine();

                //update
                //customerData.UpdateCustomer();

                //Delete
                ///customerData.DeleteInCustomer(1);

                //select by custId
                //DataTable dt1 = customerData.SelectCustomerByCustomerId(101);
                //for (int i = 0; i < dt1.Rows.Count; i++)
                //{
                //    Console.WriteLine(dt1.Rows[i][j] + "\t");
                //}
                //Console.WriteLine();
                //Console.ReadLine();

                // Employeecs employee = new Employeecs();
                //string f = employee.InsertEmployee();
                //Console.WriteLine(f);
                //Console.ReadLine();
                // string g = employee.UpdateEmployee();
                // Console.WriteLine(g);
                //  Console.ReadLine();

                // Account account = new Account();
                //string c = account.InsertAccount();
                //Console.WriteLine(c);       
                //Console.ReadLine();
                // string h = account.UpdateAccount();
                // Console.WriteLine(h);
                //   Console.ReadLine();


            
        }
    }
}
