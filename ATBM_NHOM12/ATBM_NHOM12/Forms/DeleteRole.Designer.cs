namespace ATBM_NHOM12.Forms
{
    partial class DeleteRole
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
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnCo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.ForeColor = System.Drawing.Color.White;
            this.btnKhong.Location = new System.Drawing.Point(107, 131);
            this.btnKhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(150, 40);
            this.btnKhong.TabIndex = 35;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click_1);
            // 
            // btnCo
            // 
            this.btnCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.btnCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo.ForeColor = System.Drawing.Color.White;
            this.btnCo.Location = new System.Drawing.Point(263, 131);
            this.btnCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(150, 40);
            this.btnCo.TabIndex = 34;
            this.btnCo.Text = "Có";
            this.btnCo.UseVisualStyleBackColor = false;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "BẠN CÓ CHẮC CHẮC MUỐN XÓA VAI TRÒ?";
            // 
            // DeleteRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(517, 214);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa vai trò";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Label label1;
    }
}