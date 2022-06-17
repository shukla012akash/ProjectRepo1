using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EventManagementSystem
{
    public class Event
    {
        public static string sqlConnectionstr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog = EventManagement; Integrated Security = True";

        public string InsertEvent()
        {
            Console.WriteLine("Enter Event Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Event Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Event address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Event Cost:");
            string cost = Console.ReadLine();



            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand("Insert into Eventt values("+id+",'"+name+"','"+address+"','"+cost+"')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string UpdateEvent()
        {
            return "";
        }
        public string UpdateEvent()
        {
            Console.Write("Update Event ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("update Event Name: ");
            string name = Console.ReadLine();

            Console.Write("update Event address  : ");
            string address = Console.ReadLine();

            Console.Write("update Event Cost  : ");
            string cost = Console.ReadLine();


            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);//connection establishment
            SqlCommand cmd = new SqlCommand("update SuperEventt set Event ID=" + ID + ",EventName='" +EName + "',EventAddress ='" + addres + "' where eventcost=" + cost + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }


}
}
