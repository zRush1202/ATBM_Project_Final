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
    public partial class CAPNHATDIEM_DANGKY_TABLE : Form
    {
        private string masv;
        private string magv;
        private string mahp;
        private string hk;
        private string nam;
        private string mact;
        public static OracleConnection con = LoginProvider.conn;
        public CAPNHATDIEM_DANGKY_TABLE(string masv, string magv, string mahp, string hk, string nam, string mact)
        {
            this.masv = masv;
            this.magv = magv;
            this.mahp = mahp;
            this.nam = nam;
            this.mact = mact;
            InitializeComponent();
        }

        private void btt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string masv = this.masv;
                string magv = this.magv;
                string mahp = this.mahp;
                int hk = int.Parse(this.hk);
                int nam = int.Parse(this.nam);
                string mact = this.mact;
                string dth = txt_dth.Text;
                string dqt = txt_dqt.Text;
                string dck = txt_dck.Text;
                string dtk = txt_dtk.Text;
                // Hiển thị giá trị của các biến trong một MessageBox
                //MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                //MessageBox.Show($"magvold: {this.magvOld}, mahpold: {this.mahpOld}, hkold: {this.hkOld}, namOld: {this.namOld}, mactOld: {this.mactOld}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.DANGKY set diemth ='{dth}', diemqt = '{dqt}', diemck = {dck}, diemtk = {dtk} where " +
                    $"masv = {masv} and magv ='{magv}' and mahp = '{mahp}' and hk = {hk} and nam = {nam} and mact = '{mact}' ";
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
