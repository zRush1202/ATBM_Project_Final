namespace ATBM_NHOM12.Forms
{
    partial class Add_Role
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
            this.btnAddRole = new System.Windows.Forms.Button();
            this.tbxRoleName = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.cbxPassword = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "THÊM VAI TRÒ";
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Location = new System.Drawing.Point(147, 185);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(205, 54);
            this.btnAddRole.TabIndex = 21;
            this.btnAddRole.Text = "THÊM";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // tbxRoleName
            // 
            this.tbxRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoleName.Location = new System.Drawing.Point(228, 73);
            this.tbxRoleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRoleName.Name = "tbxRoleName";
            this.tbxRoleName.Size = new System.Drawing.Size(238, 27);
            this.tbxRoleName.TabIndex = 20;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(54, 74);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(140, 24);
            this.label_user.TabIndex = 19;
            this.label_user.Text = "TÊN VAI TRÒ";
            // 
            // cbxPassword
            // 
            this.cbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPassword.Location = new System.Drawing.Point(448, 106);
            this.cbxPassword.Name = "cbxPassword";
            this.cbxPassword.Size = new System.Drawing.Size(18, 17);
            this.cbxPassword.TabIndex = 22;
            this.cbxPassword.UseVisualStyleBackColor = true;
            this.cbxPassword.CheckedChanged += new System.EventHandler(this.cbxPassword_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(300, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 16);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Có mật khẩu không?";
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassword.Location = new System.Drawing.Point(30, 137);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(179, 24);
            this.lblEnterPassword.TabIndex = 24;
            this.lblEnterPassword.Text = "NHẬP MẬT KHẨU";
            this.lblEnterPassword.Visible = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(228, 137);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(238, 27);
            this.tbxPassword.TabIndex = 25;
            this.tbxPassword.Visible = false;
            // 
            // Add_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(517, 265);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbxPassword);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.tbxRoleName);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Add_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm vai trò";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.TextBox tbxRoleName;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.CheckBox cbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.TextBox tbxPassword;
    }
}