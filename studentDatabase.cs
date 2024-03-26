using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace StudentManagementApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string connectionString = "Data Source= DESKTOP-C3E8P2C; database=StudentDatabase; Integrated Security=true";
            //insert student
             InsertStudent(connectionString, 1, "anu", "renj", 25);
            // UpdateStudent(connectionString, 1, 21);
            //ViewAllStudents(connectionString);
            //DeleteStudents(connectionString, 1);


        }
        // TASK 1

        static void InsertStudent(string connectionString, int studentID, string firstName, string lastName, int age)
        {
           using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (StudentID, FirstName, LastName, Age) VALUES (@StudentID, @FirstName, @LastName, @Age)";
                SqlCommand command = new SqlCommand(query, connection);
               command.Parameters.AddWithValue("@StudentID", studentID);
               command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Age", age);

               connection.Open();
                command.ExecuteNonQuery();
            }

        }

        //update student

        // static void UpdateStudent(string connectionString, int studentID, int newAge)
        // {
        //using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //          string query = "UPDATE Students SET Age = @NewAge WHERE StudentID = @StudentID";
        //         SqlCommand command = new SqlCommand(query, connection);
        //          command.Parameters.AddWithValue("@NewAge", newAge);
        //         command.Parameters.AddWithValue("@StudentID", studentID);

        //        connection.Open();
        //        command.ExecuteNonQuery();
        //     }
        //  }

        //view all

        //static void ViewAllStudents(string connectionString)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT * FROM Students";
        //        SqlCommand command = new SqlCommand(query, connection);

        //        connection.Open();
        //       using SqlDataAdapter adapter = new SqlDataAdapter(command);
        //        {
        //            DataTable dt= new DataTable();
        //            adapter.Fill(dt);
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                Console.WriteLine($"StudentID: {row["StudentID"]}, FirstName: {row["FirstName"]}, LastName: {row["LastName"]}, Age: {row["Age"]}");
        //            }
        //        }
        //    }
        //}

        // delete student

        //static void DeleteStudents(string connectionString,int StudentID)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "DELETE FROM Students WHERE StudentID = @StudentID";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@StudentID", StudentID);

        //       connection.Open();
        //       command.ExecuteNonQuery();



        //    }

    }
}

    
