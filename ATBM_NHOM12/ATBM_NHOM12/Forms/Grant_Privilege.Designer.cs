namespace ATBM_NHOM12.Forms
{
    partial class Grant_Privilege
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
            this.lb_ur = new System.Windows.Forms.Label();
            this.txt_ur = new System.Windows.Forms.TextBox();
            this.btt_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_check = new System.Windows.Forms.TextBox();
            this.cb_priv = new System.Windows.Forms.ComboBox();
            this.lb_priv = new System.Windows.Forms.Label();
            this.lb_tb = new System.Windows.Forms.Label();
            this.cb_table = new System.Windows.Forms.ComboBox();
            this.clb_col = new System.Windows.Forms.CheckedListBox();
            this.rd_option = new System.Windows.Forms.RadioButton();
            this.btt_grant = new System.Windows.Forms.Button();
            this.btt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ur
            // 
            this.lb_ur.AutoSize = true;
            this.lb_ur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ur.Location = new System.Drawing.Point(12, 33);
            this.lb_ur.Name = "lb_ur";
            this.lb_ur.Size = new System.Drawing.Size(212, 18);
            this.lb_ur.TabIndex = 0;
            this.lb_ur.Text = "NHẬP USSERNAME/ROLE";
            // 
            // txt_ur
            // 
            this.txt_ur.Location = new System.Drawing.Point(260, 31);
            this.txt_ur.Name = "txt_ur";
            this.txt_ur.Size = new System.Drawing.Size(186, 22);
            this.txt_ur.TabIndex = 1;
            this.txt_ur.TextChanged += new System.EventHandler(this.txt_ur_TextChanged);
            // 
            // btt_check
            // 
            this.btt_check.Enabled = false;
            this.btt_check.Location = new System.Drawing.Point(326, 59);
            this.btt_check.Name = "btt_check";
            this.btt_check.Size = new System.Drawing.Size(120, 26);
            this.btt_check.TabIndex = 2;
            this.btt_check.Text = "Phân Loại";
            this.btt_check.UseVisualStyleBackColor = true;
            this.btt_check.Click += new System.EventHandler(this.btt_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐỐI TƯỢNG";
            // 
            // txt_check
            // 
            this.txt_check.Location = new System.Drawing.Point(179, 103);
            this.txt_check.Name = "txt_check";
            this.txt_check.ReadOnly = true;
            this.txt_check.Size = new System.Drawing.Size(267, 22);
            this.txt_check.TabIndex = 4;
            // 
            // cb_priv
            // 
            this.cb_priv.FormattingEnabled = true;
            this.cb_priv.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.cb_priv.Location = new System.Drawing.Point(179, 142);
            this.cb_priv.Name = "cb_priv";
            this.cb_priv.Size = new System.Drawing.Size(267, 24);
            this.cb_priv.TabIndex = 5;
            this.cb_priv.SelectedIndexChanged += new System.EventHandler(this.cb_priv_SelectedIndexChanged);
            // 
            // lb_priv
            // 
            this.lb_priv.AutoSize = true;
            this.lb_priv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_priv.Location = new System.Drawing.Point(12, 146);
            this.lb_priv.Name = "lb_priv";
            this.lb_priv.Size = new System.Drawing.Size(66, 18);
            this.lb_priv.TabIndex = 6;
            this.lb_priv.Text = "QUYỀN";
            // 
            // lb_tb
            // 
            this.lb_tb.AutoSize = true;
            this.lb_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tb.Location = new System.Drawing.Point(12, 189);
            this.lb_tb.Name = "lb_tb";
            this.lb_tb.Size = new System.Drawing.Size(54, 18);
            this.lb_tb.TabIndex = 7;
            this.lb_tb.Text = "BẢNG";
            // 
            // cb_table
            // 
            this.cb_table.FormattingEnabled = true;
            this.cb_table.Location = new System.Drawing.Point(179, 185);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(267, 24);
            this.cb_table.TabIndex = 8;
            this.cb_table.SelectedIndexChanged += new System.EventHandler(this.cb_table_SelectedIndexChanged);
            // 
            // clb_col
            // 
            this.clb_col.Enabled = false;
            this.clb_col.FormattingEnabled = true;
            this.clb_col.Location = new System.Drawing.Point(464, 31);
            this.clb_col.Name = "clb_col";
            this.clb_col.Size = new System.Drawing.Size(227, 208);
            this.clb_col.TabIndex = 9;
            this.clb_col.SelectedIndexChanged += new System.EventHandler(this.clb_col_SelectedIndexChanged);
            // 
            // rd_option
            // 
            this.rd_option.AutoSize = true;
            this.rd_option.Enabled = false;
            this.rd_option.Location = new System.Drawing.Point(278, 233);
            this.rd_option.Name = "rd_option";
            this.rd_option.Size = new System.Drawing.Size(168, 20);
            this.rd_option.TabIndex = 10;
            this.rd_option.TabStop = true;
            this.rd_option.Text = "WITH GRANT OPTION";
            this.rd_option.UseVisualStyleBackColor = true;
            // 
            // btt_grant
            // 
            this.btt_grant.Location = new System.Drawing.Point(215, 292);
            this.btt_grant.Name = "btt_grant";
            this.btt_grant.Size = new System.Drawing.Size(116, 32);
            this.btt_grant.TabIndex = 11;
            this.btt_grant.Text = "CẤP QUYÊN";
            this.btt_grant.UseVisualStyleBackColor = true;
            this.btt_grant.Click += new System.EventHandler(this.btt_grant_Click);
            // 
            // btt_cancel
            // 
            this.btt_cancel.Location = new System.Drawing.Point(428, 292);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.Size = new System.Drawing.Size(95, 32);
            this.btt_cancel.TabIndex = 12;
            this.btt_cancel.Text = "HỦY";
            this.btt_cancel.UseVisualStyleBackColor = true;
            // 
            // Grant_Privilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 341);
            this.Controls.Add(this.btt_cancel);
            this.Controls.Add(this.btt_grant);
            this.Controls.Add(this.rd_option);
            this.Controls.Add(this.clb_col);
            this.Controls.Add(this.cb_table);
            this.Controls.Add(this.lb_tb);
            this.Controls.Add(this.lb_priv);
            this.Controls.Add(this.cb_priv);
            this.Controls.Add(this.txt_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_check);
            this.Controls.Add(this.txt_ur);
            this.Controls.Add(this.lb_ur);
            this.Name = "Grant_Privilege";
            this.Text = "Grant_Privilege";
            this.Load += new System.EventHandler(this.cb_table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ur;
        private System.Windows.Forms.TextBox txt_ur;
        private System.Windows.Forms.Button btt_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_check;
        private System.Windows.Forms.ComboBox cb_priv;
        private System.Windows.Forms.Label lb_priv;
        private System.Windows.Forms.Label lb_tb;
        private System.Windows.Forms.ComboBox cb_table;
        private System.Windows.Forms.CheckedListBox clb_col;
        private System.Windows.Forms.RadioButton rd_option;
        private System.Windows.Forms.Button btt_grant;
        private System.Windows.Forms.Button btt_cancel;
    }
}