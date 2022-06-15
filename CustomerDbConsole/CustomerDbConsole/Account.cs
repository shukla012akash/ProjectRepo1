using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDbConsole
{
    public class Account
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog=bankdb;Integrated Security=True";
        public string InsertAccount()
        {
            Console.WriteLine("Enter Account Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Account number:");
            int number = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Employee(" + id + ",'" + name + "'," + number + ")", sqlConnection);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
                return "not inserted";
            return "Inserted one row";
        }
        public string UpdateAccount()
        {
            Console.WriteLine("Enter Account Id to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Name to update:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Account number to update:");
            int number = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("update account set AccountName = '"+ name + "',Number = '" +number+ "' where AccId = '"+id+ "", sqlConnection);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
                return "not updated";
            return "";
        }
        public string SelectAccount()
        {
            return "";
        }
        public string SelectAccountById()
        {
            return "";
        }
    }
}
