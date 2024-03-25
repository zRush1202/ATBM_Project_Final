using System;

namespace ATBM_NHOM12.Forms
{
    partial class RoleDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleDetail));
            this.dgvRoleDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRoleMem = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRevokeRole = new System.Windows.Forms.PictureBox();
            this.dgvUserNotInRole = new System.Windows.Forms.DataGridView();
            this.cbAdOption = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRevokeRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserNotInRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoleDetail
            // 
            this.dgvRoleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleDetail.Location = new System.Drawing.Point(12, 118);
            this.dgvRoleDetail.Name = "dgvRoleDetail";
            this.dgvRoleDetail.RowHeadersWidth = 51;
            this.dgvRoleDetail.RowTemplate.Height = 24;
            this.dgvRoleDetail.Size = new System.Drawing.Size(491, 415);
            this.dgvRoleDetail.TabIndex = 0;
            this.dgvRoleDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoleDetail_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "CHI TIẾT VAI TRÒ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddRoleMem
            // 
            this.btnAddRoleMem.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddRoleMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoleMem.FlatAppearance.BorderSize = 0;
            this.btnAddRoleMem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddRoleMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoleMem.Location = new System.Drawing.Point(990, 82);
            this.btnAddRoleMem.Name = "btnAddRoleMem";
            this.btnAddRoleMem.Size = new System.Drawing.Size(30, 30);
            this.btnAddRoleMem.TabIndex = 19;
            this.btnAddRoleMem.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddRoleMem, "Thêm thành viên cho vai trò");
            this.btnAddRoleMem.UseVisualStyleBackColor = false;
            this.btnAddRoleMem.Click += new System.EventHandler(this.btnAddRoleMem_Click);
            // 
            // btnRevokeRole
            // 
            this.btnRevokeRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevokeRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRevokeRole.Image")));
            this.btnRevokeRole.Location = new System.Drawing.Point(12, 82);
            this.btnRevokeRole.Name = "btnRevokeRole";
            this.btnRevokeRole.Size = new System.Drawing.Size(30, 30);
            this.btnRevokeRole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRevokeRole.TabIndex = 21;
            this.btnRevokeRole.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRevokeRole, "Thu hồi vai trò");
            this.btnRevokeRole.Click += new System.EventHandler(this.btnRevokeRole_Click);
            // 
            // dgvUserNotInRole
            // 
            this.dgvUserNotInRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserNotInRole.Location = new System.Drawing.Point(529, 118);
            this.dgvUserNotInRole.Name = "dgvUserNotInRole";
            this.dgvUserNotInRole.RowHeadersWidth = 51;
            this.dgvUserNotInRole.RowTemplate.Height = 24;
            this.dgvUserNotInRole.Size = new System.Drawing.Size(491, 415);
            this.dgvUserNotInRole.TabIndex = 20;
            this.dgvUserNotInRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserNotInRole_CellClick);
            // 
            // cbAdOption
            // 
            this.cbAdOption.AutoSize = true;
            this.cbAdOption.Location = new System.Drawing.Point(731, 91);
            this.cbAdOption.Name = "cbAdOption";
            this.cbAdOption.Size = new System.Drawing.Size(226, 20);
            this.cbAdOption.TabIndex = 22;
            this.cbAdOption.Text = "Được phân quyền cho người khác";
            this.cbAdOption.UseVisualStyleBackColor = true;
            // 
            // RoleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1032, 541);
            this.Controls.Add(this.cbAdOption);
            this.Controls.Add(this.btnRevokeRole);
            this.Controls.Add(this.dgvUserNotInRole);
            this.Controls.Add(this.btnAddRoleMem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRoleDetail);
            this.Name = "RoleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RoleDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRevokeRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserNotInRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView dgvRoleDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRoleMem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvUserNotInRole;
        private System.Windows.Forms.PictureBox btnRevokeRole;
        private System.Windows.Forms.CheckBox cbAdOption;
    }
}