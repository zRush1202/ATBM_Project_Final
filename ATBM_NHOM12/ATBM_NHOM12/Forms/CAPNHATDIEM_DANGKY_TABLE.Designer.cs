namespace ATBM_NHOM12.Forms
{
    partial class CAPNHATDIEM_DANGKY_TABLE
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
            this.lb_dth = new System.Windows.Forms.Label();
            this.lb_dqt = new System.Windows.Forms.Label();
            this.lb_dck = new System.Windows.Forms.Label();
            this.lb_dtk = new System.Windows.Forms.Label();
            this.txt_dth = new System.Windows.Forms.TextBox();
            this.txt_dqt = new System.Windows.Forms.TextBox();
            this.txt_dck = new System.Windows.Forms.TextBox();
            this.txt_dtk = new System.Windows.Forms.TextBox();
            this.btt_capnhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_dth
            // 
            this.lb_dth.AutoSize = true;
            this.lb_dth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dth.Location = new System.Drawing.Point(48, 56);
            this.lb_dth.Name = "lb_dth";
            this.lb_dth.Size = new System.Drawing.Size(74, 18);
            this.lb_dth.TabIndex = 25;
            this.lb_dth.Text = "Điểm TH";
            // 
            // lb_dqt
            // 
            this.lb_dqt.AutoSize = true;
            this.lb_dqt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dqt.Location = new System.Drawing.Point(309, 59);
            this.lb_dqt.Name = "lb_dqt";
            this.lb_dqt.Size = new System.Drawing.Size(75, 18);
            this.lb_dqt.TabIndex = 26;
            this.lb_dqt.Text = "Điểm QT";
            // 
            // lb_dck
            // 
            this.lb_dck.AutoSize = true;
            this.lb_dck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dck.Location = new System.Drawing.Point(48, 123);
            this.lb_dck.Name = "lb_dck";
            this.lb_dck.Size = new System.Drawing.Size(75, 18);
            this.lb_dck.TabIndex = 27;
            this.lb_dck.Text = "Điểm CK";
            // 
            // lb_dtk
            // 
            this.lb_dtk.AutoSize = true;
            this.lb_dtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtk.Location = new System.Drawing.Point(309, 126);
            this.lb_dtk.Name = "lb_dtk";
            this.lb_dtk.Size = new System.Drawing.Size(73, 18);
            this.lb_dtk.TabIndex = 28;
            this.lb_dtk.Text = "Điểm TK";
            // 
            // txt_dth
            // 
            this.txt_dth.Location = new System.Drawing.Point(141, 53);
            this.txt_dth.Name = "txt_dth";
            this.txt_dth.Size = new System.Drawing.Size(100, 22);
            this.txt_dth.TabIndex = 29;
            // 
            // txt_dqt
            // 
            this.txt_dqt.Location = new System.Drawing.Point(386, 56);
            this.txt_dqt.Name = "txt_dqt";
            this.txt_dqt.Size = new System.Drawing.Size(100, 22);
            this.txt_dqt.TabIndex = 30;
            // 
            // txt_dck
            // 
            this.txt_dck.Location = new System.Drawing.Point(141, 120);
            this.txt_dck.Name = "txt_dck";
            this.txt_dck.Size = new System.Drawing.Size(100, 22);
            this.txt_dck.TabIndex = 31;
            // 
            // txt_dtk
            // 
            this.txt_dtk.Location = new System.Drawing.Point(386, 120);
            this.txt_dtk.Name = "txt_dtk";
            this.txt_dtk.Size = new System.Drawing.Size(100, 22);
            this.txt_dtk.TabIndex = 32;
            // 
            // btt_capnhat
            // 
            this.btt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_capnhat.Location = new System.Drawing.Point(183, 193);
            this.btt_capnhat.Name = "btt_capnhat";
            this.btt_capnhat.Size = new System.Drawing.Size(199, 38);
            this.btt_capnhat.TabIndex = 33;
            this.btt_capnhat.Text = "CẬP NHẬT";
            this.btt_capnhat.UseVisualStyleBackColor = true;
            this.btt_capnhat.Click += new System.EventHandler(this.btt_capnhat_Click);
            // 
            // CAPNHATDIEM_DANGKY_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 278);
            this.Controls.Add(this.btt_capnhat);
            this.Controls.Add(this.txt_dtk);
            this.Controls.Add(this.txt_dck);
            this.Controls.Add(this.txt_dqt);
            this.Controls.Add(this.txt_dth);
            this.Controls.Add(this.lb_dtk);
            this.Controls.Add(this.lb_dck);
            this.Controls.Add(this.lb_dqt);
            this.Controls.Add(this.lb_dth);
            this.Name = "CAPNHATDIEM_DANGKY_TABLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPNHATDIEM_DANGKY_TABLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dth;
        private System.Windows.Forms.Label lb_dqt;
        private System.Windows.Forms.Label lb_dck;
        private System.Windows.Forms.Label lb_dtk;
        private System.Windows.Forms.TextBox txt_dth;
        private System.Windows.Forms.TextBox txt_dqt;
        private System.Windows.Forms.TextBox txt_dck;
        private System.Windows.Forms.TextBox txt_dtk;
        private System.Windows.Forms.Button btt_capnhat;
    }
}