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
    public partial class CAPNHAT_PHANCONG : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        private string roleUser = "";
        private string username = "";
        private string magvOld = "";
        private string mahpOld = "";
        private string mactOld = "";
        private string hkOld = "";
        private string namOld = "";
        public CAPNHAT_PHANCONG(string role, string username)
        {
            this.roleUser = role;
            this.username = username;
            InitializeComponent();
        }
        private void CAPNHAT_PHANCONG_TABLE_Load(object sender, EventArgs e)
        {
            string query = "";
            if (roleUser == "RL_GIAOVU")
            {
                query = "select pc.* from ADPRO.PHANCONG pc , ADPRO.HOCPHAN hp where pc.mahp = hp.mahp and hp.madv = 'VPK'"; ;
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    dgv_phancong.DataSource = dataTable;
                    dgv_phancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (roleUser == "RL_TRUONGDV")
            {
                query = $"select pc.* from ADPRO.PHANCONG pc , ADPRO.HOCPHAN hp, ADPRO.DONVI dv where pc.mahp = hp.mahp and hp.madv = dv.madv and dv.trgdv = '{this.username}'"; ;
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    dgv_phancong.DataSource = dataTable;
                    dgv_phancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (roleUser == "RL_TRUONGKHOA")
            {
                query = $"select pc.* from ADPRO.PHANCONG pc , ADPRO.HOCPHAN hp where pc.mahp = hp.mahp and hp.madv = 'VPK'"; ;
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    dgv_phancong.DataSource = dataTable;
                    dgv_phancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }    
        }
        private void dgv_phancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_phancong.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_phancong.Rows[e.RowIndex];
                txt_magv.Text = row.Cells["MAGV"].Value.ToString();
                this.magvOld = row.Cells["MAGV"].Value.ToString();
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
        private void txt_magv_Load(object sender, EventArgs e)
        {
            if (this.roleUser == "RL_TRUONGDV" || this.roleUser == "RL_TRUONGKHOA")
            {
                using (OracleCommand cmd = new OracleCommand("SELECT MANV FROM ADPRO.NHANSU", con))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txt_magv.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        private void btt_capnhat_Click(object sender, EventArgs e)
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
                //MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                //MessageBox.Show($"magvold: {this.magvOld}, mahpold: {this.mahpOld}, hkold: {this.hkOld}, namOld: {this.namOld}, mactOld: {this.mactOld}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.PHANCONG set magv ='{magv}', mahp = '{mahp}', hk = {hk}, nam = {nam}, mact = '{mact}' where " +
                    $"magv ='{this.magvOld}' and mahp = '{this.mahpOld}' and hk = {this.hkOld} and nam = {this.namOld} and mact = '{this.mactOld}' ";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    CAPNHAT_PHANCONG_TABLE_Load(sender, e);
                }
                else
                {
                    if (this.roleUser == "RL_TRUONGDV")
                    {
                        MessageBox.Show("Học phần không thuộc đơn vị mình làm trưởng!");
                    }
                    else
                        // Thông báo khi không có dòng nào bị xóa
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
