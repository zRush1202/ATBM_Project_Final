﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class THEM_PHANCONG_TABLE : Form
    {
        public static OracleConnection con = LoginProvider.conn;
        private string roleUser = "RL_TRUONGDV";
        public THEM_PHANCONG_TABLE()
        {
            InitializeComponent();
        }
        private void THEM_PHANCONG_TABLE_Load(object sender, EventArgs e)
        {
            string query = "select * from ADPRO.KHMO"; ;
            OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                dgv_khmo.DataSource = dataTable;
                dgv_khmo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgv_khmo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgv_khmo.Rows.Count) // Make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dgv_khmo.Rows[e.RowIndex];
                txt_mahp.Text = row.Cells["MAHP"].Value.ToString();
                txt_hk.Text = row.Cells["HK"].Value.ToString();
                txt_mact.Text = row.Cells["MACT"].Value.ToString();
                txt_nam.Text = row.Cells["NAM"].Value.ToString();
            }
        }

        private void btt_them_Click(object sender, EventArgs e)
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
                // MessageBox.Show($"magv: {magv}, mahp: {mahp}, hk: {hk}, nam: {nam}, mact: {mact}");

                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                var cmd = new OracleCommand();
                cmd.CommandText = $"INSERT INTO ADPRO.PHANCONG VALUES('{magv}','{mahp}',{hk},{nam},'{mact}')";
                cmd.Connection = con;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Thông báo thành công hoặc thực hiện các hành động khác sau khi thêm thành công
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                else
                {
                    if (this.roleUser == "RL_TRUONGDV")
                    {
                        MessageBox.Show("Học phần không thuộc đơn vị mình làm trưởng!\nThêm thất bại.");
                    }
                    else
                        // Thông báo khi không có dòng nào bị xóa
                        MessageBox.Show("Không có dữ liệu nào được xóa!");
                }
            }
            catch (Exception ex)
            {
                if (this.roleUser == "RL_TRUONGDV")
                {
                    MessageBox.Show("Học phần không thuộc đơn vị mình làm trưởng!");
                }
                else
                    // Xử lý ngoại lệ ở đây, ví dụ: hiển thị thông báo lỗi
                    MessageBox.Show(ex.Message);
            }
        }
        private void txt_magv_Load(object sender, EventArgs e)
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
