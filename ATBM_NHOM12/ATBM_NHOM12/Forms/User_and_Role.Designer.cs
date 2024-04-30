namespace ATBM_NHOM12
{
    partial class User_and_Role
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_and_Role));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.tbxSearchUser = new System.Windows.Forms.TextBox();
            this.tbxSearchRole = new System.Windows.Forms.TextBox();
            this.btnRefreshUser = new System.Windows.Forms.Button();
            this.btnRefreshRole = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRoleDetail = new System.Windows.Forms.PictureBox();
            this.btnSearchRole = new System.Windows.Forms.PictureBox();
            this.btnSearchUser = new System.Windows.Forms.PictureBox();
            this.btnDeleteRole = new System.Windows.Forms.PictureBox();
            this.btnEditRole = new System.Windows.Forms.PictureBox();
            this.btnDeleteUser = new System.Windows.Forms.PictureBox();
            this.btnEditUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 550);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(560, 550);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvRole);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(589, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(560, 550);
            this.panel5.TabIndex = 4;
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 51;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(560, 550);
            this.dgvRole.TabIndex = 1;
            this.dgvRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(267, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(65, 24);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "USER";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(842, 38);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(65, 24);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "ROLE";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(471, 33);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(30, 30);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddUser, "Thêm người dùng");
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.Location = new System.Drawing.Point(1049, 31);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(30, 30);
            this.btnAddRole.TabIndex = 8;
            this.btnAddRole.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddRole, "Thêm vai trò");
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // tbxSearchUser
            // 
            this.tbxSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchUser.Location = new System.Drawing.Point(12, 623);
            this.tbxSearchUser.Name = "tbxSearchUser";
            this.tbxSearchUser.Size = new System.Drawing.Size(257, 28);
            this.tbxSearchUser.TabIndex = 9;
            // 
            // tbxSearchRole
            // 
            this.tbxSearchRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchRole.Location = new System.Drawing.Point(589, 623);
            this.tbxSearchRole.Name = "tbxSearchRole";
            this.tbxSearchRole.Size = new System.Drawing.Size(257, 28);
            this.tbxSearchRole.TabIndex = 17;
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnRefreshUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUser.ForeColor = System.Drawing.Color.White;
            this.btnRefreshUser.Location = new System.Drawing.Point(474, 622);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(99, 32);
            this.btnRefreshUser.TabIndex = 20;
            this.btnRefreshUser.Text = "Refresh";
            this.btnRefreshUser.UseVisualStyleBackColor = false;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // btnRefreshRole
            // 
            this.btnRefreshRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnRefreshRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshRole.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRole.Location = new System.Drawing.Point(1051, 622);
            this.btnRefreshRole.Name = "btnRefreshRole";
            this.btnRefreshRole.Size = new System.Drawing.Size(99, 32);
            this.btnRefreshRole.TabIndex = 21;
            this.btnRefreshRole.Text = "Refresh";
            this.btnRefreshRole.UseVisualStyleBackColor = false;
            this.btnRefreshRole.Click += new System.EventHandler(this.btnRefreshRole_Click);
            // 
            // btnRoleDetail
            // 
            this.btnRoleDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleDetail.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRoleDetail.ErrorImage")));
            this.btnRoleDetail.Image = global::ATBM_NHOM12.Properties.Resources.info;
            this.btnRoleDetail.Location = new System.Drawing.Point(1008, 30);
            this.btnRoleDetail.Name = "btnRoleDetail";
            this.btnRoleDetail.Size = new System.Drawing.Size(35, 33);
            this.btnRoleDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRoleDetail.TabIndex = 22;
            this.btnRoleDetail.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRoleDetail, "Chi tiết vai trò");
            this.btnRoleDetail.Click += new System.EventHandler(this.btnRoleDetail_Click);
            // 
            // btnSearchRole
            // 
            this.btnSearchRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRole.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSearchRole.ErrorImage")));
            this.btnSearchRole.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRole.Image")));
            this.btnSearchRole.Location = new System.Drawing.Point(852, 624);
            this.btnSearchRole.Name = "btnSearchRole";
            this.btnSearchRole.Size = new System.Drawing.Size(27, 27);
            this.btnSearchRole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchRole.TabIndex = 18;
            this.btnSearchRole.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSearchRole, "Tìm kiếm");
            this.btnSearchRole.Click += new System.EventHandler(this.btnSearchRole_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSearchUser.ErrorImage")));
            this.btnSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchUser.Image")));
            this.btnSearchUser.Location = new System.Drawing.Point(275, 624);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(27, 27);
            this.btnSearchUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchUser.TabIndex = 15;
            this.btnSearchUser.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSearchUser, "Tìm kiếm");
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRole.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRole.Image")));
            this.btnDeleteRole.Location = new System.Drawing.Point(1118, 31);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteRole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteRole.TabIndex = 14;
            this.btnDeleteRole.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDeleteRole, "Xoá vai trò");
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnEditRole
            // 
            this.btnEditRole.AccessibleDescription = "";
            this.btnEditRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRole.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEditRole.ErrorImage")));
            this.btnEditRole.Image = global::ATBM_NHOM12.Properties.Resources.editButton;
            this.btnEditRole.Location = new System.Drawing.Point(1085, 33);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(27, 27);
            this.btnEditRole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditRole.TabIndex = 13;
            this.btnEditRole.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEditRole, "Chỉnh sửa vai trò");
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.Location = new System.Drawing.Point(540, 33);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteUser.TabIndex = 12;
            this.btnDeleteUser.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDeleteUser, "Xoá người dùng");
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnEditUser.ErrorImage")));
            this.btnEditUser.Image = global::ATBM_NHOM12.Properties.Resources.editButton;
            this.btnEditUser.Location = new System.Drawing.Point(507, 35);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(27, 27);
            this.btnEditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditUser.TabIndex = 11;
            this.btnEditUser.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEditUser, "Chỉnh sửa người dùng");
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // User_and_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.btnRoleDetail);
            this.Controls.Add(this.btnRefreshRole);
            this.Controls.Add(this.btnRefreshUser);
            this.Controls.Add(this.btnSearchRole);
            this.Controls.Add(this.tbxSearchRole);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnEditRole);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.tbxSearchUser);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "User_and_Role";
            this.Text = "User_and_Role";
            this.Load += new System.EventHandler(this.User_and_Role_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.TextBox tbxSearchUser;
        private System.Windows.Forms.PictureBox btnEditUser;
        private System.Windows.Forms.PictureBox btnDeleteUser;
        private System.Windows.Forms.PictureBox btnEditRole;
        private System.Windows.Forms.PictureBox btnDeleteRole;
        private System.Windows.Forms.PictureBox btnSearchUser;
        private System.Windows.Forms.PictureBox btnSearchRole;
        private System.Windows.Forms.TextBox tbxSearchRole;
        private System.Windows.Forms.Button btnRefreshUser;
        private System.Windows.Forms.Button btnRefreshRole;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnRoleDetail;
    }
}