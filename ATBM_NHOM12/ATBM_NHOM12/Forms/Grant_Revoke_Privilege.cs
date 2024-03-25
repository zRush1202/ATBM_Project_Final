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
    public partial class Grant_Revoke_Privilege : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public Grant_Revoke_Privilege()
        {
            InitializeComponent();
        }
        private void Grant_Revoke_Privilege_Load(object sender, EventArgs e)
        {
            string query = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'BH_%' OR TABLE_NAME LIKE 'UV_BH_%'";
            string query2 = "select * from DBA_COL_PRIVS where TABLE_NAME LIKE 'BH_%' OR TABLE_NAME LIKE 'UV_BH_%' ";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            OracleDataAdapter adapter2 = new OracleDataAdapter(query2, con);
            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_table.DataSource = dataTable;
                adapter2.Fill(dataTable2);
                dgv_col.DataSource = dataTable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_grant_Click(object sender, EventArgs e)
        {
            Grant_Privilege gPri = new Grant_Privilege();
            gPri.ShowDialog();
        }

        private void btt_Refresh_Click(object sender, EventArgs e)
        {
            //"select * from all_views where view_name = 'UV_BH_CUAHANG_C##ADMIN1'"
            //select* from DBA_TAB_PRIVS where TABLE_NAME LIKE 'BH_%' OR TABLE_NAME LIKE 'UV_BH_%'
            string query = "select * from all_views where view_name = 'UV_BH_CUAHANG_C##ADMIN1'";
            string query2 = "select * from DBA_COL_PRIVS where TABLE_NAME LIKE 'BH_%' OR TABLE_NAME LIKE 'UV_BH_%' ";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            OracleDataAdapter adapter2 = new OracleDataAdapter(query2, con);
            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_table.DataSource = dataTable;
                adapter2.Fill(dataTable2);
                dgv_col.DataSource = dataTable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_revoke_Click(object sender, EventArgs e)
        {
            Revoke_Privilege rPri = new Revoke_Privilege();
            rPri.ShowDialog();
        }
    }
}
