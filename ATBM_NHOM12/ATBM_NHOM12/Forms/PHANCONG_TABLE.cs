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
    public partial class PHANCONG_TABLE : Form
    {
        private string roleUser = "";
        private string username = "";
        public static OracleConnection con = LoginProvider.conn;
        public PHANCONG_TABLE(string role, string username)
        {
            this.roleUser = role;
            this.username = username;
            InitializeComponent();
        }
        private void PHANCONG_TABLE_Load(object sender, EventArgs e)
        {
            if (roleUser == "RL_GIAOVU")
            {
                btt_them.Visible = false;
            }    
            string query = "select * from ADPRO.PHANCONG";;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_phancong.DataSource = dataTable;
                dgv_phancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv_phancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_phancong.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_phancong.Rows[e.RowIndex];
                txt_magv.Text = row.Cells["MAGV"].Value.ToString();
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_hk.Text = row.Cells["HK"].Value.ToString();
                txt_mact.Text = row.Cells["MACT"].Value.ToString();
                txt_nam.Text = row.Cells["NAM"].Value.ToString();
            }
        }
                                                             
        private void btt_refreshtt_Click(object sender, EventArgs e)
        {
            txt_magv.Text = "";
            txt_mahp.Text = "";
            txt_hk.Text = "";
            txt_mact.Text = "";
            txt_nam.Text = "";
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            THEM_PHANCONG_TABLE newForm = new THEM_PHANCONG_TABLE(this.roleUser,this.username);
            newForm.Show();
        }

        private void btt_hpbanthan_Click(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.QLHS_PHANCONG_GD"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_phancong.DataSource = dataTable;
                dgv_phancong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_xoa_Click(object sender, EventArgs e)
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

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"DELETE FROM ADPRO.PHANCONG where magv ='{magv}' and mahp = '{mahp}' and hk = {hk} and nam = {nam} and mact = '{mact}'";
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
            CAPNHAT_PHANCONG newForm = new CAPNHAT_PHANCONG(this.roleUser,this.username);
            newForm.Show();
        }

        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            PHANCONG_TABLE_Load(sender, e);
        }

        private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tk_mhp.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM ADPRO.PHANCONG WHERE mahp LIKE '%{txt_tk_mhp.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_phancong.DataSource = dataTable;
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
        private void txt_magv_Load(object sender, EventArgs e)
        {
            if (roleUser == "RL_TRUONGDV" || roleUser == "RL_TRUONGKHOA")
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

    }
}
