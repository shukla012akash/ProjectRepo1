using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EventManagementSystem
{
    public class Admin
    {
        public static string sqlConnectionstr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog = EventManagement; Integrated Security = True";

        public string InsertAdmin()
        {
            Console.WriteLine("Enter Admin Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Admin Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Event name:");
            string eventname = Console.ReadLine();
            Console.WriteLine("Enter eventid:");
            int eventid = Convert.ToInt32(Console.ReadLine());


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand("Insert into Admint values(" + id + ",'" + name + ",'"+eventname+"'," + eventid + ")", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        
        
        public void DisplayAllBookings()
        {
            Admin obj = new Admin();
            DataTable dt = obj.ShowAllBookings();
            Console.WriteLine("CustomerID\tCustomerName\tCustomerAddress\tEventName\t EventCost\ttotalperson\tStatus");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {

                    if (j == dt.Columns.Count - 2)
                        Console.Write(dt.Rows[i][j] + "\t\t");
                    else
                        Console.Write(dt.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public DataTable ShowAllBookings()
        {
            #region disconnected-mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);//connection stablishmentg
            SqlDataAdapter sda = new SqlDataAdapter("select* from CustomerDetail ", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            #endregion
        }
        public void InsertFoodItems()
        {
            Console.WriteLine("Enter Food Item Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Food Item name: ");
            string name = (Console.ReadLine());

            Console.Write("Enter Food item types Cost: ");
            int cost = Convert.ToInt32(Console.ReadLine());

            //insert into db
            #region connected-mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);//connection stablishmentg
            SqlCommand cmd = new SqlCommand("insert into FoodItem values("+id+",'" + name + "'," + cost + ")", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            #endregion
        }

    }
}
