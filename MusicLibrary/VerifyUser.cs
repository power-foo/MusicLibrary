using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MusicLibrary
{
    public class VerifyUser
    {
        private String connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=MusicLibrary.accdb";

        // Method for the log-in
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
    }
}
