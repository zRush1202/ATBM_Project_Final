﻿namespace ATBM_NHOM12.Forms
{
    partial class THEM_PHANCONG_TABLE
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
            this.lb_title = new System.Windows.Forms.Label();
            this.gb_khmo = new System.Windows.Forms.GroupBox();
            this.dgv_khmo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_magv = new System.Windows.Forms.ComboBox();
            this.btt_them = new System.Windows.Forms.Button();
            this.txt_mact = new System.Windows.Forms.TextBox();
            this.lb_mact = new System.Windows.Forms.Label();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.lb_nam = new System.Windows.Forms.Label();
            this.txt_hk = new System.Windows.Forms.TextBox();
            this.lb_hk = new System.Windows.Forms.Label();
            this.txt_mahp = new System.Windows.Forms.TextBox();
            this.lb_mahp = new System.Windows.Forms.Label();
            this.lb_magv = new System.Windows.Forms.Label();
            this.gb_khmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khmo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(353, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(208, 25);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "THÊM PHÂN CÔNG";
            // 
            // gb_khmo
            // 
            this.gb_khmo.Controls.Add(this.dgv_khmo);
            this.gb_khmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_khmo.Location = new System.Drawing.Point(12, 47);
            this.gb_khmo.Name = "gb_khmo";
            this.gb_khmo.Size = new System.Drawing.Size(438, 444);
            this.gb_khmo.TabIndex = 1;
            this.gb_khmo.TabStop = false;
            this.gb_khmo.Text = "KẾ HOẠCH MỞ MÔN";
            // 
            // dgv_khmo
            // 
            this.dgv_khmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khmo.Location = new System.Drawing.Point(6, 23);
            this.dgv_khmo.Name = "dgv_khmo";
            this.dgv_khmo.RowHeadersWidth = 51;
            this.dgv_khmo.RowTemplate.Height = 24;
            this.dgv_khmo.Size = new System.Drawing.Size(426, 415);
            this.dgv_khmo.TabIndex = 0;
            this.dgv_khmo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khmo_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_magv);
            this.groupBox1.Controls.Add(this.btt_them);
            this.groupBox1.Controls.Add(this.txt_mact);
            this.groupBox1.Controls.Add(this.lb_mact);
            this.groupBox1.Controls.Add(this.txt_nam);
            this.groupBox1.Controls.Add(this.lb_nam);
            this.groupBox1.Controls.Add(this.txt_hk);
            this.groupBox1.Controls.Add(this.lb_hk);
            this.groupBox1.Controls.Add(this.txt_mahp);
            this.groupBox1.Controls.Add(this.lb_mahp);
            this.groupBox1.Controls.Add(this.lb_magv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(456, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN PHÂN CÔNG";
            // 
            // txt_magv
            // 
            this.txt_magv.FormattingEnabled = true;
            this.txt_magv.Location = new System.Drawing.Point(195, 36);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(179, 26);
            this.txt_magv.TabIndex = 16;
            this.Load += new System.EventHandler(this.txt_magv_Load);
            // 
            // btt_them
            // 
            this.btt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_them.Location = new System.Drawing.Point(152, 373);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(144, 39);
            this.btt_them.TabIndex = 15;
            this.btt_them.Text = "THÊM";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // txt_mact
            // 
            this.txt_mact.Location = new System.Drawing.Point(195, 305);
            this.txt_mact.Name = "txt_mact";
            this.txt_mact.Size = new System.Drawing.Size(179, 24);
            this.txt_mact.TabIndex = 14;
            // 
            // lb_mact
            // 
            this.lb_mact.AutoSize = true;
            this.lb_mact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mact.Location = new System.Drawing.Point(31, 308);
            this.lb_mact.Name = "lb_mact";
            this.lb_mact.Size = new System.Drawing.Size(139, 18);
            this.lb_mact.TabIndex = 13;
            this.lb_mact.Text = "Mã chương trình  ";
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(195, 237);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(179, 24);
            this.txt_nam.TabIndex = 12;
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nam.Location = new System.Drawing.Point(31, 243);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(48, 18);
            this.lb_nam.TabIndex = 11;
            this.lb_nam.Text = "Năm ";
            // 
            // txt_hk
            // 
            this.txt_hk.Location = new System.Drawing.Point(195, 169);
            this.txt_hk.Name = "txt_hk";
            this.txt_hk.Size = new System.Drawing.Size(179, 24);
            this.txt_hk.TabIndex = 10;
            // 
            // lb_hk
            // 
            this.lb_hk.AutoSize = true;
            this.lb_hk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hk.Location = new System.Drawing.Point(31, 172);
            this.lb_hk.Name = "lb_hk";
            this.lb_hk.Size = new System.Drawing.Size(62, 18);
            this.lb_hk.TabIndex = 9;
            this.lb_hk.Text = "Học kì ";
            // 
            // txt_mahp
            // 
            this.txt_mahp.Location = new System.Drawing.Point(195, 103);
            this.txt_mahp.Name = "txt_mahp";
            this.txt_mahp.Size = new System.Drawing.Size(179, 24);
            this.txt_mahp.TabIndex = 8;
            // 
            // lb_mahp
            // 
            this.lb_mahp.AutoSize = true;
            this.lb_mahp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahp.Location = new System.Drawing.Point(31, 106);
            this.lb_mahp.Name = "lb_mahp";
            this.lb_mahp.Size = new System.Drawing.Size(110, 18);
            this.lb_mahp.TabIndex = 7;
            this.lb_mahp.Text = "Mã học phần ";
            // 
            // lb_magv
            // 
            this.lb_magv.AutoSize = true;
            this.lb_magv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_magv.Location = new System.Drawing.Point(31, 43);
            this.lb_magv.Name = "lb_magv";
            this.lb_magv.Size = new System.Drawing.Size(108, 18);
            this.lb_magv.TabIndex = 2;
            this.lb_magv.Text = "Mã giáo viên ";
            // 
            // THEM_PHANCONG_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_khmo);
            this.Controls.Add(this.lb_title);
            this.Name = "THEM_PHANCONG_TABLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THEM_PHANCONG_TABLE";
            this.Load += new System.EventHandler(this.THEM_PHANCONG_TABLE_Load);
            this.gb_khmo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khmo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.GroupBox gb_khmo;
        private System.Windows.Forms.DataGridView dgv_khmo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_magv;
        private System.Windows.Forms.Label lb_mahp;
        private System.Windows.Forms.TextBox txt_mahp;
        private System.Windows.Forms.Label lb_hk;
        private System.Windows.Forms.TextBox txt_hk;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Label lb_mact;
        private System.Windows.Forms.TextBox txt_mact;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.ComboBox txt_magv;
    }
}