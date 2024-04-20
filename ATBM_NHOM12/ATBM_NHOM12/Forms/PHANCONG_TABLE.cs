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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ATBM_NHOM12.Forms
{
    public partial class PHANCONG_TABLE : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public PHANCONG_TABLE()
        {
            InitializeComponent();
        }
        private void PHANCONG_TABLE_Load(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.PHANCONG";;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_phancong.DataSource = dataTable;
                dgv_phancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_phancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_phancong.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_phancong.Rows[e.RowIndex];
                txt_magv.Text = row.Cells["MAGV"].Value.ToString();
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_hk.Text = row.Cells["HK"].Value.ToString();
                txt_mact.Text = row.Cells["MACT"].Value.ToString();
                txt_nam.Text = row.Cells["NAM"].Value.ToString();
            }
        }

        private void btt_refreshtt_Click(object sender, EventArgs e)
        {
            txt_magv.Text = "";
            txt_mahp.Text = "";
            txt_hk.Text = "";
            txt_mact.Text = "";
            txt_nam.Text = "";
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string magv = txt_magv.Text;
                string mahp = txt_mahp.Text;
                int hk = int.Parse(txt_hk.Text);
                int nam = int.Parse(txt_nam.Text);
                string mact = txt_mact.Text;

                // Hiển thị giá trị của các biến trong một MessageBox
                MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"INSERT INTO ADPRO.PHANCONG VALUES('{magv}','{mahp}',{hk},{nam},'{mact}')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ: hiển thị thông báo lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void btt_hpbanthan_Click(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.QLHS_PHANCONG_GD"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_phancong.DataSource = dataTable;
                dgv_phancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
