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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM_NHOM12.Forms
{
    public partial class DeleteRole : Form
    {
        string rolename;
        public static OracleConnection con = LoginProvider.conn;
        public DeleteRole()
        {
            InitializeComponent();
        }

        public DeleteRole(string rolename)
        {
            this.rolename = rolename;
            InitializeComponent();
        }

        private void btnKhong_Click_1(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rolename))
            {
                return;
            }
            else
            {
                string query2 = "alter session set \"_ORACLE_SCRIPT\" = true";
                string query = $"drop role {rolename}";
                try
                {
                    OracleCommand command2 = new OracleCommand(query2, con);
                    command2.ExecuteNonQuery();
                    OracleCommand command = new OracleCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Vai trò '{rolename}' đã được xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vai trò: " + ex.Message);
                }
            }
            this.Close();
        }
    }
}
