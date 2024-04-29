using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.hk = hk;
            this.nam = nam;
            this.mact = mact;
            InitializeComponent();
            string commandString = $"SELECT * FROM adpro.dangky WHERE masv = '{masv}' AND magv = '{magv}' AND mahp = '{mahp}' AND hk = '{hk}' AND nam = '{nam}' AND mact = '{mact}'";
            using (OracleCommand command = new OracleCommand(commandString, con))
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                OracleDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_dth.Text = reader["diemth"].ToString();
                        txt_dqt.Text = reader["diemqt"].ToString();
                        txt_dck.Text = reader["diemck"].ToString();
                        txt_dtk.Text = reader["diemtk"].ToString();
                    }
                }
                reader.Close();
            }
        }

        private void btt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = this.masv;
                string magv = this.magv;
                string mahp = this.mahp;
                int hk = int.Parse(this.hk);
                int nam = int.Parse(this.nam);
                string mact = this.mact;
                float dth = float.Parse(txt_dth.Text);
                float dqt = float.Parse(txt_dqt.Text);
                float dck = float.Parse(txt_dck.Text);
                float dtk = float.Parse(txt_dtk.Text);

                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.QLHS_DANGKY_HPGD SET diemth ='{dth}', diemqt = '{dqt}', diemck = {dck}, diemtk = {dtk} WHERE " +
                    $"masv = '{masv}' AND magv ='{magv}' AND mahp = '{mahp}' AND hk = {hk} AND nam = {nam} AND mact = '{mact}' ";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được cập nhật!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
