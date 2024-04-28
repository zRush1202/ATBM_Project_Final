namespace ATBM_NHOM12.Forms
{
    partial class FormAudit
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
            this.dgvStandardAudit = new System.Windows.Forms.DataGridView();
            this.dgvFGADangKy = new System.Windows.Forms.DataGridView();
            this.dgvFGAPhuCap = new System.Windows.Forms.DataGridView();
            this.lblStandardAudit = new System.Windows.Forms.Label();
            this.lblFGADangKy = new System.Windows.Forms.Label();
            this.lblFGAPhuCap = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandardAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFGADangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFGAPhuCap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStandardAudit
            // 
            this.dgvStandardAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandardAudit.Location = new System.Drawing.Point(19, 48);
            this.dgvStandardAudit.Name = "dgvStandardAudit";
            this.dgvStandardAudit.RowHeadersWidth = 51;
            this.dgvStandardAudit.RowTemplate.Height = 24;
            this.dgvStandardAudit.Size = new System.Drawing.Size(1129, 236);
            this.dgvStandardAudit.TabIndex = 0;
            // 
            // dgvFGADangKy
            // 
            this.dgvFGADangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFGADangKy.Location = new System.Drawing.Point(19, 319);
            this.dgvFGADangKy.Name = "dgvFGADangKy";
            this.dgvFGADangKy.RowHeadersWidth = 51;
            this.dgvFGADangKy.RowTemplate.Height = 24;
            this.dgvFGADangKy.Size = new System.Drawing.Size(1129, 174);
            this.dgvFGADangKy.TabIndex = 1;
            // 
            // dgvFGAPhuCap
            // 
            this.dgvFGAPhuCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFGAPhuCap.Location = new System.Drawing.Point(19, 529);
            this.dgvFGAPhuCap.Name = "dgvFGAPhuCap";
            this.dgvFGAPhuCap.RowHeadersWidth = 51;
            this.dgvFGAPhuCap.RowTemplate.Height = 24;
            this.dgvFGAPhuCap.Size = new System.Drawing.Size(1129, 174);
            this.dgvFGAPhuCap.TabIndex = 2;
            // 
            // lblStandardAudit
            // 
            this.lblStandardAudit.AutoSize = true;
            this.lblStandardAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandardAudit.Location = new System.Drawing.Point(19, 15);
            this.lblStandardAudit.Name = "lblStandardAudit";
            this.lblStandardAudit.Size = new System.Drawing.Size(296, 24);
            this.lblStandardAudit.TabIndex = 3;
            this.lblStandardAudit.Text = "Nhật ký người dùng tiêu chuẩn";
            // 
            // lblFGADangKy
            // 
            this.lblFGADangKy.AutoSize = true;
            this.lblFGADangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFGADangKy.Location = new System.Drawing.Point(19, 292);
            this.lblFGADangKy.Name = "lblFGADangKy";
            this.lblFGADangKy.Size = new System.Drawing.Size(218, 24);
            this.lblFGADangKy.TabIndex = 4;
            this.lblFGADangKy.Text = "Nhật ký cập nhật điểm";
            // 
            // lblFGAPhuCap
            // 
            this.lblFGAPhuCap.AutoSize = true;
            this.lblFGAPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFGAPhuCap.Location = new System.Drawing.Point(19, 501);
            this.lblFGAPhuCap.Name = "lblFGAPhuCap";
            this.lblFGAPhuCap.Size = new System.Drawing.Size(207, 24);
            this.lblFGAPhuCap.TabIndex = 5;
            this.lblFGAPhuCap.Text = "Nhật ký xem phụ cấp";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1035, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 864);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvStandardAudit);
            this.Controls.Add(this.lblFGAPhuCap);
            this.Controls.Add(this.lblFGADangKy);
            this.Controls.Add(this.lblStandardAudit);
            this.Controls.Add(this.dgvFGAPhuCap);
            this.Controls.Add(this.dgvFGADangKy);
            this.Name = "FormAudit";
            this.Text = "FormAudit";
            this.Load += new System.EventHandler(this.FormAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandardAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFGADangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFGAPhuCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStandardAudit;
        private System.Windows.Forms.DataGridView dgvFGADangKy;
        private System.Windows.Forms.DataGridView dgvFGAPhuCap;
        private System.Windows.Forms.Label lblStandardAudit;
        private System.Windows.Forms.Label lblFGADangKy;
        private System.Windows.Forms.Label lblFGAPhuCap;
        private System.Windows.Forms.Button btnRefresh;
    }
}