using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDbConsole
{
    public class CustomerData
    {
        public static string sqlConnectionstr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog=bankdb;Integrated Security=True";
        public string InsertCustomer()
        {
            Console.WriteLine("Enter Customer Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Customer email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Customer mobile:");
            int mobile = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer address:");
            string address = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand("Inset into Customer values(" + id + ",'" + name + ",'" + email + "','" + mobile + "','" + address + "')",sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string UpdateCustomer()
        {
            return "";
        }
        public string DeleteCustomer()
        {
            return "";
        }
        public string SelectCustomer()
        {
            return "";
        }
        public string SelectCustomerById()
        {
            return "";
        }
    }
}
