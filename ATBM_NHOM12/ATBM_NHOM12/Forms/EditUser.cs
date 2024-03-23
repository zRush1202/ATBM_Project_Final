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
    public partial class EditUser : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public EditUser()
        {
            InitializeComponent();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string query = $"alter user {tbxUsername.Text.Trim()} identified by {tbxPassword.Text.Trim()}";
            try
            {
                OracleCommand command = new OracleCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa tài khoản người dùng thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing user: " + ex.Message);
            }
            this.Close();
        }
    }
}
