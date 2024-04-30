namespace ATBM_NHOM12.Forms
{
    partial class SYSTEM_PRIVS
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
            this.gb_syspriv = new System.Windows.Forms.GroupBox();
            this.dgv_sys = new System.Windows.Forms.DataGridView();
            this.btt_timkiem = new System.Windows.Forms.Button();
            this.btt_refreshds = new System.Windows.Forms.Button();
            this.txt_grantee = new System.Windows.Forms.MaskedTextBox();
            this.lb_grantee = new System.Windows.Forms.Label();
            this.btt_grant_revoke = new System.Windows.Forms.Button();
            this.gb_syspriv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sys)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_syspriv
            // 
            this.gb_syspriv.Controls.Add(this.dgv_sys);
            this.gb_syspriv.Location = new System.Drawing.Point(12, 66);
            this.gb_syspriv.Name = "gb_syspriv";
            this.gb_syspriv.Size = new System.Drawing.Size(1148, 640);
            this.gb_syspriv.TabIndex = 0;
            this.gb_syspriv.TabStop = false;
            this.gb_syspriv.Text = "QUYỀN HỆ THỐNG";
            // 
            // dgv_sys
            // 
            this.dgv_sys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sys.Location = new System.Drawing.Point(6, 21);
            this.dgv_sys.Name = "dgv_sys";
            this.dgv_sys.RowHeadersWidth = 51;
            this.dgv_sys.RowTemplate.Height = 24;
            this.dgv_sys.Size = new System.Drawing.Size(1136, 613);
            this.dgv_sys.TabIndex = 0;
            // 
            // btt_timkiem
            // 
            this.btt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_timkiem.Location = new System.Drawing.Point(360, 25);
            this.btt_timkiem.Name = "btt_timkiem";
            this.btt_timkiem.Size = new System.Drawing.Size(111, 30);
            this.btt_timkiem.TabIndex = 3;
            this.btt_timkiem.Text = "TÌM KIẾM";
            this.btt_timkiem.UseVisualStyleBackColor = true;
            this.btt_timkiem.Click += new System.EventHandler(this.btt_timkiem_Click);
            // 
            // btt_refreshds
            // 
            this.btt_refreshds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_refreshds.Location = new System.Drawing.Point(477, 25);
            this.btt_refreshds.Name = "btt_refreshds";
            this.btt_refreshds.Size = new System.Drawing.Size(130, 30);
            this.btt_refreshds.TabIndex = 5;
            this.btt_refreshds.Text = "REFRESH";
            this.btt_refreshds.UseVisualStyleBackColor = true;
            this.btt_refreshds.Click += new System.EventHandler(this.btt_refreshds_Click);
            // 
            // txt_grantee
            // 
            this.txt_grantee.Location = new System.Drawing.Point(166, 28);
            this.txt_grantee.Name = "txt_grantee";
            this.txt_grantee.Size = new System.Drawing.Size(188, 22);
            this.txt_grantee.TabIndex = 6;
            // 
            // lb_grantee
            // 
            this.lb_grantee.AutoSize = true;
            this.lb_grantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_grantee.Location = new System.Drawing.Point(25, 30);
            this.lb_grantee.Name = "lb_grantee";
            this.lb_grantee.Size = new System.Drawing.Size(113, 20);
            this.lb_grantee.TabIndex = 7;
            this.lb_grantee.Text = "Tìm Grantee";
            // 
            // btt_grant_revoke
            // 
            this.btt_grant_revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_grant_revoke.Location = new System.Drawing.Point(952, 25);
            this.btt_grant_revoke.Name = "btt_grant_revoke";
            this.btt_grant_revoke.Size = new System.Drawing.Size(208, 30);
            this.btt_grant_revoke.TabIndex = 8;
            this.btt_grant_revoke.Text = "GRANT/REVOKE";
            this.btt_grant_revoke.UseVisualStyleBackColor = true;
            this.btt_grant_revoke.Click += new System.EventHandler(this.btt_grant_revoke_Click);
            // 
            // SYSTEM_PRIVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.btt_grant_revoke);
            this.Controls.Add(this.lb_grantee);
            this.Controls.Add(this.txt_grantee);
            this.Controls.Add(this.btt_refreshds);
            this.Controls.Add(this.btt_timkiem);
            this.Controls.Add(this.gb_syspriv);
            this.Name = "SYSTEM_PRIVS";
            this.Text = "QUYỀN HỆ THỐNG";
            this.Load += new System.EventHandler(this.SYSTEM_PRIVS_Load);
            this.gb_syspriv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_syspriv;
        private System.Windows.Forms.DataGridView dgv_sys;
        private System.Windows.Forms.Button btt_timkiem;
        private System.Windows.Forms.Button btt_refreshds;
        private System.Windows.Forms.MaskedTextBox txt_grantee;
        private System.Windows.Forms.Label lb_grantee;
        private System.Windows.Forms.Button btt_grant_revoke;
    }
}