namespace ATBM_NHOM12.Forms
{
    partial class QL_DSSINHVIEN_TABLE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_thongtin = new System.Windows.Forms.GroupBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_refreshtt = new System.Windows.Forms.Button();
            this.btt_capnhat = new System.Windows.Forms.Button();
            this.btt_them = new System.Windows.Forms.Button();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.txt_DThoai = new System.Windows.Forms.TextBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.lb_mact = new System.Windows.Forms.Label();
            this.lb_nam = new System.Windows.Forms.Label();
            this.lb_hk = new System.Windows.Forms.Label();
            this.lb_magv = new System.Windows.Forms.Label();
            this.lb_mahp = new System.Windows.Forms.Label();
            this.cb_phancong = new System.Windows.Forms.GroupBox();
            this.btt_refreshds = new System.Windows.Forms.Button();
            this.dgv_DSSinhVien = new System.Windows.Forms.DataGridView();
            this.btt_timkiem = new System.Windows.Forms.Button();
            this.lb_tk_mhp = new System.Windows.Forms.Label();
            this.txt_tk_mhp = new System.Windows.Forms.TextBox();
            this.cb_thongtin.SuspendLayout();
            this.cb_phancong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_thongtin
            // 
            this.cb_thongtin.Controls.Add(this.txt_MaSV);
            this.cb_thongtin.Controls.Add(this.textBox1);
            this.cb_thongtin.Controls.Add(this.label2);
            this.cb_thongtin.Controls.Add(this.btt_refreshtt);
            this.cb_thongtin.Controls.Add(this.btt_capnhat);
            this.cb_thongtin.Controls.Add(this.btt_them);
            this.cb_thongtin.Controls.Add(this.txt_NgaySinh);
            this.cb_thongtin.Controls.Add(this.txt_TenSV);
            this.cb_thongtin.Controls.Add(this.txt_DThoai);
            this.cb_thongtin.Controls.Add(this.txt_GioiTinh);
            this.cb_thongtin.Controls.Add(this.lb_mact);
            this.cb_thongtin.Controls.Add(this.lb_nam);
            this.cb_thongtin.Controls.Add(this.lb_hk);
            this.cb_thongtin.Controls.Add(this.lb_magv);
            this.cb_thongtin.Controls.Add(this.lb_mahp);
            this.cb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thongtin.Location = new System.Drawing.Point(12, 602);
            this.cb_thongtin.Name = "cb_thongtin";
            this.cb_thongtin.Size = new System.Drawing.Size(1147, 250);
            this.cb_thongtin.TabIndex = 3;
            this.cb_thongtin.TabStop = false;
            this.cb_thongtin.Text = "THÔNG TIN SINH VIÊN";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(172, 52);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(179, 24);
            this.txt_MaSV.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(552, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 24);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Địa chỉ";
            // 
            // btt_refreshtt
            // 
            this.btt_refreshtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshtt.Location = new System.Drawing.Point(931, 182);
            this.btt_refreshtt.Name = "btt_refreshtt";
            this.btt_refreshtt.Size = new System.Drawing.Size(144, 40);
            this.btt_refreshtt.TabIndex = 12;
            this.btt_refreshtt.Text = "CLEAR";
            this.btt_refreshtt.UseVisualStyleBackColor = true;
            this.btt_refreshtt.Click += new System.EventHandler(this.btt_refreshtt_Click);
            // 
            // btt_capnhat
            // 
            this.btt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_capnhat.Location = new System.Drawing.Point(931, 88);
            this.btt_capnhat.Name = "btt_capnhat";
            this.btt_capnhat.Size = new System.Drawing.Size(144, 40);
            this.btt_capnhat.TabIndex = 11;
            this.btt_capnhat.Text = "CẬP NHẬT";
            this.btt_capnhat.UseVisualStyleBackColor = true;
            this.btt_capnhat.Click += new System.EventHandler(this.btt_capnhat_Click);
            // 
            // btt_them
            // 
            this.btt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_them.Location = new System.Drawing.Point(931, 43);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(144, 39);
            this.btt_them.TabIndex = 4;
            this.btt_them.Text = "THÊM";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(552, 124);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(255, 24);
            this.txt_NgaySinh.TabIndex = 9;
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Location = new System.Drawing.Point(552, 52);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(255, 24);
            this.txt_TenSV.TabIndex = 8;
            // 
            // txt_DThoai
            // 
            this.txt_DThoai.Location = new System.Drawing.Point(172, 195);
            this.txt_DThoai.Name = "txt_DThoai";
            this.txt_DThoai.Size = new System.Drawing.Size(179, 24);
            this.txt_DThoai.TabIndex = 7;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Location = new System.Drawing.Point(172, 124);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(179, 24);
            this.txt_GioiTinh.TabIndex = 6;
            // 
            // lb_mact
            // 
            this.lb_mact.AutoSize = true;
            this.lb_mact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mact.Location = new System.Drawing.Point(439, 58);
            this.lb_mact.Name = "lb_mact";
            this.lb_mact.Size = new System.Drawing.Size(85, 18);
            this.lb_mact.TabIndex = 4;
            this.lb_mact.Text = "Họ và Tên";
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nam.Location = new System.Drawing.Point(439, 127);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(82, 18);
            this.lb_nam.TabIndex = 3;
            this.lb_nam.Text = "Ngày sinh";
            // 
            // lb_hk
            // 
            this.lb_hk.AutoSize = true;
            this.lb_hk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hk.Location = new System.Drawing.Point(46, 198);
            this.lb_hk.Name = "lb_hk";
            this.lb_hk.Size = new System.Drawing.Size(84, 18);
            this.lb_hk.TabIndex = 2;
            this.lb_hk.Text = "Điện thoại";
            // 
            // lb_magv
            // 
            this.lb_magv.AutoSize = true;
            this.lb_magv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_magv.Location = new System.Drawing.Point(46, 58);
            this.lb_magv.Name = "lb_magv";
            this.lb_magv.Size = new System.Drawing.Size(102, 18);
            this.lb_magv.TabIndex = 1;
            this.lb_magv.Text = "Mã sinh viên";
            // 
            // lb_mahp
            // 
            this.lb_mahp.AutoSize = true;
            this.lb_mahp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahp.Location = new System.Drawing.Point(46, 127);
            this.lb_mahp.Name = "lb_mahp";
            this.lb_mahp.Size = new System.Drawing.Size(71, 18);
            this.lb_mahp.TabIndex = 0;
            this.lb_mahp.Text = "Giới tính";
            // 
            // cb_phancong
            // 
            this.cb_phancong.Controls.Add(this.btt_refreshds);
            this.cb_phancong.Controls.Add(this.dgv_DSSinhVien);
            this.cb_phancong.Controls.Add(this.btt_timkiem);
            this.cb_phancong.Controls.Add(this.lb_tk_mhp);
            this.cb_phancong.Controls.Add(this.txt_tk_mhp);
            this.cb_phancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phancong.Location = new System.Drawing.Point(12, 12);
            this.cb_phancong.Name = "cb_phancong";
            this.cb_phancong.Size = new System.Drawing.Size(1147, 541);
            this.cb_phancong.TabIndex = 2;
            this.cb_phancong.TabStop = false;
            this.cb_phancong.Text = "DANH SÁCH SINH VIÊN";
            // 
            // btt_refreshds
            // 
            this.btt_refreshds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshds.Location = new System.Drawing.Point(1015, 23);
            this.btt_refreshds.Name = "btt_refreshds";
            this.btt_refreshds.Size = new System.Drawing.Size(126, 30);
            this.btt_refreshds.TabIndex = 4;
            this.btt_refreshds.Text = "REFRESH";
            this.btt_refreshds.UseVisualStyleBackColor = true;
            this.btt_refreshds.Click += new System.EventHandler(this.btt_refreshds_Click);
            // 
            // dgv_DSSinhVien
            // 
            this.dgv_DSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSinhVien.Location = new System.Drawing.Point(0, 77);
            this.dgv_DSSinhVien.Name = "dgv_DSSinhVien";
            this.dgv_DSSinhVien.RowHeadersWidth = 51;
            this.dgv_DSSinhVien.RowTemplate.Height = 24;
            this.dgv_DSSinhVien.Size = new System.Drawing.Size(1147, 464);
            this.dgv_DSSinhVien.TabIndex = 3;
            this.dgv_DSSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSinhVien_CellClick);
            // 
            // btt_timkiem
            // 
            this.btt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_timkiem.Location = new System.Drawing.Point(884, 23);
            this.btt_timkiem.Name = "btt_timkiem";
            this.btt_timkiem.Size = new System.Drawing.Size(125, 30);
            this.btt_timkiem.TabIndex = 2;
            this.btt_timkiem.Text = "TÌM KIẾM";
            this.btt_timkiem.UseVisualStyleBackColor = true;
            this.btt_timkiem.Click += new System.EventHandler(this.btt_timkiem_Click);
            // 
            // lb_tk_mhp
            // 
            this.lb_tk_mhp.AutoSize = true;
            this.lb_tk_mhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk_mhp.Location = new System.Drawing.Point(528, 29);
            this.lb_tk_mhp.Name = "lb_tk_mhp";
            this.lb_tk_mhp.Size = new System.Drawing.Size(102, 18);
            this.lb_tk_mhp.TabIndex = 1;
            this.lb_tk_mhp.Text = "Mã sinh viên";
            // 
            // txt_tk_mhp
            // 
            this.txt_tk_mhp.Location = new System.Drawing.Point(654, 26);
            this.txt_tk_mhp.Name = "txt_tk_mhp";
            this.txt_tk_mhp.Size = new System.Drawing.Size(224, 24);
            this.txt_tk_mhp.TabIndex = 0;
            // 
            // QL_DSSINHVIEN_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 864);
            this.Controls.Add(this.cb_thongtin);
            this.Controls.Add(this.cb_phancong);
            this.Name = "QL_DSSINHVIEN_TABLE";
            this.Text = "QL_DSSINHVIEN_TABLE";
            this.Load += new System.EventHandler(this.QL_DSSINHVIEN_TABLE_Load);
            this.cb_thongtin.ResumeLayout(false);
            this.cb_thongtin.PerformLayout();
            this.cb_phancong.ResumeLayout(false);
            this.cb_phancong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cb_thongtin;
        private System.Windows.Forms.Button btt_refreshtt;
        private System.Windows.Forms.Button btt_capnhat;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.TextBox txt_DThoai;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.Label lb_mact;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.Label lb_hk;
        private System.Windows.Forms.Label lb_magv;
        private System.Windows.Forms.Label lb_mahp;
        private System.Windows.Forms.GroupBox cb_phancong;
        private System.Windows.Forms.Button btt_refreshds;
        private System.Windows.Forms.DataGridView dgv_DSSinhVien;
        private System.Windows.Forms.Button btt_timkiem;
        private System.Windows.Forms.Label lb_tk_mhp;
        private System.Windows.Forms.TextBox txt_tk_mhp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSV;
    }
}