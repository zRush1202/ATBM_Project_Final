namespace ATBM_NHOM12.Forms
{
    partial class EditRole
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
            this.btnEditRole = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbxChangePass = new System.Windows.Forms.CheckBox();
            this.chbxDelPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "CHỈNH SỬA VAI TRÒ";
            // 
            // btnEditRole
            // 
            this.btnEditRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnEditRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRole.ForeColor = System.Drawing.Color.White;
            this.btnEditRole.Location = new System.Drawing.Point(146, 200);
            this.btnEditRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(205, 54);
            this.btnEditRole.TabIndex = 28;
            this.btnEditRole.Text = "SỬA";
            this.btnEditRole.UseVisualStyleBackColor = false;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(248, 159);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(238, 27);
            this.tbxPassword.TabIndex = 27;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.Visible = false;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(30, 159);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(160, 24);
            this.label_password.TabIndex = 25;
            this.label_password.Text = "MẬT KHẨU MỚI";
            this.label_password.Visible = false;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(30, 73);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(158, 24);
            this.label_user.TabIndex = 24;
            this.label_user.Text = "CHỌN VAI TRÒ";
            // 
            // cbxRole
            // 
            this.cbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(248, 70);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(238, 30);
            this.cbxRole.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Đổi mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hủy mật khẩu";
            // 
            // chbxChangePass
            // 
            this.chbxChangePass.AutoSize = true;
            this.chbxChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxChangePass.Location = new System.Drawing.Point(206, 122);
            this.chbxChangePass.Name = "chbxChangePass";
            this.chbxChangePass.Size = new System.Drawing.Size(18, 17);
            this.chbxChangePass.TabIndex = 33;
            this.chbxChangePass.UseVisualStyleBackColor = true;
            this.chbxChangePass.CheckedChanged += new System.EventHandler(this.chbxChangePass_CheckedChanged);
            // 
            // chbxDelPass
            // 
            this.chbxDelPass.AutoSize = true;
            this.chbxDelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxDelPass.Location = new System.Drawing.Point(410, 122);
            this.chbxDelPass.Name = "chbxDelPass";
            this.chbxDelPass.Size = new System.Drawing.Size(18, 17);
            this.chbxDelPass.TabIndex = 34;
            this.chbxDelPass.UseVisualStyleBackColor = true;
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(517, 265);
            this.Controls.Add(this.chbxDelPass);
            this.Controls.Add(this.chbxChangePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditRole);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Name = "EditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa vai trò";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbxChangePass;
        private System.Windows.Forms.CheckBox chbxDelPass;
    }
}