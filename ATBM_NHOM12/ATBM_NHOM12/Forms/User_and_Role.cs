using ATBM_NHOM12.Forms;
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

namespace ATBM_NHOM12
{
    public partial class User_and_Role : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public User_and_Role()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_and_Role_Load(object sender, EventArgs e)
        {           
            string query = "SELECT* FROM dba_users";
            string query2 = "select* from dba_roles";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            OracleDataAdapter adapter2 = new OracleDataAdapter(query2, con);
            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            try
            {
                //con.Open();
                adapter.Fill(dataTable);
                dgvUser.DataSource = dataTable;
                adapter2.Fill(dataTable2);
                dgvRole.DataSource = dataTable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Add_User addUser = new Add_User();
            addUser.ShowDialog();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            Add_Role addRole = new Add_Role();
            addRole.ShowDialog();
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            User_and_Role_Load(sender, e);
            tbxSearchUser.Text = "";
        }

        private void btnRefreshRole_Click(object sender, EventArgs e)
        {
            User_and_Role_Load(sender, e);
            tbxSearchRole.Text = "";
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.ShowDialog();
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            EditRole editRole = new EditRole();
            editRole.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (tbxSearchUser.Text == "")
            {
                MessageBox.Show("Chưa chọn User!");
                return;
            }
            else
            {
                DeleteUser deleteUser = new DeleteUser(tbxSearchUser.Text);
                deleteUser.ShowDialog();
            }  
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                string ma = row.Cells["USERNAME"].Value.ToString();
                tbxSearchUser.Text = ma;
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearchUser.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM dba_users WHERE username LIKE '%{tbxSearchUser.Text.ToUpper()}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvUser.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin người dùng cho tên người dùng đã nhập.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm người dùng: " + ex.Message);
                }
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (tbxSearchRole.Text == "")
            {
                MessageBox.Show("Chưa chọn Role!");
                return;
            }
            else
            {
                DeleteRole deleteRole = new DeleteRole(tbxSearchRole.Text);
                deleteRole.ShowDialog();
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvRole.Rows[e.RowIndex];
                string ma = row.Cells["ROLE"].Value.ToString();
                tbxSearchRole.Text = ma;
            }
        }

        private void btnSearchRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearchRole.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM dba_roles WHERE role LIKE '%{tbxSearchRole.Text.ToUpper()}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvRole.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin vai trò cho tên vai trò đã nhập.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm vai trò: " + ex.Message);
                }
            }
        }
    }
}
