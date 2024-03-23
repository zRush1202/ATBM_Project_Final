using System;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_NHOM12
{
    public class LoginProvider
    {
        public bool CheckLogin(string username, string password, string role)
        {
            try
            {
                string connectionString = "";
                if (role == "SYSDBA")
                    connectionString = @"DATA SOURCE = localhost:1521/XE;DBA Privilege=SYSDBA; USER ID=" + username + ";PASSWORD=" + password;
                else
                    connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=" + username + ";PASSWORD=" + password;

                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    if (role == "SYSDBA" || role == "ADMIN")
                    {
                        OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Connect với Oracle thành công");
                    }
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
