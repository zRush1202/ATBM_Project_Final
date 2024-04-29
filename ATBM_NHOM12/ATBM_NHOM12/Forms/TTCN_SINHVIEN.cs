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
    public partial class TTCN_SINHVIEN : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public TTCN_SINHVIEN()
        {
            InitializeComponent();
        }
        private void TTCN_SINHVIEN_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADPRO.SINHVIEN";
            OracleCommand cmd = new OracleCommand(query, con);

            try
            {
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Gán giá trị từ cột tương ứng vào các textbox
                    txt_hoten.Text = reader["HOTEN"].ToString();
                    txt_phai.Text = reader["PHAI"].ToString();
                    DateTime ngsinh = Convert.ToDateTime(reader["NGSINH"].ToString());
                    txt_ngaysinh.Text = ngsinh.ToString("dd-MM-yyyy");
                    txt_sv.Text = reader["MASV"].ToString();
                    txt_diachi.Text = reader["DCHI"].ToString();
                    txt_dt.Text = reader["DT"].ToString();
                    txt_mact.Text = reader["MACT"].ToString();
                    txt_manganh.Text = reader["MANGANH"].ToString();
                    txt_sotctl.Text = reader["SOTCTL"].ToString();
                    txt_dtbtl.Text = reader["DTBTL"].ToString();
                    // Thêm các trường khác nếu cần
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"UPDATE ADPRO.SINHVIEN SET DT = '{txt_dt.Text}', DCHI = '{txt_diachi.Text}'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                TTCN_SINHVIEN_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }
    }
}
