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
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
                return "not inserted";
                return "Inserted one row";
        }
        public string UpdateEmployee()
        {
            Console.WriteLine("Enter Employee Id to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name to update:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Mobile to update:");
            int mobile = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand(" update Employee set EmpName = '"+name+"',Mobile = '"+mobile+"'where EmpId = "+id + "", sqlConnection);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
                return "not updated";
            return "";
        }
        public string DeleteEmployee()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Employee where empid=" + Empid, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
            
        }
        public DataTable SelectEmployee()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Customer", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
        public DataTable SelectEmployeeById()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Employee where Empid=" + empId, sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }
}
