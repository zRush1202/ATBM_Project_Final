namespace ATBM_NHOM12.Forms
{
    partial class THEM_SYSPRIV
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
            this.lb_thaotac = new System.Windows.Forms.Label();
            this.cb_thaotac = new System.Windows.Forms.ComboBox();
            this.lb_doituong = new System.Windows.Forms.Label();
            this.txt_doituong = new System.Windows.Forms.TextBox();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.cb_quyen = new System.Windows.Forms.ComboBox();
            this.btt_thuchien = new System.Windows.Forms.Button();
            this.btt_huy = new System.Windows.Forms.Button();
            this.checkwgo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_thaotac
            // 
            this.lb_thaotac.AutoSize = true;
            this.lb_thaotac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thaotac.Location = new System.Drawing.Point(74, 27);
            this.lb_thaotac.Name = "lb_thaotac";
            this.lb_thaotac.Size = new System.Drawing.Size(90, 18);
            this.lb_thaotac.TabIndex = 1;
            this.lb_thaotac.Text = "THAO TÁC";
            // 
            // cb_thaotac
            // 
            this.cb_thaotac.FormattingEnabled = true;
            this.cb_thaotac.Items.AddRange(new object[] {
            "GRANT",
            "REVOKE"});
            this.cb_thaotac.Location = new System.Drawing.Point(239, 26);
            this.cb_thaotac.Name = "cb_thaotac";
            this.cb_thaotac.Size = new System.Drawing.Size(239, 24);
            this.cb_thaotac.TabIndex = 2;
            // 
            // lb_doituong
            // 
            this.lb_doituong.AutoSize = true;
            this.lb_doituong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doituong.Location = new System.Drawing.Point(74, 89);
            this.lb_doituong.Name = "lb_doituong";
            this.lb_doituong.Size = new System.Drawing.Size(102, 18);
            this.lb_doituong.TabIndex = 3;
            this.lb_doituong.Text = "ĐỐI TƯỢNG";
            // 
            // txt_doituong
            // 
            this.txt_doituong.Location = new System.Drawing.Point(239, 85);
            this.txt_doituong.Name = "txt_doituong";
            this.txt_doituong.Size = new System.Drawing.Size(239, 22);
            this.txt_doituong.TabIndex = 4;
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.Location = new System.Drawing.Point(74, 147);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(66, 18);
            this.lb_quyen.TabIndex = 5;
            this.lb_quyen.Text = "QUYỀN";
            // 
            // cb_quyen
            // 
            this.cb_quyen.FormattingEnabled = true;
            this.cb_quyen.Location = new System.Drawing.Point(239, 141);
            this.cb_quyen.Name = "cb_quyen";
            this.cb_quyen.Size = new System.Drawing.Size(239, 24);
            this.cb_quyen.TabIndex = 6;
            // 
            // btt_thuchien
            // 
            this.btt_thuchien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_thuchien.Location = new System.Drawing.Point(128, 231);
            this.btt_thuchien.Name = "btt_thuchien";
            this.btt_thuchien.Size = new System.Drawing.Size(149, 39);
            this.btt_thuchien.TabIndex = 7;
            this.btt_thuchien.Text = "THỰC HIỆN";
            this.btt_thuchien.UseVisualStyleBackColor = true;
            this.btt_thuchien.Click += new System.EventHandler(this.btt_thuchien_Click);
            // 
            // btt_huy
            // 
            this.btt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_huy.Location = new System.Drawing.Point(295, 231);
            this.btt_huy.Name = "btt_huy";
            this.btt_huy.Size = new System.Drawing.Size(149, 39);
            this.btt_huy.TabIndex = 8;
            this.btt_huy.Text = "HỦY";
            this.btt_huy.UseVisualStyleBackColor = true;
            this.btt_huy.Click += new System.EventHandler(this.btt_huy_Click);
            // 
            // checkwgo
            // 
            this.checkwgo.AutoSize = true;
            this.checkwgo.Location = new System.Drawing.Point(309, 188);
            this.checkwgo.Name = "checkwgo";
            this.checkwgo.Size = new System.Drawing.Size(164, 20);
            this.checkwgo.TabIndex = 9;
            this.checkwgo.Text = "WITH ADMIN OPTION";
            this.checkwgo.UseVisualStyleBackColor = true;
            this.checkwgo.CheckedChanged += new System.EventHandler(this.checkwgo_CheckedChanged);
            // 
            // THEM_SYSPRIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 282);
            this.Controls.Add(this.checkwgo);
            this.Controls.Add(this.btt_huy);
            this.Controls.Add(this.btt_thuchien);
            this.Controls.Add(this.cb_quyen);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.txt_doituong);
            this.Controls.Add(this.lb_doituong);
            this.Controls.Add(this.cb_thaotac);
            this.Controls.Add(this.lb_thaotac);
            this.Name = "THEM_SYSPRIV";
            this.Text = "THEM_SYSPRIV";
            this.Load += new System.EventHandler(this.THEM_SYSPRIV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thaotac;
        private System.Windows.Forms.ComboBox cb_thaotac;
        private System.Windows.Forms.Label lb_doituong;
        private System.Windows.Forms.TextBox txt_doituong;
        private System.Windows.Forms.Label lb_quyen;
        private System.Windows.Forms.ComboBox cb_quyen;
        private System.Windows.Forms.Button btt_thuchien;
        private System.Windows.Forms.Button btt_huy;
        private System.Windows.Forms.CheckBox checkwgo;
    }
}