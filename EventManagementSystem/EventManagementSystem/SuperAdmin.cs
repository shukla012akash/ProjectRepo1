using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EventManagementSystem
{
    public class SuperAdmin
    {
        public static string sqlConnectionstr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog = EventManagement; Integrated Security = True";
        public string InsertSuperAdmin()
        {
            Console.WriteLine("Enter SuperAdmin Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter AdminId:");
            int AdminId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter SuperAdmin Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter role:");
            string role = Console.ReadLine();



            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand("Insert into SuperAdmin values(" + id + "," + AdminId + ",'" + name + "','" + role + "')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string UpdateSuperAdmin()
        {
            Console.Write("Update SuperAdmin ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("update AdminId: ");
            int adminID = Convert.ToInt32(Console.ReadLine());

            Console.Write("update SuperAdmin Name  : ");
            string name = Console.ReadLine();

            Console.Write("update role  : ");
            string role = Console.ReadLine();

            
            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);//connection establishment
            SqlCommand cmd = new SqlCommand("update SuperAdmin set SuperAdmin ID=" + ID + ",AdminId=" + AId + ",SuperAdmin Name ='" + name + "' where role='" + MainRole + "'", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }



    }
}

