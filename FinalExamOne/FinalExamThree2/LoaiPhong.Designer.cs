namespace FinalExamThree2
{
    partial class LoaiPhong
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
            this.dgvLoaiphong = new System.Windows.Forms.DataGridView();
            this.MaLoaiP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiphong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH LOẠI PHÒNG";
            // 
            // dgvLoaiphong
            // 
            this.dgvLoaiphong.AllowUserToAddRows = false;
            this.dgvLoaiphong.AllowUserToDeleteRows = false;
            this.dgvLoaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiP,
            this.TenLoaiPhong});
            this.dgvLoaiphong.Location = new System.Drawing.Point(12, 65);
            this.dgvLoaiphong.Name = "dgvLoaiphong";
            this.dgvLoaiphong.ReadOnly = true;
            this.dgvLoaiphong.Size = new System.Drawing.Size(386, 209);
            this.dgvLoaiphong.TabIndex = 1;
            // 
            // MaLoaiP
            // 
            this.MaLoaiP.DataPropertyName = "MaLoaiP";
            this.MaLoaiP.HeaderText = "Mã Loại Phòng";
            this.MaLoaiP.Name = "MaLoaiP";
            this.MaLoaiP.ReadOnly = true;
            this.MaLoaiP.Width = 150;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Tên Loại Phòng";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.ReadOnly = true;
            this.TenLoaiPhong.Width = 200;
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 286);
            this.Controls.Add(this.dgvLoaiphong);
            this.Controls.Add(this.label1);
            this.Name = "LoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Phòng";
            this.Load += new System.EventHandler(this.LoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
    }
}