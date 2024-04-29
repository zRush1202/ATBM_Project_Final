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
    public partial class QL_NHANSU_TABLE : Form
    {
        private string roleUser = "RL_TRUONGKHOA";
        public static OracleConnection con = LoginProvider.conn;
        public QL_NHANSU_TABLE()
        {
            InitializeComponent();
        }

        private void QL_NHANSU_TABLE_Load(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.NHANSU"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_DSNhanSu.DataSource = dataTable;
                dgv_DSNhanSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            string manv = txt_ns.Text;
            string hoten = txt_hoten.Text;
            string phai = txt_phai.Text;
            string ngsinh = txt_ngsinh.Text;
            float phucap = float.TryParse(txt_phucap.Text, out float phucapResult) ? phucapResult : 0f;
            string dt = txt_dt.Text;
            string vaitro = txt_vaitro.Text;
            string madv = txt_madv.Text;

            if (string.IsNullOrWhiteSpace(manv) || string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(phai) || string.IsNullOrWhiteSpace(ngsinh) || string.IsNullOrWhiteSpace(dt) || string.IsNullOrWhiteSpace(vaitro) || string.IsNullOrWhiteSpace(madv))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            try
            {
                var cmd = new OracleCommand();
                cmd.CommandText = $@"
                INSERT INTO ADPRO.NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV)
                VALUES (
                        '{manv}', 
                        '{hoten}', 
                        '{phai}', 
                        TO_DATE('{ngsinh}', 'dd-MM-yyyy'), 
                        {phucap}, 
                        '{dt}', 
                        '{vaitro}', 
                        '{madv}'
                )";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    QL_NHANSU_TABLE_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được thêm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mans_search.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM ADPRO.NHANSU WHERE MASV LIKE '%{txt_mans_search.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_DSNhanSu.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin nhân sự có mã đó!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm : " + ex.Message);
                }
            }
        }

        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            QL_NHANSU_TABLE_Load(sender, e);
        }

        private void dgv_DSSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_DSNhanSu.Rows.Count) 
            {
                DataGridViewRow row = this.dgv_DSNhanSu.Rows[e.RowIndex];
                txt_ns.Text = row.Cells["MANV"].Value.ToString();
                txt_hoten.Text = row.Cells["HOTEN"].Value.ToString();
                txt_phai.Text = row.Cells["PHAI"].Value.ToString();
                DateTime ngsinh = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                txt_ngsinh.Text = ngsinh.ToString("dd-MM-yyyy");
                txt_dt.Text = row.Cells["DT"].Value.ToString();
                txt_phucap.Text = row.Cells["PHUCAP"].Value.ToString();
                txt_madv.Text = row.Cells["MADV"].Value.ToString();
                txt_vaitro.Text = row.Cells["VAITRO"].Value.ToString();
            }

        }

        private void btt_capnhat_Click(object sender, EventArgs e)
        {
            string manv = txt_ns.Text;
            string hoten = txt_hoten.Text;
            string phai = txt_phai.Text;
            string ngsinh = txt_ngsinh.Text;
            string dt = txt_dt.Text;
            string vaitro = txt_vaitro.Text;
            string madv = txt_madv.Text;
            float phucap = float.TryParse(txt_phucap.Text, out float phucapResult) ? phucapResult : 0f;

            try
            {
                var cmd = new OracleCommand();
                cmd.CommandText = $@"
                UPDATE ADPRO.NHANSU 
                SET 
                    HOTEN = '{hoten}', 
                    PHAI = '{phai}', 
                    NGSINH = TO_DATE('{ngsinh}', 'dd-MM-yyyy'), 
                    DT = '{dt}', 
                    VAITRO = '{vaitro}', 
                    MADV = '{madv}', 
                    PHUCAP = {phucap} 
                WHERE 
                    MANV = '{manv}'";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    QL_NHANSU_TABLE_Load(sender, e);
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

        private void btt_cleartt_Click(object sender, EventArgs e)
        {
            txt_ns.Text = "";
            txt_hoten.Text = "";
            txt_phai.Text = "";
            txt_ngsinh.Text = "";
            txt_dt.Text = "";
            txt_phucap.Text = "";
            txt_madv.Text = "";
            txt_vaitro.Text = "";
        }

        private void txt_mans_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btt_timkiem.PerformClick();
            }
        }

        private void btt_Xoa_Click(object sender, EventArgs e)
        {
            string manv = txt_ns.Text;

            if (string.IsNullOrWhiteSpace(manv))
            {
                MessageBox.Show("Vui lòng nhập chọn nhân viên cần xoá!");
                return;
            }

            try
            {
                var cmd = new OracleCommand();
                cmd.CommandText = $"DELETE FROM ADPRO.NHANSU WHERE MANV = '{manv}'";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!");
                    QL_NHANSU_TABLE_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xóa!");
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 2292) // ORA-02292: integrity constraint violated - child record found
                {
                    MessageBox.Show("Nhân viên đã được phân công hoặc thuộc đơn vị, không thể xóa!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
