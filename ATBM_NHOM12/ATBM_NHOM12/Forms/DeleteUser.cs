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
    public partial class DeleteUser : Form
    {
        string username;
        public static OracleConnection con = LoginProvider.conn;
        public DeleteUser()
        {
            InitializeComponent();
        }

        public DeleteUser(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username))
            {
                return;
            }
            else
            {
                string query = $"drop user {username} CASCADE";
                try
                {
                    OracleCommand command = new OracleCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Người dùng '{username}' đã được xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa người dùng: " + ex.Message);
                }
            }
            this.Close();
        }
    }
}
