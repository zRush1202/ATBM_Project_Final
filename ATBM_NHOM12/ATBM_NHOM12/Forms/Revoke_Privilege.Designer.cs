namespace ATBM_NHOM12.Forms
{
    partial class Revoke_Privilege
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
            this.lb_tb = new System.Windows.Forms.Label();
            this.cb_table = new System.Windows.Forms.ComboBox();
            this.lb_priv = new System.Windows.Forms.Label();
            this.cb_priv = new System.Windows.Forms.ComboBox();
            this.btt_rev = new System.Windows.Forms.Button();
            this.btt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ur
            // 
            this.lb_ur.AutoSize = true;
            this.lb_ur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ur.Location = new System.Drawing.Point(59, 49);
            this.lb_ur.Name = "lb_ur";
            this.lb_ur.Size = new System.Drawing.Size(104, 18);
            this.lb_ur.TabIndex = 0;
            this.lb_ur.Text = "USER/ROLE";
            // 
            // txt_ur
            // 
            this.txt_ur.Location = new System.Drawing.Point(226, 45);
            this.txt_ur.Name = "txt_ur";
            this.txt_ur.Size = new System.Drawing.Size(276, 22);
            this.txt_ur.TabIndex = 1;
            this.txt_ur.TextChanged += new System.EventHandler(this.txt_ur_TextChanged);
            // 
            // lb_tb
            // 
            this.lb_tb.AutoSize = true;
            this.lb_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tb.Location = new System.Drawing.Point(59, 112);
            this.lb_tb.Name = "lb_tb";
            this.lb_tb.Size = new System.Drawing.Size(105, 18);
            this.lb_tb.TabIndex = 2;
            this.lb_tb.Text = "TABLE/VIEW";
            // 
            // cb_table
            // 
            this.cb_table.FormattingEnabled = true;
            this.cb_table.Location = new System.Drawing.Point(226, 106);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(276, 24);
            this.cb_table.TabIndex = 3;
            // 
            // lb_priv
            // 
            this.lb_priv.AutoSize = true;
            this.lb_priv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_priv.Location = new System.Drawing.Point(59, 180);
            this.lb_priv.Name = "lb_priv";
            this.lb_priv.Size = new System.Drawing.Size(56, 18);
            this.lb_priv.TabIndex = 4;
            this.lb_priv.Text = "Quyền";
            // 
            // cb_priv
            // 
            this.cb_priv.FormattingEnabled = true;
            this.cb_priv.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.cb_priv.Location = new System.Drawing.Point(226, 174);
            this.cb_priv.Name = "cb_priv";
            this.cb_priv.Size = new System.Drawing.Size(276, 24);
            this.cb_priv.TabIndex = 5;
            // 
            // btt_rev
            // 
            this.btt_rev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_rev.Location = new System.Drawing.Point(130, 215);
            this.btt_rev.Name = "btt_rev";
            this.btt_rev.Size = new System.Drawing.Size(100, 39);
            this.btt_rev.TabIndex = 6;
            this.btt_rev.Text = "THU HỒI";
            this.btt_rev.UseVisualStyleBackColor = true;
            this.btt_rev.Click += new System.EventHandler(this.btt_rev_Click);
            // 
            // btt_cancel
            // 
            this.btt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_cancel.Location = new System.Drawing.Point(313, 215);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.Size = new System.Drawing.Size(100, 39);
            this.btt_cancel.TabIndex = 7;
            this.btt_cancel.Text = "HỦY";
            this.btt_cancel.UseVisualStyleBackColor = true;
            this.btt_cancel.Click += new System.EventHandler(this.btt_cancel_Click);
            // 
            // Revoke_Privilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 282);
            this.Controls.Add(this.btt_cancel);
            this.Controls.Add(this.btt_rev);
            this.Controls.Add(this.cb_priv);
            this.Controls.Add(this.lb_priv);
            this.Controls.Add(this.cb_table);
            this.Controls.Add(this.lb_tb);
            this.Controls.Add(this.txt_ur);
            this.Controls.Add(this.lb_ur);
            this.Name = "Revoke_Privilege";
            this.Text = "Revoke_Privilege";
            this.Load += new System.EventHandler(this.cb_table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ur;
        private System.Windows.Forms.TextBox txt_ur;
        private System.Windows.Forms.Label lb_tb;
        private System.Windows.Forms.ComboBox cb_table;
        private System.Windows.Forms.Label lb_priv;
        private System.Windows.Forms.ComboBox cb_priv;
        private System.Windows.Forms.Button btt_rev;
        private System.Windows.Forms.Button btt_cancel;
    }
}