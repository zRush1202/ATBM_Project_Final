using System;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_NHOM12
{
    public class LoginProvider
    {
        public static OracleConnection conn = new OracleConnection();
        public bool CheckLogin(string username, string password, string role)
        {
            try
            {
                string connectionString = "";
                if (role == "SYSDBA")
                    connectionString = @"DATA SOURCE = localhost:1521/XE;DBA Privilege=SYSDBA; USER ID=" + username + ";PASSWORD=" + password;
                else
                    connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=" + username + ";PASSWORD=" + password;
                conn.ConnectionString = connectionString;
                conn.Open();
                
                if (role == "SYSDBA" || role == "ADMIN")
                {
                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", conn);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Connect với Oracle thành công");
                }
                return true;
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

}
