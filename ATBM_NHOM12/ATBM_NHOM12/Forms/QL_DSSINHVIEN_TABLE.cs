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
    public partial class QL_DSSINHVIEN_TABLE : Form
    {
        private string roleUser = "";
        private string username = "";
        public static OracleConnection con = LoginProvider.conn;
        public QL_DSSINHVIEN_TABLE(string role, string username)
        {
            InitializeComponent();
            this.username = username;
            this.roleUser = role;   
        }

        private void QL_DSSINHVIEN_TABLE_Load(object sender, EventArgs e)
        {
            if (roleUser == "RL_NVCOBAN" || roleUser == "RL_GIANGVIEN")
            {
                btt_them.Visible = false;
                btt_capnhat.Visible = false;
            }

            string query = "select* from ADPRO.SINHVIEN where rownum <= 200";
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_DSSinhVien.DataSource = dataTable;
                dgv_DSSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            string masv = txt_sv.Text;
            string hoten = txt_hoten.Text;
            string phai = txt_phai.Text;
            string ngsinh = txt_ngsinh.Text;
            string dchi = txt_dchi.Text;
            string dt = txt_dt.Text;
            string mact = txt_mact.Text;
            string manganh = txt_manganh.Text;
            int sotctl = int.TryParse(txt_sotctl.Text, out int sotctlResult) ? sotctlResult : 0;
            float dtbtl = float.TryParse(txt_dtbtl.Text, out float dtbtlResult) ? dtbtlResult : 0f;

            if (string.IsNullOrWhiteSpace(masv) || string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(phai) || string.IsNullOrWhiteSpace(ngsinh) || string.IsNullOrWhiteSpace(dchi) || string.IsNullOrWhiteSpace(dt) || string.IsNullOrWhiteSpace(mact) || string.IsNullOrWhiteSpace(manganh))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            try
            {
                var cmd = new OracleCommand();
                cmd.CommandText = $@"
                INSERT INTO ADPRO.SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL)
                VALUES (
                        '{masv}', 
                        '{hoten}', 
                        '{phai}', 
                        TO_DATE('{ngsinh}', 'dd-MM-yyyy'), 
                        '{dchi}', 
                        '{dt}', 
                        '{mact}', 
                        '{manganh}', 
                        {sotctl}, 
                        {dtbtl}
                )";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                    QL_DSSINHVIEN_TABLE_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được thêm!");
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 00001)
                {
                    MessageBox.Show("Đã tồn tại mã sinh viên này!");
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

        private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_masv_search.Text))
            {
                return;
            }
            else
            {
                string query = $"SELECT * FROM ADPRO.SINHVIEN WHERE MASV LIKE '%{txt_masv_search.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_DSSinhVien.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên có mã đó!");
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
            QL_DSSINHVIEN_TABLE_Load(sender, e);
        }

        private void dgv_DSSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_DSSinhVien.Rows.Count) 
            {
                DataGridViewRow row = this.dgv_DSSinhVien.Rows[e.RowIndex];
                txt_sv.Text = row.Cells["MASV"].Value.ToString();
                txt_hoten.Text = row.Cells["HOTEN"].Value.ToString();
                txt_phai.Text = row.Cells["PHAI"].Value.ToString();
                DateTime ngsinh = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                txt_ngsinh.Text = ngsinh.ToString("dd-MM-yyyy");
                txt_dchi.Text = row.Cells["DCHI"].Value.ToString();
                txt_dt.Text = row.Cells["DT"].Value.ToString();
                txt_mact.Text = row.Cells["MACT"].Value.ToString();
                txt_manganh.Text = row.Cells["MANGANH"].Value   .ToString();
                txt_sotctl.Text = row.Cells["SOTCTL"].Value.ToString();
                txt_dtbtl.Text = row.Cells["DTBTL"].Value.ToString();
                txt_sv.ReadOnly = true;
            }

        }

        private void btt_capnhat_Click(object sender, EventArgs e)
        {
            string masv = txt_sv.Text;
            string hoten = txt_hoten.Text;
            string phai = txt_phai.Text;
            string ngsinh = txt_ngsinh.Text;
            string dchi = txt_dchi.Text;
            string dt = txt_dt.Text;
            string mact = txt_mact.Text;
            string manganh = txt_manganh.Text;

            // Ensure that txt_sotctl.Text and txt_dtbtl.Text are valid numbers before parsing
            int sotctl = int.TryParse(txt_sotctl.Text, out int sotctlResult) ? sotctlResult : 0;
            float dtbtl = float.TryParse(txt_dtbtl.Text, out float dtbtlResult) ? dtbtlResult : 0f;
            try
            {
                var cmd = new OracleCommand();
                cmd.CommandText = $@"
                    UPDATE ADPRO.SINHVIEN 
                    SET 
                        HOTEN = '{hoten}', 
                        PHAI = '{phai}', 
                        NGSINH = TO_DATE('{ngsinh}', 'dd-MM-yyyy'), 
                        DCHI = '{dchi}', 
                        DT = '{dt}', 
                        MACT = '{mact}', 
                        MANGANH = '{manganh}', 
                        SOTCTL = {sotctl}, 
                        DTBTL = {dtbtl} 
                    WHERE 
                        MASV = '{masv}'
                ";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    QL_DSSINHVIEN_TABLE_Load(sender, e);
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
            txt_sv.Text = "";
            txt_hoten.Text = "";
            txt_phai.Text = "";
            txt_ngsinh.Text = "";
            txt_dchi.Text = "";
            txt_dt.Text = "";
            txt_mact.Text = "";
            txt_manganh.Text = "";
            txt_sotctl.Text = "";
            txt_dtbtl.Text = "";
            txt_sv.ReadOnly = false;
        }

        private void txt_masv_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btt_timkiem.PerformClick();
            }
        }
    }
}
