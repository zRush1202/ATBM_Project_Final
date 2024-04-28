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
            this.cb_phancong = new System.Windows.Forms.GroupBox();
            this.btt_refreshds = new System.Windows.Forms.Button();
            this.dgv_DSSinhVien = new System.Windows.Forms.DataGridView();
            this.btt_timkiem = new System.Windows.Forms.Button();
            this.lb_tk_mhp = new System.Windows.Forms.Label();
            this.txt_masv_search = new System.Windows.Forms.TextBox();
            this.btt_them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_dtbtl = new System.Windows.Forms.TextBox();
            this.lb_diemtbtl = new System.Windows.Forms.Label();
            this.txt_sotctl = new System.Windows.Forms.TextBox();
            this.txt_manganh = new System.Windows.Forms.TextBox();
            this.txt_mact = new System.Windows.Forms.TextBox();
            this.txt_sv = new System.Windows.Forms.TextBox();
            this.lb_sotctl = new System.Windows.Forms.Label();
            this.lb_manganh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_masv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_dchi = new System.Windows.Forms.TextBox();
            this.lv_diachi = new System.Windows.Forms.Label();
            this.txt_ngsinh = new System.Windows.Forms.TextBox();
            this.txt_phai = new System.Windows.Forms.TextBox();
            this.lb_phai = new System.Windows.Forms.Label();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.lb_hoten = new System.Windows.Forms.Label();
            this.lb_dt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btt_cleartt = new System.Windows.Forms.Button();
            this.btt_capnhat = new System.Windows.Forms.Button();
            this.cb_phancong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSinhVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_phancong
            // 
            this.cb_phancong.Controls.Add(this.btt_refreshds);
            this.cb_phancong.Controls.Add(this.dgv_DSSinhVien);
            this.cb_phancong.Controls.Add(this.btt_timkiem);
            this.cb_phancong.Controls.Add(this.lb_tk_mhp);
            this.cb_phancong.Controls.Add(this.txt_masv_search);
            this.cb_phancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phancong.Location = new System.Drawing.Point(12, 12);
            this.cb_phancong.Name = "cb_phancong";
            this.cb_phancong.Size = new System.Drawing.Size(613, 694);
            this.cb_phancong.TabIndex = 2;
            this.cb_phancong.TabStop = false;
            this.cb_phancong.Text = "DANH SÁCH SINH VIÊN";
            // 
            // btt_refreshds
            // 
            this.btt_refreshds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshds.Location = new System.Drawing.Point(481, 41);
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
            this.dgv_DSSinhVien.Size = new System.Drawing.Size(607, 617);
            this.dgv_DSSinhVien.TabIndex = 3;
            this.dgv_DSSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSinhVien_CellClick);
            // 
            // btt_timkiem
            // 
            this.btt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_timkiem.Location = new System.Drawing.Point(350, 41);
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
            this.lb_tk_mhp.Location = new System.Drawing.Point(5, 47);
            this.lb_tk_mhp.Name = "lb_tk_mhp";
            this.lb_tk_mhp.Size = new System.Drawing.Size(102, 18);
            this.lb_tk_mhp.TabIndex = 1;
            this.lb_tk_mhp.Text = "Mã sinh viên";
            // 
            // txt_masv_search
            // 
            this.txt_masv_search.Location = new System.Drawing.Point(120, 44);
            this.txt_masv_search.Name = "txt_masv_search";
            this.txt_masv_search.Size = new System.Drawing.Size(224, 24);
            this.txt_masv_search.TabIndex = 0;
            this.txt_masv_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_masv_search_KeyUp);
            // 
            // btt_them
            // 
            this.btt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_them.Location = new System.Drawing.Point(243, 23);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(126, 30);
            this.btt_them.TabIndex = 13;
            this.btt_them.Text = "THÊM";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.txt_dtbtl);
            this.panel2.Controls.Add(this.lb_diemtbtl);
            this.panel2.Controls.Add(this.txt_sotctl);
            this.panel2.Controls.Add(this.txt_manganh);
            this.panel2.Controls.Add(this.txt_mact);
            this.panel2.Controls.Add(this.txt_sv);
            this.panel2.Controls.Add(this.lb_sotctl);
            this.panel2.Controls.Add(this.lb_manganh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lb_masv);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 305);
            this.panel2.TabIndex = 7;
            // 
            // txt_dtbtl
            // 
            this.txt_dtbtl.Location = new System.Drawing.Point(157, 253);
            this.txt_dtbtl.Name = "txt_dtbtl";
            this.txt_dtbtl.Size = new System.Drawing.Size(323, 30);
            this.txt_dtbtl.TabIndex = 19;
            // 
            // lb_diemtbtl
            // 
            this.lb_diemtbtl.AutoSize = true;
            this.lb_diemtbtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diemtbtl.Location = new System.Drawing.Point(5, 258);
            this.lb_diemtbtl.Name = "lb_diemtbtl";
            this.lb_diemtbtl.Size = new System.Drawing.Size(121, 25);
            this.lb_diemtbtl.TabIndex = 18;
            this.lb_diemtbtl.Text = "Điểm TBTL";
            // 
            // txt_sotctl
            // 
            this.txt_sotctl.Location = new System.Drawing.Point(157, 200);
            this.txt_sotctl.Name = "txt_sotctl";
            this.txt_sotctl.Size = new System.Drawing.Size(323, 30);
            this.txt_sotctl.TabIndex = 16;
            // 
            // txt_manganh
            // 
            this.txt_manganh.Location = new System.Drawing.Point(157, 138);
            this.txt_manganh.Name = "txt_manganh";
            this.txt_manganh.Size = new System.Drawing.Size(323, 30);
            this.txt_manganh.TabIndex = 15;
            // 
            // txt_mact
            // 
            this.txt_mact.Location = new System.Drawing.Point(157, 77);
            this.txt_mact.Name = "txt_mact";
            this.txt_mact.Size = new System.Drawing.Size(323, 30);
            this.txt_mact.TabIndex = 13;
            // 
            // txt_sv
            // 
            this.txt_sv.Location = new System.Drawing.Point(157, 20);
            this.txt_sv.Name = "txt_sv";
            this.txt_sv.Size = new System.Drawing.Size(323, 30);
            this.txt_sv.TabIndex = 12;
            // 
            // lb_sotctl
            // 
            this.lb_sotctl.AutoSize = true;
            this.lb_sotctl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sotctl.Location = new System.Drawing.Point(5, 205);
            this.lb_sotctl.Name = "lb_sotctl";
            this.lb_sotctl.Size = new System.Drawing.Size(101, 25);
            this.lb_sotctl.TabIndex = 11;
            this.lb_sotctl.Text = "Số TCTL";
            // 
            // lb_manganh
            // 
            this.lb_manganh.AutoSize = true;
            this.lb_manganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manganh.Location = new System.Drawing.Point(5, 143);
            this.lb_manganh.Name = "lb_manganh";
            this.lb_manganh.Size = new System.Drawing.Size(108, 25);
            this.lb_manganh.TabIndex = 10;
            this.lb_manganh.Text = "Mã ngành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã CT";
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masv.Location = new System.Drawing.Point(5, 25);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(134, 25);
            this.lb_masv.TabIndex = 7;
            this.lb_masv.Text = "Mã sinh viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.txt_dchi);
            this.panel1.Controls.Add(this.lv_diachi);
            this.panel1.Controls.Add(this.txt_ngsinh);
            this.panel1.Controls.Add(this.txt_phai);
            this.panel1.Controls.Add(this.lb_phai);
            this.panel1.Controls.Add(this.txt_dt);
            this.panel1.Controls.Add(this.lb_ngaysinh);
            this.panel1.Controls.Add(this.txt_hoten);
            this.panel1.Controls.Add(this.lb_hoten);
            this.panel1.Controls.Add(this.lb_dt);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 316);
            this.panel1.TabIndex = 6;
            // 
            // txt_dchi
            // 
            this.txt_dchi.Location = new System.Drawing.Point(157, 253);
            this.txt_dchi.Name = "txt_dchi";
            this.txt_dchi.Size = new System.Drawing.Size(323, 30);
            this.txt_dchi.TabIndex = 16;
            // 
            // lv_diachi
            // 
            this.lv_diachi.AutoSize = true;
            this.lv_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_diachi.Location = new System.Drawing.Point(13, 257);
            this.lv_diachi.Name = "lv_diachi";
            this.lv_diachi.Size = new System.Drawing.Size(78, 25);
            this.lv_diachi.TabIndex = 15;
            this.lv_diachi.Text = "Địa chỉ";
            // 
            // txt_ngsinh
            // 
            this.txt_ngsinh.Location = new System.Drawing.Point(157, 144);
            this.txt_ngsinh.Name = "txt_ngsinh";
            this.txt_ngsinh.Size = new System.Drawing.Size(323, 30);
            this.txt_ngsinh.TabIndex = 6;
            // 
            // txt_phai
            // 
            this.txt_phai.Location = new System.Drawing.Point(157, 83);
            this.txt_phai.Name = "txt_phai";
            this.txt_phai.Size = new System.Drawing.Size(323, 30);
            this.txt_phai.TabIndex = 5;
            // 
            // lb_phai
            // 
            this.lb_phai.AutoSize = true;
            this.lb_phai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phai.Location = new System.Drawing.Point(13, 87);
            this.lb_phai.Name = "lb_phai";
            this.lb_phai.Size = new System.Drawing.Size(91, 25);
            this.lb_phai.TabIndex = 4;
            this.lb_phai.Text = "Giới tính";
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(157, 203);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(323, 30);
            this.txt_dt.TabIndex = 14;
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.Location = new System.Drawing.Point(13, 148);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(108, 25);
            this.lb_ngaysinh.TabIndex = 3;
            this.lb_ngaysinh.Text = "Ngày sinh";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(157, 28);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(323, 30);
            this.txt_hoten.TabIndex = 2;
            // 
            // lb_hoten
            // 
            this.lb_hoten.AutoSize = true;
            this.lb_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoten.Location = new System.Drawing.Point(13, 32);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(75, 25);
            this.lb_hoten.TabIndex = 1;
            this.lb_hoten.Text = "Họ tên";
            // 
            // lb_dt
            // 
            this.lb_dt.AutoSize = true;
            this.lb_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dt.Location = new System.Drawing.Point(13, 207);
            this.lb_dt.Name = "lb_dt";
            this.lb_dt.Size = new System.Drawing.Size(109, 25);
            this.lb_dt.TabIndex = 9;
            this.lb_dt.Text = "Điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btt_them);
            this.groupBox1.Controls.Add(this.btt_cleartt);
            this.groupBox1.Controls.Add(this.btt_capnhat);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(653, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 679);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // btt_cleartt
            // 
            this.btt_cleartt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_cleartt.Location = new System.Drawing.Point(0, 26);
            this.btt_cleartt.Name = "btt_cleartt";
            this.btt_cleartt.Size = new System.Drawing.Size(125, 30);
            this.btt_cleartt.TabIndex = 15;
            this.btt_cleartt.Text = "CLEAR";
            this.btt_cleartt.UseVisualStyleBackColor = true;
            this.btt_cleartt.Click += new System.EventHandler(this.btt_cleartt_Click);
            // 
            // btt_capnhat
            // 
            this.btt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_capnhat.Location = new System.Drawing.Point(375, 23);
            this.btt_capnhat.Name = "btt_capnhat";
            this.btt_capnhat.Size = new System.Drawing.Size(125, 30);
            this.btt_capnhat.TabIndex = 14;
            this.btt_capnhat.Text = "CẬP NHẬT";
            this.btt_capnhat.UseVisualStyleBackColor = true;
            this.btt_capnhat.Click += new System.EventHandler(this.btt_capnhat_Click);
            // 
            // QL_DSSINHVIEN_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_phancong);
            this.Name = "QL_DSSINHVIEN_TABLE";
            this.Text = "QL_DSSINHVIEN_TABLE";
            this.Load += new System.EventHandler(this.QL_DSSINHVIEN_TABLE_Load);
            this.cb_phancong.ResumeLayout(false);
            this.cb_phancong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSinhVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox cb_phancong;
        private System.Windows.Forms.Button btt_refreshds;
        private System.Windows.Forms.DataGridView dgv_DSSinhVien;
        private System.Windows.Forms.Button btt_timkiem;
        private System.Windows.Forms.Label lb_tk_mhp;
        private System.Windows.Forms.TextBox txt_masv_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_dtbtl;
        private System.Windows.Forms.Label lb_diemtbtl;
        private System.Windows.Forms.TextBox txt_sotctl;
        private System.Windows.Forms.TextBox txt_manganh;
        private System.Windows.Forms.TextBox txt_mact;
        private System.Windows.Forms.TextBox txt_sv;
        private System.Windows.Forms.Label lb_sotctl;
        private System.Windows.Forms.Label lb_manganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_masv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_dchi;
        private System.Windows.Forms.Label lv_diachi;
        private System.Windows.Forms.TextBox txt_ngsinh;
        private System.Windows.Forms.TextBox txt_phai;
        private System.Windows.Forms.Label lb_phai;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.Label lb_dt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_cleartt;
        private System.Windows.Forms.Button btt_capnhat;
        private System.Windows.Forms.Button btt_them;
    }
}