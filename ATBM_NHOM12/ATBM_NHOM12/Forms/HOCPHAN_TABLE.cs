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
        private string roleUser = "RL_TRUONGDV";
        private string mahpOld = "";
        private string tenhpOld = "";
        private string sotcOld = "";
        private string stltOld = "";
        private string stthOld = "";
        private string sosvtdOld = "";
        private string madvOld = "";
        public static OracleConnection con = LoginProvider.conn;
        public HOCPHAN_TABLE()
        {
            InitializeComponent();
        }
        private void HOCPHAN_TABLE_Load(object sender, EventArgs e)
        {
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
                this.tenhpOld = row.Cells["TENHP"].Value.ToString();
                txt_sotc.Text = row.Cells["SOTC"].Value.ToString();
                this.sotcOld = row.Cells["SOTC"].Value.ToString();
                txt_stlt.Text = row.Cells["STLT"].Value.ToString();
                this.stltOld = row.Cells["STLT"].Value.ToString();
                txt_stth.Text = row.Cells["STTH"].Value.ToString();
                this.stthOld = row.Cells["STTH"].Value.ToString();
                txt_sosvtd.Text = row.Cells["SOSVTD"].Value.ToString();
                this.sosvtdOld = row.Cells["SOSVTD"].Value.ToString();
                txt_madv.Text = row.Cells["MADV"].Value.ToString();
                this.madvOld = row.Cells["MADV"].Value.ToString();
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
                int sotc = int.Parse(txt_sotc.Text);
                int stlt = int.Parse(txt_stlt.Text);
                int stth = int.Parse(txt_stth.Text);
                int sosvtd = int.Parse(txt_sosvtd.Text);
                string madv = txt_madv.Text;


                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"INSERT ADPRO.HOCPHAN VALUES" +
                    $"('{mahp}','{tenhp}',{sotc} ,{stlt} ,{stth} ,{sosvtd} ,{madv})";
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
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ: hiển thị thông báo lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void btt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string mahp = txt_mahp.Text;
                string tenhp = txt_tenhp.Text;
                int sotc = int.Parse(txt_sotc.Text);
                int stlt = int.Parse(txt_stlt.Text);
                int stth = int.Parse(txt_stth.Text);
                int sosvtd = int.Parse(txt_sosvtd.Text);
                string madv = txt_madv.Text;


                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"DELETE FROM ADPRO.HOCPHAN " +
                    $"where mahp = '{mahp}' and tenhp = '{tenhp}' and sotc = {sotc} and stlt = {stlt} and stth = {stth} and sosvtd = {sosvtd} and madv = {madv}";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
                else
                {
                    if (this.roleUser == "RL_TRUONGDV")
                    {
                        MessageBox.Show("Học phần không thuộc đơn vị mình làm trưởng!\nXóa thất bại.");
                    }
                    else
                        // Thông báo khi không có dòng nào bị xóa
                        MessageBox.Show("Không có dữ liệu nào được xóa!");
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
                int sotc = int.Parse(txt_sotc.Text);
                int stlt = int.Parse(txt_stlt.Text);
                int stth = int.Parse(txt_stth.Text);
                int sosvtd = int.Parse(txt_sosvtd.Text);
                string madv = txt_madv.Text;

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.HOCPHAN set mahp = '{mahp}' ,tenhp = '{tenhp}' ,sotc = {sotc} ,stlt = {stlt} ,stth = {stth} ,sosvtd = {sosvtd} ,madv = {madv} " +
                    $"where mahp = '{this.mahpOld}' and tenhp = '{this.tenhpOld}' and sotc = {this.sotcOld} and stlt = {this.stltOld} and stth = {this.stthOld} and sosvtd = {this.sosvtdOld} and madv = {this.madvOld}";
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
    }
}
