namespace FinalExamFour
{
    partial class LoaiThuoc
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
            this.dgvLoaiThuoc = new System.Windows.Forms.DataGridView();
            this.MaLoaiT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC CÁC LOẠI THUỐC";
            // 
            // dgvLoaiThuoc
            // 
            this.dgvLoaiThuoc.AllowUserToAddRows = false;
            this.dgvLoaiThuoc.AllowUserToDeleteRows = false;
            this.dgvLoaiThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiT,
            this.TenLoaiT});
            this.dgvLoaiThuoc.Location = new System.Drawing.Point(12, 60);
            this.dgvLoaiThuoc.Name = "dgvLoaiThuoc";
            this.dgvLoaiThuoc.ReadOnly = true;
            this.dgvLoaiThuoc.Size = new System.Drawing.Size(432, 188);
            this.dgvLoaiThuoc.TabIndex = 1;
            // 
            // MaLoaiT
            // 
            this.MaLoaiT.DataPropertyName = "MaLoaiT";
            this.MaLoaiT.HeaderText = "Mã Loại Thuốc";
            this.MaLoaiT.Name = "MaLoaiT";
            this.MaLoaiT.ReadOnly = true;
            this.MaLoaiT.Width = 150;
            // 
            // TenLoaiT
            // 
            this.TenLoaiT.DataPropertyName = "TenLoaiT";
            this.TenLoaiT.HeaderText = "Tên Loại Thuốc";
            this.TenLoaiT.Name = "TenLoaiT";
            this.TenLoaiT.ReadOnly = true;
            this.TenLoaiT.Width = 250;
            // 
            // LoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 260);
            this.Controls.Add(this.dgvLoaiThuoc);
            this.Controls.Add(this.label1);
            this.Name = "LoaiThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Thuốc";
            this.Load += new System.EventHandler(this.LoaiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiT;
    }
}