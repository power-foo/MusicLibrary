using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MusicLibrary
{
    // Tri Le
    public class VerifyUser
    {
        private String connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=MusicLibrary.accdb";

        // Method for Logging In
        public bool Login(User user)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString)) 
            {
                try
                {
                    conn.Open();

                    String strQuery = "SELECT * FROM Users WHERE UserName = ? AND UserPassword = ?";

                    using (OleDbCommand cmd = new OleDbCommand(strQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.Read();
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        // Method for registering a new User
        public bool Register(User user)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    String checkQuery = "SELECT * FROM Users WHERE UserName = ?";

                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserName", user.UserName);

                        using (OleDbDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return false; // If the User already exists
                            }
                        }
                    }

                    // Adding a new User
                    String insertQuery = "INSERT INTO Users (UserName, UserPassword) VALUES (?, ?)";

                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@UserName", user.UserName);
                        insertCmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                        insertCmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
