using System;
using System.Collections.Generic;
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
            string a = customerData.InsertCustomer();
            Console.WriteLine(a);
            Console.ReadLine();
            Employeecs employee = new Employeecs();
            string b = employee.InsertEmployee();
            Console.WriteLine(b);
            Console.ReadLine();
            Account account = new Account();
            string c = account.InsertAccount();
            Console.WriteLine(c);       
            Console.ReadLine();
        }
        
    }
}
