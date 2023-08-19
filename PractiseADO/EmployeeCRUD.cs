using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PractiseADO
{
   public  class EmployeeCRUD
    {


        public static void AddEmployee(Employee employee)
        {
            using (SqlConnection connect = new DBConnection().GetConnection()) 
            {
               // string query = "Insert into Employee values(@ID,@Name,@Location,@Salary)";

                using (SqlCommand cmd = new SqlCommand("InsertEmployees", connect))
                {
                    connect.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", employee.ID);
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Location", employee.Loctaion);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateEmployee(int id, string name)
        {
            using (SqlConnection connect = new DBConnection().GetConnection())
            {
                string query = "update Employee set Name = @name where ID = @id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                   

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteEmployee(int id)
        {
            using (SqlConnection connect = new DBConnection().GetConnection())
            {
                string query = "Delete from  Employee where @ID = id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();

                    cmd.Parameters.AddWithValue("@ID",id);
                   

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void DisplayEmployee()
        {
            using (SqlConnection connect = new DBConnection().GetConnection())
            {
                string query = "select *From Employee ";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();

                  SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                        int id = (int)reader["ID"];
                        string name = (string)reader["Name"];
                        string location = (string)reader["Location"];
                        double salary = (double)reader["Salary"];

                        Console.WriteLine($"Id:{id},Name:{name}, Location:{location},Salary:{salary}");

                        }

                   
                }
            }
        }
    }
}
