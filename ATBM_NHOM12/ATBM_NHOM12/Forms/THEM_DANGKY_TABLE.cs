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
    public partial class THEM_DANGKY_TABLE : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        private string roleUser = "";
        private string username = "";
        public THEM_DANGKY_TABLE(string role, string username)
        {
            InitializeComponent();
            this.roleUser = role;
            this.username = username;
        }

        private void THEM_DANGKY_TABLE_Load(object sender, EventArgs e)
        {
            
            string query = "select * from ADPRO.KHMO"; 
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_khmo.DataSource = dataTable;
                dgv_khmo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_khmo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_khmo.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_khmo.Rows[e.RowIndex];
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_hk.Text = row.Cells["HK"].Value.ToString();
                txt_mact.Text = row.Cells["MACT"].Value.ToString();
                txt_nam.Text = row.Cells["NAM"].Value.ToString();
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string masv = txt_masv.Text;
                string magv = txt_magv.Text;
                string mahp = txt_mahp.Text;
                int hk = int.Parse(txt_hk.Text);
                int nam = int.Parse(txt_nam.Text);
                string mact = txt_mact.Text;

                // Hiển thị giá trị của các biến trong một MessageBox
                // MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                if (this.roleUser == "RL_SINHVIEN")
                    cmd.CommandText = $"INSERT INTO ADPRO.DANGKY(MASV, MAGV, MAHP, HK, NAM, MACT) VALUES('{masv}','{magv}','{mahp}',{hk},{nam},'{mact}')";
                else
                    cmd.CommandText = $"INSERT INTO ADPRO.QLHS_DANGKY_HPGD(MASV, MAGV, MAHP, HK, NAM, MACT) VALUES('{masv}','{magv}','{mahp}',{hk},{nam},'{mact}')";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                else
                { 
                    MessageBox.Show("Không có dữ liệu nào được xóa!");
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 28115)
                {
                    MessageBox.Show("Quá thời hạn đăng ký học phần!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
