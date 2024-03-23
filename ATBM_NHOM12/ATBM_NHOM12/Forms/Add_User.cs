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
    public partial class Add_User : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public Add_User()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string query = $"create user {tbxUsername.Text.Trim()} identified by {tbxPassword.Text.Trim()}";
            try
            {
                OracleCommand command = new OracleCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm người dùng thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message);
            }
            this.Close();
        }
    }
}
