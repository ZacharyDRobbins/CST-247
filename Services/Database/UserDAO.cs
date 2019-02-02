using Milestone.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Milestone.Services.Database
{
    public class UserDAO
    {
        string dbconn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool findByUser(User user) {

            bool result = false;

            try
            {
                //prepare the SELECT statement
                string query = "SELECT * FROM dbo.Users WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD";
                using (SqlConnection cn = new SqlConnection(dbconn))
                using (SqlCommand cmd = new SqlCommand(query, cn))

                {
                    //set parameter values
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = user.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = user.Password;

                    //open connection then execute the SELECT statement and close the connection
                    cn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        result = true;
                    else
                        result = false;

                    cn.Close();
                }
                //return the result of findByUser
                return result;
            }
            catch (Exception e)
            {
                return result;
            }
        }

        public bool register(User user) {

            bool result = false;

            try
            {
                // prepare the INSERT statement
                string query = "INSERT INTO dbo.Users (USERNAME, PASSWORD) VALUES (@Username, @Password)";

                // Create connection and command
                using (SqlConnection cn = new SqlConnection(dbconn))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    //parameters values
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = user.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = user.Password;

                    // Open the connection and execute the insert method afterwards close the connection
                    cn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                        result = true;
                    else
                        result = false;
                    cn.Close();
                }

            }
            catch (SqlException e)
            {
           
                throw e;
            }

            // Return result of register
            return result;
        }
    }

    
}