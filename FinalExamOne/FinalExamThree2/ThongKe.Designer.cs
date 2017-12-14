namespace FinalExamThree2
{
    partial class ThongKe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongke = new System.Windows.Forms.Button();
            this.nbNamhoc = new System.Windows.Forms.NumericUpDown();
            this.view_LichDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new FinalExamThree2.DataSet1();
            this.view_LichDangKyTableAdapter = new FinalExamThree2.DataSet1TableAdapters.view_LichDangKyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nbNamhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_LichDangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_LichDangKyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalExamThree2.rpLichDangKy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(770, 382);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm học:";
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(235, 9);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(75, 23);
            this.btnThongke.TabIndex = 2;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // nbNamhoc
            // 
            this.nbNamhoc.Location = new System.Drawing.Point(96, 11);
            this.nbNamhoc.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nbNamhoc.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nbNamhoc.Name = "nbNamhoc";
            this.nbNamhoc.Size = new System.Drawing.Size(120, 20);
            this.nbNamhoc.TabIndex = 1;
            this.nbNamhoc.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // view_LichDangKyBindingSource
            // 
            this.view_LichDangKyBindingSource.DataMember = "view_LichDangKy";
            this.view_LichDangKyBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_LichDangKyTableAdapter
            // 
            this.view_LichDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 468);
            this.Controls.Add(this.nbNamhoc);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbNamhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_LichDangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.NumericUpDown nbNamhoc;
        private System.Windows.Forms.BindingSource view_LichDangKyBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.view_LichDangKyTableAdapter view_LichDangKyTableAdapter;
    }
}