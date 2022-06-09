using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDbConsole
{
    public class Employeecs
    {
        public static string sqlConnectionstr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog=bankdb;Integrated Security=True";

        public string InsertEmployee()
        {
            Console.WriteLine("Enter Employee Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Mobile:");
            int mobile = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand("insert into Employee(" + id + ",'" + name + "'," + mobile + ")", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
                return "Inserted one row";
        }
        public string UpdateEmployee()
        {
            return "";
        }
        public string SelectEmployee()
        {
            return "";
        }
        public string SelectEmployeeById()
        {
            return "";
        }
    }
}
