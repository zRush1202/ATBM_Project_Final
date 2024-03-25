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
    }
}
