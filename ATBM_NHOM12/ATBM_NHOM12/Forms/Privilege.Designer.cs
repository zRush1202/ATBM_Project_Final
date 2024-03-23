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
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPriv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilege.Location = new System.Drawing.Point(190, 26);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(115, 24);
            this.lblPrivilege.TabIndex = 0;
            this.lblPrivilege.Text = "PRIVILEGE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPriv);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 531);
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
            this.dgvPriv.Size = new System.Drawing.Size(500, 531);
            this.dgvPriv.TabIndex = 0;
            // 
            // Privilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPrivilege);
            this.Name = "Privilege";
            this.Text = "Privilege";
            this.Load += new System.EventHandler(this.Privilege_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPriv;
    }
}