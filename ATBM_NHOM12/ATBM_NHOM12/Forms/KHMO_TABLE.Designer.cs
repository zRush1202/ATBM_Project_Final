namespace ATBM_NHOM12.Forms
{
    partial class KHMO_TABLE
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
            this.txt_mahp = new System.Windows.Forms.ComboBox();
            this.txt_hk = new System.Windows.Forms.ComboBox();
            this.txt_mact = new System.Windows.Forms.ComboBox();
            this.btt_refreshtt = new System.Windows.Forms.Button();
            this.btt_capnhat = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_them = new System.Windows.Forms.Button();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.lb_mact = new System.Windows.Forms.Label();
            this.lb_nam = new System.Windows.Forms.Label();
            this.lb_hk = new System.Windows.Forms.Label();
            this.lb_mahp = new System.Windows.Forms.Label();
            this.cb_phancong = new System.Windows.Forms.GroupBox();
            this.btt_refreshds = new System.Windows.Forms.Button();
            this.dgv_KHMO = new System.Windows.Forms.DataGridView();
            this.btt_timkiem = new System.Windows.Forms.Button();
            this.lb_tk_mhp = new System.Windows.Forms.Label();
            this.txt_tk_mhp = new System.Windows.Forms.TextBox();
            this.cb_thongtin.SuspendLayout();
            this.cb_phancong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KHMO)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_thongtin
            // 
            this.cb_thongtin.Controls.Add(this.txt_mahp);
            this.cb_thongtin.Controls.Add(this.txt_hk);
            this.cb_thongtin.Controls.Add(this.txt_mact);
            this.cb_thongtin.Controls.Add(this.btt_refreshtt);
            this.cb_thongtin.Controls.Add(this.btt_capnhat);
            this.cb_thongtin.Controls.Add(this.btt_xoa);
            this.cb_thongtin.Controls.Add(this.btt_them);
            this.cb_thongtin.Controls.Add(this.txt_nam);
            this.cb_thongtin.Controls.Add(this.lb_mact);
            this.cb_thongtin.Controls.Add(this.lb_nam);
            this.cb_thongtin.Controls.Add(this.lb_hk);
            this.cb_thongtin.Controls.Add(this.lb_mahp);
            this.cb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thongtin.Location = new System.Drawing.Point(12, 428);
            this.cb_thongtin.Name = "cb_thongtin";
            this.cb_thongtin.Size = new System.Drawing.Size(1147, 278);
            this.cb_thongtin.TabIndex = 3;
            this.cb_thongtin.TabStop = false;
            this.cb_thongtin.Text = "THÔNG TIN PHÂN CÔNG";
            // 
            // txt_mahp
            // 
            this.txt_mahp.FormattingEnabled = true;
            this.txt_mahp.Location = new System.Drawing.Point(155, 102);
            this.txt_mahp.Name = "txt_mahp";
            this.txt_mahp.Size = new System.Drawing.Size(179, 26);
            this.txt_mahp.TabIndex = 15;
            // 
            // txt_hk
            // 
            this.txt_hk.FormattingEnabled = true;
            this.txt_hk.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txt_hk.Location = new System.Drawing.Point(155, 174);
            this.txt_hk.Name = "txt_hk";
            this.txt_hk.Size = new System.Drawing.Size(179, 26);
            this.txt_hk.TabIndex = 14;
            // 
            // txt_mact
            // 
            this.txt_mact.FormattingEnabled = true;
            this.txt_mact.Items.AddRange(new object[] {
            "CQ",
            "CLC",
            "CTTT",
            "VP"});
            this.txt_mact.Location = new System.Drawing.Point(575, 103);
            this.txt_mact.Name = "txt_mact";
            this.txt_mact.Size = new System.Drawing.Size(179, 26);
            this.txt_mact.TabIndex = 13;
            // 
            // btt_refreshtt
            // 
            this.btt_refreshtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshtt.Location = new System.Drawing.Point(931, 203);
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
            this.btt_capnhat.Location = new System.Drawing.Point(931, 143);
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
            this.btt_xoa.Location = new System.Drawing.Point(931, 85);
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
            this.btt_them.Location = new System.Drawing.Point(931, 27);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(144, 39);
            this.btt_them.TabIndex = 4;
            this.btt_them.Text = "THÊM";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(575, 171);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(179, 24);
            this.txt_nam.TabIndex = 9;
            // 
            // lb_mact
            // 
            this.lb_mact.AutoSize = true;
            this.lb_mact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mact.Location = new System.Drawing.Point(426, 109);
            this.lb_mact.Name = "lb_mact";
            this.lb_mact.Size = new System.Drawing.Size(139, 18);
            this.lb_mact.TabIndex = 4;
            this.lb_mact.Text = "Mã chương trình  ";
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nam.Location = new System.Drawing.Point(426, 180);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(48, 18);
            this.lb_nam.TabIndex = 3;
            this.lb_nam.Text = "Năm ";
            // 
            // lb_hk
            // 
            this.lb_hk.AutoSize = true;
            this.lb_hk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hk.Location = new System.Drawing.Point(29, 177);
            this.lb_hk.Name = "lb_hk";
            this.lb_hk.Size = new System.Drawing.Size(62, 18);
            this.lb_hk.TabIndex = 2;
            this.lb_hk.Text = "Học kì ";
            // 
            // lb_mahp
            // 
            this.lb_mahp.AutoSize = true;
            this.lb_mahp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahp.Location = new System.Drawing.Point(29, 106);
            this.lb_mahp.Name = "lb_mahp";
            this.lb_mahp.Size = new System.Drawing.Size(110, 18);
            this.lb_mahp.TabIndex = 0;
            this.lb_mahp.Text = "Mã học phần ";
            // 
            // cb_phancong
            // 
            this.cb_phancong.Controls.Add(this.btt_refreshds);
            this.cb_phancong.Controls.Add(this.dgv_KHMO);
            this.cb_phancong.Controls.Add(this.btt_timkiem);
            this.cb_phancong.Controls.Add(this.lb_tk_mhp);
            this.cb_phancong.Controls.Add(this.txt_tk_mhp);
            this.cb_phancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_phancong.Location = new System.Drawing.Point(12, 12);
            this.cb_phancong.Name = "cb_phancong";
            this.cb_phancong.Size = new System.Drawing.Size(1147, 403);
            this.cb_phancong.TabIndex = 2;
            this.cb_phancong.TabStop = false;
            this.cb_phancong.Text = "DANH SÁCH KHMO";
            // 
            // btt_refreshds
            // 
            this.btt_refreshds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshds.Location = new System.Drawing.Point(1004, 22);
            this.btt_refreshds.Name = "btt_refreshds";
            this.btt_refreshds.Size = new System.Drawing.Size(137, 30);
            this.btt_refreshds.TabIndex = 4;
            this.btt_refreshds.Text = "REFRESH";
            this.btt_refreshds.UseVisualStyleBackColor = true;
            this.btt_refreshds.Click += new System.EventHandler(this.btt_refreshds_Click);
            // 
            // dgv_KHMO
            // 
            this.dgv_KHMO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KHMO.Location = new System.Drawing.Point(6, 66);
            this.dgv_KHMO.Name = "dgv_KHMO";
            this.dgv_KHMO.RowHeadersWidth = 51;
            this.dgv_KHMO.RowTemplate.Height = 24;
            this.dgv_KHMO.Size = new System.Drawing.Size(1135, 331);
            this.dgv_KHMO.TabIndex = 3;
            this.dgv_KHMO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KHMO_CellClick);
            // 
            // btt_timkiem
            // 
            this.btt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_timkiem.Location = new System.Drawing.Point(844, 22);
            this.btt_timkiem.Name = "btt_timkiem";
            this.btt_timkiem.Size = new System.Drawing.Size(139, 30);
            this.btt_timkiem.TabIndex = 2;
            this.btt_timkiem.Text = "TÌM KIẾM";
            this.btt_timkiem.UseVisualStyleBackColor = true;
            this.btt_timkiem.Click += new System.EventHandler(this.btt_timkiem_Click);
            // 
            // lb_tk_mhp
            // 
            this.lb_tk_mhp.AutoSize = true;
            this.lb_tk_mhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk_mhp.Location = new System.Drawing.Point(473, 28);
            this.lb_tk_mhp.Name = "lb_tk_mhp";
            this.lb_tk_mhp.Size = new System.Drawing.Size(105, 18);
            this.lb_tk_mhp.TabIndex = 1;
            this.lb_tk_mhp.Text = "Mã học phần";
            // 
            // txt_tk_mhp
            // 
            this.txt_tk_mhp.Location = new System.Drawing.Point(595, 25);
            this.txt_tk_mhp.Name = "txt_tk_mhp";
            this.txt_tk_mhp.Size = new System.Drawing.Size(224, 24);
            this.txt_tk_mhp.TabIndex = 0;
            // 
            // KHMO_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.cb_thongtin);
            this.Controls.Add(this.cb_phancong);
            this.Name = "KHMO_TABLE";
            this.Text = "KHMO_TABLE";
            this.Load += new System.EventHandler(this.KHMO_TABLE_Load);
            this.cb_thongtin.ResumeLayout(false);
            this.cb_thongtin.PerformLayout();
            this.cb_phancong.ResumeLayout(false);
            this.cb_phancong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KHMO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cb_thongtin;
        private System.Windows.Forms.Button btt_refreshtt;
        private System.Windows.Forms.Button btt_capnhat;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Label lb_mact;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.Label lb_hk;
        private System.Windows.Forms.Label lb_mahp;
        private System.Windows.Forms.GroupBox cb_phancong;
        private System.Windows.Forms.Button btt_refreshds;
        private System.Windows.Forms.DataGridView dgv_KHMO;
        private System.Windows.Forms.Button btt_timkiem;
        private System.Windows.Forms.Label lb_tk_mhp;
        private System.Windows.Forms.TextBox txt_tk_mhp;
        private System.Windows.Forms.ComboBox txt_hk;
        private System.Windows.Forms.ComboBox txt_mact;
        private System.Windows.Forms.ComboBox txt_mahp;
    }
}