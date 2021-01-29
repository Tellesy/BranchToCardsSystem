using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database
{
    public class User
    {
        public static Status addUser(int privilege,int EmployeeID, int branch, string username, string password, string name)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[Users]
                                                   ([Username]
                                                   ,[Password]
                                                   ,[Employee]
                                                   ,[Active]
                                                   ,[LIB_ID]
                                                   ,[Role]
                                                   ,[Branch])
                       VALUES (@v1, @v2, @v3,@v4,@v5,@v6,@v7)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", username);
                    cmd.Parameters.AddWithValue("@v2", password);
                    cmd.Parameters.AddWithValue("@v3", name);
                    cmd.Parameters.AddWithValue("@v4", 1);
                    cmd.Parameters.AddWithValue("@v5", EmployeeID);
                    cmd.Parameters.AddWithValue("@v6", privilege);
                    cmd.Parameters.AddWithValue("@v7", branch);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to Add User\n" + Errors.ErrorsString.Error002 + "\n" + e;
                    conn.Close();
                    return status;
                }
            }
            else
            {
                conn.Close();
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                return status;
            }
        }
    }
}
