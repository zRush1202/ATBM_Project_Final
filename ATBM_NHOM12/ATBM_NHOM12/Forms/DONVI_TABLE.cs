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
    public partial class DONVI_TABLE : Form
    {
        private string roleUser = "RL_TRUONGDV";
        private string madvOld = "";
        //private string tendvOld = "";
        //private string trgdvOld = "";
        public static OracleConnection con = LoginProvider.conn;
        public DONVI_TABLE()
        {
            InitializeComponent();
        }
        private void DONVI_TABLE_Load(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.DONVI"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_donvi.DataSource = dataTable;
                dgv_donvi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_donvi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_donvi.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_donvi.Rows[e.RowIndex];
                txt_madv.Text = row.Cells["MADV"].Value.ToString();
                this.madvOld = row.Cells["MADV"].Value.ToString();
                txt_tendv.Text = row.Cells["TENDV"].Value.ToString();
                //this.tendvOld = row.Cells["TENDV"].Value.ToString();
                txt_trgdv.Text = row.Cells["TRGDV"].Value.ToString();
                //this.trgdvOld = row.Cells["TRGDV"].Value.ToString();
            }
        }

        private void btt_refreshtt_Click(object sender, EventArgs e)
        {
            txt_madv.Text = "";
            txt_tendv.Text = "";
            txt_trgdv.Text = "";
        }

        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            DONVI_TABLE_Load(sender, e);
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string madv = txt_madv.Text;
                string tendv = txt_tendv.Text;
                string trgdv = txt_trgdv.Text;

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"INSERT ADPRO.DONVI VALUES" +
                    $"('{madv}','{tendv}',{trgdv})";
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
                string madv = txt_madv.Text;
                string tendv = txt_tendv.Text;
                string trgdv = txt_trgdv.Text;


                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"DELETE FROM ADPRO.DONVI " +
                    $"where madv = '{madv}'";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
                else
                {
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
                string madv = txt_madv.Text;
                string tendv = txt_tendv.Text;
                string trgdv = txt_trgdv.Text;

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.DONVI set tendv = '{tendv}' ,trgdv = {trgdv} " +
                    $"where madv = '{this.madvOld}'";
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
            if (string.IsNullOrEmpty(txt_tk_tendv.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM ADPRO.DONVI WHERE tendv LIKE '%{txt_tk_tendv.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_donvi.DataSource = dataTable;
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
