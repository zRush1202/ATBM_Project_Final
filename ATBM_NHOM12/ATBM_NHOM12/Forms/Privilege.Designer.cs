namespace ATBM_NHOM12
{
    partial class Privilege
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Privilege));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPriv = new System.Windows.Forms.DataGridView();
            this.tbxSearchUser = new System.Windows.Forms.TextBox();
            this.btnRefreshUser = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPriv);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 648);
            this.panel1.TabIndex = 1;
            // 
            // dgvPriv
            // 
            this.dgvPriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPriv.Location = new System.Drawing.Point(0, 0);
            this.dgvPriv.Name = "dgvPriv";
            this.dgvPriv.RowHeadersWidth = 51;
            this.dgvPriv.RowTemplate.Height = 24;
            this.dgvPriv.Size = new System.Drawing.Size(1147, 648);
            this.dgvPriv.TabIndex = 0;
            this.dgvPriv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriv_CellClick);
            // 
            // tbxSearchUser
            // 
            this.tbxSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchUser.Location = new System.Drawing.Point(868, 19);
            this.tbxSearchUser.Name = "tbxSearchUser";
            this.tbxSearchUser.Size = new System.Drawing.Size(257, 28);
            this.tbxSearchUser.TabIndex = 16;
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnRefreshUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUser.ForeColor = System.Drawing.Color.White;
            this.btnRefreshUser.Location = new System.Drawing.Point(11, 15);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(99, 32);
            this.btnRefreshUser.TabIndex = 21;
            this.btnRefreshUser.Text = "Refresh";
            this.btnRefreshUser.UseVisualStyleBackColor = false;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSearchUser.ErrorImage")));
            this.btnSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchUser.Image")));
            this.btnSearchUser.Location = new System.Drawing.Point(1131, 20);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(27, 27);
            this.btnSearchUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchUser.TabIndex = 17;
            this.btnSearchUser.TabStop = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // Privilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1172, 718);
            this.Controls.Add(this.btnRefreshUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.tbxSearchUser);
            this.Controls.Add(this.panel1);
            this.Name = "Privilege";
            this.Text = "Privilege";
            this.Load += new System.EventHandler(this.Privilege_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPriv;
        private System.Windows.Forms.PictureBox btnSearchUser;
        private System.Windows.Forms.TextBox tbxSearchUser;
        private System.Windows.Forms.Button btnRefreshUser;
    }
}