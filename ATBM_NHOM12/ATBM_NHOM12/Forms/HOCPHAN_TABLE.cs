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
    public partial class HOCPHAN_TABLE : Form
    {
        private string roleUser = "";
        private string username = "";
        private string mahpOld = "";
        //private string tenhpOld = "";
        //private string sotcOld = "";
        //private string stltOld = "";
        //private string stthOld = "";
        //private string sosvtdOld = "";
        //private string madvOld = "";
        public static OracleConnection con = LoginProvider.conn;
        public HOCPHAN_TABLE(string role, string username)
        {
            this.roleUser = role;
            this.username = username;
            InitializeComponent();
        }
        private void HOCPHAN_TABLE_Load(object sender, EventArgs e)
        {
            if (roleUser == "RL_NVCOBAN" || roleUser == "RL_GIANGVIEN" || roleUser == "RL_TRUONGKHOA" || roleUser == "RL_SINHVIEN" || roleUser == "RL_TRUONGDV")
            {
                btt_them.Visible = false;
                btt_capnhat.Visible = false;
                btt_refreshtt.Location = new Point(700, 100);
            }
            string query = "select * from ADPRO.HOCPHAN"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_hocphan.DataSource = dataTable;
                dgv_hocphan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_hocphan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_hocphan.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_hocphan.Rows[e.RowIndex];
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                this.mahpOld = row.Cells["MAHP"].Value.ToString();
                txt_tenhp.Text = row.Cells["TENHP"].Value.ToString();
                //this.tenhpOld = row.Cells["TENHP"].Value.ToString();
                txt_sotc.Text = row.Cells["SOTC"].Value.ToString();
                //this.sotcOld = row.Cells["SOTC"].Value.ToString();
                txt_stlt.Text = row.Cells["STLT"].Value.ToString();
                //this.stltOld = row.Cells["STLT"].Value.ToString();
                txt_stth.Text = row.Cells["STTH"].Value.ToString();
                //this.stthOld = row.Cells["STTH"].Value.ToString();
                txt_sosvtd.Text = row.Cells["SOSVDT"].Value.ToString();
                //this.sosvtdOld = row.Cells["SOSVTD"].Value.ToString();
                txt_madv.Text = row.Cells["MADV"].Value.ToString();
                //this.madvOld = row.Cells["MADV"].Value.ToString();
                txt_mahp.ReadOnly = true;
            }
        }
        private void btt_refreshtt_Click(object sender, EventArgs e)
        {
            txt_mahp.Text = "";
            txt_tenhp.Text = "";
            txt_sotc.Text = "";
            txt_stlt.Text = "";
            txt_stth.Text = "";
            txt_sosvtd.Text = "";
            txt_madv.Text = "";
            txt_mahp.ReadOnly = false;
        }

        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            HOCPHAN_TABLE_Load(sender, e);
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string mahp = txt_mahp.Text;
                string tenhp = txt_tenhp.Text;
                int sotc = 0;
                if (txt_sotc.Text != "")
                    sotc = int.Parse(txt_sotc.Text);
                int stlt = 0;
                if (txt_stlt.Text != "")
                    stlt = int.Parse(txt_stlt.Text);
                int stth = 0;
                if (txt_stth.Text != "")
                    stth = int.Parse(txt_stth.Text);
                int sosvtd = 0;
                if (txt_sosvtd.Text != "")
                    sosvtd = int.Parse(txt_sosvtd.Text);
                string madv = txt_madv.Text;


                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"INSERT INTO ADPRO.HOCPHAN(MAHP, TENHP, SOTC, STLT, STTH, SOSVTĐ, MADV) VALUES" +
                    $"('{mahp}','{tenhp}',{sotc} ,{stlt} ,{stth} ,{sosvtd} ,'{madv}')";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                else
                {
                    // Thông báo khi không có dòng nào bị xóa
                   MessageBox.Show("Không có dữ liệu nào được thêm!");
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 00001)
                {
                    MessageBox.Show("Đã tồn tại mã học phần này!");
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
                string tenhp = txt_tenhp.Text;
                int sotc = 0;
                if (txt_sotc.Text != "")
                    sotc = int.Parse(txt_sotc.Text);
                int stlt = 0;
                if (txt_stlt.Text != "")
                    stlt = int.Parse(txt_stlt.Text);
                int stth = 0;
                if (txt_stth.Text != "")
                    stth = int.Parse(txt_stth.Text);
                int sosvtd = 0;
                if (txt_sosvtd.Text != "")
                    sosvtd = int.Parse(txt_sosvtd.Text);
                string madv = txt_madv.Text;

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.HOCPHAN set tenhp = '{tenhp}' ,sotc = {sotc} ,stlt = {stlt} ,stth = {stth} ,sosvtd = {sosvtd} ,madv = '{madv}' " +
                    $"where mahp = '{mahp}'";
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

        private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tk_mhp.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM ADPRO.HOCPHAN WHERE tenhp LIKE '%{txt_tk_mhp.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_hocphan.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin học phần đó!");
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
