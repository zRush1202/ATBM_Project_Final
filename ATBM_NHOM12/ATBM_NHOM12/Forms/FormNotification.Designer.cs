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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotifi
            // 
            this.dgvNotifi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNotifi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifi.Location = new System.Drawing.Point(24, 12);
            this.dgvNotifi.Name = "dgvNotifi";
            this.dgvNotifi.RowHeadersWidth = 51;
            this.dgvNotifi.RowTemplate.Height = 24;
            this.dgvNotifi.Size = new System.Drawing.Size(1135, 695);
            this.dgvNotifi.TabIndex = 0;
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 864);
            this.Controls.Add(this.dgvNotifi);
            this.Name = "FormNotification";
            this.Text = "FormNotification";
            this.Load += new System.EventHandler(this.FormNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotifi;
    }
}