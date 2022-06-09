using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CustomerLibraryAuthor
{
    internal class Author
    {
        public static string sqlConnectionstr = @"Data Source=DESKTOP-0LKSRK2;Initial Catalog=library;Integrated Security=True";
        public string InsertAuthor()
        {
            Console.WriteLine("Enter the Authorid:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Authorname:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Authornumber:");
            int number = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionstr);
            SqlCommand cmd = new SqlCommand("insert into Author values(" + id + ",'" + name + "'," + number + ")", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        public string UpdateBook()
        {
            return "";
        }
        public string SelectBook()
        {
            return "";
        }
        public string DeleteBook()
        {
            return "";
        }
        public string SelectById()
        {
            return "";
        }
    }
}

