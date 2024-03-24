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
    public partial class EditRole : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public EditRole()
        {
            InitializeComponent();
            load_Role();
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            string query = "alter session set \"_ORACLE_SCRIPT\" = true";
            string query2 = $"alter role {cbxRole.Text.Trim()} identified by {tbxPassword.Text}";
            string query3 = "alter session set \"_ORACLE_SCRIPT\" = false";
            string query4 = $"alter role {cbxRole.Text.Trim()} not identified";
            if (chbxChangePass.Checked == true && chbxDelPass.Checked == true)
            {
                MessageBox.Show("Chỉ chọn đổi mật khẩu hoặc hủy mật khẩu!!!!");
                return;
            }
            else if (chbxChangePass.Checked == true && tbxPassword.Text != "")
            {
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
                    MessageBox.Show("Chỉnh sửa vai trò thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error editing role: " + ex.Message);
                }
            }
            else if (chbxChangePass.Checked == true && tbxPassword.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!!!");
                return;
            }
            else if (chbxDelPass.Checked == true)
            {
                try
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = con;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    command.CommandText = query4;
                    command.ExecuteNonQuery();
                    command.CommandText = query3;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Hủy mật khẩu của vai trò thành công!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error editing role: " + ex.Message);
                }
            }
            else
            {
                return;
            }
            this.Close();
        }

        private void chbxChangePass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxChangePass.Checked)
            {
                label_password.Visible = true;
                tbxPassword.Visible = true;
            }
            else
            {
                label_password.Visible = false; 
                tbxPassword.Visible = false;
            }
        }

        private void load_Role()
        {
            string query = "SELECT role FROM dba_roles";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
                cbxRole.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    cbxRole.Items.Add(row["role"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message);
            }
        }
    }
}
