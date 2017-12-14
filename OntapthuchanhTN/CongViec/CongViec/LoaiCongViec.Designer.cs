namespace CongViec
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLoaiCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách loại công việc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiCV,
            this.TenLoaiCV});
            this.dataGridView1.Location = new System.Drawing.Point(66, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 187);
            this.dataGridView1.TabIndex = 1;
            // 
            // MaLoaiCV
            // 
            this.MaLoaiCV.DataPropertyName = "MaLoaiCV";
            this.MaLoaiCV.HeaderText = "Mã Loại Công Việc";
            this.MaLoaiCV.Name = "MaLoaiCV";
            this.MaLoaiCV.Width = 200;
            // 
            // TenLoaiCV
            // 
            this.TenLoaiCV.DataPropertyName = "TenLoaiCV";
            this.TenLoaiCV.HeaderText = "Tên Loại Công Việc";
            this.TenLoaiCV.Name = "TenLoaiCV";
            this.TenLoaiCV.Width = 200;
            // 
            // LoaiCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "LoaiCongViec";
            this.Text = "LoaiCongViec";
            this.Load += new System.EventHandler(this.LoaiCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiCV;
    }
}