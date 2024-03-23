using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_NHOM12.Forms
{
    public partial class Add_Role : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public Add_Role()
        {
            InitializeComponent();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string query = "alter session set \"_ORACLE_SCRIPT\" = true";
            string query2 = $"create role {tbxRoleName.Text.Trim()}";
            string query3 = "alter session set \"_ORACLE_SCRIPT\" = false";
            try
            {
                OracleCommand command = new OracleCommand();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();
                command.CommandText = query2;
                command.ExecuteNonQuery();
                command.CommandText = query3;       
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm vai trò thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating role: " + ex.Message);
            }
            this.Close();
        }
    }
}
