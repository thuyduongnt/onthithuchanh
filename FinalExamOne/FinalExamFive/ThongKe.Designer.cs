namespace FinalExamFive
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.nbNam = new System.Windows.Forms.NumericUpDown();
            this.btnThongke = new System.Windows.Forms.Button();
            this.view_TheodoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new FinalExamFive.DataSet1();
            this.view_TheodoiTableAdapter = new FinalExamFive.DataSet1TableAdapters.view_TheodoiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nbNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TheodoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.view_TheodoiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalExamFive.rpTheodoi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1026, 339);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm:";
            // 
            // nbNam
            // 
            this.nbNam.Location = new System.Drawing.Point(119, 13);
            this.nbNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nbNam.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nbNam.Name = "nbNam";
            this.nbNam.Size = new System.Drawing.Size(120, 20);
            this.nbNam.TabIndex = 1;
            this.nbNam.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(264, 11);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(75, 23);
            this.btnThongke.TabIndex = 2;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // view_TheodoiBindingSource
            // 
            this.view_TheodoiBindingSource.DataMember = "view_Theodoi";
            this.view_TheodoiBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_TheodoiTableAdapter
            // 
            this.view_TheodoiTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 414);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.nbNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TheodoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbNam;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.BindingSource view_TheodoiBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.view_TheodoiTableAdapter view_TheodoiTableAdapter;
    }
}