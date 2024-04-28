using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_NHOM12
{
    public class LoginProvider
    {
        public string userRole = "";
        public string username = "";
        public static OracleConnection conn = new OracleConnection();

        public bool CheckLogin(string inputUsername, string inputPassword, string inputRole)
        {
            try
            {
                string connectionString;
                if (inputRole == "SYSDBA")
                {
                    connectionString = $"DATA SOURCE = localhost:1521/ATBM_PROJECTFINAL; DBA Privilege=SYSDBA; USER ID={inputUsername}; PASSWORD={inputPassword}";
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    this.userRole = inputRole;
                    this.username = inputUsername;
                    return true;
                }
                else if (inputRole == "ADMIN")
                {
                    if (inputUsername != "ADPRO") return false;
                    connectionString = $"DATA SOURCE = localhost:1521/ATBM_PROJECTFINAL; USER ID={inputUsername}; PASSWORD={inputPassword}";
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    this.userRole = inputRole;
                    this.username = inputUsername;
                    return true;
                }
                else 
                {
                    if (inputRole == "ADMIN" || inputUsername == "ADPRO")
                    {
                        return false;
                    }

                    connectionString = $"DATA SOURCE = localhost:1521/ATBM_PROJECTFINAL; USER ID={inputUsername}; PASSWORD={inputPassword}";
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    try
                    {
                        string query = "SELECT granted_role FROM user_role_privs WHERE username = USER";
                        OracleCommand cmd = new OracleCommand(query, conn);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            userRole = result.ToString();
                            this.username = inputUsername;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (OracleException ex)
                    {
                        Console.WriteLine(ex.Message);
                        conn.Close();
                        return false;
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }
    }
}
