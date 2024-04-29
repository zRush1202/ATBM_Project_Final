namespace ATBM_NHOM12.Forms
{
    partial class QL_NHANSU_TABLE
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
            this.dgv_DSNhanSu = new System.Windows.Forms.DataGridView();
            this.btt_timkiem = new System.Windows.Forms.Button();
            this.lb_tk_mhp = new System.Windows.Forms.Label();
            this.txt_mans_search = new System.Windows.Forms.TextBox();
            this.btt_them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_vaitro = new System.Windows.Forms.TextBox();
            this.lb_diemtbtl = new System.Windows.Forms.Label();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.txt_phucap = new System.Windows.Forms.TextBox();
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.lb_sotctl = new System.Windows.Forms.Label();
            this.lb_manganh = new System.Windows.Forms.Label();
            this.lb_masv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btt_Xoa = new System.Windows.Forms.Button();
            this.cb_phancong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNhanSu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_phancong
            // 
            this.cb_phancong.Controls.Add(this.btt_refreshds);
            this.cb_phancong.Controls.Add(this.dgv_DSNhanSu);
            this.cb_phancong.Controls.Add(this.btt_timkiem);
            this.cb_phancong.Controls.Add(this.lb_tk_mhp);
            this.cb_phancong.Controls.Add(this.txt_mans_search);
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
            // dgv_DSNhanSu
            // 
            this.dgv_DSNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSNhanSu.Location = new System.Drawing.Point(0, 77);
            this.dgv_DSNhanSu.Name = "dgv_DSNhanSu";
            this.dgv_DSNhanSu.RowHeadersWidth = 51;
            this.dgv_DSNhanSu.RowTemplate.Height = 24;
            this.dgv_DSNhanSu.Size = new System.Drawing.Size(607, 617);
            this.dgv_DSNhanSu.TabIndex = 3;
            this.dgv_DSNhanSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSinhVien_CellClick);
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
            this.lb_tk_mhp.Size = new System.Drawing.Size(95, 18);
            this.lb_tk_mhp.TabIndex = 1;
            this.lb_tk_mhp.Text = "Mã nhân sự";
            // 
            // txt_mans_search
            // 
            this.txt_mans_search.Location = new System.Drawing.Point(120, 44);
            this.txt_mans_search.Name = "txt_mans_search";
            this.txt_mans_search.Size = new System.Drawing.Size(224, 24);
            this.txt_mans_search.TabIndex = 0;
            this.txt_mans_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mans_search_KeyUp);
            // 
            // btt_them
            // 
            this.btt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_them.Location = new System.Drawing.Point(111, 23);
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
            this.panel2.Controls.Add(this.txt_vaitro);
            this.panel2.Controls.Add(this.lb_diemtbtl);
            this.panel2.Controls.Add(this.txt_madv);
            this.panel2.Controls.Add(this.txt_phucap);
            this.panel2.Controls.Add(this.txt_ns);
            this.panel2.Controls.Add(this.lb_sotctl);
            this.panel2.Controls.Add(this.lb_manganh);
            this.panel2.Controls.Add(this.lb_masv);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 305);
            this.panel2.TabIndex = 7;
            // 
            // txt_vaitro
            // 
            this.txt_vaitro.Location = new System.Drawing.Point(157, 253);
            this.txt_vaitro.Name = "txt_vaitro";
            this.txt_vaitro.Size = new System.Drawing.Size(323, 30);
            this.txt_vaitro.TabIndex = 19;
            // 
            // lb_diemtbtl
            // 
            this.lb_diemtbtl.AutoSize = true;
            this.lb_diemtbtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diemtbtl.Location = new System.Drawing.Point(5, 258);
            this.lb_diemtbtl.Name = "lb_diemtbtl";
            this.lb_diemtbtl.Size = new System.Drawing.Size(75, 25);
            this.lb_diemtbtl.TabIndex = 18;
            this.lb_diemtbtl.Text = "Vai trò";
            // 
            // txt_madv
            // 
            this.txt_madv.Location = new System.Drawing.Point(157, 104);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(323, 30);
            this.txt_madv.TabIndex = 16;
            // 
            // txt_phucap
            // 
            this.txt_phucap.Location = new System.Drawing.Point(157, 181);
            this.txt_phucap.Name = "txt_phucap";
            this.txt_phucap.Size = new System.Drawing.Size(323, 30);
            this.txt_phucap.TabIndex = 15;
            // 
            // txt_ns
            // 
            this.txt_ns.Location = new System.Drawing.Point(157, 33);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(323, 30);
            this.txt_ns.TabIndex = 12;
            // 
            // lb_sotctl
            // 
            this.lb_sotctl.AutoSize = true;
            this.lb_sotctl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sotctl.Location = new System.Drawing.Point(5, 109);
            this.lb_sotctl.Name = "lb_sotctl";
            this.lb_sotctl.Size = new System.Drawing.Size(106, 25);
            this.lb_sotctl.TabIndex = 11;
            this.lb_sotctl.Text = "Mã đơn vị";
            // 
            // lb_manganh
            // 
            this.lb_manganh.AutoSize = true;
            this.lb_manganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manganh.Location = new System.Drawing.Point(5, 186);
            this.lb_manganh.Name = "lb_manganh";
            this.lb_manganh.Size = new System.Drawing.Size(91, 25);
            this.lb_manganh.TabIndex = 10;
            this.lb_manganh.Text = "Phụ cấp";
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masv.Location = new System.Drawing.Point(5, 38);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(125, 25);
            this.lb_masv.TabIndex = 7;
            this.lb_masv.Text = "Mã nhân sự";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
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
            // txt_ngsinh
            // 
            this.txt_ngsinh.Location = new System.Drawing.Point(157, 172);
            this.txt_ngsinh.Name = "txt_ngsinh";
            this.txt_ngsinh.Size = new System.Drawing.Size(323, 30);
            this.txt_ngsinh.TabIndex = 6;
            // 
            // txt_phai
            // 
            this.txt_phai.Location = new System.Drawing.Point(157, 100);
            this.txt_phai.Name = "txt_phai";
            this.txt_phai.Size = new System.Drawing.Size(323, 30);
            this.txt_phai.TabIndex = 5;
            // 
            // lb_phai
            // 
            this.lb_phai.AutoSize = true;
            this.lb_phai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phai.Location = new System.Drawing.Point(13, 104);
            this.lb_phai.Name = "lb_phai";
            this.lb_phai.Size = new System.Drawing.Size(91, 25);
            this.lb_phai.TabIndex = 4;
            this.lb_phai.Text = "Giới tính";
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(157, 242);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(323, 30);
            this.txt_dt.TabIndex = 14;
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.Location = new System.Drawing.Point(13, 176);
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
            this.lb_dt.Location = new System.Drawing.Point(13, 246);
            this.lb_dt.Name = "lb_dt";
            this.lb_dt.Size = new System.Drawing.Size(109, 25);
            this.lb_dt.TabIndex = 9;
            this.lb_dt.Text = "Điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btt_Xoa);
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
            this.groupBox1.Text = "THÔNG TIN NHÂN SỰ";
            // 
            // btt_cleartt
            // 
            this.btt_cleartt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_cleartt.Location = new System.Drawing.Point(0, 26);
            this.btt_cleartt.Name = "btt_cleartt";
            this.btt_cleartt.Size = new System.Drawing.Size(80, 30);
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
            // btt_Xoa
            // 
            this.btt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Xoa.Location = new System.Drawing.Point(243, 23);
            this.btt_Xoa.Name = "btt_Xoa";
            this.btt_Xoa.Size = new System.Drawing.Size(126, 30);
            this.btt_Xoa.TabIndex = 16;
            this.btt_Xoa.Text = "XOÁ";
            this.btt_Xoa.UseVisualStyleBackColor = true;
            this.btt_Xoa.Click += new System.EventHandler(this.btt_Xoa_Click);
            // 
            // QL_NHANSU_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_phancong);
            this.Name = "QL_NHANSU_TABLE";
            this.Text = "QL_NHANSU_TABLE";
            this.Load += new System.EventHandler(this.QL_NHANSU_TABLE_Load);
            this.cb_phancong.ResumeLayout(false);
            this.cb_phancong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNhanSu)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_DSNhanSu;
        private System.Windows.Forms.Button btt_timkiem;
        private System.Windows.Forms.Label lb_tk_mhp;
        private System.Windows.Forms.TextBox txt_mans_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_vaitro;
        private System.Windows.Forms.Label lb_diemtbtl;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.TextBox txt_phucap;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.Label lb_sotctl;
        private System.Windows.Forms.Label lb_manganh;
        private System.Windows.Forms.Label lb_masv;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button btt_Xoa;
    }
}