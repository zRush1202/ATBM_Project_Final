namespace ATBM_NHOM12.Forms
{
    partial class FormAddNoti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.tbxNoiDung = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.clbLevel = new System.Windows.Forms.CheckedListBox();
            this.clbCompartment = new System.Windows.Forms.CheckedListBox();
            this.clbGroup = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "THÊM THÔNG BÁO";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(35, 100);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(96, 24);
            this.label_user.TabIndex = 20;
            this.label_user.Text = "Nội dung";
            // 
            // tbxNoiDung
            // 
            this.tbxNoiDung.Location = new System.Drawing.Point(137, 97);
            this.tbxNoiDung.Multiline = true;
            this.tbxNoiDung.Name = "tbxNoiDung";
            this.tbxNoiDung.Size = new System.Drawing.Size(397, 83);
            this.tbxNoiDung.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbGroup);
            this.groupBox1.Controls.Add(this.clbCompartment);
            this.groupBox1.Controls.Add(this.clbLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 249);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhãn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Compartment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Group";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(206, 457);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(168, 43);
            this.btnXacNhan.TabIndex = 23;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // clbLevel
            // 
            this.clbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbLevel.FormattingEnabled = true;
            this.clbLevel.Items.AddRange(new object[] {
            "SV",
            "NV",
            "GVU",
            "GV",
            "TDV",
            "TK"});
            this.clbLevel.Location = new System.Drawing.Point(24, 80);
            this.clbLevel.Name = "clbLevel";
            this.clbLevel.Size = new System.Drawing.Size(113, 142);
            this.clbLevel.TabIndex = 26;
            // 
            // clbCompartment
            // 
            this.clbCompartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCompartment.FormattingEnabled = true;
            this.clbCompartment.Items.AddRange(new object[] {
            "HTTT",
            "CNPM",
            "KHMT",
            "CNTT",
            "TGMT",
            "MMT"});
            this.clbCompartment.Location = new System.Drawing.Point(188, 80);
            this.clbCompartment.Name = "clbCompartment";
            this.clbCompartment.Size = new System.Drawing.Size(115, 142);
            this.clbCompartment.TabIndex = 27;
            // 
            // clbGroup
            // 
            this.clbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGroup.FormattingEnabled = true;
            this.clbGroup.Items.AddRange(new object[] {
            "CS1",
            "CS2"});
            this.clbGroup.Location = new System.Drawing.Point(353, 80);
            this.clbGroup.Name = "clbGroup";
            this.clbGroup.Size = new System.Drawing.Size(120, 142);
            this.clbGroup.TabIndex = 28;
            // 
            // FormAddNoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 533);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxNoiDung);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNoti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddNoti";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox tbxNoiDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.CheckedListBox clbGroup;
        private System.Windows.Forms.CheckedListBox clbCompartment;
        private System.Windows.Forms.CheckedListBox clbLevel;
    }
}