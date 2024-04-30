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
    public partial class SYSTEM_PRIVS : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public SYSTEM_PRIVS()
        {
            InitializeComponent();
        }
        private void SYSTEM_PRIVS_Load(object sender, EventArgs e)
        {
            string query = "select * from sys.dba_sys_privs"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_sys.DataSource = dataTable;
                dgv_sys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btt_grant_revoke_Click(object sender, EventArgs e)
        {
            THEM_SYSPRIV grantSPF = new THEM_SYSPRIV();
            grantSPF.Show();
        }

        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            SYSTEM_PRIVS_Load(sender, e);
        }

        private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_grantee.Text))
            {
                return;
            }
            else
            {
                string query = $"select * from sys.dba_sys_privs where grantee LIKE '%{txt_grantee.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_sys.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy grantee!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm : " + ex.Message);
                }
            }
        }
    }
}
