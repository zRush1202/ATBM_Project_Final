namespace ATBM_NHOM12.Forms
{
    partial class DONVI_TABLE
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
            this.btt_refreshtt = new System.Windows.Forms.Button();
            this.btt_capnhat = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_them = new System.Windows.Forms.Button();
            this.txt_trgdv = new System.Windows.Forms.TextBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.lb_trdv = new System.Windows.Forms.Label();
            this.lb_tendv = new System.Windows.Forms.Label();
            this.cb_donvi = new System.Windows.Forms.GroupBox();
            this.btt_refreshds = new System.Windows.Forms.Button();
            this.dgv_donvi = new System.Windows.Forms.DataGridView();
            this.btt_timkiem = new System.Windows.Forms.Button();
            this.lb_tk_tendv = new System.Windows.Forms.Label();
            this.txt_tk_tendv = new System.Windows.Forms.TextBox();
            this.cb_thongtin.SuspendLayout();
            this.cb_donvi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donvi)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_thongtin
            // 
            this.cb_thongtin.Controls.Add(this.txt_madv);
            this.cb_thongtin.Controls.Add(this.lb_madv);
            this.cb_thongtin.Controls.Add(this.btt_refreshtt);
            this.cb_thongtin.Controls.Add(this.btt_capnhat);
            this.cb_thongtin.Controls.Add(this.btt_xoa);
            this.cb_thongtin.Controls.Add(this.btt_them);
            this.cb_thongtin.Controls.Add(this.txt_trgdv);
            this.cb_thongtin.Controls.Add(this.txt_tendv);
            this.cb_thongtin.Controls.Add(this.lb_trdv);
            this.cb_thongtin.Controls.Add(this.lb_tendv);
            this.cb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thongtin.Location = new System.Drawing.Point(12, 417);
            this.cb_thongtin.Name = "cb_thongtin";
            this.cb_thongtin.Size = new System.Drawing.Size(1148, 289);
            this.cb_thongtin.TabIndex = 5;
            this.cb_thongtin.TabStop = false;
            this.cb_thongtin.Text = "THÔNG TIN HỌC PHẦN";
            // 
            // txt_madv
            // 
            this.txt_madv.Location = new System.Drawing.Point(203, 84);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(113, 24);
            this.txt_madv.TabIndex = 16;
            // 
            // lb_madv
            // 
            this.lb_madv.AutoSize = true;
            this.lb_madv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madv.Location = new System.Drawing.Point(89, 87);
            this.lb_madv.Name = "lb_madv";
            this.lb_madv.Size = new System.Drawing.Size(81, 18);
            this.lb_madv.TabIndex = 15;
            this.lb_madv.Text = "Mã đơn vị";
            // 
            // btt_refreshtt
            // 
            this.btt_refreshtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshtt.Location = new System.Drawing.Point(886, 171);
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
            this.btt_capnhat.Location = new System.Drawing.Point(649, 171);
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
            this.btt_xoa.Location = new System.Drawing.Point(389, 171);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(144, 40);
            this.btt_xoa.TabIndex = 10;
            this.btt_xoa.Text = "XÓA";
            this.btt_xoa.UseVisualStyleBackColor = true;
            this.btt_xoa.Click += new System.EventHandler(this.btt_xoa_Click);
            // 
            // btt_them
            // 
            this.btt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_them.Location = new System.Drawing.Point(155, 171);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(144, 40);
            this.btt_them.TabIndex = 4;
            this.btt_them.Text = "THÊM";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // txt_trgdv
            // 
            this.txt_trgdv.Location = new System.Drawing.Point(913, 84);
            this.txt_trgdv.Name = "txt_trgdv";
            this.txt_trgdv.Size = new System.Drawing.Size(143, 24);
            this.txt_trgdv.TabIndex = 9;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(477, 84);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(227, 24);
            this.txt_tendv.TabIndex = 6;
            // 
            // lb_trdv
            // 
            this.lb_trdv.AutoSize = true;
            this.lb_trdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trdv.Location = new System.Drawing.Point(733, 87);
            this.lb_trdv.Name = "lb_trdv";
            this.lb_trdv.Size = new System.Drawing.Size(134, 18);
            this.lb_trdv.TabIndex = 3;
            this.lb_trdv.Text = "Mã trưởng đơn vị";
            // 
            // lb_tendv
            // 
            this.lb_tendv.AutoSize = true;
            this.lb_tendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tendv.Location = new System.Drawing.Point(362, 87);
            this.lb_tendv.Name = "lb_tendv";
            this.lb_tendv.Size = new System.Drawing.Size(86, 18);
            this.lb_tendv.TabIndex = 0;
            this.lb_tendv.Text = "Tên đơn vị";
            // 
            // cb_donvi
            // 
            this.cb_donvi.Controls.Add(this.btt_refreshds);
            this.cb_donvi.Controls.Add(this.dgv_donvi);
            this.cb_donvi.Controls.Add(this.btt_timkiem);
            this.cb_donvi.Controls.Add(this.lb_tk_tendv);
            this.cb_donvi.Controls.Add(this.txt_tk_tendv);
            this.cb_donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_donvi.Location = new System.Drawing.Point(12, 12);
            this.cb_donvi.Name = "cb_donvi";
            this.cb_donvi.Size = new System.Drawing.Size(1148, 399);
            this.cb_donvi.TabIndex = 4;
            this.cb_donvi.TabStop = false;
            this.cb_donvi.Text = "DANH SÁCH ĐƠN VỊ";
            // 
            // btt_refreshds
            // 
            this.btt_refreshds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshds.Location = new System.Drawing.Point(1030, 23);
            this.btt_refreshds.Name = "btt_refreshds";
            this.btt_refreshds.Size = new System.Drawing.Size(111, 30);
            this.btt_refreshds.TabIndex = 4;
            this.btt_refreshds.Text = "REFRESH";
            this.btt_refreshds.UseVisualStyleBackColor = true;
            this.btt_refreshds.Click += new System.EventHandler(this.btt_refreshds_Click);
            // 
            // dgv_donvi
            // 
            this.dgv_donvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donvi.Location = new System.Drawing.Point(6, 66);
            this.dgv_donvi.Name = "dgv_donvi";
            this.dgv_donvi.RowHeadersWidth = 51;
            this.dgv_donvi.RowTemplate.Height = 24;
            this.dgv_donvi.Size = new System.Drawing.Size(1136, 327);
            this.dgv_donvi.TabIndex = 3;
            this.dgv_donvi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_donvi_CellClick);
            // 
            // btt_timkiem
            // 
            this.btt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_timkiem.Location = new System.Drawing.Point(913, 23);
            this.btt_timkiem.Name = "btt_timkiem";
            this.btt_timkiem.Size = new System.Drawing.Size(111, 30);
            this.btt_timkiem.TabIndex = 2;
            this.btt_timkiem.Text = "TÌM KIẾM";
            this.btt_timkiem.UseVisualStyleBackColor = true;
            this.btt_timkiem.Click += new System.EventHandler(this.btt_timkiem_Click);
            // 
            // lb_tk_tendv
            // 
            this.lb_tk_tendv.AutoSize = true;
            this.lb_tk_tendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk_tendv.Location = new System.Drawing.Point(562, 32);
            this.lb_tk_tendv.Name = "lb_tk_tendv";
            this.lb_tk_tendv.Size = new System.Drawing.Size(96, 18);
            this.lb_tk_tendv.TabIndex = 1;
            this.lb_tk_tendv.Text = "Tên đơn vị :";
            // 
            // txt_tk_tendv
            // 
            this.txt_tk_tendv.Location = new System.Drawing.Point(683, 29);
            this.txt_tk_tendv.Name = "txt_tk_tendv";
            this.txt_tk_tendv.Size = new System.Drawing.Size(224, 24);
            this.txt_tk_tendv.TabIndex = 0;
            // 
            // DONVI_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.cb_thongtin);
            this.Controls.Add(this.cb_donvi);
            this.Name = "DONVI_TABLE";
            this.Text = "DONVI_TABLE";
            this.Load += new System.EventHandler(this.DONVI_TABLE_Load);
            this.cb_thongtin.ResumeLayout(false);
            this.cb_thongtin.PerformLayout();
            this.cb_donvi.ResumeLayout(false);
            this.cb_donvi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donvi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cb_thongtin;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.Label lb_madv;
        private System.Windows.Forms.Button btt_refreshtt;
        private System.Windows.Forms.Button btt_capnhat;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.Label lb_trdv;
        private System.Windows.Forms.Label lb_tendv;
        private System.Windows.Forms.GroupBox cb_donvi;
        private System.Windows.Forms.Button btt_refreshds;
        private System.Windows.Forms.DataGridView dgv_donvi;
        private System.Windows.Forms.Button btt_timkiem;
        private System.Windows.Forms.Label lb_tk_tendv;
        private System.Windows.Forms.TextBox txt_tk_tendv;
        private System.Windows.Forms.TextBox txt_trgdv;
    }
}