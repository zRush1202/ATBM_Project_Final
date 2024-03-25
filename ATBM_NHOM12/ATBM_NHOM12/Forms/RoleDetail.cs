using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM_NHOM12.Forms
{
    public partial class RoleDetail : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public string roleName;
        public string userName;

        public RoleDetail()
        {
            InitializeComponent();
        }

        DataSet LoadData_RoleDetail()
        {
            DataSet data = new DataSet();
            string query = $"SELECT * FROM dba_role_privs WHERE granted_role = '{roleName}'";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            try
            {
                adapter.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating role: " + ex.Message);
            }
            return data;
        }

        DataSet LoadData_UserNotInRole()
        {
            DataSet data = new DataSet();
            string query = $"SELECT * FROM dba_users WHERE username NOT IN (SELECT grantee FROM dba_role_privs WHERE granted_role = '{roleName}')";

            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            try
            {
                adapter.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating role: " + ex.Message);
            }
            return data;
        }

        public RoleDetail(string role)
        {
            this.roleName = role;
            InitializeComponent();

            dgvRoleDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRoleDetail.Columns.Clear();
            dgvRoleDetail.DataSource = LoadData_RoleDetail().Tables[0];
            dgvUserNotInRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUserNotInRole.Columns.Clear();
            dgvUserNotInRole.DataSource = LoadData_UserNotInRole().Tables[0];

        }

        private void btnAddRoleMem_Click(object sender, EventArgs e)
        {
            string query = $"GRANT {roleName} TO {userName}";
            try
            {
                OracleCommand command = new OracleCommand();
                command.Connection = con;
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm người dùng vào vai trò thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating role: " + ex.Message);
            }

            dgvRoleDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRoleDetail.Columns.Clear();
            dgvRoleDetail.DataSource = LoadData_RoleDetail().Tables[0];
            dgvUserNotInRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUserNotInRole.Columns.Clear();
            dgvUserNotInRole.DataSource = LoadData_UserNotInRole().Tables[0];


        }

        private void dgvRoleDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvRoleDetail.Rows[e.RowIndex];
                userName = row.Cells["GRANTEE"].Value?.ToString() ?? string.Empty;

            }
        }

        private void dgvUserNotInRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvUserNotInRole.Rows[e.RowIndex];
                userName = row.Cells["USERNAME"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnRevokeRole_Click(object sender, EventArgs e)
        {
            string query = $"REVOKE {roleName} FROM {userName}";
            MessageBox.Show(query);
            try
            {
                OracleCommand command = new OracleCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show($"Vai trò {roleName} cho người dùng {userName} đã được xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa vai trò: " + ex.Message);
            }

            dgvRoleDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRoleDetail.Columns.Clear();
            dgvRoleDetail.DataSource = LoadData_RoleDetail().Tables[0];
            dgvUserNotInRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUserNotInRole.Columns.Clear();
            dgvUserNotInRole.DataSource = LoadData_UserNotInRole().Tables[0];
        }
    }
}
