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
        }

        private void btnRefreshRole_Click(object sender, EventArgs e)
        {
            User_and_Role_Load(sender, e);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.ShowDialog();
        }
    }
}
