//connected model
//How to connect database to console app
//how to read data from database
//CRUD operations using sql in connected model (database)

using Microsoft.Data.SqlClient;
namespace lecture21
{
    class program
    {
        static void Main(String[] args)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Record;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "Select * from Donor";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dr.GetValue(0);
                Console.WriteLine($"id: {dr.GetValue(0)}, Name: {dr[1]}, Age: {dr[2]}");
            }
            con.Close();
        }
    }

}



namespace Lecture22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            Console.WriteLine(b.ToString());
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyNewDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conString);
            Console.Write("Enter User Name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter Password");
            string pwd = Console.ReadLine();

            string q1 = "insert into Users(UserName, Password) values('admin','123')";
            string q2 = $"insert into Users(UserName, Password) values('{userName}','{pwd}')";
            string q3 = $"Update  Users set Password ='{pwd}' where username  = '{userName}'";
            string q4 = $"delete from  Users where username  = '{userName}'";
            SqlCommand cmd = new SqlCommand(q1, connection);
            connection.Open();
            int insertedRows = cmd.ExecuteNonQuery();
            if (insertedRows >= 1)
            {
                Console.WriteLine("row inserted/updated/deleted");
            }
            else
            {
                Console.WriteLine("failed");
            }
            connection.Close();
        }
    }
}