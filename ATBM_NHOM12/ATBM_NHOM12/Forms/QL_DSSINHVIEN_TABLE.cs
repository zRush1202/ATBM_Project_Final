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
    public partial class QL_DSSINHVIEN_TABLE : Form
    {
        private string roleUser = "RL_TRUONGDV";
        private string magvOld = "";
        private string mahpOld = "";
        private string mactOld = "";
        private string hkOld = "";
        private string namOld = "";
        public static OracleConnection con = LoginProvider.conn;
        public QL_DSSINHVIEN_TABLE()
        {
            InitializeComponent();
        }

        private void QL_DSSINHVIEN_TABLE_Load(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.SINHVIEN"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_DSSinhVien.DataSource = dataTable;
                dgv_DSSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
        {

        }

        private void btt_capnhat_Click(object sender, EventArgs e)
        {

        }

        private void btt_refreshtt_Click(object sender, EventArgs e)
        {

        }

        private void btt_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void btt_refreshds_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DSSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
