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
    public partial class DANGKY_TABLE : Form
    {
        private string roleUser = "RL_TRUONGDV";
        private string masvOld = "";
        private string magvOld = "";
        private string mahpOld = "";
        private string mactOld = "";
        private string hkOld = "";
        private string namOld = "";
        private string dthOld = "";
        private string dqtOld = "";
        private string dckOld = "";
        private string dtkOld = "";
        public static OracleConnection con = LoginProvider.conn;
        public DANGKY_TABLE()
        {
            InitializeComponent();
        }
        private void DANGKY_TABLE_Load(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.DANGKY"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_dangky.DataSource = dataTable;
                dgv_dangky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            DANGKY_TABLE_Load(sender, e);
        }

        private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tk_mhp.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM ADPRO.DANGKY WHERE mahp LIKE '%{txt_tk_mhp.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_dangky.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin phân công liên quan đến học phần đó!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm : " + ex.Message);
                }
            }
        }

        private void btt_refreshtt_Click(object sender, EventArgs e)
        {
            txt_masv.Text = "";
            txt_magv.Text = "";
            txt_mahp.Text = "";
            txt_hk.Text = "";
            txt_mact.Text = ""; txt_magv.Text = "";
            txt_mahp.Text = "";
            txt_hk.Text = "";
            txt_mact.Text = "";
            txt_nam.Text = ""; txt_magv.Text = "";
            txt_mahp.Text = "";
            txt_hk.Text = "";
            txt_mact.Text = "";
            txt_nam.Text = "";
            txt_nam.Text = "";
            txt_dth.Text = "";
            txt_dqt.Text = "";
            txt_dck.Text = "";
            txt_dtk.Text = "";
        }
        private void dgv_dangky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_dangky.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_dangky.Rows[e.RowIndex];
                txt_masv.Text = row.Cells["MASV"].Value.ToString();
                this.masvOld = row.Cells["MASV"].Value.ToString();
                txt_magv.Text = row.Cells["MAGV"].Value.ToString();
                this.magvOld = row.Cells["MAGV"].Value.ToString();
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                this.mahpOld = row.Cells["MAHP"].Value.ToString();
                txt_hk.Text = row.Cells["HK"].Value.ToString();
                this.hkOld = row.Cells["HK"].Value.ToString();
                txt_mact.Text = row.Cells["MACT"].Value.ToString();
                this.mactOld = row.Cells["MACT"].Value.ToString();
                txt_nam.Text = row.Cells["NAM"].Value.ToString();
                this.namOld = row.Cells["NAM"].Value.ToString();
                txt_dth.Text = row.Cells["DIEMTH"].Value.ToString();
                this.dthOld = row.Cells["DIEMTH"].Value.ToString();
                txt_dqt.Text = row.Cells["DIEMQT"].Value.ToString();
                this.dqtOld = row.Cells["DIEMQT"].Value.ToString();
                txt_dck.Text = row.Cells["DIEMCK"].Value.ToString();
                this.dckOld = row.Cells["DIEMCK"].Value.ToString();
                txt_dtk.Text = row.Cells["DIEMTK"].Value.ToString();
                this.dtkOld = row.Cells["DIEMTK"].Value.ToString();
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
        {

        }
    }
}
