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
    public partial class KHMO_TABLE : Form
    {
        private string roleUser = "";
        private string username = "";
        private string mahpOld = "";
        private string mactOld = "";
        private string hkOld = "";
        private string namOld = "";
        public static OracleConnection con = LoginProvider.conn;
        public KHMO_TABLE(string role, string username)
        {
            this.roleUser = role;
            this.username = username;
            InitializeComponent();
        }

        private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tk_mhp.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM ADPRO.KHMO WHERE mahp LIKE '%{txt_tk_mhp.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_KHMO.DataSource = dataTable;
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
        private void KHMO_TABLE_Load(object sender, EventArgs e)
        {
            if (roleUser == "RL_NVCOBAN" || roleUser == "RL_GIANGVIEN" || roleUser == "RL_TRUONGDV" || roleUser == "RL_TRUONGKHOA" || roleUser == "RL_SINHVIEN")
            {
                btt_them.Visible = false;
                btt_capnhat.Visible = false;
                btt_refreshtt.Location = new Point(700, 100);
            }
            string query = "select * from ADPRO.KHMO"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_KHMO.DataSource = dataTable;
                dgv_KHMO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            KHMO_TABLE_Load(sender, e);
        }
        private void txt_mahp_Load(object sender, EventArgs e)
        {
            using (OracleCommand cmd = new OracleCommand("SELECT MAHP FROM ADPRO.HOCPHAN", con))
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txt_mahp.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string mahp = txt_mahp.Text;
                int hk = 0;
                if (txt_hk.Text != "")
                    hk = int.Parse(txt_hk.Text);
                int nam = 0;
                if (txt_nam.Text != "")
                    nam = int.Parse(txt_nam.Text);
                string mact = txt_mact.Text;

                // Hiển thị giá trị của các biến trong một MessageBox
                // MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"INSERT INTO ADPRO.KHMO VALUES('{mahp}',{hk},{nam},'{mact}')";
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
                if (ex.Number == 00001)
                {
                    MessageBox.Show("Đã tồn tại kế hoạch mở học phần này!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                    // Xử lý ngoại lệ ở đây, ví dụ: hiển thị thông báo lỗi
                    MessageBox.Show(ex.Message);
            }
        }
        private void btt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string mahp = txt_mahp.Text;
                int hk = 1;
                if (txt_hk.Text != "")
                    hk = int.Parse(txt_hk.Text);
                int nam = 0;
                if (txt_nam.Text != "")
                    nam = int.Parse(txt_nam.Text);
                string mact = txt_mact.Text;

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.KHMO set mahp = '{mahp}', hk = {hk}, nam = {nam}, mact = '{mact}' where " +
                    $"mahp = '{this.mahpOld}' and hk = {this.hkOld} and nam = {this.namOld} and mact = '{this.mactOld}' ";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được cập nhật!");
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ: hiển thị thông báo lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void btt_refreshtt_Click(object sender, EventArgs e)
        {
            txt_mahp.Text = "";
            txt_hk.Text = "";
            txt_mact.Text = "";
            txt_nam.Text = "";
            this.mactOld = "";
            this.mahpOld = "";
            this.hkOld = "";
            this.namOld = "";
        }
        private void dgv_KHMO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_KHMO.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_KHMO.Rows[e.RowIndex];
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                this.mahpOld = row.Cells["MAHP"].Value.ToString();
                txt_hk.Text = row.Cells["HK"].Value.ToString();
                this.hkOld = row.Cells["HK"].Value.ToString();
                txt_mact.Text = row.Cells["MACT"].Value.ToString();
                this.mactOld = row.Cells["MACT"].Value.ToString();
                txt_nam.Text = row.Cells["NAM"].Value.ToString();
                this.namOld = row.Cells["NAM"].Value.ToString();
            }
        }
    }
}
