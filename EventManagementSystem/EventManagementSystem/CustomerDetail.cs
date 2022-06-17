using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EventManagementSystem
{
    public class CustomerDetail
    {
        public static string sqlConnectionstr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog = EventManagement; Integrated Security = True";
        public string CustomerDetails()
        {
            Console.WriteLine("Enter Customer Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Customer address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Event name:");
            string eventname = Console.ReadLine();
            Console.WriteLine("Enter Event Cost:");
            int cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total person:");
            int person = Convert.ToInt32(Console.ReadLine());




            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand("Insert into CustomerDetail values(" + id + ",'" + name + "','" + address + "','" + eventname + "'," + cost + "," + person + ")", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string UpdateCustomerDetail()
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
            SqlCommand cmd = new SqlCommand("update CustomerDetail set SuperAdmin ID=" + ID + ",AdminId=" + AId + ",SuperAdmin Name ='" + name + "' where role=" + MainRole + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }
    }

   


}

        
       

      
               

        


 
        
     
      

        

    

