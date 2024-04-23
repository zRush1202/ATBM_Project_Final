namespace ATBM_NHOM12.Forms
{
    partial class HOCPHAN_TABLE
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
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.lb_madv = new System.Windows.Forms.Label();
            this.txt_sosvtd = new System.Windows.Forms.TextBox();
            this.lb_sosvtd = new System.Windows.Forms.Label();
            this.btt_refreshtt = new System.Windows.Forms.Button();
            this.btt_capnhat = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_them = new System.Windows.Forms.Button();
            this.txt_stth = new System.Windows.Forms.TextBox();
            this.txt_stlt = new System.Windows.Forms.TextBox();
            this.txt_sotc = new System.Windows.Forms.TextBox();
            this.txt_mahp = new System.Windows.Forms.TextBox();
            this.txt_tenhp = new System.Windows.Forms.TextBox();
            this.lb_stlt = new System.Windows.Forms.Label();
            this.lb_stth = new System.Windows.Forms.Label();
            this.lb_sotc = new System.Windows.Forms.Label();
            this.lb_tenhp = new System.Windows.Forms.Label();
            this.lb_mahp = new System.Windows.Forms.Label();
            this.cb_phancong = new System.Windows.Forms.GroupBox();
            this.btt_refreshds = new System.Windows.Forms.Button();
            this.dgv_hocphan = new System.Windows.Forms.DataGridView();
            this.btt_timkiem = new System.Windows.Forms.Button();
            this.lb_tk_mhp = new System.Windows.Forms.Label();
            this.txt_tk_mhp = new System.Windows.Forms.TextBox();
            this.cb_thongtin.SuspendLayout();
            this.cb_phancong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocphan)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_thongtin
            // 
            this.cb_thongtin.Controls.Add(this.txt_madv);
            this.cb_thongtin.Controls.Add(this.lb_madv);
            this.cb_thongtin.Controls.Add(this.txt_sosvtd);
            this.cb_thongtin.Controls.Add(this.lb_sosvtd);
            this.cb_thongtin.Controls.Add(this.btt_refreshtt);
            this.cb_thongtin.Controls.Add(this.btt_capnhat);
            this.cb_thongtin.Controls.Add(this.btt_xoa);
            this.cb_thongtin.Controls.Add(this.btt_them);
            this.cb_thongtin.Controls.Add(this.txt_stth);
            this.cb_thongtin.Controls.Add(this.txt_stlt);
            this.cb_thongtin.Controls.Add(this.txt_sotc);
            this.cb_thongtin.Controls.Add(this.txt_mahp);
            this.cb_thongtin.Controls.Add(this.txt_tenhp);
            this.cb_thongtin.Controls.Add(this.lb_stlt);
            this.cb_thongtin.Controls.Add(this.lb_stth);
            this.cb_thongtin.Controls.Add(this.lb_sotc);
            this.cb_thongtin.Controls.Add(this.lb_tenhp);
            this.cb_thongtin.Controls.Add(this.lb_mahp);
            this.cb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thongtin.Location = new System.Drawing.Point(12, 333);
            this.cb_thongtin.Name = "cb_thongtin";
            this.cb_thongtin.Size = new System.Drawing.Size(1001, 240);
            this.cb_thongtin.TabIndex = 3;
            this.cb_thongtin.TabStop = false;
            this.cb_thongtin.Text = "THÔNG TIN HỌC PHẦN";
            // 
            // txt_madv
            // 
            this.txt_madv.Location = new System.Drawing.Point(502, 145);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(196, 24);
            this.txt_madv.TabIndex = 16;
            // 
            // lb_madv
            // 
            this.lb_madv.AutoSize = true;
            this.lb_madv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madv.Location = new System.Drawing.Point(392, 148);
            this.lb_madv.Name = "lb_madv";
            this.lb_madv.Size = new System.Drawing.Size(81, 18);
            this.lb_madv.TabIndex = 15;
            this.lb_madv.Text = "Mã đơn vị";
            // 
            // txt_sosvtd
            // 
            this.txt_sosvtd.Location = new System.Drawing.Point(502, 93);
            this.txt_sosvtd.Name = "txt_sosvtd";
            this.txt_sosvtd.Size = new System.Drawing.Size(196, 24);
            this.txt_sosvtd.TabIndex = 14;
            // 
            // lb_sosvtd
            // 
            this.lb_sosvtd.AutoSize = true;
            this.lb_sosvtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sosvtd.Location = new System.Drawing.Point(392, 96);
            this.lb_sosvtd.Name = "lb_sosvtd";
            this.lb_sosvtd.Size = new System.Drawing.Size(102, 18);
            this.lb_sosvtd.TabIndex = 13;
            this.lb_sosvtd.Text = "Số SV tối đa";
            // 
            // btt_refreshtt
            // 
            this.btt_refreshtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshtt.Location = new System.Drawing.Point(809, 166);
            this.btt_refreshtt.Name = "btt_refreshtt";
            this.btt_refreshtt.Size = new System.Drawing.Size(144, 40);
            this.btt_refreshtt.TabIndex = 12;
            this.btt_refreshtt.Text = "REFRESH";
            this.btt_refreshtt.UseVisualStyleBackColor = true;
            this.btt_refreshtt.Click += new System.EventHandler(this.btt_refreshtt_Click);
            // 
            // btt_capnhat
            // 
            this.btt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_capnhat.Location = new System.Drawing.Point(809, 120);
            this.btt_capnhat.Name = "btt_capnhat";
            this.btt_capnhat.Size = new System.Drawing.Size(144, 40);
            this.btt_capnhat.TabIndex = 11;
            this.btt_capnhat.Text = "CẬP NHẬT";
            this.btt_capnhat.UseVisualStyleBackColor = true;
            this.btt_capnhat.Click += new System.EventHandler(this.btt_capnhat_Click);
            // 
            // btt_xoa
            // 
            this.btt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_xoa.Location = new System.Drawing.Point(809, 72);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(144, 42);
            this.btt_xoa.TabIndex = 10;
            this.btt_xoa.Text = "XÓA";
            this.btt_xoa.UseVisualStyleBackColor = true;
            this.btt_xoa.Click += new System.EventHandler(this.btt_xoa_Click);
            // 
            // btt_them
            // 
            this.btt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_them.Location = new System.Drawing.Point(809, 27);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(144, 39);
            this.btt_them.TabIndex = 4;
            this.btt_them.Text = "THÊM";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // txt_stth
            // 
            this.txt_stth.Location = new System.Drawing.Point(502, 42);
            this.txt_stth.Name = "txt_stth";
            this.txt_stth.Size = new System.Drawing.Size(196, 24);
            this.txt_stth.TabIndex = 9;
            // 
            // txt_stlt
            // 
            this.txt_stlt.Location = new System.Drawing.Point(155, 197);
            this.txt_stlt.Name = "txt_stlt";
            this.txt_stlt.Size = new System.Drawing.Size(179, 24);
            this.txt_stlt.TabIndex = 8;
            // 
            // txt_sotc
            // 
            this.txt_sotc.Location = new System.Drawing.Point(155, 142);
            this.txt_sotc.Name = "txt_sotc";
            this.txt_sotc.Size = new System.Drawing.Size(179, 24);
            this.txt_sotc.TabIndex = 7;
            // 
            // txt_mahp
            // 
            this.txt_mahp.Location = new System.Drawing.Point(155, 42);
            this.txt_mahp.Name = "txt_mahp";
            this.txt_mahp.Size = new System.Drawing.Size(179, 24);
            this.txt_mahp.TabIndex = 6;
            // 
            // txt_tenhp
            // 
            this.txt_tenhp.Location = new System.Drawing.Point(155, 90);
            this.txt_tenhp.Name = "txt_tenhp";
            this.txt_tenhp.Size = new System.Drawing.Size(179, 24);
            this.txt_tenhp.TabIndex = 5;
            // 
            // lb_stlt
            // 
            this.lb_stlt.AutoSize = true;
            this.lb_stlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stlt.Location = new System.Drawing.Point(29, 200);
            this.lb_stlt.Name = "lb_stlt";
            this.lb_stlt.Size = new System.Drawing.Size(81, 18);
            this.lb_stlt.TabIndex = 4;
            this.lb_stlt.Text = "Số tiết LT";
            // 
            // lb_stth
            // 
            this.lb_stth.AutoSize = true;
            this.lb_stth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stth.Location = new System.Drawing.Point(392, 45);
            this.lb_stth.Name = "lb_stth";
            this.lb_stth.Size = new System.Drawing.Size(84, 18);
            this.lb_stth.TabIndex = 3;
            this.lb_stth.Text = "Số tiết TH";
            // 
            // lb_sotc
            // 
            this.lb_sotc.AutoSize = true;
            this.lb_sotc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sotc.Location = new System.Drawing.Point(29, 148);
            this.lb_sotc.Name = "lb_sotc";
            this.lb_sotc.Size = new System.Drawing.Size(56, 18);
            this.lb_sotc.TabIndex = 2;
            this.lb_sotc.Text = "Số TC";
            // 
            // lb_tenhp
            // 
            this.lb_tenhp.AutoSize = true;
            this.lb_tenhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhp.Location = new System.Drawing.Point(29, 96);
            this.lb_tenhp.Name = "lb_tenhp";
            this.lb_tenhp.Size = new System.Drawing.Size(110, 18);
            this.lb_tenhp.TabIndex = 1;
            this.lb_tenhp.Text = "Tên học phần";
            // 
            // lb_mahp
            // 
            this.lb_mahp.AutoSize = true;
            this.lb_mahp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahp.Location = new System.Drawing.Point(29, 45);
            this.lb_mahp.Name = "lb_mahp";
            this.lb_mahp.Size = new System.Drawing.Size(110, 18);
            this.lb_mahp.TabIndex = 0;
            this.lb_mahp.Text = "Mã học phần ";
            // 
            // cb_phancong
            // 
            this.cb_phancong.Controls.Add(this.btt_refreshds);
            this.cb_phancong.Controls.Add(this.dgv_hocphan);
            this.cb_phancong.Controls.Add(this.btt_timkiem);
            this.cb_phancong.Controls.Add(this.lb_tk_mhp);
            this.cb_phancong.Controls.Add(this.txt_tk_mhp);
            this.cb_phancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phancong.Location = new System.Drawing.Point(12, 12);
            this.cb_phancong.Name = "cb_phancong";
            this.cb_phancong.Size = new System.Drawing.Size(1001, 315);
            this.cb_phancong.TabIndex = 2;
            this.cb_phancong.TabStop = false;
            this.cb_phancong.Text = "DANH SÁCH HỌC PHẦN";
            // 
            // btt_refreshds
            // 
            this.btt_refreshds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshds.Location = new System.Drawing.Point(884, 19);
            this.btt_refreshds.Name = "btt_refreshds";
            this.btt_refreshds.Size = new System.Drawing.Size(111, 30);
            this.btt_refreshds.TabIndex = 4;
            this.btt_refreshds.Text = "REFRESH";
            this.btt_refreshds.UseVisualStyleBackColor = true;
            this.btt_refreshds.Click += new System.EventHandler(this.btt_refreshds_Click);
            // 
            // dgv_hocphan
            // 
            this.dgv_hocphan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hocphan.Location = new System.Drawing.Point(6, 66);
            this.dgv_hocphan.Name = "dgv_hocphan";
            this.dgv_hocphan.RowHeadersWidth = 51;
            this.dgv_hocphan.RowTemplate.Height = 24;
            this.dgv_hocphan.Size = new System.Drawing.Size(989, 238);
            this.dgv_hocphan.TabIndex = 3;
            this.dgv_hocphan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hocphan_CellClick);
            // 
            // btt_timkiem
            // 
            this.btt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_timkiem.Location = new System.Drawing.Point(767, 19);
            this.btt_timkiem.Name = "btt_timkiem";
            this.btt_timkiem.Size = new System.Drawing.Size(111, 30);
            this.btt_timkiem.TabIndex = 2;
            this.btt_timkiem.Text = "TÌM KIẾM";
            this.btt_timkiem.UseVisualStyleBackColor = true;
            // 
            // lb_tk_mhp
            // 
            this.lb_tk_mhp.AutoSize = true;
            this.lb_tk_mhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk_mhp.Location = new System.Drawing.Point(416, 28);
            this.lb_tk_mhp.Name = "lb_tk_mhp";
            this.lb_tk_mhp.Size = new System.Drawing.Size(115, 18);
            this.lb_tk_mhp.TabIndex = 1;
            this.lb_tk_mhp.Text = "Mã học phần :";
            // 
            // txt_tk_mhp
            // 
            this.txt_tk_mhp.Location = new System.Drawing.Point(537, 25);
            this.txt_tk_mhp.Name = "txt_tk_mhp";
            this.txt_tk_mhp.Size = new System.Drawing.Size(224, 24);
            this.txt_tk_mhp.TabIndex = 0;
            // 
            // HOCPHAN_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 585);
            this.Controls.Add(this.cb_thongtin);
            this.Controls.Add(this.cb_phancong);
            this.Name = "HOCPHAN_TABLE";
            this.Text = "HOCPHAN_TABLE";
            this.Load += new System.EventHandler(this.HOCPHAN_TABLE_Load);
            this.cb_thongtin.ResumeLayout(false);
            this.cb_thongtin.PerformLayout();
            this.cb_phancong.ResumeLayout(false);
            this.cb_phancong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocphan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cb_thongtin;
        private System.Windows.Forms.Button btt_refreshtt;
        private System.Windows.Forms.Button btt_capnhat;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.TextBox txt_stth;
        private System.Windows.Forms.TextBox txt_stlt;
        private System.Windows.Forms.TextBox txt_sotc;
        private System.Windows.Forms.TextBox txt_mahp;
        private System.Windows.Forms.TextBox txt_tenhp;
        private System.Windows.Forms.Label lb_stlt;
        private System.Windows.Forms.Label lb_stth;
        private System.Windows.Forms.Label lb_sotc;
        private System.Windows.Forms.Label lb_tenhp;
        private System.Windows.Forms.Label lb_mahp;
        private System.Windows.Forms.GroupBox cb_phancong;
        private System.Windows.Forms.Button btt_refreshds;
        private System.Windows.Forms.DataGridView dgv_hocphan;
        private System.Windows.Forms.Button btt_timkiem;
        private System.Windows.Forms.Label lb_tk_mhp;
        private System.Windows.Forms.TextBox txt_tk_mhp;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.Label lb_madv;
        private System.Windows.Forms.TextBox txt_sosvtd;
        private System.Windows.Forms.Label lb_sosvtd;
    }
}