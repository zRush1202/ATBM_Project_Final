namespace ATBM_NHOM12.Forms
{
    partial class FormNotification
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
            this.dgvNotifi = new System.Windows.Forms.DataGridView();
            this.btnAddNotify = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotifi
            // 
            this.dgvNotifi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNotifi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifi.Location = new System.Drawing.Point(24, 57);
            this.dgvNotifi.Name = "dgvNotifi";
            this.dgvNotifi.RowHeadersWidth = 51;
            this.dgvNotifi.RowTemplate.Height = 24;
            this.dgvNotifi.Size = new System.Drawing.Size(1135, 650);
            this.dgvNotifi.TabIndex = 0;
            // 
            // btnAddNotify
            // 
            this.btnAddNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNotify.Location = new System.Drawing.Point(1009, 12);
            this.btnAddNotify.Name = "btnAddNotify";
            this.btnAddNotify.Size = new System.Drawing.Size(149, 33);
            this.btnAddNotify.TabIndex = 1;
            this.btnAddNotify.Text = "Thêm";
            this.btnAddNotify.UseVisualStyleBackColor = true;
            this.btnAddNotify.Click += new System.EventHandler(this.btnAddNotify_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(843, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 33);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 864);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddNotify);
            this.Controls.Add(this.dgvNotifi);
            this.Name = "FormNotification";
            this.Text = "FormNotification";
            this.Load += new System.EventHandler(this.FormNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotifi;
        private System.Windows.Forms.Button btnAddNotify;
        private System.Windows.Forms.Button btnRefresh;
    }
}