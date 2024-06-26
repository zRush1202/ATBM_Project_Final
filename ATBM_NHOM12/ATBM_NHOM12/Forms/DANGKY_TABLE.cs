﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_NHOM12.Forms
{
    public partial class DANGKY_TABLE : Form
    {
        private string roleUser = "";
        private string username = "";
        private string masvOld = "";
        private string magvOld = "";
        private string mahpOld = "";
        private string mactOld = "";
        private string hkOld = "";
        private string namOld = "";
        public static OracleConnection con = LoginProvider.conn;
        public DANGKY_TABLE(string role, string username)
        {
            InitializeComponent();
            this.username = username;
            this.roleUser = role;
        }
        private void DANGKY_TABLE_Load(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.QLHS_DANGKY_HPGD";
            if (roleUser == "RL_SINHVIEN")
            {
                btt_capnhatdiem.Visible = false;
                btt_them.Location = new Point(200, 245);
                btt_xoa.Location = new Point(400, 245);
                btt_refreshtt.Location = new Point(600, 245);
                txt_dth.ReadOnly = true;
                txt_dqt.ReadOnly = true;
                txt_dck.ReadOnly = true;
                txt_dtk.ReadOnly = true;
                txt_masv.ReadOnly = true;
                txt_masv.Text = username;
                query = "select * from ADPRO.DANGKY";
            }
            else if (roleUser == "RL_GIAOVU")
            {
                query = "select * from ADPRO.DANGKY";
                btt_capnhatdiem.Visible=false;
            }
            else
                query = "select * from ADPRO.QLHS_DANGKY_HPGD";
            if (roleUser == "RL_GIANGVIEN" || roleUser == "RL_TRUONGKHOA")
            {
                btt_them.Visible = false;
                btt_xoa.Visible = false;
                btt_refreshtt.Location = new Point(270,250);
                btt_capnhatdiem.Location = new Point(450, 250);
            }
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_dangky.DataSource = dataTable;
                dgv_dangky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btt_refreshds_Click(object sender, EventArgs e)
        {
            DANGKY_TABLE_Load(sender, e);
        }

        private void btt_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tk_mhp.Text))
            {
                return;
            }
            else
            {
                string query = "";
                if (this.roleUser == "RL_SINHVIEN")
                    query = $"SELECT * FROM ADPRO.DANGKY WHERE mahp LIKE '%{txt_tk_mhp.Text}%'";
                else
                    query = $"SELECT * FROM ADPRO.QLHS_DANGKY_HPGD WHERE mahp LIKE '%{txt_tk_mhp.Text}%'";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                try
                {
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv_dangky.DataSource = dataTable;
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

        private void btt_refreshtt_Click(object sender, EventArgs e)
        {
            txt_masv.Text = "";
            txt_magv.Text = "";
            txt_mahp.Text = "";
            txt_hk.Text = "";
            txt_mact.Text = "";
            txt_nam.Text = "";
            this.magvOld = "";
            this.masvOld = "";
            this.mahpOld = "";
            this.hkOld = "";
            this.mactOld = "";
            this.namOld = "";
        }
        private void dgv_dangky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_dangky.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_dangky.Rows[e.RowIndex];
                txt_masv.Text = row.Cells["MASV"].Value.ToString();
                this.masvOld = row.Cells["MASV"].Value.ToString();
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
                txt_dth.Text = row.Cells["DIEMTH"].Value.ToString();
                txt_dqt.Text = row.Cells["DIEMQT"].Value.ToString();
                txt_dck.Text = row.Cells["DIEMCK"].Value.ToString();
                txt_dtk.Text = row.Cells["DIEMTK"].Value.ToString();
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            THEM_DANGKY_TABLE newForm = new THEM_DANGKY_TABLE(roleUser,username);
            newForm.Show();
        }

        private void btt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các trường nhập liệu và gán vào các biến cụ thể
                string masv = txt_masv.Text;
                string magv = txt_magv.Text;
                string mahp = txt_mahp.Text;
                int hk = int.Parse(txt_hk.Text);
                int nam = int.Parse(txt_nam.Text);
                string mact = txt_mact.Text;

                // Hiển thị giá trị của các biến trong một MessageBox
                //MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                if (this.roleUser == "RL_SINHVIEN" || this.roleUser == "RL_GIAOVU")
                    cmd.CommandText = $"DELETE FROM ADPRO.DANGKY where masv = '{masv}' and magv ='{magv}' and mahp = '{mahp}' and hk = {hk} and nam = {nam} and mact = '{mact}'";
                else
                    cmd.CommandText = $"DELETE FROM ADPRO.QLHS_DANGKY_HPGD where masv = '{masv}' and magv ='{magv}' and mahp = '{mahp}' and hk = {hk} and nam = {nam} and mact = '{mact}'";
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
                string magv = txt_magv.Text; 
                string mahp = txt_mahp.Text;
                int hk = int.Parse(txt_hk.Text);
                int nam = int.Parse(txt_nam.Text);
                string mact = txt_mact.Text;
                string dth = txt_dth.Text;
                string dqt = txt_dqt.Text;
                string dck = txt_dck.Text;
                string dtk = txt_dtk.Text;
                // Hiển thị giá trị của các biến trong một MessageBox
                //MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                //MessageBox.Show($"magvold: {this.magvOld}, mahpold: {this.mahpOld}, hkold: {this.hkOld}, namOld: {this.namOld}, mactOld: {this.mactOld}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"UPDATE ADPRO.DANGKY set magv ='{magv}', mahp = '{mahp}', hk = {hk}, nam = {nam}, mact = '{mact}' where " +
                    $"magv ='{this.magvOld}' and mahp = '{this.mahpOld}' and hk = {this.hkOld} and nam = {this.namOld} and mact = '{this.mactOld}' ";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                   MessageBox.Show("Không có dữ liệu nào được cập nhật!");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ: hiển thị thông báo lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void btt_capnhatdiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.masvOld))
            {
                CAPNHATDIEM_DANGKY_TABLE newForm = new CAPNHATDIEM_DANGKY_TABLE(this.masvOld, this.magvOld, this.mahpOld, this.hkOld, this.namOld, this.mactOld);
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Đăng ký cần cập nhật điểm!");
            }
        }
    }
}
