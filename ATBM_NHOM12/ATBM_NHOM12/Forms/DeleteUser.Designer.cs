namespace ATBM_NHOM12.Forms
{
    partial class DeleteUser
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
            this.btnCo = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "BẠN CÓ CHẮC CHẮC MUỐN XÓA NGƯỜI DÙNG?";
            // 
            // btnCo
            // 
            this.btnCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo.ForeColor = System.Drawing.Color.White;
            this.btnCo.Location = new System.Drawing.Point(262, 129);
            this.btnCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(150, 40);
            this.btnCo.TabIndex = 31;
            this.btnCo.Text = "Có";
            this.btnCo.UseVisualStyleBackColor = false;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.ForeColor = System.Drawing.Color.White;
            this.btnKhong.Location = new System.Drawing.Point(106, 129);
            this.btnKhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(150, 40);
            this.btnKhong.TabIndex = 32;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(517, 214);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Button btnKhong;
    }
}