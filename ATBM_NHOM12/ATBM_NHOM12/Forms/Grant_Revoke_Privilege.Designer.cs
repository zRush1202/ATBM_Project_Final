namespace ATBM_NHOM12.Forms
{
    partial class Grant_Revoke_Privilege
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
            this.gb_table = new System.Windows.Forms.GroupBox();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.gb_col = new System.Windows.Forms.GroupBox();
            this.dgv_col = new System.Windows.Forms.DataGridView();
            this.btt_grant = new System.Windows.Forms.Button();
            this.btt_revoke = new System.Windows.Forms.Button();
            this.btt_Refresh = new System.Windows.Forms.Button();
            this.gb_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.gb_col.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_col)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_table
            // 
            this.gb_table.Controls.Add(this.dgv_table);
            this.gb_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_table.Location = new System.Drawing.Point(12, 93);
            this.gb_table.Name = "gb_table";
            this.gb_table.Size = new System.Drawing.Size(553, 613);
            this.gb_table.TabIndex = 0;
            this.gb_table.TabStop = false;
            this.gb_table.Text = "Table";
            // 
            // dgv_table
            // 
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(6, 29);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidth = 51;
            this.dgv_table.RowTemplate.Height = 24;
            this.dgv_table.Size = new System.Drawing.Size(542, 578);
            this.dgv_table.TabIndex = 0;
            // 
            // gb_col
            // 
            this.gb_col.Controls.Add(this.dgv_col);
            this.gb_col.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_col.Location = new System.Drawing.Point(571, 93);
            this.gb_col.Name = "gb_col";
            this.gb_col.Size = new System.Drawing.Size(588, 613);
            this.gb_col.TabIndex = 1;
            this.gb_col.TabStop = false;
            this.gb_col.Text = "Column";
            // 
            // dgv_col
            // 
            this.dgv_col.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_col.Location = new System.Drawing.Point(14, 23);
            this.dgv_col.Name = "dgv_col";
            this.dgv_col.RowHeadersWidth = 51;
            this.dgv_col.RowTemplate.Height = 24;
            this.dgv_col.Size = new System.Drawing.Size(568, 584);
            this.dgv_col.TabIndex = 1;
            // 
            // btt_grant
            // 
            this.btt_grant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btt_grant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_grant.ForeColor = System.Drawing.Color.White;
            this.btt_grant.Location = new System.Drawing.Point(18, 38);
            this.btt_grant.Name = "btt_grant";
            this.btt_grant.Size = new System.Drawing.Size(234, 35);
            this.btt_grant.TabIndex = 2;
            this.btt_grant.Text = "CẤP QUYỀN";
            this.btt_grant.UseVisualStyleBackColor = false;
            this.btt_grant.Click += new System.EventHandler(this.btt_grant_Click);
            // 
            // btt_revoke
            // 
            this.btt_revoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btt_revoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_revoke.ForeColor = System.Drawing.Color.White;
            this.btt_revoke.Location = new System.Drawing.Point(282, 38);
            this.btt_revoke.Name = "btt_revoke";
            this.btt_revoke.Size = new System.Drawing.Size(236, 35);
            this.btt_revoke.TabIndex = 3;
            this.btt_revoke.Text = "THU HỒI QUYỀN ";
            this.btt_revoke.UseVisualStyleBackColor = false;
            this.btt_revoke.Click += new System.EventHandler(this.btt_revoke_Click);
            // 
            // btt_Refresh
            // 
            this.btt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btt_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Refresh.ForeColor = System.Drawing.Color.White;
            this.btt_Refresh.Location = new System.Drawing.Point(1036, 38);
            this.btt_Refresh.Name = "btt_Refresh";
            this.btt_Refresh.Size = new System.Drawing.Size(118, 35);
            this.btt_Refresh.TabIndex = 4;
            this.btt_Refresh.Text = "Refresh";
            this.btt_Refresh.UseVisualStyleBackColor = false;
            this.btt_Refresh.Click += new System.EventHandler(this.btt_Refresh_Click);
            // 
            // Grant_Revoke_Privilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.btt_Refresh);
            this.Controls.Add(this.btt_revoke);
            this.Controls.Add(this.btt_grant);
            this.Controls.Add(this.gb_col);
            this.Controls.Add(this.gb_table);
            this.Name = "Grant_Revoke_Privilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant_Revoke_Privilege";
            this.Load += new System.EventHandler(this.Grant_Revoke_Privilege_Load);
            this.gb_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.gb_col.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_col)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_table;
        private System.Windows.Forms.GroupBox gb_col;
        private System.Windows.Forms.Button btt_grant;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.DataGridView dgv_col;
        private System.Windows.Forms.Button btt_revoke;
        private System.Windows.Forms.Button btt_Refresh;
    }
}