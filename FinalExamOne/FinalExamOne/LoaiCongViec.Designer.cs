namespace FinalExamOne
{
    partial class LoaiCongViec
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
            this.dgvLoaiCV = new System.Windows.Forms.DataGridView();
            this.LoaiCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiCV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Công Việc";
            // 
            // dgvLoaiCV
            // 
            this.dgvLoaiCV.AllowUserToAddRows = false;
            this.dgvLoaiCV.AllowUserToDeleteRows = false;
            this.dgvLoaiCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiCV,
            this.TenLoaiCV});
            this.dgvLoaiCV.Location = new System.Drawing.Point(12, 57);
            this.dgvLoaiCV.Name = "dgvLoaiCV";
            this.dgvLoaiCV.ReadOnly = true;
            this.dgvLoaiCV.Size = new System.Drawing.Size(397, 263);
            this.dgvLoaiCV.TabIndex = 1;
            // 
            // LoaiCV
            // 
            this.LoaiCV.DataPropertyName = "LoaiCV";
            this.LoaiCV.HeaderText = "Mã loại công việc";
            this.LoaiCV.Name = "LoaiCV";
            this.LoaiCV.ReadOnly = true;
            this.LoaiCV.Width = 150;
            // 
            // TenLoaiCV
            // 
            this.TenLoaiCV.DataPropertyName = "TenLoaiCV";
            this.TenLoaiCV.HeaderText = "Tên loại công việc";
            this.TenLoaiCV.Name = "TenLoaiCV";
            this.TenLoaiCV.ReadOnly = true;
            this.TenLoaiCV.Width = 200;
            // 
            // LoaiCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 340);
            this.Controls.Add(this.dgvLoaiCV);
            this.Controls.Add(this.label1);
            this.Name = "LoaiCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Công Việc";
            this.Load += new System.EventHandler(this.LoaiCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiCV;
    }
}