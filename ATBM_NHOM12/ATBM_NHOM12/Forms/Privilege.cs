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
    public partial class Privilege : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public Privilege()
        {
            InitializeComponent();
        }

        private void Privilege_Load(object sender, EventArgs e)
        {
            string query = "SELECT grantee, owner, table_name, privilege FROM dba_tab_privs where rownum <= 100";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                //con.Open();
                adapter.Fill(dataTable);
                dgvPriv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPriv.DataSource = dataTable;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            };
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string query = $"SELECT grantee, owner, table_name, privilege FROM dba_tab_privs where grantee = '{tbxSearchUser.Text}'";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                //con.Open();
                adapter.Fill(dataTable);
                dgvPriv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPriv.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            };
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            Privilege_Load(sender, e);
        }

        private void dgvPriv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvPriv.Rows[e.RowIndex];
                string ma = row.Cells["GRANTEE"].Value.ToString();
                tbxSearchUser.Text = ma;
            }
        }
    }
}
