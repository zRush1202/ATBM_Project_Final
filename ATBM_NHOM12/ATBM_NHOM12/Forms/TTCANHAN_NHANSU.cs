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
    public partial class TTCANHAN_NHANSU : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        public TTCANHAN_NHANSU()
        {
            InitializeComponent();
        }
        private void TTCANHAN_NHANSU_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ADPRO.QLHS_TTCANHAN"; // Thay <điều_kiện_lọc> bằng điều kiện bạn muốn lọc dữ liệu
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
                    txt_manv.Text = reader["MANV"].ToString();
                    txt_phucap.Text = reader["PHUCAP"].ToString();
                    txt_dt.Text = reader["DT"].ToString();
                    txt_vaitro.Text = reader["VAITRO"].ToString();
                    txt_madv.Text = reader["MADV"].ToString();
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
                MessageBox.Show(txt_dt.Text);
                var cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"UPDATE ADPRO.QLHS_TTCANHAN SET DT = '{txt_dt.Text}'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                TTCANHAN_NHANSU_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }
    }
}
